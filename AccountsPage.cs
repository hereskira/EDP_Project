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
            // Define the target directory relative to the application's base directory
            string targetDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reports");

            // Ensure the directory exists
            if (!System.IO.Directory.Exists(targetDirectory))
            {
                System.IO.Directory.CreateDirectory(targetDirectory);
            }

            // Define the file name and combine it with the target directory
            string filePath = System.IO.Path.Combine(targetDirectory, "userlist.xlsx");

            // Log the file path
            Console.WriteLine("Exporting to File Path: " + filePath);

            // Call the method to export the data, providing the file path
            ExportDataGridViewToExcelTemplate(AccountsData, filePath);
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
