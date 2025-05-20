using System;
using System.Data;
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
                            AccountsData.DataSource = dataTable;
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
            // Define base directory
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Path to the template in reportTemplate folder
            string templateDir = System.IO.Path.Combine(baseDir, "reportTemplate");
            string templatePath = System.IO.Path.Combine(templateDir, "userlist.xlsx");

            // Ensure the template exists
            if (!System.IO.File.Exists(templatePath))
            {
                MessageBox.Show("Excel template not found in reportTemplate folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Path to the generatedreports folder
            string generatedDir = System.IO.Path.Combine(baseDir, "generatedreports");
            if (!System.IO.Directory.Exists(generatedDir))
            {
                System.IO.Directory.CreateDirectory(generatedDir);
            }

            // Generate filename with timestamp
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string generatedFileName = $"report-{timestamp}.xlsx";
            string generatedFilePath = System.IO.Path.Combine(generatedDir, generatedFileName);

            // Copy the template to the generatedreports folder with the new name
            System.IO.File.Copy(templatePath, generatedFilePath, true);

            // Export data to the copied file
            ExportDataGridViewToExcelTemplate(AccountsData, generatedFilePath);
        }

        private void ExportDataGridViewToExcelTemplate(DataGridView dgv, string filePath)
        {
            try
            {
                var excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Excel is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Make Excel invisible
                excelApp.Visible = false;

                // Open the existing workbook
                var workbook = excelApp.Workbooks.Open(filePath);
                var worksheet = (Excel.Worksheet)workbook.Worksheets[1]; // Use the first sheet in the workbook

                // Start writing from row 2 (assuming row 1 has headers)
                int rowIndex = 2;

                // Iterate through the rows of the DataGridView
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow) // Skip the new row in DataGridView
                    {
                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            // Write data to Excel cells (Excel is 1-based)
                            worksheet.Cells[rowIndex, col + 1] = row.Cells[col].Value?.ToString() ?? string.Empty;
                        }
                        rowIndex++;
                    }
                }

                // Save the workbook (overwrite without prompt)
                workbook.Save();
                workbook.Close(false);
                excelApp.Quit();

                MessageBox.Show("Data exported successfully in userlist.xlsx", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Release COM objects to avoid memory leaks
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                // If an error occurs, show the error message
                MessageBox.Show($"An error occurred during export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
