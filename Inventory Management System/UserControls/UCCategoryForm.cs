using ClosedXML.Excel;
using ExcelDataReader;
using OfficeOpenXml;
using QRCoder;
using School_Management_System.Services; // Assuming DatabaseService is in this namespace
using System;
using System.Text;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Management_System.UserControls
{
    public partial class UCCategoryForm : UserControl
    {
        private string placeholder = "Search Categories...";
        public int GetID;

        public UCCategoryForm()
        {
            InitializeComponent();
            txtCategoryName.TextChanged += txtCategoryName_TextChanged;
            LoadCategories();

            txtSearch.Text = placeholder;
            txtSearch.ForeColor = Color.Gray;

            txtSearch.Enter += RemovePlaceholder;
            txtSearch.Leave += SetPlaceholder;

        }


        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                LoadCategories();
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholder;
                txtSearch.ForeColor = Color.Gray;
                LoadCategories();
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                int nextCategoryId = GetNextCategoryId();
                string prefix = "QR-";
                string code = (100000 + nextCategoryId).ToString();
                string suffix = new string(categoryName.ToUpper().Where(char.IsLetterOrDigit).Take(4).ToArray());
                string qrText = $"{prefix}{code}-{suffix}";

                txtQRCode.Text = qrText;
                GenerateQRCodeImage(qrText);
            }
            else
            {
                txtQRCode.Text = "";
                picQRCode.Image = null;
            }
        }

        private void GenerateQRCodeImage(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            picQRCode.Image = qrCodeImage;
        }

        private int GetNextCategoryId()
        {
            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(CategoryID), 0) + 1 FROM Category";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch
            {
                return 1; // Default if error
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text) || string.IsNullOrWhiteSpace(txtQRCode.Text))
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string CategoryNamePattern = @"^[A-Za-z]+( [A-Za-z]+)*$";
                if (!Regex.IsMatch(txtCategoryName.Text, CategoryNamePattern))
                {
                    MessageBox.Show("Category name must be letters and single spaces only.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string categoryName = txtCategoryName.Text.Trim();
                string qrCode = txtQRCode.Text.Trim();

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Category WHERE LOWER(CategoryName) = LOWER(@CategoryName)";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            MessageBox.Show("This category already exists.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = @"INSERT INTO Category (CategoryName, QRCode, InsertDate) VALUES (@CategoryName, @QRCode, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.Parameters.AddWithValue("@QRCode", qrCode);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT CategoryID, CategoryName, QRCode, InsertDate,UpdateDate FROM Category ORDER BY InsertDate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        CategorydataGridView.DataSource = dt;
                    }
                }

                CategorydataGridView.Columns["CategoryID"].HeaderText = "ID";
                CategorydataGridView.Columns["CategoryName"].HeaderText = "Category Name";
                CategorydataGridView.Columns["QRCode"].HeaderText = "QR Code";
                CategorydataGridView.Columns["InsertDate"].HeaderText = "Inserted On";
                CategorydataGridView.Columns["UpdateDate"].HeaderText = "Updated On";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetID == 0)
                {
                    MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text) || string.IsNullOrWhiteSpace(txtQRCode.Text))
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string Categoryname = txtCategoryName.Text.Trim();
                string QRCode = txtQRCode.Text.Trim();

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string updatedata = @"Update Category set CategoryName=@CategoryName, QRCode=@QRCode, updateDate=GETDATE() where CategoryID=@CategoryID";
                    using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", GetID);
                        cmd.Parameters.AddWithValue("@CategoryName", Categoryname);
                        cmd.Parameters.AddWithValue("@QRCode", QRCode);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategorydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = CategorydataGridView.Rows[e.RowIndex];
                GetID = Convert.ToInt32(row.Cells[0].Value);
                txtCategoryName.Text = row.Cells[1].Value.ToString();
                txtQRCode.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text) || string.IsNullOrWhiteSpace(txtQRCode.Text))
                {
                    MessageBox.Show("Please select a record to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete ID" + " " + GetID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = DatabaseService.GetConnection())
                        {
                            conn.Open();
                            string deletedata = "delete Category where categoryid = @id";
                            using (SqlCommand cmd = new SqlCommand(deletedata, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", GetID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                                ClearControls();
                            }
                        }
                    }
                }
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearControls()
        {
            txtCategoryName.Text = "";
            txtQRCode.Text = "";
            picQRCode.Image = null;
            GetID = 0;
            CategorydataGridView.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || txtSearch.Text == placeholder)
            {
                LoadCategories();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT CategoryID, CategoryName, QRCode, InsertDate, UpdateDate 
                                   FROM Category WHERE CategoryName LIKE @keyword";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CategorydataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }


        public DataTable ImportExcelFile(string filePath, string[] expectedColumns)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true // first row = column names
                    }
                });

                DataTable dt = result.Tables[0];

                // Check if columns match expected
                var fileCols = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.Trim()).ToArray();
                bool match = expectedColumns.All(c => fileCols.Contains(c, StringComparer.OrdinalIgnoreCase));

                if (!match)
                {
                    MessageBox.Show("Excel columns do not match required format.", "Import Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                return dt;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string[] requiredColumns = { "CategoryName", "QRCode" };

            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                Title = "Select Excel File"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = ImportExcelFile(ofd.FileName, requiredColumns);

                    if (dt != null)
                    {
                        // Bind to grid
                        CategorydataGridView.DataSource = dt;

                        int skippedCount = 0;
                        int insertedCount = 0;

                        using (SqlConnection conn = DatabaseService.GetConnection())
                        {
                            conn.Open();
                            foreach (DataRow row in dt.Rows)
                            {
                                string categoryName = row["CategoryName"].ToString().Trim();
                                string qrCode = row["QRCode"].ToString().Trim();

                                // Check if record exists
                                using (SqlCommand checkCmd = new SqlCommand(
                                    "SELECT COUNT(*) FROM Category WHERE CategoryName = @name OR QRCode = @qr", conn))
                                {
                                    checkCmd.Parameters.AddWithValue("@name", categoryName);
                                    checkCmd.Parameters.AddWithValue("@qr", qrCode);

                                    int exists = (int)checkCmd.ExecuteScalar();
                                    if (exists > 0)
                                    {
                                        skippedCount++;
                                        continue; // Skip this record
                                    }
                                }

                                // Insert new record
                                using (SqlCommand cmd = new SqlCommand(
                                    "INSERT INTO Category (CategoryName, QRCode, InsertDate) VALUES (@name, @qr, GETDATE())",
                                    conn))
                                {
                                    cmd.Parameters.AddWithValue("@name", categoryName);
                                    cmd.Parameters.AddWithValue("@qr", qrCode);
                                    insertedCount += cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        LoadCategories();

                        MessageBox.Show(
                            $"Data imported successfully.\nInserted: {insertedCount}\nSkipped: {skippedCount}",
                            "Import Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Duplicatebtn_Click(object sender, EventArgs e)
        {
            if (CategorydataGridView.Rows.Count <= 1) // Only header row
            {
                MessageBox.Show("No data available to check duplicates.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to remove duplicate records from the database?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                int skippedCount = 0;

                using (SqlConnection conn =  DatabaseService.GetConnection())
                {
                    conn.Open();

                    // Step 1: Count duplicates before deleting
                    using (SqlCommand countCmd = new SqlCommand(@"
                SELECT COUNT(*) - COUNT(DISTINCT CategoryName + '|' + QRCode) 
                FROM category
            ", conn))
                    {
                        skippedCount = Convert.ToInt32(countCmd.ExecuteScalar());
                    }

                    // Step 2: Remove duplicates (keep the one with smallest ID)
                    using (SqlCommand deleteCmd = new SqlCommand(@"
                WITH CTE AS (
                    SELECT *,
                           ROW_NUMBER() OVER (PARTITION BY CategoryName, QRCode ORDER BY CategoryID) AS rn
                    FROM category
                )
                DELETE FROM CTE WHERE rn > 1
            ", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                // Step 3: Reload DataGridView
                LoadCategories();

                MessageBox.Show($"Duplicate removal complete.\nRemoved records: {skippedCount}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Exportbtn_Click(object sender, EventArgs e)
        {
            if (CategorydataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Create Excel application
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;

                // Add a workbook
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Category Data";

                // Add column headers
                for (int i = 0; i < CategorydataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = CategorydataGridView.Columns[i].HeaderText;
                }

                // Sort DataGridView rows by ID (first column)
                var rows = CategorydataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .OrderBy(r => Convert.ToInt32(r.Cells[0].Value)) // First column assumed as ID
                    .ToList();

                // Add sorted rows to Excel
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = 0; j < CategorydataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = rows[i].Cells[j].Value?.ToString();
                    }
                }
                string todaydate = DateTime.Now.ToString("yyyy-MM-dd");

                // Ask where to save
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = $"CategoryData {todaydate}.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                }

                // Cleanup
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
