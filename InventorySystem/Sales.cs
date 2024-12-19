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

namespace InventorySystem
{
    public partial class Sales : Form
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

        public Sales(int ID)
        {
            InitializeComponent();
            loggedInUserId = ID;
            string username = GetUsernameFromUserID(loggedInUserId);
            RefreshInventoryData += LoadSalesData;
            lUser.Text = "User: " + username;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadSalesData();
            // Set MinDate and MaxDate to today's date only
            dtpSaleDate.MinDate = DateTime.Now.Date;  // Set minimum date to today (no time part)
            dtpSaleDate.MaxDate = DateTime.Now.Date;  // Set maximum date to today (no time part)

            // Set the DateTimePicker value to today with no time part
            dtpSaleDate.Value = DateTime.Now.Date;
        }

        private void LoadSalesData()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb;";
            string query = @"
    SELECT 
        ProductID, 
        ProductName, 
        ProductBrand, 
        ProductCategory, 
        ProductPrice
    FROM ShelfAllocation";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the data to the DataGridView
                dgvSales.DataSource = dataTable;

                // Make the DataGridView read-only
                dgvSales.ReadOnly = true;   // Prevent editing
                dgvSales.AllowUserToAddRows = false;  // Prevent adding rows
                dgvSales.AllowUserToDeleteRows = false; // Prevent deleting rows
                dgvSales.AllowUserToOrderColumns = false; // Disable column ordering
                dgvSales.AllowUserToResizeRows = false;  // Disable row resizing
            }
        }
        private void dataGridViewInventory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Sort by column clicked
            string columnName = dgvSales.Columns[e.ColumnIndex].Name;
            DataTable dt = (DataTable)dgvSales.DataSource;
            DataView dataView = dt.DefaultView;
            dataView.Sort = columnName + " ASC";
            dgvSales.DataSource = dataView.ToTable();
        }
        private void InsertSalesReportAndReduceStock(int productID, string productName, int productSold,
                                             decimal productPrice, decimal totalRevenue,
                                             DateTime saleDate, int userID)
        {
            // Connection string to your MS Access database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Begin a transaction
                OleDbTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Step 1: Reduce stock in ShelfAllocation table
                    string updateStockQuery = @"UPDATE ShelfAllocation 
                                        SET ShelfStock = ShelfStock - ? 
                                        WHERE ProductID = ? AND ShelfStock >= ?";

                    using (OleDbCommand updateCommand = new OleDbCommand(updateStockQuery, connection, transaction))
                    {
                        updateCommand.Parameters.Add("@StockReduction", OleDbType.Integer).Value = productSold;
                        updateCommand.Parameters.Add("@ProductID", OleDbType.Integer).Value = productID;
                        updateCommand.Parameters.Add("@MinimumStock", OleDbType.Integer).Value = productSold;

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            // If no rows were affected, it means insufficient stock
                            throw new Exception("Insufficient stock to complete the transaction.");
                        }
                    }

                    // Step 2: Insert into SalesReport table
                    string insertSalesQuery = @"INSERT INTO SalesReport 
                                        (ProductID, ProductName, ProductSold, ProductPrice, 
                                         TotalRevenue, SaleDate, UserID) 
                                        VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand insertCommand = new OleDbCommand(insertSalesQuery, connection, transaction))
                    {
                        insertCommand.Parameters.Add("@ProductID", OleDbType.Integer).Value = productID;
                        insertCommand.Parameters.Add("@ProductName", OleDbType.VarChar).Value = productName;
                        insertCommand.Parameters.Add("@ProductSold", OleDbType.Integer).Value = productSold;
                        insertCommand.Parameters.Add("@ProductPrice", OleDbType.Currency).Value = productPrice;
                        insertCommand.Parameters.Add("@TotalRevenue", OleDbType.Currency).Value = totalRevenue;
                        insertCommand.Parameters.Add("@SaleDate", OleDbType.Date).Value = saleDate.Date;
                        insertCommand.Parameters.Add("@UserID", OleDbType.Integer).Value = userID;

                        insertCommand.ExecuteNonQuery();
                    }

                    // Commit the transaction
                    transaction.Commit();

                    MessageBox.Show("Sales report added and stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Rollback the transaction in case of error
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch data from form inputs
                int productID = int.Parse(txtProductID.Text); // Convert text to int
                string productName = txtProductName.Text; // Match ProductName field
                int productSold = int.Parse(txtProductSold.Text);
                decimal productPrice = decimal.Parse(txtProductPrice.Text);
                decimal totalRevenue = productSold * productPrice; // Calculate TotalRevenue

                // Ensure that only the date part is used, no time portion
                DateTime saleDate = dtpSaleDate.Value.Date; // Use .Date to remove time part

                int userID = int.Parse(txtUserID.Text);

                // Ensure the DateTimePicker is within valid date range (today only)
                if (saleDate != DateTime.Now.Date)
                {
                    MessageBox.Show("The selected date must be today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Prevent submission if the date is not today
                }

                InsertSalesReportAndReduceStock(productID, productName, productSold, productPrice, totalRevenue, saleDate, userID);


                // Show success message
                MessageBox.Show("Sales report added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form fields after submission
                ClearFields();
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductSold.Clear();
            txtProductPrice.Clear();
            txtUserID.Clear();
            dtpSaleDate.Value = DateTime.Now.Date; // Reset date picker to today's date
        }

        private void dtpSaleDate_ValueChanged(object sender, EventArgs e)
        {
            // Ensure the selected date is today (no time part)
            if (dtpSaleDate.Value.Date != DateTime.Now.Date)
            {
                // Reset to today's date if it's not today
                dtpSaleDate.Value = DateTime.Now.Date;
            }

            // Format the DateTimePicker to only display the date
            dtpSaleDate.CustomFormat = "yyyy-MM-dd";
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb";

            conn = new OleDbConnection(connectionString);

            string searchQuery = "SELECT * FROM ShelfAllocation WHERE ProductID LIKE ? OR ProductName LIKE ? OR ProductCategory LIKE ? OR ProductBrand LIKE ?";
            adapter = new OleDbDataAdapter(searchQuery, conn);

            string searchText = tbSearch.Text.Trim() + "%";  // Add '%' for partial matching
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText);
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText);
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText);
            adapter.SelectCommand.Parameters.AddWithValue("?", searchText);
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
            dgvSales.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text.Trim(); // Get the search value from the input field
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb;";

            // SQL query to search by ProductID or ProductName
            string query = @"
        SELECT 
            ProductID, 
            ProductName, 
            ProductBrand, 
            ProductCategory, 
            ProductPrice
        FROM Inventory 
        WHERE ProductID = ? OR ProductName LIKE ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection))
                {
                    // Initialize parameters for the query
                    int productID;
                    if (int.TryParse(searchValue, out productID)) // If searchValue is numeric, search by ProductID
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("?", productID); // ProductID parameter
                        dataAdapter.SelectCommand.Parameters.AddWithValue("?", DBNull.Value); // Placeholder for ProductName
                    }
                    else // Otherwise, search by ProductName
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("?", DBNull.Value); // Placeholder for ProductID
                        dataAdapter.SelectCommand.Parameters.AddWithValue("?", "%" + searchValue + "%"); // ProductName parameter
                    }

                    // Fill the results into a DataTable
                    DataTable searchResults = new DataTable();
                    dataAdapter.Fill(searchResults);

                    // Bind the results to DataGridView
                    dgvSales.DataSource = searchResults;

                    // Inform the user if no records are found
                    if (searchResults.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found matching your search.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Form SalesReport = new SalesReport(); // Pass the ID
                SalesReport.Show();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btAdminLogout_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the connection is initialized with a valid connection string
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open(); // Open the connection

                    // Format the logout timestamp
                    string formattedLogoutTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // SQL query to update the logout timestamp
                    string updateLogQuery = @"UPDATE Logs 
                                      SET LogoutTimestamp = @LogoutTimestamp 
                                      WHERE UserID = @ID AND LogoutTimestamp IS NULL";

                    // Create the command and add parameters
                    using (OleDbCommand cmd = new OleDbCommand(updateLogQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@LogoutTimestamp", formattedLogoutTimestamp);
                        cmd.Parameters.AddWithValue("@ID", loggedInUserId);
                        cmd.ExecuteNonQuery(); // Execute the update query
                    }
                }

                // Proceed to log out the user
                //this.Hide();
                Form LogInForm = new LogInForm();
                LogInForm.Show();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message, "Logout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btShelf_Click(object sender, EventArgs e)
        {
            // Create an instance of the Shelf form
            shelfForm = new Shelf(loggedInUserId);
            shelfForm.Show();

            shelfForm.RefreshShelfData += shelfForm.LoadShelfData;

            this.Hide();
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
    }
}
