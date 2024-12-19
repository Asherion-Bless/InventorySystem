using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace InventorySystem
{
    public partial class AdminInterface : Form
    {
        public delegate void RefreshInventoryDataEventHandler();
        public event RefreshInventoryDataEventHandler RefreshInventoryData;
        private Shelf shelfForm = null; // Initialize shelfForm to null
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public int loggedInUserId;
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb;";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse
            );

        public AdminInterface(int ID)
        {
            InitializeComponent();
            loggedInUserId = ID;
            // Get the username from the database using the logged-in UserID
            string username = GetUsernameFromUserID(loggedInUserId);
            RefreshInventoryData += LoadInventoryData;
            // Set the text of the lUser label to the username
            lUser.Text = "User: " + username;

        }
        //dt = new DataTable();
        //adapter = new OleDbDataAdapter("Select * FROM /*table*/ )
        private void AdminInterface_Load(object sender, EventArgs e)
        {
            // Load data from the database to DataGridView
            LoadInventoryData();
            cbSort.Items.Add("ProductID".ToUpper());
            cbSort.Items.Add("ProductName".ToUpper());
            cbSort.Items.Add("ProductBrand".ToUpper());
            cbSort.Items.Add("ProductCategory".ToUpper());
            cbSort.Items.Add("ProductPrice".ToUpper());
            cbSort.Items.Add("Quantity".ToUpper());
            cbSort.Items.Add("ReorderLevel".ToUpper());
            cbSort.Items.Add("DateStocked".ToUpper());
            cbSort.Items.Add("ExpirationDate".ToUpper());
        }

        private void CheckAndDisplayNotifications()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                if (dgvNotification.Columns.Count == 0)
                {
                    dgvNotification.Columns.Add("ProductID", "Product ID");
                    dgvNotification.Columns.Add("ProductName", "Product Name");
                    dgvNotification.Columns.Add("Note", "Notification");
                }

                DateTime currentDate = DateTime.Now;
                DateTime expiryThreshold = currentDate.AddDays(7);

                Console.WriteLine($"Expiration Threshold: {expiryThreshold}, Type: {expiryThreshold.GetType()}");

                // Low stock query
                string lowStockQuery = "SELECT ProductID, ProductName, ReorderLevel FROM Inventory WHERE StockQuantity <= ReorderLevel";
                using (OleDbCommand cmdLowStock = new OleDbCommand(lowStockQuery, conn))
                {
                    OleDbDataReader readerLowStock = cmdLowStock.ExecuteReader();
                    while (readerLowStock.Read())
                    {
                        int productID = Convert.ToInt32(readerLowStock["ProductID"]);
                        string productName = readerLowStock["ProductName"].ToString();
                        dgvNotification.Rows.Add(productID, productName, "Stock is low");
                    }
                    readerLowStock.Close();
                }

                // Near-expiry query
                string nearExpiryQuery = "SELECT ProductID, ProductName, ExpirationDate FROM Inventory WHERE ExpirationDate IS NOT NULL AND ExpirationDate <= ?";
                using (OleDbCommand cmdNearExpiry = new OleDbCommand(nearExpiryQuery, conn))
                {
                    cmdNearExpiry.Parameters.AddWithValue("?", expiryThreshold.ToString("MM/dd/yyyy"));

                    Console.WriteLine("Executing near-expiry query...");
                    OleDbDataReader readerNearExpiry = cmdNearExpiry.ExecuteReader();
                    while (readerNearExpiry.Read())
                    {
                        int productID = Convert.ToInt32(readerNearExpiry["ProductID"]);
                        string productName = readerNearExpiry["ProductName"].ToString();
                        DateTime expirationDate = Convert.ToDateTime(readerNearExpiry["ExpirationDate"]);
                        dgvNotification.Rows.Add(productID, productName, $"Expiring soon (Expires on {expirationDate:yyyy-MM-dd})");
                    }
                    readerNearExpiry.Close();
                }
                conn.Close();
            }
        }


        public void LoadInventoryData()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Inventory", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);

            // Create a BindingSource and set its DataSource
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            // Set the DataGridView's DataSource to the BindingSource
            dgvInventory.DataSource = bindingSource;

            // Close the database connection
            conn.Close();

        }

        private void btAdminLogout_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string formattedLogoutTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //string updateLogQuery = "UPDATE LogTable SET TimeOut = @timeOut WHERE TimeOut IS NULL";
                string updateLogQuery = "UPDATE Logs SET LogoutTimestamp = @LogoutTimestamp WHERE UserID = @ID AND LogoutTimestamp IS NULL";
                OleDbCommand cmd = new OleDbCommand(updateLogQuery, conn);
                cmd.Parameters.AddWithValue("@LogoutTimestamp", formattedLogoutTimestamp);
                cmd.Parameters.AddWithValue("@ID", loggedInUserId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                
                Form LogInForm = new LogInForm();
                LogInForm.Show();
                this.Close();
                
                //Application.Exit();
            }
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            try
            {
                Form UserTab = new UserTab(loggedInUserId); // Pass the ID
                UserTab.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddProduct form, passing the loggedInUserId
                Form AddProduct = new AddProduct(loggedInUserId);

                // Display the new form
                AddProduct.Show();
                //this.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Declare a Timer in your form
        //private Timer refreshTimer; //doesnt work

        /*private void RefreshDataGrid(object sender, EventArgs e)
        {
            // Reload the data every time the timer ticks
            LoadInventoryData(); // Re-load the data into the DataGridView
        }*/

        private void AdminInterface_Load_1(object sender, EventArgs e)
        {
            LoadInventoryData();
            CheckAndDisplayNotifications();

            btAutofill.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, btAutofill.Width, btAutofill.Height, 30, 30));
            btImport.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, btImport.Width, btImport.Height, 30, 30));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, btnAdd.Width, btnAdd.Height, 30, 30));
            btUpdate.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, btUpdate.Width, btUpdate.Height, 30, 30));
            btDelete.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, btDelete.Width, btDelete.Height, 30, 30));
            cbSort.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, cbSort.Width, cbSort.Height, 30, 30));

            // Initialize and start the Timer
            //refreshTimer = new Timer();
            //refreshTimer.Interval = 2000; // Set the interval to 2000 milliseconds (2 seconds)
            //refreshTimer.Tick += new EventHandler(RefreshDataGrid); // Attach the event handler
            //refreshTimer.Start(); // Start the timer


            // SQL query to select stock data (assumes you have a 'Products' table with a 'StockLevel' column)
            string query = "SELECT ProductName, ReorderLevel, Price FROM Inventory";

            // Create the adapter and data table
            try
            {
                // Apply conditional formatting to rows based on stock level
                HighlightLowStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                // Check if the row is the new row (empty row)
                if (row.IsNewRow)
                {
                    continue; // Skip to the next row
                }

                // ... (Your existing code to check StockQuantity and ReorderLevel)
                if (row.Cells["StockQuantity"].Value != DBNull.Value && row.Cells["ReorderLevel"].Value != DBNull.Value)
                {
                    int stockQuantity = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                    int reorderLevel = Convert.ToInt32(row.Cells["ReorderLevel"].Value);

                    if (stockQuantity <= reorderLevel)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Red; // Use yellow for highlighting
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White; // Set text color to black
                    }
                    else
                    {
                        // Reset the background color to default if not low stock
                        row.DefaultCellStyle.BackColor = dgvInventory.DefaultCellStyle.BackColor;
                        // Reset the foreground color to default if not low stock
                        row.DefaultCellStyle.ForeColor = dgvInventory.DefaultCellStyle.ForeColor; // Use default color
                    }
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any rows are selected in the DataGridView
                if (dgvInventory.SelectedRows.Count > 0)
                {
                    // Confirm the delete action with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected products?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Loop through all selected rows in the DataGridView
                        foreach (DataGridViewRow row in dgvInventory.SelectedRows)
                        {
                            // Skip the row if it's a new row (can be added to prevent deleting new, unsaved rows)
                            if (row.IsNewRow) continue;

                            // Get the ProductID from the selected row (assuming ProductID is in the first column)
                            int productId = Convert.ToInt32(row.Cells["ProductID"].Value);

                            // Define the connection string
                            string connString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb";

                            // Create the SQL query with a parameter for ProductID
                            string query = "DELETE FROM Inventory WHERE ProductID = @ProductID";

                            // Create a new OleDbConnection object
                            using (OleDbConnection conn = new OleDbConnection(connString))
                            {
                                // Create the OleDbCommand object
                                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                                {
                                    // Add the parameter to the command
                                    cmd.Parameters.AddWithValue("@ProductID", productId);

                                    // Open the connection
                                    conn.Open();

                                    // Execute the DELETE command
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    // Show a message if the deletion was successful for this row
                                    if (rowsAffected > 0)
                                    {
                                        Console.WriteLine("Product ID " + productId + " deleted successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No product found with ProductID " + productId);
                                    }
                                }
                            }
                        }

                        // Refresh the DataGridView to reflect the changes
                        LoadInventoryData();

                        MessageBox.Show("Selected products deleted successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one product to delete.");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btRecords_Click(object sender, EventArgs e)
        {
            try
            {
                Form RecordsTab = new RecordsTab(loggedInUserId);  // Instantiate the form
                RecordsTab.Show();  // Display the new form
                this.Hide();     // Hide the current form
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected column name and convert to uppercase
            string sortColumn = cbSort.SelectedItem.ToString().ToUpper();

            // Sort the DataGridView
            SortDataGridView(sortColumn);
        }
        private void SortDataGridView(string sortColumn)
        {
            // Get the BindingSource from the DataGridView (if it's already set)
            BindingSource bindingSource = (BindingSource)dgvInventory.DataSource;

            // Convert Quantity to numeric before sorting
            if (sortColumn == "StockQuantity".ToUpper())
            {
                // Create a new DataTable to store the converted data
                DataTable convertedDataTable = dt.Clone(); // Create a clone of the original DataTable

                // Iterate through the rows of the original DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Convert Quantity to int
                    int quantity = Convert.ToInt32(row["StockQuantity"]);

                    // Add a new row to the converted DataTable with the converted Quantity
                    convertedDataTable.Rows.Add(row["ProductID"], row["ProductName"], row["ProductBrand"], row["ProductCategory"], row["ProductPrice"], quantity, row["ReorderLevel"], row["DateStocked"], row["ExpirationDate"]);
                }

                // Set the BindingSource's DataSource to the converted DataTable
                bindingSource.DataSource = convertedDataTable;
            }

            // Sort the BindingSource by the selected column (convert to uppercase)
            bindingSource.Sort = sortColumn + " ASC"; // "ASC" for ascending, "DESC" for descending
        }


        private void btImport_Click(object sender, EventArgs e)
        {
            // Show an OpenFileDialog to select the Excel file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Select Excel File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFilePath = openFileDialog.FileName; // Path of the selected Excel file
                string accessDbPath = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb"; // Path to your Access DB

                // Connection string for Excel
                string excelConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFilePath + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";

                // Connection string for MS Access
                string accessConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb;" + accessDbPath + ";Persist Security Info=False;";

                try
                {
                    using (OleDbConnection excelConn = new OleDbConnection(excelConnString))
                    {
                        excelConn.Open();

                        // Get the sheet names from the Excel file
                        DataTable sheetNames = excelConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        if (sheetNames != null && sheetNames.Rows.Count > 0)
                        {
                            // Get the name of the first sheet
                            string sheetName = sheetNames.Rows[0]["TABLE_NAME"].ToString();

                            // Optional: Show the sheet name (for debugging purposes)
                            MessageBox.Show("Sheet name: " + sheetName);

                            // Now you can use sheetName to read data from the selected sheet.
                            string query = "SELECT * FROM [" + sheetName + "]";  // Query to select all data from the sheet
                            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConn);
                            DataTable excelData = new DataTable();
                            dataAdapter.Fill(excelData);  // Fill the DataTable with data from the Excel sheet

                            // Now, insert data into Access database
                            using (OleDbConnection accessConn = new OleDbConnection(accessConnString))
                            {
                                accessConn.Open();

                                // Insert data into the table
                                foreach (DataRow row in excelData.Rows)
                                {
                                    string insertQuery = "INSERT INTO Inventory (ProductName, ProductBrand, ProductCategory, ProductPrice, StockQuantity, ReorderLevel, ExpirationDate, UserID) " +
                                                         "VALUES (@ProductName, @ProductBrand, @ProductCategory, @ProductPrice, @StockQuantity, @ReorderLevel, @ExpirationDate, @UserID)";

                                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, accessConn))
                                    {
                                        // Add parameters to the command
                                        cmd.Parameters.AddWithValue("@ProductName", row["ProductName"]);
                                        cmd.Parameters.AddWithValue("@ProductBrand", row["ProductBrand"]);
                                        cmd.Parameters.AddWithValue("@ProductCategory", row["ProductCategory"]);
                                        cmd.Parameters.AddWithValue("@ProductPrice", row["ProductPrice"]);
                                        cmd.Parameters.AddWithValue("@StockQuantity", row["StockQuantity"]);
                                        cmd.Parameters.AddWithValue("@ReorderLevel", row["ReorderLevel"]);
                                        cmd.Parameters.AddWithValue("@ExpirationDate", row["ExpirationDate"]);
                                        //cmd.Parameters.AddWithValue("@Supplier", row["Supplier"]);

                                        // Insert the current UserID
                                        cmd.Parameters.AddWithValue("@UserID", loggedInUserId);

                                        cmd.ExecuteNonQuery();  // Execute the insert command
                                    }
                                }

                                // Example: Update the 'Logs' table with a specific UserID after import
                                string updateLogQuery = "UPDATE Inventory SET DateStocked = @DateStocked WHERE UserID = @UserID AND DateStocked IS NULL";

                                using (OleDbCommand updateCmd = new OleDbCommand(updateLogQuery, accessConn))
                                {
                                    string formattedDateStocked = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    // You can set the logout timestamp or any other logic
                                    OleDbCommand cmd = new OleDbCommand(updateLogQuery, conn);
                                    updateCmd.Parameters.AddWithValue("@DateStocked", formattedDateStocked);  // Example timestamp
                                    updateCmd.Parameters.AddWithValue("@UserID", loggedInUserId);

                                    // Execute the update query
                                    updateCmd.ExecuteNonQuery();


                                }
                                LoadInventoryData();



                                // Show success message to the user using MessageBox
                                MessageBox.Show("Import completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            // Show error message if no sheets are found
                            MessageBox.Show("No sheets found in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    MessageBox.Show("Error: " + ex.Message, "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb";

            // Initialize the OleDbConnection
            conn = new OleDbConnection(connectionString);

            // Prepare the SQL query (using parameterized queries)
            string searchQuery = "SELECT * FROM Inventory WHERE ProductID LIKE ? OR ProductName LIKE ? OR ProductCategory LIKE ? OR ProductBrand LIKE ?";

            // Create a new OleDbDataAdapter with the search query and the database connection
            adapter = new OleDbDataAdapter(searchQuery, conn);

            // Add parameters for ProductID, ProductName, and ProductCategory
            string searchText = tbSearch.Text.Trim() + "%";  // Add '%' for partial matching
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText); // For ProductID
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText); // For ProductName
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText); // For ProductCategory
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText);

            // Create a new DataTable to hold the search results
            dt = new DataTable();


            try
            {
                // Open the connection, fill the DataTable with search results, and close the connection
                conn.Open();
                adapter.Fill(dt); // Fill the DataTable with search results
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Bind the DataTable to the DataGridView
            dgvInventory.DataSource = dt;

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            // Get the current row index
            int rowIndex = dgvInventory.CurrentCell.RowIndex;

            // Check if a row is selected
            if (rowIndex >= 0)
            {
                // Get the ProductID from the selected row
                int productID = Convert.ToInt32(dgvInventory.Rows[rowIndex].Cells["ProductID"].Value);

                // Get the updated values from the DataGridView cells
                string productName = dgvInventory.Rows[rowIndex].Cells["ProductName"].Value.ToString();
                string productBrand = dgvInventory.Rows[rowIndex].Cells["ProductBrand"].Value.ToString();
                decimal productPrice = Convert.ToDecimal(dgvInventory.Rows[rowIndex].Cells["ProductPrice"].Value);
                int stockQuantity = Convert.ToInt32(dgvInventory.Rows[rowIndex].Cells["StockQuantity"].Value);
                int reorderLevel = Convert.ToInt32(dgvInventory.Rows[rowIndex].Cells["ReorderLevel"].Value);

                // Validate StockQuantity
                if (stockQuantity < 0 || stockQuantity > 100)
                {
                    MessageBox.Show("Stock Quantity must be between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Don't proceed with the update
                }

                // Create the update query
                string query = "UPDATE Inventory SET ProductName = @ProductName, ProductBrand = @ProductBrand, ProductPrice = @ProductPrice, StockQuantity = @StockQuantity, ReorderLevel = @ReorderLevel WHERE ProductID = @ProductID";

                // Create and configure the command
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@ProductBrand", productBrand);
                    cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
                    cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                    cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    // Execute the update command
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    // Display message based on the result
                    MessageBox.Show(rowsAffected > 0 ? "Product Updated Successfully" : "No product found with the provided ID.");
                }

                // Refresh the DataGridView
                LoadInventoryData(); // Assuming you have a function to reload data
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        public void dgvInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            HighlightLowStock();
        }

        private void btShelf_Click(object sender, EventArgs e)
        {
            // Create an instance of the Shelf form
            shelfForm = new Shelf(loggedInUserId);
            shelfForm.Show();

            shelfForm.RefreshShelfData += shelfForm.LoadShelfData;

            this.Hide();
        }
        private string GetUsernameFromUserID(int userID)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserName FROM Users WHERE UserID = @UserID";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0); // Get the username from the first column
                    }
                }
                conn.Close();
            }
            return "Unknown User"; // Return "Unknown User" if no username is found
        }

        public void btAutofill_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if 'LastUpdated' column exists in ShelfAllocation table
                    DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "ShelfAllocation", "LastUpdated" });
                    if (schemaTable.Rows.Count == 0) // Column does not exist
                    {
                        string alterTableQuery = "ALTER TABLE ShelfAllocation ADD LastUpdated DATETIME";
                        using (OleDbCommand cmdAlterTable = new OleDbCommand(alterTableQuery, conn))
                        {
                            cmdAlterTable.ExecuteNonQuery();
                            MessageBox.Show("LastUpdated column added successfully!");
                        }
                    }

                    // Process each selected row in the DataGridView
                    foreach (DataGridViewRow row in dgvInventory.SelectedRows)
                    {
                        try
                        {
                            // Get values from the DataGridView row, handling nulls
                            int? productID = row.Cells["ProductID"].Value as int?;
                            string productName = row.Cells["ProductName"].Value as string;
                            string productBrand = row.Cells["ProductBrand"].Value as string;
                            string productCategory = row.Cells["ProductCategory"].Value as string;
                            decimal? productPrice = row.Cells["ProductPrice"].Value as decimal?;
                            DateTime? expirationDate = row.Cells["ExpirationDate"].Value as DateTime?;

                            // Get the StockQuantity from the Inventory table
                            string selectStockQuery = "SELECT StockQuantity FROM Inventory WHERE ProductID = @ProductID";
                            using (OleDbCommand cmdSelectStock = new OleDbCommand(selectStockQuery, conn))
                            {
                                cmdSelectStock.Parameters.AddWithValue("@ProductID", productID);
                                object stockQuantityResult = cmdSelectStock.ExecuteScalar();
                                int stockQuantity = stockQuantityResult != DBNull.Value ? (int)stockQuantityResult : 0;

                                // Check if the ProductID already exists in ShelfAllocation
                                string checkProductQuery = "SELECT ShelfStock FROM ShelfAllocation WHERE ProductID = @ProductID";
                                using (OleDbCommand cmdCheckProduct = new OleDbCommand(checkProductQuery, conn))
                                {
                                    cmdCheckProduct.Parameters.AddWithValue("@ProductID", productID);
                                    object shelfStockResult = cmdCheckProduct.ExecuteScalar();

                                    if (shelfStockResult != null) // ProductID exists in ShelfAllocation
                                    {
                                        int currentShelfStock = (int)shelfStockResult;
                                        int updatedShelfStock = Math.Min(currentShelfStock + stockQuantity, 50); // Ensure ShelfStock doesn't exceed 50
                                        int stockReduction = updatedShelfStock - currentShelfStock;

                                        // Update the ShelfStock and LastUpdated in ShelfAllocation
                                        //string updateShelfQuery = "UPDATE ShelfAllocation SET ShelfStock = @ShelfStock, LastUpdated = @LastUpdated WHERE ProductID = @ProductID";
                                        //using (OleDbCommand cmdUpdateShelf = new OleDbCommand(updateShelfQuery, conn))
                                        {
                                            //cmdUpdateShelf.Parameters.AddWithValue("@ShelfStock", updatedShelfStock);
                                            //cmdUpdateShelf.Parameters.AddWithValue("@LastUpdated", DateTime.Now);
                                            //cmdUpdateShelf.Parameters.AddWithValue("@ProductID", productID);
                                            //cmdUpdateShelf.ExecuteNonQuery();
                                        }

                                        // Reduce the StockQuantity in Inventory
                                        string reduceStockQuery = "UPDATE Inventory SET StockQuantity = StockQuantity - @StockReduction WHERE ProductID = @ProductID";
                                        using (OleDbCommand cmdReduceStock = new OleDbCommand(reduceStockQuery, conn))
                                        {
                                            cmdReduceStock.Parameters.AddWithValue("@StockReduction", stockReduction);
                                            cmdReduceStock.Parameters.AddWithValue("@ProductID", productID);
                                            cmdReduceStock.ExecuteNonQuery();
                                        }
                                    }
                                    else // ProductID does not exist in ShelfAllocation
                                    {
                                        // Insert the new record into ShelfAllocation
                                        string insertQuery = "INSERT INTO ShelfAllocation (ProductID, ProductName, ProductBrand, ProductCategory, ProductPrice, ShelfStock, ExpirationDate) " +
                                                             "VALUES (@ProductID, @ProductName, @ProductBrand, @ProductCategory, @ProductPrice, @ShelfStock, @ExpirationDate)";
                                        int initialShelfStock = Math.Min(stockQuantity, 50);

                                        using (OleDbCommand cmdInsert = new OleDbCommand(insertQuery, conn))
                                        {
                                            cmdInsert.Parameters.AddWithValue("@ProductID", productID ?? (object)DBNull.Value);
                                            cmdInsert.Parameters.AddWithValue("@ProductName", string.IsNullOrEmpty(productName) ? (object)DBNull.Value : productName);
                                            cmdInsert.Parameters.AddWithValue("@ProductBrand", string.IsNullOrEmpty(productBrand) ? (object)DBNull.Value : productBrand);
                                            cmdInsert.Parameters.AddWithValue("@ProductCategory", string.IsNullOrEmpty(productCategory) ? (object)DBNull.Value : productCategory);
                                            cmdInsert.Parameters.AddWithValue("@ProductPrice", productPrice ?? (object)DBNull.Value);
                                            cmdInsert.Parameters.AddWithValue("@ShelfStock", initialShelfStock);
                                            cmdInsert.Parameters.AddWithValue("@ExpirationDate", expirationDate ?? (object)DBNull.Value);
                                            //cmdInsert.Parameters.AddWithValue("@LastUpdated", DateTime.Now);
                                            cmdInsert.ExecuteNonQuery();
                                        }

                                        // Reduce the StockQuantity in Inventory
                                        string reduceStockQuery = "UPDATE Inventory SET StockQuantity = StockQuantity - @StockReduction WHERE ProductID = @ProductID";
                                        using (OleDbCommand cmdReduceStock = new OleDbCommand(reduceStockQuery, conn))
                                        {
                                            cmdReduceStock.Parameters.AddWithValue("@StockReduction", initialShelfStock);
                                            cmdReduceStock.Parameters.AddWithValue("@ProductID", productID);
                                            cmdReduceStock.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error processing row: " + ex.Message);
                        }
                    }

                    // Optionally, reload the shelf data after processing
                    if (shelfForm != null)
                    {
                        shelfForm.RefreshData(); // Call the RefreshData method in the Shelf form
                    }

                    MessageBox.Show("Data processed successfully, shelf updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing data: " + ex.Message);
                }
            }
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            try
            {
                Form Sales = new Sales(loggedInUserId); // Pass the ID
                Sales.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if 'LastUpdated' column exists in ShelfAllocation table
                    DataTable schemaTable = conn.GetSchema("Columns", new string[] { null, null, "ShelfAllocation", "LastUpdated" });
                    if (schemaTable.Rows.Count == 0) // Column does not exist
                    {
                        string alterTableQuery = "ALTER TABLE ShelfAllocation ADD LastUpdated DATETIME";
                        using (OleDbCommand cmdAlterTable = new OleDbCommand(alterTableQuery, conn))
                        {
                            cmdAlterTable.ExecuteNonQuery();
                            MessageBox.Show("LastUpdated column added successfully!");
                        }
                    }

                    // Process each selected row in the DataGridView
                    foreach (DataGridViewRow row in dgvInventory.SelectedRows)
                    {
                        try
                        {
                            // Get values from the DataGridView row, handling nulls
                            int? productID = row.Cells["ProductID"].Value as int?;
                            string productName = row.Cells["ProductName"].Value as string;
                            string productBrand = row.Cells["ProductBrand"].Value as string;
                            string productCategory = row.Cells["ProductCategory"].Value as string;
                            decimal? productPrice = row.Cells["ProductPrice"].Value as decimal?;
                            DateTime? expirationDate = row.Cells["ExpirationDate"].Value as DateTime?;

                            // Get the StockQuantity from the Inventory table
                            string selectStockQuery = "SELECT StockQuantity FROM Inventory WHERE ProductID = @ProductID";
                            using (OleDbCommand cmdSelectStock = new OleDbCommand(selectStockQuery, conn))
                            {
                                cmdSelectStock.Parameters.AddWithValue("@ProductID", productID);
                                object stockQuantityResult = cmdSelectStock.ExecuteScalar();
                                int stockQuantity = stockQuantityResult != DBNull.Value ? (int)stockQuantityResult : 0;

                                // Check if the ProductID already exists in ShelfAllocation
                                string checkProductQuery = "SELECT ShelfStock FROM ShelfAllocation WHERE ProductID = @ProductID";
                                using (OleDbCommand cmdCheckProduct = new OleDbCommand(checkProductQuery, conn))
                                {
                                    cmdCheckProduct.Parameters.AddWithValue("@ProductID", productID);
                                    object shelfStockResult = cmdCheckProduct.ExecuteScalar();

                                    if (shelfStockResult != null) // ProductID exists in ShelfAllocation
                                    {
                                        int currentShelfStock = (int)shelfStockResult;
                                        int updatedShelfStock = Math.Min(currentShelfStock + stockQuantity, 50); // Ensure ShelfStock doesn't exceed 50
                                        int stockReduction = updatedShelfStock - currentShelfStock;

                                        // Update the ShelfStock and LastUpdated in ShelfAllocation
                                        //string updateShelfQuery = "UPDATE ShelfAllocation SET ShelfStock = @ShelfStock, LastUpdated = @LastUpdated WHERE ProductID = @ProductID";
                                        //using (OleDbCommand cmdUpdateShelf = new OleDbCommand(updateShelfQuery, conn))
                                        {
                                            //cmdUpdateShelf.Parameters.AddWithValue("@ShelfStock", updatedShelfStock);
                                            //cmdUpdateShelf.Parameters.AddWithValue("@LastUpdated", DateTime.Now);
                                            //cmdUpdateShelf.Parameters.AddWithValue("@ProductID", productID);
                                            //cmdUpdateShelf.ExecuteNonQuery();
                                        }

                                        // Reduce the StockQuantity in Inventory
                                        string reduceStockQuery = "UPDATE Inventory SET StockQuantity = StockQuantity - @StockReduction WHERE ProductID = @ProductID";
                                        using (OleDbCommand cmdReduceStock = new OleDbCommand(reduceStockQuery, conn))
                                        {
                                            cmdReduceStock.Parameters.AddWithValue("@StockReduction", stockReduction);
                                            cmdReduceStock.Parameters.AddWithValue("@ProductID", productID);
                                            cmdReduceStock.ExecuteNonQuery();
                                        }
                                    }
                                    else // ProductID does not exist in ShelfAllocation
                                    {
                                        // Insert the new record into ShelfAllocation
                                        string insertQuery = "INSERT INTO ShelfAllocation (ProductID, ProductName, ProductBrand, ProductCategory, ProductPrice, ShelfStock, ExpirationDate) " +
                                                             "VALUES (@ProductID, @ProductName, @ProductBrand, @ProductCategory, @ProductPrice, @ShelfStock, @ExpirationDate)";
                                        int initialShelfStock = Math.Min(stockQuantity, 50);

                                        using (OleDbCommand cmdInsert = new OleDbCommand(insertQuery, conn))
                                        {
                                            cmdInsert.Parameters.AddWithValue("@ProductID", productID ?? (object)DBNull.Value);
                                            cmdInsert.Parameters.AddWithValue("@ProductName", string.IsNullOrEmpty(productName) ? (object)DBNull.Value : productName);
                                            cmdInsert.Parameters.AddWithValue("@ProductBrand", string.IsNullOrEmpty(productBrand) ? (object)DBNull.Value : productBrand);
                                            cmdInsert.Parameters.AddWithValue("@ProductCategory", string.IsNullOrEmpty(productCategory) ? (object)DBNull.Value : productCategory);
                                            cmdInsert.Parameters.AddWithValue("@ProductPrice", productPrice ?? (object)DBNull.Value);
                                            cmdInsert.Parameters.AddWithValue("@ShelfStock", initialShelfStock);
                                            cmdInsert.Parameters.AddWithValue("@ExpirationDate", expirationDate ?? (object)DBNull.Value);
                                            //cmdInsert.Parameters.AddWithValue("@LastUpdated", DateTime.Now);
                                            cmdInsert.ExecuteNonQuery();
                                        }

                                        // Reduce the StockQuantity in Inventory
                                        string reduceStockQuery = "UPDATE Inventory SET StockQuantity = StockQuantity - @StockReduction WHERE ProductID = @ProductID";
                                        using (OleDbCommand cmdReduceStock = new OleDbCommand(reduceStockQuery, conn))
                                        {
                                            cmdReduceStock.Parameters.AddWithValue("@StockReduction", initialShelfStock);
                                            cmdReduceStock.Parameters.AddWithValue("@ProductID", productID);
                                            cmdReduceStock.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error processing row: " + ex.Message);
                        }
                    }

                    // Optionally, reload the shelf data after processing
                    if (shelfForm != null)
                    {
                        shelfForm.RefreshData(); // Call the RefreshData method in the Shelf form
                    }

                    MessageBox.Show("Data processed successfully, shelf updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing data: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
