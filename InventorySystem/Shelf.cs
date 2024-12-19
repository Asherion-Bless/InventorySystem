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
using System.Runtime.InteropServices;

namespace InventorySystem
{
    public partial class Shelf : Form
    {
        public delegate void RefreshShelfDataEventHandler();
        public event RefreshShelfDataEventHandler RefreshShelfData;

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public int loggedInUserId;
        string connectionString = ("Provider= Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse
            );


        public Shelf(int ID)
        {
            InitializeComponent();
            loggedInUserId = ID;
            LoadShelfData();

            // Subscribe to the RefreshShelfData event

            // Get the username from the database using the logged-in UserID
            string username = GetUsernameFromUserID(loggedInUserId);

            // Set the text of the lUser label to the username
            lUser.Text = "User: " + username;

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
        public void LoadShelfData()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb");

            // Initialize the DataTable to hold data
            dt = new DataTable();
           
            try
            {
                // Set up an adapter to run the query and fetch the data
                adapter = new OleDbDataAdapter("SELECT * FROM ShelfAllocation", conn);

                // Open the connection
                conn.Open();

                // Fill the DataTable with the result of the query
                adapter.Fill(dt);

                // Check if the DataTable has any rows
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found in ShelfAllocation table.");
                }

                // Create a BindingSource and set its DataSource
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                // Set the DataGridView's DataSource to the BindingSource
                dgvShelf.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                conn.Close();
                HighlightLowStock();

            }
        }

        public void RefreshData()
        {
            LoadShelfData();
        }

        private void Shelf_Load(object sender, EventArgs e)
        {
            LoadShelfData();
            CheckAndDisplayNotifications();

            btDelete.Region = Region.FromHrgn(CreateRoundRectRgn
              (0, 0, btDelete.Width, btDelete.Height, 30, 30));
            cbSort.Region = Region.FromHrgn(CreateRoundRectRgn
            (0, 0, cbSort.Width, cbSort.Height, 30, 30));
        }

        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in dgvShelf.Rows)
            {
                // Check if the row is the new row (empty row)
                if (row.IsNewRow)
                {
                    continue; // Skip to the next row
                }

                // Check if StockShelf column exists and has a value
                if (row.Cells["ShelfStock"].Value != DBNull.Value)
                {
                    int stockShelf = Convert.ToInt32(row.Cells["ShelfStock"].Value);

                    // Highlight if StockShelf is less than or equal to 10
                    if (stockShelf <= 10)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Red; // Use red for highlighting
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White; // Set text color to white
                    }
                    else
                    {
                        // Reset the background color to default if not low stock
                        row.DefaultCellStyle.BackColor = dgvShelf.DefaultCellStyle.BackColor;
                        // Reset the foreground color to default if not low stock
                        row.DefaultCellStyle.ForeColor = dgvShelf.DefaultCellStyle.ForeColor; // Use default color
                    }
                }
            }

            // Refresh the DataGridView to apply the changes
            dgvShelf.Refresh();
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
                this.Hide();
                Form LogInForm = new LogInForm();
                LogInForm.Show();
                //Application.Exit();
            }
        }

        private void btInventory_Click(object sender, EventArgs e)
        {
            try
            {
                int currentUserID = 1;
                // Create an instance of the AdminInterface form (fully qualified name)
                InventorySystem.AdminInterface AdminInterface = new InventorySystem.AdminInterface(currentUserID);

                // Show the form
                AdminInterface.Show();

                // Hide the current form
                this.Hide();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btAutofill_Click(object sender, EventArgs e)
        {
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
                string lowStockQuery = "SELECT ProductID, ProductName, ShelfStock FROM ShelfAllocation WHERE ShelfStock <= 20";
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
                string nearExpiryQuery = "SELECT ProductID, ProductName, ExpirationDate FROM ShelfAllocation WHERE ExpirationDate IS NOT NULL AND ExpirationDate <= ?";
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

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected column name and convert to uppercase
            string sortColumn = cbSort.SelectedItem.ToString().ToUpper();

            // Sort the DataGridView
            SortDataGridView(sortColumn);
        }
        private void SortDataGridView(string sortColumn)
        {
            // Get the BindingSource from the DataGridView (if it's already set)
            BindingSource bindingSource = (BindingSource)dgvShelf.DataSource;

            // Convert Quantity to numeric before sorting
            if (sortColumn == "ShelfStock".ToUpper())
            {
                // Create a new DataTable to store the converted data
                DataTable convertedDataTable = dt.Clone(); // Create a clone of the original DataTable

                // Iterate through the rows of the original DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Convert Quantity to int
                    int quantity = Convert.ToInt32(row["ShelfStock"]);

                    // Add a new row to the converted DataTable with the converted Quantity
                    convertedDataTable.Rows.Add(row["ProductID"], row["ProductName"], row["ProductBrand"], row["ProductCategory"], row["ProductPrice"], row["ExpirationDate"]);
                }

                // Set the BindingSource's DataSource to the converted DataTable
                bindingSource.DataSource = convertedDataTable;
            }

            // Sort the BindingSource by the selected column (convert to uppercase)
            bindingSource.Sort = sortColumn + " ASC"; // "ASC" for ascending, "DESC" for descending
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any rows are selected in the DataGridView
                if (dgvShelf.SelectedRows.Count > 0)
                {
                    // Confirm the delete action with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected products?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Loop through all selected rows in the DataGridView
                        foreach (DataGridViewRow row in dgvShelf.SelectedRows)
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
                        LoadShelfData();

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
    }
    
}





