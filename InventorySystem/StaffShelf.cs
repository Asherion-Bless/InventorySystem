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
    public partial class StaffShelf : Form
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


        public StaffShelf(int ID)
        {
            InitializeComponent();
            loggedInUserId = ID;
            LoadShelfData();

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
                //HighlightLowStock();

            }
        }

        public void RefreshData()
        {
            LoadShelfData();
        }

        private void btInventory_Click(object sender, EventArgs e)
        {
            try
            {
                InventorySystem.StaffInterface StaffInterface = new InventorySystem.StaffInterface(loggedInUserId);

                // Show the form
                StaffInterface.Show();

                // Hide the current form
                this.Hide();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btSales_Click(object sender, EventArgs e)
        {
            try
            {
                Form StaffSales = new StaffSales(loggedInUserId); // Pass the ID
                StaffSales.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
        private void btStaffLogout_Click(object sender, EventArgs e)
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

        private void StaffShelf_Load(object sender, EventArgs e)
        {

            cbSort.Region = Region.FromHrgn(CreateRoundRectRgn
            (0, 0, cbSort.Width, cbSort.Height, 30, 30));
        }
    }
}
