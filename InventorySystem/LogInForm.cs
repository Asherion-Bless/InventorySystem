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
using System.Timers;

namespace InventorySystem
{
    public partial class LogInForm : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        private Dictionary<string, int> loginAttemptsDictionary = new Dictionary<string, int>();
        private Dictionary<string, DateTime> lockoutEndTimesDictionary = new Dictionary<string, DateTime>();

        private int currentUserID;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse
            );

        public LogInForm()
        {
            InitializeComponent();

            // Start a timer to check for unlocked users every second
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            //button ellipse
            btLogin.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btLogin.Width, btLogin.Height, 30, 30));
            //textbox ellipse
            tbUsername.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, tbUsername.Width, tbUsername.Height, 15, 15));
            tbPassword.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, tbPassword.Width, tbPassword.Height, 15, 15));
            //panel ellipse
            pTB.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pTB.Width, pTB.Height, 7, 7));
            pTB2.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pTB2.Width, pTB2.Height, 7, 7));
            pPanelBg.Region = Region.FromHrgn(CreateRoundRectRgn
               (0, 0, pPanelBg.Width, pPanelBg.Height, 15, 15));
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;

            if (loginAttemptsDictionary.ContainsKey(username) && loginAttemptsDictionary[username] >= 3 && DateTime.Now < lockoutEndTimesDictionary[username])
            {
                MessageBox.Show("Your account is locked. Please try again later.");
                return;
            }

            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = InventoryManagementSystem.accdb;");
            string query = "SELECT UserID, [Type] FROM Users WHERE Username = @username AND Password = @password";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int ID = (int)reader["UserID"];
                    string userType = reader["Type"].ToString();

                    currentUserID = ID;  // Assign the retrieved ID to currentUserID

                    reader.Close();
                    this.Hide();
                    string formattedLoginTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string insertLogQuery = "INSERT INTO Logs (UserID,LoginTimestamp,Type) VALUES (@ID, @LoginTimestamp,@type)";
                    OleDbCommand insertCmd = new OleDbCommand(insertLogQuery, conn);
                    insertCmd.Parameters.AddWithValue("@userId", ID);
                    insertCmd.Parameters.AddWithValue("@LoginTimestamp", formattedLoginTimestamp);
                    insertCmd.Parameters.AddWithValue("@type", userType);
                    insertCmd.ExecuteNonQuery();

                    if (userType == "Admin")
                    {
                        Form AdminInterface = new AdminInterface(ID);
                        AdminInterface.Show();
                    }
                    else if (userType == "Staff")
                    {
                        Form StaffInterface = new StaffInterface(ID);
                        StaffInterface.Show();
                    }
                    //else { MessageBox.Show("Unrecognized User."); }

                    // Reset login attempts and unlock account if it was locked
                    if (loginAttemptsDictionary.ContainsKey(username))
                    {
                        loginAttemptsDictionary[username] = 0;
                    }
                    if (lockoutEndTimesDictionary.ContainsKey(username))
                    {
                        lockoutEndTimesDictionary.Remove(username);
                    }
                }
                else
                {
                    if (!loginAttemptsDictionary.ContainsKey(username))
                    {
                        loginAttemptsDictionary[username] = 1;
                    }
                    else
                    {
                        loginAttemptsDictionary[username]++;
                    }

                    MessageBox.Show("Invalid Username or Password");

                    if (loginAttemptsDictionary[username] == 3)
                    {
                        lockoutEndTimesDictionary[username] = DateTime.Now.AddMinutes(5);
                        MessageBox.Show("Your account has been locked for 5 minute due to multiple failed login attempts.");
                    }
                }

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

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            List<string> usernamesToRemove = new List<string>();

            foreach (var pair in lockoutEndTimesDictionary)
            {
                if (DateTime.Now >= pair.Value)
                {
                    usernamesToRemove.Add(pair.Key);
                }
            }

            foreach (string username in usernamesToRemove)
            {
                lockoutEndTimesDictionary.Remove(username);
                loginAttemptsDictionary[username] = 0;
                MessageBox.Show($"Account {username} has been unlocked.");
            }
        }
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            { tbUsername.Text = ""; tbUsername.ForeColor = Color.White; }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            { tbUsername.Text = "Username"; tbUsername.ForeColor = Color.White; }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = ""; // Clear the placeholder
                tbPassword.ForeColor = Color.White; // Set text color to black
                tbPassword.PasswordChar = '*';
            }
        }
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password"; // Set the placeholder text
                tbPassword.ForeColor = Color.White; // Set text color to silver for placeholder
                tbPassword.PasswordChar = '\0'; // Remove masking (show the placeholder as text)
            }
            else
            {
                tbPassword.PasswordChar = '*'; // Ensure the text is always masked as '*'
            }

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Mask the text with asterisks while typing
            tbPassword.PasswordChar = '*';
        }
    }
}


