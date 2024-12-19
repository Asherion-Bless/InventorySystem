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
    public partial class AddProduct : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        //OleDbDataAdapter adapter;

        private int loggedInUserId;

        public AddProduct(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = InventoryManagementSystem.accdb;");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbProdName.Text) ||    // Product Name
                string.IsNullOrWhiteSpace(tbBrand.Text) ||    // Product Brand
                //string.IsNullOrWhiteSpace(tbCategory.Text) ||     // Product Category
                string.IsNullOrWhiteSpace(tbPrice.Text) ||     // Product Price
                string.IsNullOrWhiteSpace(tbQuantity.Text) || // Stock Quantity
                string.IsNullOrWhiteSpace(tbReorder.Text) ||
                //string.IsNullOrWhiteSpace(tbSupplier.Text) ||// Reorder Level
                //dtDateStocked.Value == null || 
                dtExpiration.Value == null)

            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Ensure correct data types
            decimal productPrice;
            int stockQuantity, reorderLevel;            
            //DateTime dateStocked = dtDateStocked.Value;
            DateTime expirationDate = dtExpiration.Value;
            //DateTime DateStocked = DateTime.Now;
            string DateStocked = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Try to parse and handle any potential issues with incorrect data types
            if (!decimal.TryParse(tbPrice.Text, out productPrice))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(tbQuantity.Text, out stockQuantity))
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            if (!int.TryParse(tbReorder.Text, out reorderLevel))
            {
                MessageBox.Show("Please enter a valid reorder level.");
                return;
            }

            string query = "INSERT INTO Inventory (ProductName, ProductBrand, ProductCategory, ProductPrice, StockQuantity, ReorderLevel, DateStocked, ExpirationDate, UserID) VALUES " +
                           "(@ProductName, @ProductBrand, @ProductCategory, @ProductPrice, @StockQuantity, @ReorderLevel, @DateStocked, @ExpirationDate, @UserID)";
            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@ProductName", tbProdName.Text);
            cmd.Parameters.AddWithValue("@ProductBrand", tbBrand.Text);
            cmd.Parameters.AddWithValue("@ProductCategory", cbCategory.Text);
            cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
            cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
            cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
            cmd.Parameters.AddWithValue("@DateStocked", DateStocked);
            //cmd.Parameters.AddWithValue("@SupplierID", tbSupplier); //couldnt be added due to some unknown data mismatch
            //cmd.Parameters.AddWithValue("@DateStocked", DateStocked); // when not automatic
            cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            cmd.Parameters.AddWithValue("@UserID", loggedInUserId); // UserID (Int)
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Inserted Successfully");
            try
            {
               

                // Hide the current form
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
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

        private void btClear_Click(object sender, EventArgs e)
        {
            tbProdName.Clear();
            tbBrand.Clear();
            //tbCategory.Clear();  // when category is still input
            tbPrice.Clear();
            tbQuantity.Clear();
            tbReorder.Clear();
            //tbSupplier.Clear();
            //dtDateStocked.Value = DateTime.Now;
            dtExpiration.Value = DateTime.Now;}
    }
}
