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
    public partial class RecordsTab : Form
    {
        public delegate void RefreshInventoryDataEventHandler();
        public event RefreshInventoryDataEventHandler RefreshInventoryData;
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public int loggedInUserId;
        private Shelf shelfForm = null; // Initialize shelfForm to null

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
            int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse
           );

        public RecordsTab(int ID)
        {
            InitializeComponent();
            loggedInUserId = ID;
            string username = GetUsernameFromUserID(loggedInUserId);
            RefreshInventoryData += GetUsers;
            RefreshInventoryData += GetSuppliers;
            lUser.Text = "User: " + username;
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

        private void btUser_Click(object sender, EventArgs e)
        {
            try
            {
                Form UserTab = new UserTab(loggedInUserId);  // Instantiate the form
                UserTab.Show();  // Display the new form
                this.Hide();     // Hide the current form
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RecordsTab_Load(object sender, EventArgs e)
        {
            GetUsers();
            GetSuppliers();

            btAddSupplier.Region = Region.FromHrgn(CreateRoundRectRgn
            (0, 0, btAddSupplier.Width, btAddSupplier.Height, 30, 30));
            btDeleteSupplier.Region = Region.FromHrgn(CreateRoundRectRgn
             (0, 0, btDeleteSupplier.Width, btDeleteSupplier.Height, 30, 30));

        }

        private void GetUsers()
        {

            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Logs", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvLogs.DataSource = dt;
            // Close the database connection
            conn.Close();
        }
        private void GetSuppliers()
        {

            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Suppliers", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvSupplier.DataSource = dt;
            // Close the database connection
            conn.Close();
        }

        private void btAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Form SupplierTab = new SupplierTab();  // Instantiate the form
                SupplierTab.Show();  // Display the new form
                                    // this.Hide();     // Hide the current form
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any rows are selected in the DataGridView
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    // Confirm the delete action with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Loop through all selected rows in the DataGridView
                        foreach (DataGridViewRow row in dgvSupplier.SelectedRows)
                        {
                            // Skip the row if it's a new row (can be added to prevent deleting new, unsaved rows)
                            if (row.IsNewRow) continue;

                            // Get the ProductID from the selected row (assuming ProductID is in the first column)
                            int productId = Convert.ToInt32(row.Cells["SupplierID"].Value);

                            // Define the connection string
                            string connString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb";

                            // Create the SQL query with a parameter for ProductID
                            string query = "DELETE FROM Suppliers WHERE SupplierID = @Supplier";

                            // Create a new OleDbConnection object
                            using (OleDbConnection conn = new OleDbConnection(connString))
                            {
                                // Create the OleDbCommand object
                                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                                {
                                    // Add the parameter to the command
                                    cmd.Parameters.AddWithValue("@SupplierID", productId);

                                    // Open the connection
                                    conn.Open();

                                    // Execute the DELETE command
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    // Show a message if the deletion was successful for this row
                                    if (rowsAffected > 0)
                                    {
                                        Console.WriteLine("Supplier ID " + productId + " deleted successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No upplier found with SupplyID " + productId);
                                    }
                                }
                            }
                        }

                        // Refresh the DataGridView to reflect the changes
                        GetSuppliers();

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

        private void btShelf_Click(object sender, EventArgs e)
        {
    // Create an instance of the Shelf form
            shelfForm = new Shelf(loggedInUserId);
            shelfForm.Show();

            shelfForm.RefreshShelfData += shelfForm.LoadShelfData;

            this.Hide();
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
