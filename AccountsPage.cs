using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace EDP_Project
{
    public partial class AccountsPage : Form
    {
        public AccountsPage()
        {
            InitializeComponent();
            LoadAccountsData();
            ExportButton.Click += btnExport_Click;
        }

        private void LoadAccountsData()
        {
            try
            {
                using (var connection = DatabaseService.GetConnection())
                {
                    string query = "SELECT user_id, username, password, full_name, email, security_question, security_answer FROM users";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            AccountsData.DataSource = dataTable; // Bind the data to the DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            string reportsFolder = Application.StartupPath + @"\reports";
            if (!System.IO.Directory.Exists(reportsFolder))
            {
                System.IO.Directory.CreateDirectory(reportsFolder); // Ensure the reports folder exists
            }

            DateTime now = DateTime.Now;
            string mydate = now.ToString("yyyy-MM-dd-HH-mm-ss"); // Corrected date format
            string newFilePath = reportsFolder + @"\report-" + mydate + ".csv";

            ExportDataGridViewToCsv(AccountsData, newFilePath);
        }
        private void ExportDataGridViewToExcelTemplate(DataGridView dgv, string templatePath, string newFilePath)
        {
            try
            {
                // Set the EPPlus license key or context
                // For non-commercial use:
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // For commercial use (replace with your actual license key):
                // OfficeOpenXml.ExcelPackage.License = "your-license-key-here";

                // Check if the template file exists
                if (!System.IO.File.Exists(templatePath))
                {
                    MessageBox.Show($"Template file not found at: {templatePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load the template file
                using (var package = new OfficeOpenXml.ExcelPackage(new System.IO.FileInfo(templatePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Assuming the first worksheet

                    // Start from row 3 (assuming headers in rows 1 and 2)
                    int rowIndex = 3;

                    // Iterate through the rows of the DataGridView
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow) // Skip the new row in DataGridView
                        {
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                worksheet.Cells[rowIndex, col + 1].Value = row.Cells[col].Value?.ToString() ?? string.Empty;
                            }
                            rowIndex++;
                        }
                    }

                    // Save the new file
                    package.SaveAs(new System.IO.FileInfo(newFilePath));
                }

                MessageBox.Show($"Data exported successfully to {newFilePath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportDataGridViewToCsv(DataGridView dgv, string newFilePath)
        {
            try
            {
                // Create or overwrite the file
                using (var writer = new System.IO.StreamWriter(newFilePath))
                {
                    // Write the header row
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        writer.Write(dgv.Columns[col].HeaderText);
                        if (col < dgv.Columns.Count - 1)
                            writer.Write(","); // Add a comma between columns
                    }
                    writer.WriteLine(); // End the header row

                    // Write the data rows
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow) // Skip the new row in DataGridView
                        {
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                writer.Write(row.Cells[col].Value?.ToString() ?? string.Empty);
                                if (col < dgv.Columns.Count - 1)
                                    writer.Write(","); // Add a comma between columns
                            }
                            writer.WriteLine(); // End the data row
                        }
                    }
                }

                MessageBox.Show($"Data exported successfully to {newFilePath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}