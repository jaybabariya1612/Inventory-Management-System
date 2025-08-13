using DocumentFormat.OpenXml.InkML;
using ExcelDataReader;
using School_Management_System.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Management_System.UserControls
{
    public partial class UCProductForm : UserControl
    {
        private int GetId = 0;
        private string placeholder = "Search products...";
        public UCProductForm()
        {
            InitializeComponent();
            LoadProductGrid();
            txtSearch.Text = placeholder;
            txtSearch.ForeColor = Color.Gray;

            txtSearch.Leave += SetPlaceholder;
            txtSearch.Enter += RemovePlaceholder;
            LoadSuppliers();
            LoadCategories();

            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;

        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
            LoadProductGrid();
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholder;
                txtSearch.ForeColor = Color.Gray;
            }
            LoadProductGrid();
        }
        private void LoadSuppliers()
        {
            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                string query = "SELECT SupplierID, Name, Category FROM Suppliers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSuppliers.DataSource = dt;
                cmbSuppliers.DisplayMember = "Name";
                cmbSuppliers.ValueMember = "Name"; // Matching by Name
            }
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName FROM Category";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryName";
            }
        }



        private void FilterSuppliersByCategory(string categoryName)
        {
            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                string query = "SELECT SupplierID, Name FROM Suppliers WHERE Category = @CategoryName";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSuppliers.DataSource = dt;
                cmbSuppliers.DisplayMember = "Name";
                cmbSuppliers.ValueMember = "Name";
            }
        }



        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null && cmbCategory.SelectedValue is string categoryName)
            {
                FilterSuppliersByCategory(categoryName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Validate required fields
                if (cmbCategory.SelectedIndex == -1 || cmbSuppliers.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtStock.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2️⃣ Validate product name (letters only + spaces allowed)
                string ProductNamePattern = @"^[A-Za-z]+( [A-Za-z]+)*$";
                if (!Regex.IsMatch(txtProductName.Text, ProductNamePattern))
                {
                    MessageBox.Show("Product name must contain only letters and spaces.",
                                    "Invalid Product Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txtDescription.Text, ProductNamePattern))
                {
                    MessageBox.Show("Description name must contain only letters and spaces.",
                                    "Invalid Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // 3️⃣ Get form values
                string name = txtProductName.Text.Trim();
                string description = txtDescription.Text.Trim();
                decimal price = decimal.Parse(txtPrice.Text.Trim());
                int quantity = int.Parse(txtStock.Text.Trim());
                string imagePath = txtFilePath.Text.Trim();

                // Extract names from combo boxes
                string categoryName = cmbCategory.Text.Contains("-") ? cmbCategory.Text.Split('-')[1].Trim() : cmbCategory.Text;
                string supplierName = cmbSuppliers.Text.Contains("-") ? cmbSuppliers.Text.Split('-')[1].Trim() : cmbSuppliers.Text;

                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    // 4️⃣ Check for duplicate product (case-insensitive, within the same category)
                    string checkQuery = @"SELECT COUNT(*) FROM imss_products
                                  WHERE LOWER(Name) = LOWER(@Name)
                                  AND LOWER(CategoryName) = LOWER(@CategoryName)";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Name", name);
                        checkCmd.Parameters.AddWithValue("@CategoryName", categoryName);

                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("This product already exists in the selected category.",
                                            "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 5️⃣ Insert if no duplicate
                    string insertQuery = @"INSERT INTO imss_products
                                   (Name, CategoryName, Quantity, Price, Description, SupplierName, ImagePath, AddedDate)
                                   VALUES (@Name, @CategoryName, @Quantity, @Price, @Description, @SupplierName, @ImagePath, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                        cmd.ExecuteNonQuery();
                    }
                }

                // 6️⃣ Success
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductGrid();
                clecontrol();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Price and Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    txtFilePath.Text = filePath;

                    try
                    {
                        pbProductImage.Image = Image.FromFile(filePath);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not load image. File might be corrupted.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadProductGrid()
        {
            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ProductID, Name, CategoryName, Quantity, Price, Description, SupplierName, ImagePath, AddedDate, UpdateDate FROM imss_products";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Create new column for images
                    DataTable imageTable = dt.Clone();
                    imageTable.Columns.Add("Image", typeof(Image)); // new column

                    foreach (DataRow row in dt.Rows)
                    {
                        DataRow newRow = imageTable.NewRow();
                        newRow.ItemArray = row.ItemArray;

                        string imagePath = row["ImagePath"].ToString();

                        if (File.Exists(imagePath))
                        {
                            newRow["Image"] = Image.FromFile(imagePath);
                        }
                        //else
                        //{
                        //    newRow["Image"] = Properties.Resources.placeholder; // optional fallback
                        //}

                        imageTable.Rows.Add(newRow);
                    }

                    // Show image column only
                    productdataGridView.Columns.Clear();
                    productdataGridView.DataSource = imageTable;

                    // Set image column layout
                    if (productdataGridView.Columns["Image"] is DataGridViewImageColumn imgCol)
                    {
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        imgCol.Width = 100;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadProductGrid(); // Reload all data if search box is empty
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    ProductID, Name, CategoryName, Quantity, Price, Description, SupplierName, ImagePath, AddedDate, UpdateDate
                FROM 
                    imss_products
                WHERE 
                    Name LIKE @keyword ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    productdataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetId == 0)
                {
                    MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbCategory.SelectedIndex == -1 || cmbSuppliers.SelectedIndex == -1 ||
    string.IsNullOrWhiteSpace(txtProductName.Text) ||
    string.IsNullOrWhiteSpace(txtPrice.Text) ||
    string.IsNullOrWhiteSpace(txtStock.Text) ||
    string.IsNullOrWhiteSpace(txtDescription.Text) ||
    string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = txtProductName.Text.Trim();
                string description = txtDescription.Text.Trim();
                decimal price = decimal.Parse(txtPrice.Text.Trim());
                int quantity = int.Parse(txtStock.Text.Trim());
                string imagePath = txtFilePath.Text.Trim();

                // Extract name from "ID - Name"
                string categoryDisplay = cmbCategory.Text;
                string categoryName = categoryDisplay.Contains("-") ? categoryDisplay.Split('-')[1].Trim() : categoryDisplay;

                string supplierDisplay = cmbSuppliers.Text;
                string supplierName = supplierDisplay.Contains("-") ? supplierDisplay.Split('-')[1].Trim() : supplierDisplay;
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();
                    string updatedata = " update imss_products set Name = @Name,CategoryName=@CategoryName,Quantity=@Quantity,Price=@Price,Description=@Description,SupplierName=@SupplierName,ImagePath=@ImagePath,UpdateDate=GETDATE() where productid = @productid";

                    using (SqlCommand cmd = new SqlCommand(updatedata, conn))
                    {
                        cmd.Parameters.AddWithValue("@productid", GetId);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductGrid();
                clecontrol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void clecontrol()
        {
            txtStock.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtFilePath.Text = "";
            txtDescription.Text = "";
            cmbSuppliers.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex == -1 || cmbSuppliers.SelectedIndex == -1 ||
                   string.IsNullOrWhiteSpace(txtProductName.Text) ||
                   string.IsNullOrWhiteSpace(txtPrice.Text) ||
                   string.IsNullOrWhiteSpace(txtStock.Text) ||
                   string.IsNullOrWhiteSpace(txtDescription.Text) ||
                   string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("Please select a record to Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete ID" + GetId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = DatabaseService.GetConnection())
                        {
                            conn.Open();
                            string deletedata = "delete Imss_products where productid = @id";
                            using (SqlCommand cmd = new SqlCommand(deletedata, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", GetId);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                conn.Close();
                                clecontrol();
                            }
                        }

                    }
                }
                LoadProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clecontrol();
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
                    string query = @"SELECT ProductID, Name, CategoryName, Quantity, Price, Description, SupplierName, ImagePath,AddedDate,UpdateDate  FROM imss_products where name like @keyword";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    productdataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }

        }

        private void productdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = productdataGridView.Rows[e.RowIndex];
                GetId = Convert.ToInt32(row.Cells["productid"].Value);
                txtProductName.Text = row.Cells["Name"].Value.ToString();
                cmbCategory.SelectedValue = row.Cells["CategoryName"].Value.ToString();
                txtStock.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                cmbSuppliers.SelectedValue = row.Cells["SupplierName"].Value.ToString();
                txtFilePath.Text = row.Cells["ImagePath"].Value.ToString();
                pbProductImage.Image = Image.FromFile(txtFilePath.Text);
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
            string[] requiredColumns = { "Name", "Quantity", "Price", "CategoryName", "Description", "SupplierName", "Imagepath" };

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
                        productdataGridView.DataSource = dt;

                        int skippedCount = 0;
                        int insertedCount = 0;

                        using (SqlConnection conn = DatabaseService.GetConnection())
                        {
                            conn.Open();
                            foreach (DataRow row in dt.Rows)
                            {
                                string ProductName = row["Name"].ToString().Trim();
                                int Quantity = Convert.ToInt32(row["Quantity"]);
                                decimal Price = Convert.ToDecimal(row["Price"]);
                                string CategoryName = row["CategoryName"].ToString().Trim();
                                string Description = row["Description"].ToString().Trim();
                                string SupplierName = row["SupplierName"].ToString().Trim();
                                string Imagepath = row["Imagepath"].ToString().Trim();

                                // Check if record exists
                                using (SqlCommand checkCmd = new SqlCommand(
                                    "SELECT COUNT(*) FROM IMSS_Products WHERE Name = @name", conn))
                                {
                                    checkCmd.Parameters.AddWithValue("@name", ProductName);
                                    checkCmd.Parameters.AddWithValue("@Quantity", Quantity);
                                    checkCmd.Parameters.AddWithValue("@Price", Price);
                                    checkCmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                                    checkCmd.Parameters.AddWithValue("@Description", Description);
                                    checkCmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                                    checkCmd.Parameters.AddWithValue("@Imagepath", Imagepath);

                                    int exists = (int)checkCmd.ExecuteScalar();
                                    if (exists > 0)
                                    {
                                        skippedCount++;
                                        continue; // Skip this record
                                    }
                                }

                                // Insert new record
                                using (SqlCommand cmd = new SqlCommand(
                                    "INSERT INTO imss_products (Name, CategoryName, Quantity, Price, Description, SupplierName, ImagePath, AddedDate) VALUES(@Name, @CategoryName, @Quantity, @Price, @Description, @SupplierName, @ImagePath, GETDATE())",
                                    conn))
                                {
                                    cmd.Parameters.AddWithValue("@Name", ProductName);
                                    cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                                    cmd.Parameters.AddWithValue("@Price", Price);
                                    cmd.Parameters.AddWithValue("@Description", Description);
                                    cmd.Parameters.AddWithValue("@SupplierName", SupplierName);
                                    cmd.Parameters.AddWithValue("@ImagePath", Imagepath);
                                    insertedCount += cmd.ExecuteNonQuery();
                                }
                            }

                            LoadProductGrid();

                            MessageBox.Show(
                                $"Data imported successfully.\nInserted: {insertedCount}\nSkipped: {skippedCount}",
                                "Import Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            if (productdataGridView.Rows.Count == 0)
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
                worksheet.Name = "Product Data";

                // Add column headers
                for (int i = 0; i < productdataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = productdataGridView.Columns[i].HeaderText;
                }

                // Sort DataGridView rows by ID (first column)
                var rows = productdataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .OrderBy(r => Convert.ToInt32(r.Cells[0].Value)) // First column assumed as ID
                    .ToList();

                // Add sorted rows to Excel
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = 0; j < productdataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = rows[i].Cells[j].Value?.ToString();
                    }
                }
                string todaydate = DateTime.Now.ToString("yyyy-MM-dd");

                // Ask where to save
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = $"productData {todaydate}.xlsx"
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

        private void Duplicatebtn_Click(object sender, EventArgs e)
        {
            if (productdataGridView.Rows.Count <= 1) // Only header row
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
                SELECT COUNT(*) - COUNT(DISTINCT Name + '|' + CategoryName) 
                FROM imss_products
            ", conn))
                    {
                        skippedCount = Convert.ToInt32(countCmd.ExecuteScalar());
                    }

                    // Step 2: Remove duplicates in product table (keep the one with smallest ProductID)
                    using (SqlCommand deleteCmd = new SqlCommand(@"
    WITH CTE AS (
        SELECT *,
               ROW_NUMBER() OVER (PARTITION BY Name, CategoryName ORDER BY ProductID) AS rn
        FROM imss_products
    )
    DELETE FROM CTE WHERE rn > 1
", conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }


                    // Step 3: Reload DataGridView
                    LoadCategories();

                    MessageBox.Show($"Duplicate removal complete.\nRemoved records: {skippedCount}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
