using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class SalesReport : Form
    {
        private DataTable salesReportTable = new DataTable();
        private PrintDocument printDocument = new PrintDocument();
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryManagementSystem.accdb";
        private string pdfFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\SalesReport.pdf";

        public SalesReport()
        {
            InitializeComponent();
            // Subscribe to the PrintPage event
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesReportTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to print. Please generate the report first.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Sales Report";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);  // Default directory set to Documents

                    // Append current date to the default file name
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    saveFileDialog.FileName = $"SalesReport_{currentDate}.pdf";  // Default file name with date
                    saveFileDialog.OverwritePrompt = true;  // Prompt if overwriting

                    // Show SaveFileDialog
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the user-selected file name (including full path)
                        string userFileName = saveFileDialog.FileName;

                        // Assign the selected file path to pdfFilePath
                        pdfFilePath = userFileName;  // Directly use the file path selected by the user

                        // Debugging: Show the selected file path
                        MessageBox.Show($"Selected file path: {pdfFilePath}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Call method to print the document to PDF
                        PrintToPdf();

                        // Wait a bit for the print job to finish
                        System.Threading.Thread.Sleep(2000);

                        // Check if the file exists
                        if (File.Exists(pdfFilePath))
                        {
                            MessageBox.Show($"Sales report saved successfully to {pdfFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SanitizeFileName(string fileName)
        {
            // Get invalid characters in Windows file names
            char[] invalidChars = Path.GetInvalidFileNameChars();

            // Loop through invalid characters and replace them with underscores
            foreach (char invalidChar in invalidChars)
            {
                fileName = fileName.Replace(invalidChar.ToString(), "_");  // Replace invalid characters with "_"
            }

            return fileName;
        }

        private void PrintToPdf()
        {
            try
            {
                // Printer settings for "Microsoft Print to PDF"
                PrinterSettings printerSettings = new PrinterSettings
                {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true
                };

                // Ensure the file path is set correctly for saving the PDF
                printerSettings.PrintFileName = pdfFilePath;

                // Debugging: show the file path before printing
                MessageBox.Show($"Saving to: {pdfFilePath}", "File Path", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Page settings for the printed document
                PageSettings pageSettings = new PageSettings
                {
                    Landscape = true,
                    Margins = new Margins(50, 50, 50, 50)
                };

                // Set the printer settings and page settings for the print document
                printDocument.PrinterSettings = printerSettings;
                printDocument.DefaultPageSettings = pageSettings;

                // Print the document (this will generate the PDF at the specified location)
                printDocument.Print();

                // Debugging: Sleep for 2 seconds to give time for PDF creation
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define fonts and brushes
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font columnHeaderFont = new Font("Arial", 10, FontStyle.Bold);
            Font dataFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            // Set margins and starting positions
            int leftMargin = 50;
            int topMargin = 50;
            int yOffset = 0;

            // Calculate column width based on available space
            int columnWidth = (e.MarginBounds.Width - leftMargin * 2) / salesReportTable.Columns.Count;

            // Print title
            string title = "Sales Report";
            SizeF titleSize = e.Graphics.MeasureString(title, headerFont);
            e.Graphics.DrawString(title, headerFont, brush, e.MarginBounds.Left + (e.MarginBounds.Width - titleSize.Width) / 2, topMargin);
            yOffset += (int)titleSize.Height + 20;

            // Print column headers
            for (int i = 0; i < salesReportTable.Columns.Count; i++)
            {
                string columnName = salesReportTable.Columns[i].ColumnName;
                e.Graphics.DrawString(columnName, columnHeaderFont, brush, leftMargin + i * columnWidth, topMargin + yOffset);
            }
            yOffset += 30;

            // Print rows of data
            foreach (DataRow row in salesReportTable.Rows)
            {
                for (int i = 0; i < salesReportTable.Columns.Count; i++)
                {
                    string cellValue = row[i]?.ToString() ?? string.Empty;

                    // Special formatting for SaleDate (show only the date)
                    if (salesReportTable.Columns[i].ColumnName == "SaleDate")
                    {
                        DateTime saleDate = Convert.ToDateTime(cellValue);
                        cellValue = saleDate.ToString("yyyy-MM-dd"); // Display only the date
                    }

                    // Special formatting for TotalRevenue and ProductPrice to include Peso symbol
                    if (salesReportTable.Columns[i].ColumnName == "TotalRevenue" || salesReportTable.Columns[i].ColumnName == "ProductPrice")
                    {
                        decimal value;
                        if (decimal.TryParse(cellValue, out value))
                        {
                            // Format the value as peso currency
                            cellValue = "₱" + value.ToString("N2");  // "N2" formats the decimal to 2 decimal places
                        }
                    }

                    // Print the data normally
                    e.Graphics.DrawString(cellValue, dataFont, brush, leftMargin + i * columnWidth, topMargin + yOffset);
                }
                yOffset += 20; // Move to the next row
            }
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Retrieve date range from the DateTimePickers
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date;

                // Step 2: Query the database for total sales grouped by ProductID
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    ProductID, 
                    ProductName, 
                    SUM(ProductSold) AS TotalQuantitySold, 
                    SUM(TotalRevenue) AS TotalSales
                FROM SalesReport
                WHERE SaleDate >= ? AND SaleDate <= ?
                GROUP BY ProductID, ProductName";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fromDate", fromDate);
                    cmd.Parameters.AddWithValue("@toDate", toDate);

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    salesReportTable.Clear();
                    adapter.Fill(salesReportTable);
                }

                // Step 3: Display the grouped data in the DataGridView
                dgvSR.DataSource = salesReportTable;

                // Make the DataGridView read-only and disable user editing/deletion
                dgvSR.ReadOnly = true;  // Prevent editing
                dgvSR.AllowUserToDeleteRows = false;  // Prevent row deletion
                dgvSR.AllowUserToAddRows = false;  // Prevent adding new rows
                dgvSR.AllowUserToResizeRows = false;  // Prevent resizing of rows

                // Show the DataGridView if hidden earlier
                dgvSR.Visible = true;

                // Optionally, show a message to indicate success
                MessageBox.Show("Sales report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpFrom.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.CustomFormat = "yyyy-MM-dd";
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // Hide the DataGridView initially when the form loads
            dgvSR.Visible = false;

            // Hook up the event handler for formatting cells
            dgvSR.CellFormatting += dgvSR_CellFormatting;

            // Additional settings to make DataGridView completely non-editable
            dgvSR.ReadOnly = true;  // Prevent editing
            dgvSR.AllowUserToDeleteRows = false;  // Prevent row deletion
            dgvSR.AllowUserToAddRows = false;  // Prevent adding new rows
            dgvSR.AllowUserToResizeRows = false;  // Prevent resizing of rows
            dgvSR.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Only select rows
        }

        private void dgvSR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is 'TotalRevenue' or 'ProductPrice'
            if (dgvSR.Columns[e.ColumnIndex].Name == "TotalRevenue" || dgvSR.Columns[e.ColumnIndex].Name == "ProductPrice")
            {
                // Only format if the value is not null and is numeric
                if (e.Value != null)
                {
                    decimal value;
                    if (Decimal.TryParse(e.Value.ToString(), out value))
                    {
                        // Format the value to include the Peso symbol and two decimal places
                        e.Value = "₱" + value.ToString("N2");  // "N2" formats the decimal to 2 decimal places
                        e.FormattingApplied = true;  // Mark the formatting as applied
                    }
                }
            }
        }

        private void SalesReport_Load_1(object sender, EventArgs e)
        {

        }
    }
    }

