using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;


namespace CreateAccount
{
    public partial class CreateAccount : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        public int loggedInUserId;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
             int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse
          );

        public CreateAccount()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = InventoryManagementSystem.accdb;");
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            btSave.Region = Region.FromHrgn(CreateRoundRectRgn
                    (0, 0, btSave.Width, btSave.Height, 30, 30));
            btClear.Region = Region.FromHrgn(CreateRoundRectRgn
                    (0, 0, btClear.Width, btClear.Height, 30, 30));
            //btDelete.Region = Region.FromHrgn(CreateRoundRectRgn
            //      (0, 0, btDelete.Width, btDelete.Height, 30, 30));
            //textbox ellipse
            cbType.Region = Region.FromHrgn(CreateRoundRectRgn
                    (0, 0, cbType.Width, cbType.Height, 30, 30));
            tbUsername.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, tbUsername.Width, tbUsername.Height, 15, 15));
            tbPassword.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, tbPassword.Width, tbPassword.Height, 15, 15));
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Users (UserName, [Password], [Type]) VALUES (@UserName, @Password, @Type)";
            cmd = new OleDbCommand(query, conn);

            // First, get the latest UserID (maximum value) from the Users table
            OleDbCommand cmdGetMaxID = new OleDbCommand("SELECT MAX(UserID) FROM Users", conn);

            try
            {
                conn.Open(); // Open the connection to the database

                // Get the latest UserID
                object result = cmdGetMaxID.ExecuteScalar();
                int newUserID;

                if (result == DBNull.Value)
                {
                    // If there are no users yet, start from 1
                    newUserID = 1;
                }
                else
                {
                    // Increment the latest UserID
                    newUserID = Convert.ToInt32(result) + 1;
                }

                // Now, add the new user to the table with the incremented UserID
                //cmd.Parameters.Add("@UserID", OleDbType.Integer).Value = newUserID;
                cmd.Parameters.Add("@UserName", OleDbType.VarWChar, 50).Value = tbUsername.Text;
                cmd.Parameters.Add("@Password", OleDbType.VarWChar, 50).Value = tbPassword.Text;
                cmd.Parameters.Add("@Type", OleDbType.VarWChar, 50).Value = cbType.Text;

                // Execute the insert query
                cmd.ExecuteNonQuery();

                MessageBox.Show("User Inserted Successfully");

                try
                {
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Show error message
            }
            finally
            {
                conn.Close(); // Close the connection to the database
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            tbUsername.Clear(); // Clear the Last Name textbox
            tbPassword.Clear();
            //tbType.Clear();// Clear the Username textbox
            // Clear the ReenterPassword textbox
        }
    }
}

