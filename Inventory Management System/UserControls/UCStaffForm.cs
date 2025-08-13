using ExcelDataReader;
using QRCoder;
using School_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Management_System.UserControls
{
    public partial class UCStaffForm : UserControl
    {
        private int GetId;
        private string placeholder = "Search Staff...";
        public UCStaffForm()
        {
            InitializeComponent();

            LoadStaff();
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
                LoadStaff();
            }

        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholder;
                txtSearch.ForeColor = Color.Gray;
                LoadStaff();
            }

        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Required field check
                if (string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtContact.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtPosition.Text) ||
                    string.IsNullOrWhiteSpace(txtSalary.Text) ||
                    (!radioMale.Checked && !radioFemale.Checked))
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2️⃣ Validate email format
                bool IsValidEmail(string email)
                {
                    try
                    {
                        var addr = new System.Net.Mail.MailAddress(email);
                        return addr.Address == email;
                    }
                    catch
                    {
                        return false;
                    }
                }

                if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3️⃣ Validate numeric contact
                if (!txtContact.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Contact number must be numeric only.", "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dtpJoinindDate.Value <= dtpDOB.Value)
                {
                    MessageBox.Show("Joining date cannot be earlier than date of birth.",
                                    "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtContact.Text.Length < 10)
                {
                    MessageBox.Show("Contact is Invalid",
                "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4️⃣ Gather data
                string Address = txtAddress.Text.Trim();
                string Contact = txtContact.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string FullName = txtFullName.Text.Trim();
                string Position = txtPosition.Text.Trim();
                decimal Salary = Convert.ToDecimal(txtSalary.Text.Trim());
                DateTime DOB = dtpDOB.Value;
                DateTime JoiningDate = dtpJoinindDate.Value;
                string Gender = radioMale.Checked ? "Male" : "Female";

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    // 5️⃣ Check for duplicates (FullName + Email)
                    string checkQuery = @"SELECT COUNT(*) FROM IMS_Staff
                                  WHERE LOWER(FullName) = LOWER(@FullName)
                                  AND LOWER(Email) = LOWER(@Email)";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@FullName", FullName);
                        checkCmd.Parameters.AddWithValue("@Email", Email);

                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("A staff member with this name and email already exists.",
                                            "Duplicate Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 6️⃣ Insert if no duplicate
                    string insertQuery = @"INSERT INTO IMS_Staff(FullName, Gender, DOB, Contact, Email, Address, Position, JoiningDate, Salary,InsertDate)
                                   VALUES(@FullName, @Gender, @DOB, @Contact, @Email, @Address, @Position, @JoiningDate, @Salary,GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", FullName);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@Contact", Contact);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@Position", Position);
                        cmd.Parameters.AddWithValue("@JoiningDate", JoiningDate);
                        cmd.Parameters.AddWithValue("@Salary", Salary);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 7️⃣ Success
                MessageBox.Show("Staff added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls()
        {
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtFullName.Text = "";
            txtPosition.Text = "";
            txtSalary.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            dtpDOB.Value = DateTime.Now;
            dtpJoinindDate.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            LoadStaff();
        }
        private void LoadStaff()
        {
            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = "select StaffID,FullName,Gender,DOB,Contact,Email,Address,Position,JoiningDate,Salary,InsertDate,UpdateDate from IMS_Staff ORDER BY JoiningDate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        StaffdataGridView.DataSource = dt;
                    }
                }

                // Optional: format DataGridView columns
                StaffdataGridView.Columns["StaffID"].HeaderText = "Staff ID";
                StaffdataGridView.Columns["FullName"].HeaderText = "FullName";
                StaffdataGridView.Columns["Gender"].HeaderText = "Gender";
                StaffdataGridView.Columns["DOB"].HeaderText = "DOB";
                StaffdataGridView.Columns["Contact"].HeaderText = "Contact";
                StaffdataGridView.Columns["Email"].HeaderText = "Email";
                StaffdataGridView.Columns["Address"].HeaderText = "Address";
                StaffdataGridView.Columns["JoiningDate"].HeaderText = "JoiningDate";
                StaffdataGridView.Columns["Salary"].HeaderText = "Salary";
                StaffdataGridView.Columns["InsertDate"].HeaderText = "Insert Date";
                StaffdataGridView.Columns["UpdateDate"].HeaderText = "Update Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetId == 0)
                {
                    MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string Address = txtAddress.Text.Trim();
                string Contact = txtContact.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string FullName = txtFullName.Text.Trim();
                string Position = txtPosition.Text.Trim();
                decimal Salary = Convert.ToDecimal(txtSalary.Text.Trim());
                DateTime DOB = dtpDOB.Value;
                DateTime JOiningDate = dtpJoinindDate.Value;
                string Gender = "";
                if (radioMale.Checked)
                {
                    Gender = "Male";
                }
                else if (radioFemale.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string updatedata = " update IMS_Staff set FullName=@FullName,Gender=@Gender,DOB=@DOB,Contact=@Contact,Email=@Email,Address=@Address,Position=@Position,JoiningDate=@JoiningDate,Salary=@Salary,UpdateDate = GETDATE() where staffId = @staffId";

                    using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                    {
                        cmd.Parameters.AddWithValue("@staffId", GetId);
                        cmd.Parameters.AddWithValue("@FullName", FullName);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Position", Position);
                        cmd.Parameters.AddWithValue("@JoiningDate", JOiningDate);
                        cmd.Parameters.AddWithValue("@Contact", Contact);
                        cmd.Parameters.AddWithValue("@Salary", Salary);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void StaffdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = StaffdataGridView.Rows[e.RowIndex];
                GetId = Convert.ToInt32(row.Cells[0].Value);
                txtFullName.Text = row.Cells[1].Value.ToString();
                string genderValue = row.Cells[2].Value.ToString();

                // Set radio buttons accordingly
                if (genderValue == "Male")
                {
                    radioMale.Checked = true;
                }
                else if (genderValue == "Female")
                {
                    radioFemale.Checked = true;
                }
                else
                {
                    radioMale.Checked = false;
                    radioFemale.Checked = false;
                }
                dtpDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
                txtContact.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtAddress.Text = row.Cells[6].Value.ToString();
                txtPosition.Text = row.Cells[7].Value.ToString();
                dtpJoinindDate.Value = Convert.ToDateTime(row.Cells[8].Value);
                txtSalary.Text = row.Cells[9].Value.ToString();
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtContact.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtPosition.Text) ||
                    string.IsNullOrWhiteSpace(txtSalary.Text) ||
                     (!radioMale.Checked && !radioFemale.Checked)
                    )
                {
                    MessageBox.Show("Please select a record to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete ID" + " " + GetId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = DatabaseService.GetConnection())
                        {
                            conn.Open();
                            string deletedata = "delete Ims_Staff where Staffid = @id";
                            using (SqlCommand cmd = new SqlCommand(deletedata, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", GetId);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                conn.Close();
                                ClearControls();
                            }
                        }

                    }
                }
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadStaff();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = @"
                select StaffId,FullName,Gender,DOB,Contact,Email,Address,Position,JoiningDate,Salary,InsertDate,Updatedate from IMS_Staff
                WHERE 
                    FullName LIKE @keyword ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    StaffdataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }

        }

        private void Duplicatebtn_Click(object sender, EventArgs e)
        {
            if (StaffdataGridView.Rows.Count <= 1) // Only header row
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
                SELECT COUNT(*) - COUNT(DISTINCT FullName+ '|' + Position) 
                FROM ims_staff
            ", conn))
                    {
                        skippedCount = Convert.ToInt32(countCmd.ExecuteScalar());
                    }

                    // Step 2: Remove duplicates (keep the one with smallest ID)
                    using (SqlCommand deleteCmd = new SqlCommand(@"
                WITH CTE AS (
                    SELECT *,
                           ROW_NUMBER() OVER (PARTITION BY FullName, Position ORDER BY StaffID) AS rn
                    FROM Ims_Staff
                )
                DELETE FROM CTE WHERE rn > 1
            ", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                // Step 3: Reload DataGridView
                LoadStaff();

                MessageBox.Show($"Duplicate removal complete.\nRemoved records: {skippedCount}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            if (StaffdataGridView.Rows.Count == 0)
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
                worksheet.Name = "Staff Data";

                // Add column headers
                for (int i = 0; i < StaffdataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = StaffdataGridView.Columns[i].HeaderText;
                }

                // Sort DataGridView rows by ID (first column)
                var rows = StaffdataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .OrderBy(r => Convert.ToInt32(r.Cells[0].Value)) // First column assumed as ID
                    .ToList();

                // Add sorted rows to Excel
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = 0; j < StaffdataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = rows[i].Cells[j].Value?.ToString();
                    }
                }
                string todaydate = DateTime.Now.ToString("yyyy-MM-dd");

                // Ask where to save
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = $"StaffData {todaydate}.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaff();
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
            string[] requiredColumns = { "FullName", "Gender","DOB","Contact","Email","Address","Position","JoiningDate","Salary" };

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
                        StaffdataGridView.DataSource = dt;

                        int skippedCount = 0;
                        int insertedCount = 0;

                        using (SqlConnection conn = DatabaseService.GetConnection())
                        {
                            conn.Open();
                            foreach (DataRow row in dt.Rows)
                            {
                                string FullName = row["FullName"].ToString().Trim();
                                string Gender = row["Gender"].ToString().Trim();
                                string DOB = row["DOB"].ToString().Trim();
                                string Contact = row["Contact"].ToString().Trim();
                                string Email = row["Email"].ToString().Trim();
                                string Address = row["Address"].ToString().Trim();
                                string Position = row["Position"].ToString().Trim();
                                string JoiningDate = row["JoiningDate"].ToString().Trim();
                                string Salary = row["Salary"].ToString().Trim();

                                // Check if record exists
                                using (SqlCommand checkCmd = new SqlCommand(
                                    "SELECT COUNT(*) FROM ims_Staff WHERE FullName = @FullName OR Position = @Position", conn))
                                {
                                    checkCmd.Parameters.AddWithValue("@FullName", FullName);
                                    checkCmd.Parameters.AddWithValue("@Position", Position);

                                    int exists = (int)checkCmd.ExecuteScalar();
                                    if (exists > 0)
                                    {
                                        skippedCount++;
                                        continue; // Skip this record
                                    }
                                }

                                // Insert new record
                                using (SqlCommand cmd = new SqlCommand(
                                    "INSERT INTO Ims_Staff (FullName, Gender,DOB,Contact,Email,Address,Position,JoiningDate,Salary, InsertDate) " +
                                    "VALUES (@FullName, @Gender,@DOB,@Contact,@Email,@Address,@Position,@JoiningDate,@Salary, GETDATE())",
                                    conn))
                                {
                                    cmd.Parameters.AddWithValue("@FullName", FullName);
                                    cmd.Parameters.AddWithValue("@Gender", Gender);
                                    cmd.Parameters.AddWithValue("@DOB", DOB);
                                    cmd.Parameters.AddWithValue("@Email", Email);
                                    cmd.Parameters.AddWithValue("@Position", Position);
                                    cmd.Parameters.AddWithValue("@JoiningDate", JoiningDate);
                                    cmd.Parameters.AddWithValue("@Contact", Contact);
                                    cmd.Parameters.AddWithValue("@Salary", Salary);
                                    cmd.Parameters.AddWithValue("@Address", Address);
                                    insertedCount += cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        LoadStaff();

                        MessageBox.Show(
                            $"Data imported successfully.\nInserted: {insertedCount}\nSkipped: {skippedCount}",
                            "Import Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }
    }
}