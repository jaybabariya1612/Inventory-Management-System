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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Management_System.UserControls
{
    public partial class UCAdminForm : UserControl
    {
        private string placeholder = "Search Users...";
        public int GetID;
        public UCAdminForm()
        {
            InitializeComponent();
            LoadUsers();
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
                LoadUsers();
            }

        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholder;
                txtSearch.ForeColor = Color.Gray;
                LoadUsers();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtRole.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the details.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Pattern = @"^[A-Za-z]+( [A-Za-z]+)*$";
                if (!Regex.IsMatch(txtUserName.Text, Pattern))
                {
                    MessageBox.Show("UserName must be letters and single spaces only.",
                                    "Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txtRole.Text, Pattern))
                {
                    MessageBox.Show("Role must be letters and single spaces only.",
                                    "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?""{}|<>]).{8,}$";
                if (!Regex.IsMatch(txtPassword.Text, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 8 characters long and include 1 uppercase, 1 lowercase, 1 number, and 1 special character.",
                                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string UserName = txtUserName.Text.Trim();
                string Password = txtPassword.Text.Trim();
                string Role = txtRole.Text.Trim();

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM IMS_users WHERE LOWER(UserName) = LOWER(@UserName)";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserName", UserName);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            MessageBox.Show("This UserName already exists.", "Duplicate UserName",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 2️⃣ Insert new category
                    string insertQuery = @"INSERT INTO IMS_Users (UserName, PassWord, Role,InsertDate) 
                                   VALUES (@UserName, @Password,@Role, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@PassWord", Password);
                        cmd.Parameters.AddWithValue("@Role", Role);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User added successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT UserID, UserName, PassWord, Role,InsertDate,UpdateDate FROM IMS_Users ORDER BY InsertDate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        UsersdataGridView.DataSource = dt;
                    }
                }

                // Optional: format DataGridView columns
                UsersdataGridView.Columns["UserID"].HeaderText = "ID";
                UsersdataGridView.Columns["UserName"].HeaderText = "UserName";
                UsersdataGridView.Columns["PassWord"].HeaderText = "PassWord";
                UsersdataGridView.Columns["Role"].HeaderText = "Role";
                UsersdataGridView.Columns["InsertDate"].HeaderText = "Inserted On";
                UsersdataGridView.Columns["UpdateDate"].HeaderText = "Updated On";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string UserName = txtUserName.Text.Trim();
                string Password = txtPassword.Text.Trim();
                string Role = txtRole.Text.Trim();
                string Pattern = @"^[A-Za-z]+( [A-Za-z]+)*$";
                if (!Regex.IsMatch(txtUserName.Text, Pattern))
                {
                    MessageBox.Show("UserName must be letters and single spaces only.",
                                    "Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txtRole.Text, Pattern))
                {
                    MessageBox.Show("Role must be letters and single spaces only.",
                                    "Invalid Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?""{}|<>]).{8,}$";
                if (!Regex.IsMatch(txtPassword.Text, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 8 characters long and include 1 uppercase, 1 lowercase, 1 number, and 1 special character.",
                                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string updatedata = @"Update IMS_Users set UserName=@UserName, PassWord=@PassWord,Role=@Role, updateDate=GETDATE() where UserID=@USERID";
                    using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                    {
                        cmd.Parameters.AddWithValue("@USERID", GetID);
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@PassWord", Password);
                        cmd.Parameters.AddWithValue("@Role", Role);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UsersdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = UsersdataGridView.Rows[e.RowIndex];
                GetID = Convert.ToInt32(row.Cells[0].Value);
                txtUserName.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                txtRole.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtRole.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
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
                            string deletedata = "delete IMS_users where Userid = @id";
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
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ClearControls()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
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
                LoadUsers();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT UserID, UserName, Password,Role, InsertDate,UpdateDate FROM IMS_users
                WHERE 
                    UserName LIKE @keyword ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    UsersdataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }

        }

        private void Duplicatebtn_Click(object sender, EventArgs e)
        {
            if (UsersdataGridView.Rows.Count <= 1) // Only header row
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
                SELECT COUNT(*) - COUNT(DISTINCT UserName+ '|' + Role) 
                FROM ims_Users
            ", conn))
                    {
                        skippedCount = Convert.ToInt32(countCmd.ExecuteScalar());
                    }

                    // Step 2: Remove duplicates (keep the one with smallest ID)
                    using (SqlCommand deleteCmd = new SqlCommand(@"
                WITH CTE AS (
                    SELECT *,
                           ROW_NUMBER() OVER (PARTITION BY UserName, Role ORDER BY UserID) AS rn
                    FROM Ims_users
                )
                DELETE FROM CTE WHERE rn > 1
            ", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                // Step 3: Reload DataGridView
                LoadUsers();

                MessageBox.Show($"Duplicate removal complete.\nRemoved records: {skippedCount}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            if (UsersdataGridView.Rows.Count == 0)
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
                worksheet.Name = "Users Data";

                // Add column headers
                for (int i = 0; i < UsersdataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = UsersdataGridView.Columns[i].HeaderText;
                }

                // Sort DataGridView rows by ID (first column)
                var rows = UsersdataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .OrderBy(r => Convert.ToInt32(r.Cells[0].Value)) // First column assumed as ID
                    .ToList();

                // Add sorted rows to Excel
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = 0; j < UsersdataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = rows[i].Cells[j].Value?.ToString();
                    }
                }
                string todaydate = DateTime.Now.ToString("yyyy-MM-dd");

                // Ask where to save
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = $"UsersData {todaydate}.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
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
            {
                string[] requiredColumns = { "UserName", "PassWord", "Role" };

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
                            UsersdataGridView.DataSource = dt;

                            int skippedCount = 0;
                            int insertedCount = 0;

                            using (SqlConnection conn = DatabaseService.GetConnection())
                            {
                                conn.Open();
                                foreach (DataRow row in dt.Rows)
                                {
                                    string UserName = row["UserName"].ToString().Trim();
                                    string Password = row["Password"].ToString().Trim();
                                    string Role = row["Role"].ToString().Trim();

                                    // Check if record exists
                                    using (SqlCommand checkCmd = new SqlCommand(
                                        "SELECT COUNT(*) FROM ims_users WHERE UserName = @UserName OR Role = @Role", conn))
                                    {
                                        checkCmd.Parameters.AddWithValue("@UserName", UserName);
                                        checkCmd.Parameters.AddWithValue("@Password", Password);
                                        checkCmd.Parameters.AddWithValue("@Role", Role);

                                        int exists = (int)checkCmd.ExecuteScalar();
                                        if (exists > 0)
                                        {
                                            skippedCount++;
                                            continue; // Skip this record
                                        }
                                    }

                                    // Insert new record
                                    using (SqlCommand cmd = new SqlCommand(
                                        "INSERT INTO Ims_Users (UserName,Password,Role,InsertDate) " +
                                        "VALUES (UserName,Password,Role,GETDATE())",
                                        conn))
                                    {
                                        cmd.Parameters.AddWithValue("@UserName", UserName);
                                        cmd.Parameters.AddWithValue("@Password", Password);
                                        cmd.Parameters.AddWithValue("@Role", Role);
                                        insertedCount += cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            LoadUsers();

                            MessageBox.Show(
                                $"Data imported successfully.\nInserted: {insertedCount}\nSkipped: {skippedCount}",
                                "Import Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
        }
    }
}
