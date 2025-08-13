using School_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.UserControls
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
            InitializeAllListViews(); // Initialize styling first
            LoadStaffData();
            LoadProductData();
            LoadCategoryData();
            LoadSuppliersData();
            LoadTotalProductCount();
        }

        private void InitializeAllListViews()
        {
            var listViews = new[] {
                listViewTodaysAddedProducts,
                listViewTodaysAddedStaff,
                listViewtodaysAddedCategory,
                listViewTodaysAddedSuppliers
            };

            foreach (var lv in listViews)
            {
                lv.BackColor = Color.White;
                lv.BorderStyle = BorderStyle.None;
                lv.Font = new System.Drawing.Font("Segoe UI", 9.75F);
                lv.FullRowSelect = true;
                lv.GridLines = false;
                lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                lv.HideSelection = false;
                lv.OwnerDraw = true;
                lv.MultiSelect = false;

                // Add event handlers
                lv.SelectedIndexChanged += ListView_SelectedIndexChanged;
                lv.DrawColumnHeader += ListView_DrawColumnHeader;
                lv.DrawItem += ListView_DrawItem;
                lv.DrawSubItem += ListView_DrawSubItem;
                lv.MouseMove += ListView_MouseMove;
                lv.MouseLeave += ListView_MouseLeave;
            }
        }

        private void LoadStaffData()
        {
            listViewTodaysAddedStaff.Items.Clear();
            listViewTodaysAddedStaff.View = View.Details;

            listViewTodaysAddedStaff.Columns.Clear();
            listViewTodaysAddedStaff.Columns.Add("Staff ID", 80);
            listViewTodaysAddedStaff.Columns.Add("Full Name", 150);
            listViewTodaysAddedStaff.Columns.Add("Gender", 80);
            listViewTodaysAddedStaff.Columns.Add("Contact", 120);
            listViewTodaysAddedStaff.Columns.Add("Position", 120);

            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT StaffId, FullName, Gender, Contact, Position FROM IMS_Staff WHERE CAST(InsertDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["StaffId"].ToString());
                    item.SubItems.Add(reader["FullName"].ToString());
                    item.SubItems.Add(reader["Gender"].ToString());
                    item.SubItems.Add(reader["Contact"].ToString());
                    item.SubItems.Add(reader["Position"].ToString());

                    listViewTodaysAddedStaff.Items.Add(item);
                }
            }
        }

        private void LoadProductData()
        {
            listViewTodaysAddedProducts.Items.Clear();
            listViewTodaysAddedProducts.View = View.Details;

            listViewTodaysAddedProducts.Columns.Clear();
            listViewTodaysAddedProducts.Columns.Add("Product ID", 80);
            listViewTodaysAddedProducts.Columns.Add("Product Name", 150);
            listViewTodaysAddedProducts.Columns.Add("Quantity", 80);
            listViewTodaysAddedProducts.Columns.Add("Price", 80);
            listViewTodaysAddedProducts.Columns.Add("Category", 120);
            listViewTodaysAddedProducts.Columns.Add("Supplier", 120);

            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductID, Name, Quantity, Price, CategoryName, SupplierName FROM IMSS_Products WHERE CAST(AddedDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ProductID"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    item.SubItems.Add(reader["Quantity"].ToString());
                    item.SubItems.Add(reader["Price"].ToString());
                    item.SubItems.Add(reader["CategoryName"].ToString());
                    item.SubItems.Add(reader["SupplierName"].ToString());

                    listViewTodaysAddedProducts.Items.Add(item);
                }
            }
        }

        private void LoadCategoryData()
        {
            listViewtodaysAddedCategory.Items.Clear();
            listViewtodaysAddedCategory.View = View.Details;

            listViewtodaysAddedCategory.Columns.Clear();
            listViewtodaysAddedCategory.Columns.Add("Category ID", 80);
            listViewtodaysAddedCategory.Columns.Add("Category Name", 200);
            listViewtodaysAddedCategory.Columns.Add("QR Code", 120);

            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CategoryID, CategoryName, QRCode FROM Category WHERE CAST(Insertdate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["CategoryID"].ToString());
                    item.SubItems.Add(reader["CategoryName"].ToString());
                    item.SubItems.Add(reader["QRCode"].ToString());

                    listViewtodaysAddedCategory.Items.Add(item);
                }
            }
        }

        private void LoadSuppliersData()
        {
            listViewTodaysAddedSuppliers.Items.Clear();
            listViewTodaysAddedSuppliers.View = View.Details;

            listViewTodaysAddedSuppliers.Columns.Clear();
            listViewTodaysAddedSuppliers.Columns.Add("Supplier ID", 80);
            listViewTodaysAddedSuppliers.Columns.Add("Name", 180);
            listViewTodaysAddedSuppliers.Columns.Add("Contact", 120);

            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SupplierID, Name, Contact FROM Suppliers WHERE CAST(Inserteddate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["SupplierID"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    item.SubItems.Add(reader["Contact"].ToString());

                    listViewTodaysAddedSuppliers.Items.Add(item);
                }
            }
        }

        //private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        //{
        //    using (var headerBrush = new SolidBrush(Color.FromArgb(70, 104, 159)))
        //    using (var headerTextBrush = new SolidBrush(Color.White))
        //    using (var headerFont = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold))
        //    {
        //        e.Graphics.FillRectangle(headerBrush, e.Bounds);
        //        TextRenderer.DrawText(e.Graphics, e.Header.Text, headerFont,
        //            new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 5, e.Bounds.Height),
        //            headerTextBrush.Color, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        //    }
        //}

        //private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        //{
        //    e.DrawDefault = true;
        //}

        //private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        //{
        //    // Alternate row colors
        //    if (e.ItemIndex % 2 == 0)
        //    {
        //        e.Item.BackColor = Color.White;
        //    }
        //    else
        //    {
        //        e.Item.BackColor = Color.FromArgb(249, 249, 249);
        //    }

        //    // Default drawing for subitems
        //    e.DrawDefault = true;
        //}

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = sender as ListView;
            if (listView != null)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.Selected)
                    {
                        item.BackColor = Color.FromArgb(229, 243, 255);
                        item.ForeColor = Color.FromArgb(0, 92, 185);
                    }
                    else
                    {
                        item.BackColor = (item.Index % 2 == 0) ? Color.White : Color.FromArgb(249, 249, 249);
                        item.ForeColor = Color.FromArgb(64, 64, 64);
                    }
                }
            }
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            var listView = sender as ListView;
            var item = listView.GetItemAt(e.X, e.Y);
            if (item != null && !item.Selected)
            {
                item.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        private void ListView_MouseLeave(object sender, EventArgs e)
        {
            var listView = sender as ListView;
            foreach (ListViewItem item in listView.Items)
            {
                if (!item.Selected)
                {
                    item.BackColor = (item.Index % 2 == 0) ? Color.White : Color.FromArgb(249, 249, 249);
                }
            }
        }

        private void LoadTotalProductCount()
        {
            string query = "SELECT COUNT(*) FROM imss_Products";

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    // FIXED: Assign the connection to SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        TotalProductsCount.Text = count.ToString();
                    }
                    LoadTotalStaffCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total products: " + ex.Message);
            }
        }

        private void LoadTotalStaffCount()
        {
            string query = "SELECT COUNT(*) FROM ims_staff";

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    // FIXED: Assign the connection to SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        TotalStaffCount.Text = count.ToString();
                    }
                    LoadTotalSuppliersCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total products: " + ex.Message);
            }
        }

        private void LoadTotalSuppliersCount()
        {
            string query = "SELECT COUNT(*) FROM Suppliers";

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    // FIXED: Assign the connection to SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        TotalSuppliersCountLabel.Text = count.ToString();
                    }
                    LoadLowStockItemsCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total products: " + ex.Message);
            }
        }
        private void LoadLowStockItemsCount()
        {
            string query = "select COUNT(*) from imss_products where Quantity < 10";

            try
            {
                using (SqlConnection conn = DatabaseService.GetConnection())
                {
                    conn.Open();

                    // FIXED: Assign the connection to SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        LowStockItemsCountLabel.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total products: " + ex.Message);
            }
        }


        
        
        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                e.DrawBackground();
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(240, 242, 245)), e.Bounds);
                e.Graphics.DrawString(e.Header.Text, new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold), Brushes.Black, e.Bounds, sf);
            }
        }

        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // This event is not needed if we handle DrawSubItem, but it's good practice to have it.
            // e.DrawDefault = true; would draw the default item.
        }

        private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Use this to draw each cell (sub-item)
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;
            e.DrawBackground(); // Draw the default background (for selection colors)

            // Draw the text
            e.Graphics.DrawString(e.SubItem.Text, e.Item.Font, new SolidBrush(e.Item.ForeColor), e.Bounds, new StringFormat { LineAlignment = StringAlignment.Center, FormatFlags = StringFormatFlags.NoWrap });
        }

    }
}


