namespace Inventory_Management_System.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblSummaryCards = new System.Windows.Forms.TableLayoutPanel();
            this.TotalSupplierspanel = new System.Windows.Forms.Panel();
            this.TotalSuppliersCountLabel = new System.Windows.Forms.Label();
            this.TotalSuppliersLabel = new System.Windows.Forms.Label();
            this.SuppliersPBX = new System.Windows.Forms.PictureBox();
            this.LowStockItemspanel = new System.Windows.Forms.Panel();
            this.LowStockItemsCountLabel = new System.Windows.Forms.Label();
            this.LowStockItemsLabel = new System.Windows.Forms.Label();
            this.StockPBX = new System.Windows.Forms.PictureBox();
            this.TotalStaffpanel = new System.Windows.Forms.Panel();
            this.TotalStaffCount = new System.Windows.Forms.Label();
            this.TotalStaffLabel = new System.Windows.Forms.Label();
            this.staffPBX = new System.Windows.Forms.PictureBox();
            this.TotalProductspanel = new System.Windows.Forms.Panel();
            this.TotalProductsCount = new System.Windows.Forms.Label();
            this.TotalProductsLabel = new System.Windows.Forms.Label();
            this.ProducrPBX = new System.Windows.Forms.PictureBox();
            this.tblSummaryCards.SuspendLayout();
            this.TotalSupplierspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersPBX)).BeginInit();
            this.LowStockItemspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockPBX)).BeginInit();
            this.TotalStaffpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffPBX)).BeginInit();
            this.TotalProductspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProducrPBX)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSummaryCards
            // 
            this.tblSummaryCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSummaryCards.ColumnCount = 4;
            this.tblSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSummaryCards.Controls.Add(this.TotalSupplierspanel, 2, 0);
            this.tblSummaryCards.Controls.Add(this.LowStockItemspanel, 3, 0);
            this.tblSummaryCards.Controls.Add(this.TotalStaffpanel, 1, 0);
            this.tblSummaryCards.Controls.Add(this.TotalProductspanel, 0, 0);
            this.tblSummaryCards.Location = new System.Drawing.Point(37, 273);
            this.tblSummaryCards.Name = "tblSummaryCards";
            this.tblSummaryCards.RowCount = 1;
            this.tblSummaryCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSummaryCards.Size = new System.Drawing.Size(953, 94);
            this.tblSummaryCards.TabIndex = 6;
            // 
            // TotalSupplierspanel
            // 
            this.TotalSupplierspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.TotalSupplierspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSupplierspanel.Controls.Add(this.TotalSuppliersCountLabel);
            this.TotalSupplierspanel.Controls.Add(this.TotalSuppliersLabel);
            this.TotalSupplierspanel.Controls.Add(this.SuppliersPBX);
            this.TotalSupplierspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalSupplierspanel.Location = new System.Drawing.Point(479, 3);
            this.TotalSupplierspanel.Name = "TotalSupplierspanel";
            this.TotalSupplierspanel.Size = new System.Drawing.Size(232, 88);
            this.TotalSupplierspanel.TabIndex = 6;
            // 
            // TotalSuppliersCountLabel
            // 
            this.TotalSuppliersCountLabel.AutoSize = true;
            this.TotalSuppliersCountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.TotalSuppliersCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.TotalSuppliersCountLabel.Location = new System.Drawing.Point(68, 45);
            this.TotalSuppliersCountLabel.Name = "TotalSuppliersCountLabel";
            this.TotalSuppliersCountLabel.Size = new System.Drawing.Size(23, 25);
            this.TotalSuppliersCountLabel.TabIndex = 4;
            this.TotalSuppliersCountLabel.Text = "0";
            // 
            // TotalSuppliersLabel
            // 
            this.TotalSuppliersLabel.AutoSize = true;
            this.TotalSuppliersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TotalSuppliersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.TotalSuppliersLabel.Location = new System.Drawing.Point(68, 16);
            this.TotalSuppliersLabel.Name = "TotalSuppliersLabel";
            this.TotalSuppliersLabel.Size = new System.Drawing.Size(96, 17);
            this.TotalSuppliersLabel.TabIndex = 3;
            this.TotalSuppliersLabel.Text = "Total Suppliers";
            // 
            // SuppliersPBX
            // 
            this.SuppliersPBX.Image = global::Inventory_Management_System.Properties.Resources.Total_Suppliers;
            this.SuppliersPBX.Location = new System.Drawing.Point(12, 16);
            this.SuppliersPBX.Name = "SuppliersPBX";
            this.SuppliersPBX.Size = new System.Drawing.Size(50, 50);
            this.SuppliersPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SuppliersPBX.TabIndex = 0;
            this.SuppliersPBX.TabStop = false;
            // 
            // LowStockItemspanel
            // 
            this.LowStockItemspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LowStockItemspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowStockItemspanel.Controls.Add(this.LowStockItemsCountLabel);
            this.LowStockItemspanel.Controls.Add(this.LowStockItemsLabel);
            this.LowStockItemspanel.Controls.Add(this.StockPBX);
            this.LowStockItemspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowStockItemspanel.Location = new System.Drawing.Point(717, 3);
            this.LowStockItemspanel.Name = "LowStockItemspanel";
            this.LowStockItemspanel.Size = new System.Drawing.Size(233, 88);
            this.LowStockItemspanel.TabIndex = 6;
            // 
            // LowStockItemsCountLabel
            // 
            this.LowStockItemsCountLabel.AutoSize = true;
            this.LowStockItemsCountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.LowStockItemsCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LowStockItemsCountLabel.Location = new System.Drawing.Point(68, 45);
            this.LowStockItemsCountLabel.Name = "LowStockItemsCountLabel";
            this.LowStockItemsCountLabel.Size = new System.Drawing.Size(23, 25);
            this.LowStockItemsCountLabel.TabIndex = 4;
            this.LowStockItemsCountLabel.Text = "0";
            // 
            // LowStockItemsLabel
            // 
            this.LowStockItemsLabel.AutoSize = true;
            this.LowStockItemsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LowStockItemsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LowStockItemsLabel.Location = new System.Drawing.Point(68, 16);
            this.LowStockItemsLabel.Name = "LowStockItemsLabel";
            this.LowStockItemsLabel.Size = new System.Drawing.Size(107, 17);
            this.LowStockItemsLabel.TabIndex = 3;
            this.LowStockItemsLabel.Text = "Low Stock Items";
            // 
            // StockPBX
            // 
            this.StockPBX.Image = global::Inventory_Management_System.Properties.Resources.Low_Stock_Items_Count;
            this.StockPBX.Location = new System.Drawing.Point(12, 16);
            this.StockPBX.Name = "StockPBX";
            this.StockPBX.Size = new System.Drawing.Size(50, 50);
            this.StockPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StockPBX.TabIndex = 0;
            this.StockPBX.TabStop = false;
            // 
            // TotalStaffpanel
            // 
            this.TotalStaffpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.TotalStaffpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalStaffpanel.Controls.Add(this.TotalStaffCount);
            this.TotalStaffpanel.Controls.Add(this.TotalStaffLabel);
            this.TotalStaffpanel.Controls.Add(this.staffPBX);
            this.TotalStaffpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalStaffpanel.Location = new System.Drawing.Point(241, 3);
            this.TotalStaffpanel.Name = "TotalStaffpanel";
            this.TotalStaffpanel.Size = new System.Drawing.Size(232, 88);
            this.TotalStaffpanel.TabIndex = 0;
            // 
            // TotalStaffCount
            // 
            this.TotalStaffCount.AutoSize = true;
            this.TotalStaffCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.TotalStaffCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TotalStaffCount.Location = new System.Drawing.Point(68, 45);
            this.TotalStaffCount.Name = "TotalStaffCount";
            this.TotalStaffCount.Size = new System.Drawing.Size(23, 25);
            this.TotalStaffCount.TabIndex = 4;
            this.TotalStaffCount.Text = "0";
            // 
            // TotalStaffLabel
            // 
            this.TotalStaffLabel.AutoSize = true;
            this.TotalStaffLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TotalStaffLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TotalStaffLabel.Location = new System.Drawing.Point(68, 16);
            this.TotalStaffLabel.Name = "TotalStaffLabel";
            this.TotalStaffLabel.Size = new System.Drawing.Size(68, 17);
            this.TotalStaffLabel.TabIndex = 3;
            this.TotalStaffLabel.Text = "Total Staff";
            // 
            // staffPBX
            // 
            this.staffPBX.Image = global::Inventory_Management_System.Properties.Resources.Total_Staff;
            this.staffPBX.Location = new System.Drawing.Point(12, 16);
            this.staffPBX.Name = "staffPBX";
            this.staffPBX.Size = new System.Drawing.Size(50, 50);
            this.staffPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staffPBX.TabIndex = 0;
            this.staffPBX.TabStop = false;
            // 
            // TotalProductspanel
            // 
            this.TotalProductspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.TotalProductspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalProductspanel.Controls.Add(this.TotalProductsCount);
            this.TotalProductspanel.Controls.Add(this.TotalProductsLabel);
            this.TotalProductspanel.Controls.Add(this.ProducrPBX);
            this.TotalProductspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalProductspanel.Location = new System.Drawing.Point(3, 3);
            this.TotalProductspanel.Name = "TotalProductspanel";
            this.TotalProductspanel.Size = new System.Drawing.Size(232, 88);
            this.TotalProductspanel.TabIndex = 0;
            // 
            // TotalProductsCount
            // 
            this.TotalProductsCount.AutoSize = true;
            this.TotalProductsCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.TotalProductsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.TotalProductsCount.Location = new System.Drawing.Point(68, 45);
            this.TotalProductsCount.Name = "TotalProductsCount";
            this.TotalProductsCount.Size = new System.Drawing.Size(23, 25);
            this.TotalProductsCount.TabIndex = 4;
            this.TotalProductsCount.Text = "0";
            // 
            // TotalProductsLabel
            // 
            this.TotalProductsLabel.AutoSize = true;
            this.TotalProductsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TotalProductsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.TotalProductsLabel.Location = new System.Drawing.Point(68, 16);
            this.TotalProductsLabel.Name = "TotalProductsLabel";
            this.TotalProductsLabel.Size = new System.Drawing.Size(95, 17);
            this.TotalProductsLabel.TabIndex = 3;
            this.TotalProductsLabel.Text = "Total Products";
            // 
            // ProducrPBX
            // 
            this.ProducrPBX.Image = global::Inventory_Management_System.Properties.Resources.Total_products;
            this.ProducrPBX.Location = new System.Drawing.Point(12, 16);
            this.ProducrPBX.Name = "ProducrPBX";
            this.ProducrPBX.Size = new System.Drawing.Size(50, 50);
            this.ProducrPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProducrPBX.TabIndex = 0;
            this.ProducrPBX.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 640);
            this.Controls.Add(this.tblSummaryCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tblSummaryCards.ResumeLayout(false);
            this.TotalSupplierspanel.ResumeLayout(false);
            this.TotalSupplierspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersPBX)).EndInit();
            this.LowStockItemspanel.ResumeLayout(false);
            this.LowStockItemspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockPBX)).EndInit();
            this.TotalStaffpanel.ResumeLayout(false);
            this.TotalStaffpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffPBX)).EndInit();
            this.TotalProductspanel.ResumeLayout(false);
            this.TotalProductspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProducrPBX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSummaryCards;
        private System.Windows.Forms.Panel TotalSupplierspanel;
        private System.Windows.Forms.Label TotalSuppliersCountLabel;
        private System.Windows.Forms.Label TotalSuppliersLabel;
        private System.Windows.Forms.PictureBox SuppliersPBX;
        private System.Windows.Forms.Panel LowStockItemspanel;
        private System.Windows.Forms.Label LowStockItemsCountLabel;
        private System.Windows.Forms.Label LowStockItemsLabel;
        private System.Windows.Forms.PictureBox StockPBX;
        private System.Windows.Forms.Panel TotalStaffpanel;
        private System.Windows.Forms.Label TotalStaffCount;
        private System.Windows.Forms.Label TotalStaffLabel;
        private System.Windows.Forms.PictureBox staffPBX;
        private System.Windows.Forms.Panel TotalProductspanel;
        private System.Windows.Forms.Label TotalProductsCount;
        private System.Windows.Forms.Label TotalProductsLabel;
        private System.Windows.Forms.PictureBox ProducrPBX;
    }
}