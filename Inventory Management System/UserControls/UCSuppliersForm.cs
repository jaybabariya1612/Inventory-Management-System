using ExcelDataReader;
using QRCoder;
using School_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Management_System.UserControls
{
    public partial class UCSuppliersForm : UserControl
    {
        private string placeholder = "Search Suppliers...";
        public int GetID;
        public UCSuppliersForm()
        {
            InitializeComponent();
            txtSearch.Text = placeholder;
            txtSearch.ForeColor = Color.Gray;

            txtSearch.Enter += RemovePlaceholder;
            txtSearch.Leave += SetPlaceholder;
            LoadSuppliers();
            LoadComboBoxes();

        }
        public void DisplayCategory()
        {
            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                string selectdata = "SELECT CategoryID, CAST(CategoryID AS VARCHAR) + ' - ' + CategoryName AS DisplayName FROM Category";

                SqlDataAdapter da = new SqlDataAdapter(selectdata, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "DisplayName";
                cmbCategory.ValueMember = "CategoryID";
            }
        }

        private void LoadComboBoxes()
        {
            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();

                // Load Categories
                SqlDataAdapter catAdapter = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Category", conn);
                DataTable dtCat = new DataTable();
                catAdapter.Fill(dtCat);
                cmbCategory.DataSource = dtCat;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryName";
            }
        }


        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                LoadSuppliers();
            }

        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholder;
                txtSearch.ForeColor = Color.Gray;
                LoadSuppliers();
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(txtSupplierContact.Text) ||
                    string.IsNullOrWhiteSpace(txtSupplierEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSupplierName.Text)||
                    cmbCategory.SelectedIndex == -1
                    )
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string SupplierNamePattern = @"^[A-Za-z]+( [A-Za-z]+)*$";

                bool IsValidEmail(string email)
                {
                    try
                    {
                        var addr = new MailAddress(email);
                        return addr.Address == email;
                    }
                    catch
                    {
                        return false;
                    }
                }
                if (!Regex.IsMatch(txtSupplierName.Text, SupplierNamePattern))
                {
                    MessageBox.Show("Supplier Name Must be a String.",
                                    "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtSupplierContact.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Supplier Contact must be numbers only.", "Invalid Contact",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(txtSupplierEmail.Text))
                {
                    MessageBox.Show("Supplier Email is invalid.", "Invalid Email",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtSupplierContact.Text.Length < 10)
                {
                    MessageBox.Show("Contact is Invalid",
                "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                string SupplierName = txtSupplierName.Text.Trim();
                string SupplierContact = txtSupplierContact.Text.Trim();
                string categoryDisplay = cmbCategory.Text;
                string categoryName = categoryDisplay.Contains("-") ? categoryDisplay.Split('-')[1].Trim() : categoryDisplay;
                string SupplierEmail = txtSupplierEmail.Text.Trim();

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string insertQuery = @"insert into Suppliers(Name,Contact,Category,Email,InsertedDate) values(@Name,@Contact,@Category,@Email,GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", SupplierName);
                        cmd.Parameters.AddWithValue("@Contact", SupplierContact);
                        cmd.Parameters.AddWithValue("@Category", categoryName);
                        cmd.Parameters.AddWithValue("@Email", SupplierEmail);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                // Optionally reload data grid here
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadSuppliers()
        {
            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT SupplierID, Name,Category, Contact, Email,InsertedDate,UpdatedDate FROM Suppliers ORDER BY InsertedDate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        SupplierdataGridView.DataSource = dt;
                    }
                }

                // Optional: format DataGridView columns
                SupplierdataGridView.Columns["SupplierID"].HeaderText = "ID";
                SupplierdataGridView.Columns["Name"].HeaderText = "Name";
                SupplierdataGridView.Columns["Category"].HeaderText = "Category";
                SupplierdataGridView.Columns["Contact"].HeaderText = "Contact";
                SupplierdataGridView.Columns["Email"].HeaderText = "Email";
                SupplierdataGridView.Columns["InsertedDate"].HeaderText = "Inserted On";
                SupplierdataGridView.Columns["UpdatedDate"].HeaderText = "Updated On";
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
                string SupplierName = txtSupplierName.Text.Trim();
                string SupplierContact = txtSupplierContact.Text.Trim();
                string SupplierEmail = txtSupplierEmail.Text.Trim();
                string categoryDisplay = cmbCategory.Text;
                string categoryName = categoryDisplay.Contains("-") ? categoryDisplay.Split('-')[1].Trim() : categoryDisplay;


                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string updatedata = @"update Suppliers set Name=@Name,Category=@Category,Contact=@Contact,Email=@Email,updatedDate = GETDATE() where SupplierID=@SupplierID";
                    using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", GetID);
                        cmd.Parameters.AddWithValue("@Name", SupplierName);
                        cmd.Parameters.AddWithValue("@Category", categoryName);
                        cmd.Parameters.AddWithValue("@Contact", SupplierContact);
                        cmd.Parameters.AddWithValue("@Email", SupplierEmail);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void ClearControls()
        {
            txtSupplierName.Text="";
            txtSupplierContact.Text="";
            txtSupplierEmail.Text = "";
            cmbCategory.SelectedIndex = -1;

        }

        private void SupplierdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = SupplierdataGridView.Rows[e.RowIndex];
                GetID = Convert.ToInt32(row.Cells["SupplierID"].Value);
                txtSupplierName.Text = row.Cells["Name"].Value.ToString();
                txtSupplierContact.Text = row.Cells["Contact"].Value.ToString();
                txtSupplierEmail.Text = row.Cells["Email"].Value.ToString();
                cmbCategory.SelectedValue = row.Cells["Category"].Value.ToString();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(txtSupplierContact.Text) ||
                    string.IsNullOrWhiteSpace(txtSupplierEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSupplierName.Text)||
                    cmbCategory.SelectedIndex == -1
                    )
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
                            string deletedata = "delete Suppliers where SupplierID = @id";
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
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadSuppliers();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT SupplierID, Name,Category, Contact,Email, InsertedDate,UpdatedDate FROM Suppliers
                WHERE 
                    Name LIKE @keyword ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    SupplierdataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }

        }

        private void Duplicatebtn_Click(object sender, EventArgs e)
        {
            if (SupplierdataGridView.Rows.Count <= 1) // Only header row
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

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    // Step 1: Count duplicates before deleting
                    using (SqlCommand countCmd = new SqlCommand(@"
                SELECT COUNT(*) - COUNT(DISTINCT Name + '|' + Category) 
                FROM Suppliers
            ", conn))
                    {
                        skippedCount = Convert.ToInt32(countCmd.ExecuteScalar());
                    }

                    // Step 2: Remove duplicates (keep the one with smallest ID)
                    using (SqlCommand deleteCmd = new SqlCommand(@"
                WITH CTE AS (
                    SELECT *,
                           ROW_NUMBER() OVER (PARTITION BY Name, Category ORDER BY SupplierID) AS rn
                    FROM Suppliers
                )
                DELETE FROM CTE WHERE rn > 1
            ", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                // Step 3: Reload DataGridView
                LoadSuppliers();

                MessageBox.Show($"Duplicate removal complete.\nRemoved records: {skippedCount}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            if (SupplierdataGridView.Rows.Count == 0)
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
                worksheet.Name = "Supplier Data";

                // Add column headers
                for (int i = 0; i < SupplierdataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = SupplierdataGridView.Columns[i].HeaderText;
                }

                // Sort DataGridView rows by ID (first column)
                var rows = SupplierdataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .OrderBy(r => Convert.ToInt32(r.Cells[0].Value)) // First column assumed as ID
                    .ToList();

                // Add sorted rows to Excel
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = 0; j < SupplierdataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = rows[i].Cells[j].Value?.ToString();
                    }
                }
                string todaydate = DateTime.Now.ToString("yyyy-MM-dd");

                // Ask where to save
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = $"SupplierData {todaydate}.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
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

        private void ImportdataBtn_Click(object sender, EventArgs e)
        {
            string[] requiredColumns = { "Name", "Category","Contact", "Email", };

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
                        SupplierdataGridView.DataSource = dt;

                        int skippedCount = 0;
                        int insertedCount = 0;

                        using (SqlConnection conn = DatabaseService.GetConnection())
                        {
                            conn.Open();
                            foreach (DataRow row in dt.Rows)
                            {
                                string SupplierName = row["Name"].ToString().Trim();
                                string Category = row["Category"].ToString().Trim();
                                string Contact = row["Contact"].ToString().Trim();
                                string Email = row["Email"].ToString().Trim();

                                // Check if record exists
                                using (SqlCommand checkCmd = new SqlCommand(
                                    "SELECT COUNT(*) FROM Suppliers WHERE Name = @name OR Category = @Category", conn))
                                {
                                    checkCmd.Parameters.AddWithValue("@name", SupplierName);
                                    checkCmd.Parameters.AddWithValue("@Category", Category);

                                    int exists = (int)checkCmd.ExecuteScalar();
                                    if (exists > 0)
                                    {
                                        skippedCount++;
                                        continue; // Skip this record
                                    }
                                }

                                // Insert new record
                                using (SqlCommand cmd = new SqlCommand(
                                    "INSERT INTO Suppliers (name, Category,Contact,Email, InsertedDate) VALUES (@name, ,@Category,@Contact, GETDATE())",
                                    conn))
                                {
                                    cmd.Parameters.AddWithValue("@name",SupplierName );
                                    cmd.Parameters.AddWithValue("@Category ", Category );
                                    cmd.Parameters.AddWithValue("@Contact", Contact);
                                    cmd.Parameters.AddWithValue("@Email", Email);
                                    insertedCount += cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        LoadSuppliers();

                        MessageBox.Show(
                            $"Data imported successfully.\nInserted: {insertedCount}\nSkipped: {skippedCount}",
                            "Import Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }
    }
}
