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
    public partial class UserTab : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        private int loggedInUserId;
        private Shelf shelfForm = null; // Initialize shelfForm to null

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
            int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse
           );

        public UserTab(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = InventoryManagementSystem.accdb;");

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

        private void UserTab_Load(object sender, EventArgs e)
        {
            GetUsers();

            btCreateAcc.Region = Region.FromHrgn(CreateRoundRectRgn
             (0, 0, btCreateAcc.Width, btCreateAcc.Height, 30, 30));
            btDelete.Region = Region.FromHrgn(CreateRoundRectRgn
             (0, 0, btDelete.Width, btDelete.Height, 30, 30));
        }

        private void GetUsers()
        {
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Users", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvUsers.DataSource = dt;
            // Close the database connection
            conn.Close();
        }
        private void UserTab_Load1(object sender, EventArgs e)
        {
            GetUsers();
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

        private void btCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                Form CreateAccount = new CreateAccount.CreateAccount();  // Instantiate the form
                CreateAccount.Show();  // Display the new form
                //this.Close();     // Hide the current form
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
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


        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any rows are selected in the DataGridView
                if (dgvUsers.SelectedRows.Count > 0)
                {
                    // Confirm the delete action with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected users?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Loop through all selected rows in the DataGridView
                        foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                        {
                            // Skip the row if it's a new row (can be added to prevent deleting new, unsaved rows)
                            if (row.IsNewRow) continue;

                            // Get the ProductID from the selected row (assuming ProductID is in the first column)
                            int UserID = Convert.ToInt32(row.Cells["UserID"].Value);

                            // Define the connection string
                            string connString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=InventoryManagementSystem.accdb";

                            // Create the SQL query with a parameter for ProductID
                            string query = "DELETE FROM Users WHERE UserID = @UserID";

                            // Create a new OleDbConnection object
                            using (OleDbConnection conn = new OleDbConnection(connString))
                            {
                                // Create the OleDbCommand object
                                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                                {
                                    // Add the parameter to the command
                                    cmd.Parameters.AddWithValue("@UserID", UserID);

                                    // Open the connection
                                    conn.Open();

                                    // Execute the DELETE command
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    // Show a message if the deletion was successful for this row
                                    if (rowsAffected > 0)
                                    {
                                        Console.WriteLine("User ID " + UserID + " deleted successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No product found with User ID " + UserID);
                                    }
                                }
                            }
                        }

                        // Refresh the DataGridView to reflect the changes
                        GetUsers();

                        MessageBox.Show("Selected users deleted successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one user to delete.");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btHistory_Click(object sender, EventArgs e)
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

        private void btShelf_Click(object sender, EventArgs e)
        {
            if (shelfForm == null || shelfForm.IsDisposed)
            {
                shelfForm = new Shelf(loggedInUserId);
                shelfForm.RefreshShelfData += shelfForm.LoadShelfData;
            }

            shelfForm.Show();
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
    }
}
