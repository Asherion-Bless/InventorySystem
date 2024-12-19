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
    public partial class SupplierTab : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;

        public SupplierTab()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = InventoryManagementSystem.accdb;");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSupplyName.Text) ||    // Product Name
               string.IsNullOrWhiteSpace(tbSupplyContact.Text) ||    // Product Brand
               string.IsNullOrWhiteSpace(tbSupplyEmail.Text) ||     // Product Category
               string.IsNullOrWhiteSpace(tbSupplyAddress.Text))    // Product Price
            {
                MessageBox.Show("Please fill in all fields."); // Display a message if any field is empty
                return; // Exit the method if any field is missing
            }
             // SQL query to insert a new product into the 'Inventory' table
            string query = "INSERT INTO Suppliers (SupplierName, SupplierContact, SupplierEmail, SupplierAddress) VALUES " +
                           "(@SupplierName, @SupplierContact, @SupplierEmail, @SupplierAddress)";

            // Create the command to execute the query
            cmd = new OleDbCommand(query, conn);

            // Add values from textboxes and other controls to the command parameters
            cmd.Parameters.AddWithValue("@SupplierName", tbSupplyName.Text); // Product Name
            cmd.Parameters.AddWithValue("@SupplierContact", tbSupplyContact.Text); // Product Brand
            cmd.Parameters.AddWithValue("@SupplierEmail", tbSupplyEmail.Text); // Product Category
            cmd.Parameters.AddWithValue("@SupplierAddress", tbSupplyAddress.Text); // Product Price (Decimal)

            try
            {
                // Open the connection, execute the command, and close the connection
                conn.Open(); // Open the connection to the database
                cmd.ExecuteNonQuery(); // Execute the insert query
                MessageBox.Show("Supplier Inserted Successfully"); // Show success message
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
            tbSupplyName.Clear(); // Clear the Last Name textbox
            tbSupplyContact.Clear();  // Clear the Username textbox
            tbSupplyEmail.Clear();  // Clear the Password textbox
            tbSupplyAddress.Clear();  // Clear the ReenterPassword textbox
        }
    }
    
}
