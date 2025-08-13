//using System.Windows.Forms;
//using System.Drawing;

//namespace Inventory_Management_System.UserControls
//{
//    partial class UCDashboard
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.panelHeader = new System.Windows.Forms.Panel();
//            this.RecentActivityPanel = new System.Windows.Forms.Panel();
//            this.lblRecentActivity = new System.Windows.Forms.Label();
//            this.todaysAddedCategorypanel = new System.Windows.Forms.Panel();
//            this.listViewtodaysAddedCategory = new System.Windows.Forms.ListView();
//            this.todaysAddedCategorylbl = new System.Windows.Forms.Label();
//            this.TodaysAddedSupplierspanel = new System.Windows.Forms.Panel();
//            this.listViewTodaysAddedSuppliers = new System.Windows.Forms.ListView();
//            this.TodaysAddedSupplierslbl = new System.Windows.Forms.Label();
//            this.TodaysAddedStaffpanel = new System.Windows.Forms.Panel();
//            this.listViewTodaysAddedStaff = new System.Windows.Forms.ListView();
//            this.TodaysAddedStafflbl = new System.Windows.Forms.Label();
//            this.TodaysAddedProductspanel = new System.Windows.Forms.Panel();
//            this.listViewTodaysAddedProducts = new System.Windows.Forms.ListView();
//            this.TodaysAddedProductslbl = new System.Windows.Forms.Label();
//            this.SummaryCardsPanel = new System.Windows.Forms.Panel();
//            this.TotalSupplierspanel = new System.Windows.Forms.Panel();
//            this.TotalSuppliersCountLabel = new System.Windows.Forms.Label();
//            this.TotalSuppliersLabel = new System.Windows.Forms.Label();
//            this.LowStockItemspanel = new System.Windows.Forms.Panel();
//            this.LowStockItemsCountLabel = new System.Windows.Forms.Label();
//            this.LowStockItemsLabel = new System.Windows.Forms.Label();
//            this.TotalStaffpanel = new System.Windows.Forms.Panel();
//            this.TotalStaffCount = new System.Windows.Forms.Label();
//            this.TotalStaffLabel = new System.Windows.Forms.Label();
//            this.TotalProductspanel = new System.Windows.Forms.Panel();
//            this.TotalProductsCount = new System.Windows.Forms.Label();
//            this.TotalProductsLabel = new System.Windows.Forms.Label();
//            this.SummaryCardsLabel = new System.Windows.Forms.Label();
//            this.lblTitle = new System.Windows.Forms.Label();
//            this.panelMainContainer = new System.Windows.Forms.Panel();
//            this.panelFormContainer = new System.Windows.Forms.Panel();
//            this.SuppliersPBX = new System.Windows.Forms.PictureBox();
//            this.StockPBX = new System.Windows.Forms.PictureBox();
//            this.staffPBX = new System.Windows.Forms.PictureBox();
//            this.ProducrPBX = new System.Windows.Forms.PictureBox();
//            this.panelHeader.SuspendLayout();
//            this.RecentActivityPanel.SuspendLayout();
//            this.todaysAddedCategorypanel.SuspendLayout();
//            this.TodaysAddedSupplierspanel.SuspendLayout();
//            this.TodaysAddedStaffpanel.SuspendLayout();
//            this.TodaysAddedProductspanel.SuspendLayout();
//            this.SummaryCardsPanel.SuspendLayout();
//            this.TotalSupplierspanel.SuspendLayout();
//            this.LowStockItemspanel.SuspendLayout();
//            this.TotalStaffpanel.SuspendLayout();
//            this.TotalProductspanel.SuspendLayout();
//            this.panelMainContainer.SuspendLayout();
//            this.panelFormContainer.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.SuppliersPBX)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.StockPBX)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.staffPBX)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.ProducrPBX)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panelHeader
//            // 
//            this.panelHeader.BackColor = System.Drawing.Color.White;
//            this.panelHeader.Controls.Add(this.RecentActivityPanel);
//            this.panelHeader.Controls.Add(this.SummaryCardsPanel);
//            this.panelHeader.Controls.Add(this.lblTitle);
//            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelHeader.Location = new System.Drawing.Point(10, 10);
//            this.panelHeader.Name = "panelHeader";
//            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
//            this.panelHeader.Size = new System.Drawing.Size(980, 574);
//            this.panelHeader.TabIndex = 0;
//            // 
//            // RecentActivityPanel
//            // 
//            this.RecentActivityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.RecentActivityPanel.BackColor = System.Drawing.Color.White;
//            this.RecentActivityPanel.Controls.Add(this.lblRecentActivity);
//            this.RecentActivityPanel.Controls.Add(this.todaysAddedCategorypanel);
//            this.RecentActivityPanel.Controls.Add(this.TodaysAddedSupplierspanel);
//            this.RecentActivityPanel.Controls.Add(this.TodaysAddedStaffpanel);
//            this.RecentActivityPanel.Controls.Add(this.TodaysAddedProductspanel);
//            this.RecentActivityPanel.Location = new System.Drawing.Point(18, 180);
//            this.RecentActivityPanel.Name = "RecentActivityPanel";
//            this.RecentActivityPanel.Size = new System.Drawing.Size(950, 381);
//            this.RecentActivityPanel.TabIndex = 0;
//            // 
//            // lblRecentActivity
//            // 
//            this.lblRecentActivity.AutoSize = true;
//            this.lblRecentActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblRecentActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.lblRecentActivity.Location = new System.Drawing.Point(10, 11);
//            this.lblRecentActivity.Name = "lblRecentActivity";
//            this.lblRecentActivity.Size = new System.Drawing.Size(120, 21);
//            this.lblRecentActivity.TabIndex = 0;
//            this.lblRecentActivity.Text = "Recent Activity";
//            // 
//            // todaysAddedCategorypanel
//            // 
//            this.todaysAddedCategorypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
//            this.todaysAddedCategorypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.todaysAddedCategorypanel.Controls.Add(this.listViewtodaysAddedCategory);
//            this.todaysAddedCategorypanel.Controls.Add(this.todaysAddedCategorylbl);
//            this.todaysAddedCategorypanel.Location = new System.Drawing.Point(480, 40);
//            this.todaysAddedCategorypanel.Name = "todaysAddedCategorypanel";
//            this.todaysAddedCategorypanel.Size = new System.Drawing.Size(440, 165);
//            this.todaysAddedCategorypanel.TabIndex = 0;
//            // 
//            // listViewtodaysAddedCategory
//            // 
//            this.listViewtodaysAddedCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.listViewtodaysAddedCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.listViewtodaysAddedCategory.HideSelection = false;
//            this.listViewtodaysAddedCategory.Location = new System.Drawing.Point(7, 30);
//            this.listViewtodaysAddedCategory.Name = "listViewtodaysAddedCategory";
//            this.listViewtodaysAddedCategory.Size = new System.Drawing.Size(422, 130);
//            this.listViewtodaysAddedCategory.TabIndex = 0;
//            this.listViewtodaysAddedCategory.UseCompatibleStateImageBehavior = false;
//            this.listViewtodaysAddedCategory.View = System.Windows.Forms.View.Details;
//            // 
//            // todaysAddedCategorylbl
//            // 
//            this.todaysAddedCategorylbl.AutoSize = true;
//            this.todaysAddedCategorylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.todaysAddedCategorylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
//            this.todaysAddedCategorylbl.Location = new System.Drawing.Point(123, 6);
//            this.todaysAddedCategorylbl.Name = "todaysAddedCategorylbl";
//            this.todaysAddedCategorylbl.Size = new System.Drawing.Size(156, 17);
//            this.todaysAddedCategorylbl.TabIndex = 0;
//            this.todaysAddedCategorylbl.Text = "Today\'s Added Category";
//            // 
//            // TodaysAddedSupplierspanel
//            // 
//            this.TodaysAddedSupplierspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
//            this.TodaysAddedSupplierspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.TodaysAddedSupplierspanel.Controls.Add(this.listViewTodaysAddedSuppliers);
//            this.TodaysAddedSupplierspanel.Controls.Add(this.TodaysAddedSupplierslbl);
//            this.TodaysAddedSupplierspanel.Location = new System.Drawing.Point(480, 213);
//            this.TodaysAddedSupplierspanel.Name = "TodaysAddedSupplierspanel";
//            this.TodaysAddedSupplierspanel.Size = new System.Drawing.Size(440, 165);
//            this.TodaysAddedSupplierspanel.TabIndex = 0;
//            // 
//            // listViewTodaysAddedSuppliers
//            // 
//            this.listViewTodaysAddedSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.listViewTodaysAddedSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.listViewTodaysAddedSuppliers.HideSelection = false;
//            this.listViewTodaysAddedSuppliers.Location = new System.Drawing.Point(7, 30);
//            this.listViewTodaysAddedSuppliers.Name = "listViewTodaysAddedSuppliers";
//            this.listViewTodaysAddedSuppliers.Size = new System.Drawing.Size(422, 130);
//            this.listViewTodaysAddedSuppliers.TabIndex = 0;
//            this.listViewTodaysAddedSuppliers.UseCompatibleStateImageBehavior = false;
//            this.listViewTodaysAddedSuppliers.View = System.Windows.Forms.View.Details;
//            // 
//            // TodaysAddedSupplierslbl
//            // 
//            this.TodaysAddedSupplierslbl.AutoSize = true;
//            this.TodaysAddedSupplierslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TodaysAddedSupplierslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
//            this.TodaysAddedSupplierslbl.Location = new System.Drawing.Point(132, 6);
//            this.TodaysAddedSupplierslbl.Name = "TodaysAddedSupplierslbl";
//            this.TodaysAddedSupplierslbl.Size = new System.Drawing.Size(155, 17);
//            this.TodaysAddedSupplierslbl.TabIndex = 0;
//            this.TodaysAddedSupplierslbl.Text = "Today\'s Added Suppliers";
//            // 
//            // TodaysAddedStaffpanel
//            // 
//            this.TodaysAddedStaffpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
//            this.TodaysAddedStaffpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.TodaysAddedStaffpanel.Controls.Add(this.listViewTodaysAddedStaff);
//            this.TodaysAddedStaffpanel.Controls.Add(this.TodaysAddedStafflbl);
//            this.TodaysAddedStaffpanel.Location = new System.Drawing.Point(14, 213);
//            this.TodaysAddedStaffpanel.Name = "TodaysAddedStaffpanel";
//            this.TodaysAddedStaffpanel.Size = new System.Drawing.Size(440, 165);
//            this.TodaysAddedStaffpanel.TabIndex = 0;
//            // 
//            // listViewTodaysAddedStaff
//            // 
//            this.listViewTodaysAddedStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.listViewTodaysAddedStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.listViewTodaysAddedStaff.HideSelection = false;
//            this.listViewTodaysAddedStaff.Location = new System.Drawing.Point(7, 30);
//            this.listViewTodaysAddedStaff.Name = "listViewTodaysAddedStaff";
//            this.listViewTodaysAddedStaff.Size = new System.Drawing.Size(422, 130);
//            this.listViewTodaysAddedStaff.TabIndex = 0;
//            this.listViewTodaysAddedStaff.UseCompatibleStateImageBehavior = false;
//            this.listViewTodaysAddedStaff.View = System.Windows.Forms.View.Details;
//            // 
//            // TodaysAddedStafflbl
//            // 
//            this.TodaysAddedStafflbl.AutoSize = true;
//            this.TodaysAddedStafflbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TodaysAddedStafflbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
//            this.TodaysAddedStafflbl.Location = new System.Drawing.Point(134, 6);
//            this.TodaysAddedStafflbl.Name = "TodaysAddedStafflbl";
//            this.TodaysAddedStafflbl.Size = new System.Drawing.Size(127, 17);
//            this.TodaysAddedStafflbl.TabIndex = 3;
//            this.TodaysAddedStafflbl.Text = "Today\'s Added Staff";
//            // 
//            // TodaysAddedProductspanel
//            // 
//            this.TodaysAddedProductspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
//            this.TodaysAddedProductspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.TodaysAddedProductspanel.Controls.Add(this.listViewTodaysAddedProducts);
//            this.TodaysAddedProductspanel.Controls.Add(this.TodaysAddedProductslbl);
//            this.TodaysAddedProductspanel.Location = new System.Drawing.Point(14, 40);
//            this.TodaysAddedProductspanel.Name = "TodaysAddedProductspanel";
//            this.TodaysAddedProductspanel.Size = new System.Drawing.Size(440, 165);
//            this.TodaysAddedProductspanel.TabIndex = 1;
//            // 
//            // listViewTodaysAddedProducts
//            // 
//            this.listViewTodaysAddedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.listViewTodaysAddedProducts.BackColor = System.Drawing.Color.White;
//            this.listViewTodaysAddedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.listViewTodaysAddedProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.listViewTodaysAddedProducts.FullRowSelect = true;
//            this.listViewTodaysAddedProducts.GridLines = true;
//            this.listViewTodaysAddedProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
//            this.listViewTodaysAddedProducts.HideSelection = false;
//            this.listViewTodaysAddedProducts.Location = new System.Drawing.Point(9, 30);
//            this.listViewTodaysAddedProducts.MultiSelect = false;
//            this.listViewTodaysAddedProducts.Name = "listViewTodaysAddedProducts";
//            this.listViewTodaysAddedProducts.OwnerDraw = true;
//            this.listViewTodaysAddedProducts.Size = new System.Drawing.Size(422, 130);
//            this.listViewTodaysAddedProducts.TabIndex = 4;
//            this.listViewTodaysAddedProducts.UseCompatibleStateImageBehavior = false;
//            this.listViewTodaysAddedProducts.View = System.Windows.Forms.View.Details;
//            this.listViewTodaysAddedProducts.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
//            this.listViewTodaysAddedProducts.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
//            this.listViewTodaysAddedProducts.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListView_DrawSubItem);
//            this.listViewTodaysAddedProducts.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
//            // 
//            // TodaysAddedProductslbl
//            // 
//            this.TodaysAddedProductslbl.AutoSize = true;
//            this.TodaysAddedProductslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TodaysAddedProductslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
//            this.TodaysAddedProductslbl.Location = new System.Drawing.Point(123, 6);
//            this.TodaysAddedProductslbl.Name = "TodaysAddedProductslbl";
//            this.TodaysAddedProductslbl.Size = new System.Drawing.Size(154, 17);
//            this.TodaysAddedProductslbl.TabIndex = 3;
//            this.TodaysAddedProductslbl.Text = "Today\'s Added Products";
//            // 
//            // SummaryCardsPanel
//            // 
//            this.SummaryCardsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.SummaryCardsPanel.BackColor = System.Drawing.Color.White;
//            this.SummaryCardsPanel.Controls.Add(this.TotalSupplierspanel);
//            this.SummaryCardsPanel.Controls.Add(this.LowStockItemspanel);
//            this.SummaryCardsPanel.Controls.Add(this.TotalStaffpanel);
//            this.SummaryCardsPanel.Controls.Add(this.TotalProductspanel);
//            this.SummaryCardsPanel.Controls.Add(this.SummaryCardsLabel);
//            this.SummaryCardsPanel.Location = new System.Drawing.Point(18, 34);
//            this.SummaryCardsPanel.Name = "SummaryCardsPanel";
//            this.SummaryCardsPanel.Size = new System.Drawing.Size(950, 140);
//            this.SummaryCardsPanel.TabIndex = 0;
//            // 
//            // TotalSupplierspanel
//            // 
//            this.TotalSupplierspanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.TotalSupplierspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
//            this.TotalSupplierspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.TotalSupplierspanel.Controls.Add(this.TotalSuppliersCountLabel);
//            this.TotalSupplierspanel.Controls.Add(this.TotalSuppliersLabel);
//            this.TotalSupplierspanel.Controls.Add(this.SuppliersPBX);
//            this.TotalSupplierspanel.Location = new System.Drawing.Point(450, 40);
//            this.TotalSupplierspanel.MinimumSize = new System.Drawing.Size(150, 77);
//            this.TotalSupplierspanel.Name = "TotalSupplierspanel";
//            this.TotalSupplierspanel.Size = new System.Drawing.Size(200, 77);
//            this.TotalSupplierspanel.TabIndex = 6;
//            // 
//            // TotalSuppliersCountLabel
//            // 
//            this.TotalSuppliersCountLabel.AutoSize = true;
//            this.TotalSuppliersCountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TotalSuppliersCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
//            this.TotalSuppliersCountLabel.Location = new System.Drawing.Point(68, 45);
//            this.TotalSuppliersCountLabel.Name = "TotalSuppliersCountLabel";
//            this.TotalSuppliersCountLabel.Size = new System.Drawing.Size(23, 25);
//            this.TotalSuppliersCountLabel.TabIndex = 4;
//            this.TotalSuppliersCountLabel.Text = "0";
//            // 
//            // TotalSuppliersLabel
//            // 
//            this.TotalSuppliersLabel.AutoSize = true;
//            this.TotalSuppliersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TotalSuppliersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
//            this.TotalSuppliersLabel.Location = new System.Drawing.Point(68, 16);
//            this.TotalSuppliersLabel.Name = "TotalSuppliersLabel";
//            this.TotalSuppliersLabel.Size = new System.Drawing.Size(96, 17);
//            this.TotalSuppliersLabel.TabIndex = 3;
//            this.TotalSuppliersLabel.Text = "Total Suppliers";
//            // 
//            // LowStockItemspanel
//            // 
//            this.LowStockItemspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
//            this.LowStockItemspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.LowStockItemspanel.Controls.Add(this.LowStockItemsCountLabel);
//            this.LowStockItemspanel.Controls.Add(this.LowStockItemsLabel);
//            this.LowStockItemspanel.Controls.Add(this.StockPBX);
//            this.LowStockItemspanel.Location = new System.Drawing.Point(672, 40);
//            this.LowStockItemspanel.Name = "LowStockItemspanel";
//            this.LowStockItemspanel.Size = new System.Drawing.Size(260, 77);
//            this.LowStockItemspanel.TabIndex = 6;
//            // 
//            // LowStockItemsCountLabel
//            // 
//            this.LowStockItemsCountLabel.AutoSize = true;
//            this.LowStockItemsCountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.LowStockItemsCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
//            this.LowStockItemsCountLabel.Location = new System.Drawing.Point(68, 45);
//            this.LowStockItemsCountLabel.Name = "LowStockItemsCountLabel";
//            this.LowStockItemsCountLabel.Size = new System.Drawing.Size(23, 25);
//            this.LowStockItemsCountLabel.TabIndex = 4;
//            this.LowStockItemsCountLabel.Text = "0";
//            // 
//            // LowStockItemsLabel
//            // 
//            this.LowStockItemsLabel.AutoSize = true;
//            this.LowStockItemsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.LowStockItemsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
//            this.LowStockItemsLabel.Location = new System.Drawing.Point(68, 16);
//            this.LowStockItemsLabel.Name = "LowStockItemsLabel";
//            this.LowStockItemsLabel.Size = new System.Drawing.Size(148, 17);
//            this.LowStockItemsLabel.TabIndex = 3;
//            this.LowStockItemsLabel.Text = "Low Stock Items Count";
//            // 
//            // TotalStaffpanel
//            // 
//            this.TotalStaffpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
//            this.TotalStaffpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.TotalStaffpanel.Controls.Add(this.TotalStaffCount);
//            this.TotalStaffpanel.Controls.Add(this.TotalStaffLabel);
//            this.TotalStaffpanel.Controls.Add(this.staffPBX);
//            this.TotalStaffpanel.Location = new System.Drawing.Point(232, 40);
//            this.TotalStaffpanel.Name = "TotalStaffpanel";
//            this.TotalStaffpanel.Size = new System.Drawing.Size(200, 77);
//            this.TotalStaffpanel.TabIndex = 0;
//            // 
//            // TotalStaffCount
//            // 
//            this.TotalStaffCount.AutoSize = true;
//            this.TotalStaffCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TotalStaffCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
//            this.TotalStaffCount.Location = new System.Drawing.Point(68, 45);
//            this.TotalStaffCount.Name = "TotalStaffCount";
//            this.TotalStaffCount.Size = new System.Drawing.Size(23, 25);
//            this.TotalStaffCount.TabIndex = 4;
//            this.TotalStaffCount.Text = "0";
//            // 
//            // TotalStaffLabel
//            // 
//            this.TotalStaffLabel.AutoSize = true;
//            this.TotalStaffLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TotalStaffLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
//            this.TotalStaffLabel.Location = new System.Drawing.Point(68, 16);
//            this.TotalStaffLabel.Name = "TotalStaffLabel";
//            this.TotalStaffLabel.Size = new System.Drawing.Size(68, 17);
//            this.TotalStaffLabel.TabIndex = 3;
//            this.TotalStaffLabel.Text = "Total Staff";
//            // 
//            // TotalProductspanel
//            // 
//            this.TotalProductspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
//            this.TotalProductspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.TotalProductspanel.Controls.Add(this.TotalProductsCount);
//            this.TotalProductspanel.Controls.Add(this.TotalProductsLabel);
//            this.TotalProductspanel.Controls.Add(this.ProducrPBX);
//            this.TotalProductspanel.Location = new System.Drawing.Point(14, 40);
//            this.TotalProductspanel.Name = "TotalProductspanel";
//            this.TotalProductspanel.Size = new System.Drawing.Size(200, 77);
//            this.TotalProductspanel.TabIndex = 0;
//            // 
//            // TotalProductsCount
//            // 
//            this.TotalProductsCount.AutoSize = true;
//            this.TotalProductsCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TotalProductsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
//            this.TotalProductsCount.Location = new System.Drawing.Point(68, 45);
//            this.TotalProductsCount.Name = "TotalProductsCount";
//            this.TotalProductsCount.Size = new System.Drawing.Size(23, 25);
//            this.TotalProductsCount.TabIndex = 4;
//            this.TotalProductsCount.Text = "0";
//            // 
//            // TotalProductsLabel
//            // 
//            this.TotalProductsLabel.AutoSize = true;
//            this.TotalProductsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.TotalProductsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
//            this.TotalProductsLabel.Location = new System.Drawing.Point(68, 16);
//            this.TotalProductsLabel.Name = "TotalProductsLabel";
//            this.TotalProductsLabel.Size = new System.Drawing.Size(95, 17);
//            this.TotalProductsLabel.TabIndex = 3;
//            this.TotalProductsLabel.Text = "Total Products";
//            // 
//            // SummaryCardsLabel
//            // 
//            this.SummaryCardsLabel.AutoSize = true;
//            this.SummaryCardsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.SummaryCardsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.SummaryCardsLabel.Location = new System.Drawing.Point(10, 11);
//            this.SummaryCardsLabel.Name = "SummaryCardsLabel";
//            this.SummaryCardsLabel.Size = new System.Drawing.Size(124, 21);
//            this.SummaryCardsLabel.TabIndex = 3;
//            this.SummaryCardsLabel.Text = "Summary Cards";
//            // 
//            // lblTitle
//            // 
//            this.lblTitle.AutoSize = true;
//            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.lblTitle.Location = new System.Drawing.Point(14, 6);
//            this.lblTitle.Name = "lblTitle";
//            this.lblTitle.Size = new System.Drawing.Size(109, 25);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "Dashboard";
//            // 
//            // panelMainContainer
//            // 
//            this.panelMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
//            this.panelMainContainer.Controls.Add(this.panelFormContainer);
//            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
//            this.panelMainContainer.Name = "panelMainContainer";
//            this.panelMainContainer.Size = new System.Drawing.Size(1000, 597);
//            this.panelMainContainer.TabIndex = 1;
//            // 
//            // panelFormContainer
//            // 
//            this.panelFormContainer.Controls.Add(this.panelHeader);
//            this.panelFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelFormContainer.Location = new System.Drawing.Point(0, 0);
//            this.panelFormContainer.Name = "panelFormContainer";
//            this.panelFormContainer.Padding = new System.Windows.Forms.Padding(10);
//            this.panelFormContainer.Size = new System.Drawing.Size(1000, 597);
//            this.panelFormContainer.TabIndex = 2;
//            // 
//            // SuppliersPBX
//            // 
//            this.SuppliersPBX.Image = global::Inventory_Management_System.Properties.Resources.Total_Suppliers;
//            this.SuppliersPBX.Location = new System.Drawing.Point(12, 16);
//            this.SuppliersPBX.Name = "SuppliersPBX";
//            this.SuppliersPBX.Size = new System.Drawing.Size(50, 50);
//            this.SuppliersPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.SuppliersPBX.TabIndex = 0;
//            this.SuppliersPBX.TabStop = false;
//            // 
//            // StockPBX
//            // 
//            this.StockPBX.Image = global::Inventory_Management_System.Properties.Resources.Low_Stock_Items_Count;
//            this.StockPBX.Location = new System.Drawing.Point(12, 16);
//            this.StockPBX.Name = "StockPBX";
//            this.StockPBX.Size = new System.Drawing.Size(50, 50);
//            this.StockPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.StockPBX.TabIndex = 0;
//            this.StockPBX.TabStop = false;
//            // 
//            // staffPBX
//            // 
//            this.staffPBX.Image = global::Inventory_Management_System.Properties.Resources.Total_Staff;
//            this.staffPBX.Location = new System.Drawing.Point(12, 16);
//            this.staffPBX.Name = "staffPBX";
//            this.staffPBX.Size = new System.Drawing.Size(50, 50);
//            this.staffPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.staffPBX.TabIndex = 0;
//            this.staffPBX.TabStop = false;
//            // 
//            // ProducrPBX
//            // 
//            this.ProducrPBX.Image = global::Inventory_Management_System.Properties.Resources.Total_products;
//            this.ProducrPBX.Location = new System.Drawing.Point(12, 16);
//            this.ProducrPBX.Name = "ProducrPBX";
//            this.ProducrPBX.Size = new System.Drawing.Size(50, 50);
//            this.ProducrPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.ProducrPBX.TabIndex = 0;
//            this.ProducrPBX.TabStop = false;
//            // 
//            // UCDashboard
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.panelMainContainer);
//            this.Name = "UCDashboard";
//            this.Size = new System.Drawing.Size(1000, 597);
//            this.panelHeader.ResumeLayout(false);
//            this.panelHeader.PerformLayout();
//            this.RecentActivityPanel.ResumeLayout(false);
//            this.RecentActivityPanel.PerformLayout();
//            this.todaysAddedCategorypanel.ResumeLayout(false);
//            this.todaysAddedCategorypanel.PerformLayout();
//            this.TodaysAddedSupplierspanel.ResumeLayout(false);
//            this.TodaysAddedSupplierspanel.PerformLayout();
//            this.TodaysAddedStaffpanel.ResumeLayout(false);
//            this.TodaysAddedStaffpanel.PerformLayout();
//            this.TodaysAddedProductspanel.ResumeLayout(false);
//            this.TodaysAddedProductspanel.PerformLayout();
//            this.SummaryCardsPanel.ResumeLayout(false);
//            this.SummaryCardsPanel.PerformLayout();
//            this.TotalSupplierspanel.ResumeLayout(false);
//            this.TotalSupplierspanel.PerformLayout();
//            this.LowStockItemspanel.ResumeLayout(false);
//            this.LowStockItemspanel.PerformLayout();
//            this.TotalStaffpanel.ResumeLayout(false);
//            this.TotalStaffpanel.PerformLayout();
//            this.TotalProductspanel.ResumeLayout(false);
//            this.TotalProductspanel.PerformLayout();
//            this.panelMainContainer.ResumeLayout(false);
//            this.panelFormContainer.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.SuppliersPBX)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.StockPBX)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.staffPBX)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.ProducrPBX)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion
//        private System.Windows.Forms.Panel panelHeader;
//        private System.Windows.Forms.Panel panelMainContainer;
//        private System.Windows.Forms.Panel panelFormContainer;
//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Panel TotalProductspanel;
//        private System.Windows.Forms.PictureBox ProducrPBX;
//        private System.Windows.Forms.Panel SummaryCardsPanel;
//        private System.Windows.Forms.Label TotalProductsCount;
//        private System.Windows.Forms.Label TotalProductsLabel;
//        private System.Windows.Forms.Panel TotalStaffpanel;
//        private System.Windows.Forms.Label TotalStaffCount;
//        private System.Windows.Forms.Label TotalStaffLabel;
//        private System.Windows.Forms.PictureBox staffPBX;
//        private System.Windows.Forms.Panel LowStockItemspanel;
//        private System.Windows.Forms.Label LowStockItemsCountLabel;
//        private System.Windows.Forms.Label LowStockItemsLabel;
//        private System.Windows.Forms.PictureBox StockPBX;
//        private System.Windows.Forms.Panel TotalSupplierspanel;
//        private System.Windows.Forms.Label TotalSuppliersCountLabel;
//        private System.Windows.Forms.Label TotalSuppliersLabel;
//        private System.Windows.Forms.PictureBox SuppliersPBX;
//        private System.Windows.Forms.Label SummaryCardsLabel;
//        private System.Windows.Forms.Panel RecentActivityPanel;
//        private System.Windows.Forms.Label lblRecentActivity;
//        private System.Windows.Forms.Panel todaysAddedCategorypanel;
//        private System.Windows.Forms.Label todaysAddedCategorylbl;
//        private System.Windows.Forms.Panel TodaysAddedSupplierspanel;
//        private System.Windows.Forms.Label TodaysAddedSupplierslbl;
//        private System.Windows.Forms.Panel TodaysAddedStaffpanel;
//        private System.Windows.Forms.Label TodaysAddedStafflbl;
//        private System.Windows.Forms.Panel TodaysAddedProductspanel;
//        private System.Windows.Forms.Label TodaysAddedProductslbl;
//        private System.Windows.Forms.ListView listViewTodaysAddedProducts;
//        private System.Windows.Forms.ListView listViewTodaysAddedStaff;
//        private System.Windows.Forms.ListView listViewtodaysAddedCategory;
//        private System.Windows.Forms.ListView listViewTodaysAddedSuppliers;
//    }
//}

// UCDashboard.Designer.cs
// NOTE: This code is heavily modified to use TableLayoutPanels for responsiveness.

namespace Inventory_Management_System.UserControls
{
    partial class UCDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tblRecentActivity = new System.Windows.Forms.TableLayoutPanel();
            this.todaysAddedCategorypanel = new System.Windows.Forms.Panel();
            this.listViewtodaysAddedCategory = new System.Windows.Forms.ListView();
            this.todaysAddedCategorylbl = new System.Windows.Forms.Label();
            this.TodaysAddedSupplierspanel = new System.Windows.Forms.Panel();
            this.listViewTodaysAddedSuppliers = new System.Windows.Forms.ListView();
            this.TodaysAddedSupplierslbl = new System.Windows.Forms.Label();
            this.TodaysAddedStaffpanel = new System.Windows.Forms.Panel();
            this.listViewTodaysAddedStaff = new System.Windows.Forms.ListView();
            this.TodaysAddedStafflbl = new System.Windows.Forms.Label();
            this.TodaysAddedProductspanel = new System.Windows.Forms.Panel();
            this.listViewTodaysAddedProducts = new System.Windows.Forms.ListView();
            this.TodaysAddedProductslbl = new System.Windows.Forms.Label();
            this.lblRecentActivity = new System.Windows.Forms.Label();
            this.SummaryCardsLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TotalProductspanel = new System.Windows.Forms.Panel();
            this.ProducrPBX = new System.Windows.Forms.PictureBox();
            this.TotalProductsLabel = new System.Windows.Forms.Label();
            this.TotalProductsCount = new System.Windows.Forms.Label();
            this.TotalStaffpanel = new System.Windows.Forms.Panel();
            this.staffPBX = new System.Windows.Forms.PictureBox();
            this.TotalStaffLabel = new System.Windows.Forms.Label();
            this.TotalStaffCount = new System.Windows.Forms.Label();
            this.LowStockItemspanel = new System.Windows.Forms.Panel();
            this.StockPBX = new System.Windows.Forms.PictureBox();
            this.LowStockItemsLabel = new System.Windows.Forms.Label();
            this.LowStockItemsCountLabel = new System.Windows.Forms.Label();
            this.TotalSupplierspanel = new System.Windows.Forms.Panel();
            this.SuppliersPBX = new System.Windows.Forms.PictureBox();
            this.TotalSuppliersLabel = new System.Windows.Forms.Label();
            this.TotalSuppliersCountLabel = new System.Windows.Forms.Label();
            this.tblSummaryCards = new System.Windows.Forms.TableLayoutPanel();
            this.panelMainContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tblRecentActivity.SuspendLayout();
            this.todaysAddedCategorypanel.SuspendLayout();
            this.TodaysAddedSupplierspanel.SuspendLayout();
            this.TodaysAddedStaffpanel.SuspendLayout();
            this.TodaysAddedProductspanel.SuspendLayout();
            this.TotalProductspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProducrPBX)).BeginInit();
            this.TotalStaffpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffPBX)).BeginInit();
            this.LowStockItemspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockPBX)).BeginInit();
            this.TotalSupplierspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersPBX)).BeginInit();
            this.tblSummaryCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelMainContainer.Controls.Add(this.panelHeader);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Padding = new System.Windows.Forms.Padding(10);
            this.panelMainContainer.Size = new System.Drawing.Size(1000, 700);
            this.panelMainContainer.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.tblSummaryCards);
            this.panelHeader.Controls.Add(this.tblRecentActivity);
            this.panelHeader.Controls.Add(this.lblRecentActivity);
            this.panelHeader.Controls.Add(this.SummaryCardsLabel);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(10, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeader.Size = new System.Drawing.Size(980, 680);
            this.panelHeader.TabIndex = 0;
            // 
            // tblRecentActivity
            // 
            this.tblRecentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblRecentActivity.ColumnCount = 2;
            this.tblRecentActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecentActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecentActivity.Controls.Add(this.todaysAddedCategorypanel, 1, 0);
            this.tblRecentActivity.Controls.Add(this.TodaysAddedSupplierspanel, 1, 1);
            this.tblRecentActivity.Controls.Add(this.TodaysAddedStaffpanel, 0, 1);
            this.tblRecentActivity.Controls.Add(this.TodaysAddedProductspanel, 0, 0);
            this.tblRecentActivity.Location = new System.Drawing.Point(14, 208);
            this.tblRecentActivity.Name = "tblRecentActivity";
            this.tblRecentActivity.RowCount = 2;
            this.tblRecentActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecentActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecentActivity.Size = new System.Drawing.Size(953, 459);
            this.tblRecentActivity.TabIndex = 4;
            // 
            // todaysAddedCategorypanel
            // 
            this.todaysAddedCategorypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.todaysAddedCategorypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todaysAddedCategorypanel.Controls.Add(this.listViewtodaysAddedCategory);
            this.todaysAddedCategorypanel.Controls.Add(this.todaysAddedCategorylbl);
            this.todaysAddedCategorypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todaysAddedCategorypanel.Location = new System.Drawing.Point(479, 3);
            this.todaysAddedCategorypanel.Name = "todaysAddedCategorypanel";
            this.todaysAddedCategorypanel.Size = new System.Drawing.Size(471, 223);
            this.todaysAddedCategorypanel.TabIndex = 0;
            // 
            // listViewtodaysAddedCategory
            // 
            this.listViewtodaysAddedCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewtodaysAddedCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewtodaysAddedCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listViewtodaysAddedCategory.HideSelection = false;
            this.listViewtodaysAddedCategory.Location = new System.Drawing.Point(7, 30);
            this.listViewtodaysAddedCategory.Name = "listViewtodaysAddedCategory";
            this.listViewtodaysAddedCategory.Size = new System.Drawing.Size(455, 185);
            this.listViewtodaysAddedCategory.TabIndex = 0;
            this.listViewtodaysAddedCategory.UseCompatibleStateImageBehavior = false;
            this.listViewtodaysAddedCategory.View = System.Windows.Forms.View.Details;
            // 
            // todaysAddedCategorylbl
            // 
            this.todaysAddedCategorylbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todaysAddedCategorylbl.AutoSize = true;
            this.todaysAddedCategorylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.todaysAddedCategorylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.todaysAddedCategorylbl.Location = new System.Drawing.Point(157, 6);
            this.todaysAddedCategorylbl.Name = "todaysAddedCategorylbl";
            this.todaysAddedCategorylbl.Size = new System.Drawing.Size(156, 17);
            this.todaysAddedCategorylbl.TabIndex = 0;
            this.todaysAddedCategorylbl.Text = "Today\'s Added Category";
            // 
            // TodaysAddedSupplierspanel
            // 
            this.TodaysAddedSupplierspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TodaysAddedSupplierspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TodaysAddedSupplierspanel.Controls.Add(this.listViewTodaysAddedSuppliers);
            this.TodaysAddedSupplierspanel.Controls.Add(this.TodaysAddedSupplierslbl);
            this.TodaysAddedSupplierspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodaysAddedSupplierspanel.Location = new System.Drawing.Point(479, 232);
            this.TodaysAddedSupplierspanel.Name = "TodaysAddedSupplierspanel";
            this.TodaysAddedSupplierspanel.Size = new System.Drawing.Size(471, 224);
            this.TodaysAddedSupplierspanel.TabIndex = 0;
            // 
            // listViewTodaysAddedSuppliers
            // 
            this.listViewTodaysAddedSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTodaysAddedSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTodaysAddedSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listViewTodaysAddedSuppliers.HideSelection = false;
            this.listViewTodaysAddedSuppliers.Location = new System.Drawing.Point(7, 30);
            this.listViewTodaysAddedSuppliers.Name = "listViewTodaysAddedSuppliers";
            this.listViewTodaysAddedSuppliers.Size = new System.Drawing.Size(455, 186);
            this.listViewTodaysAddedSuppliers.TabIndex = 0;
            this.listViewTodaysAddedSuppliers.UseCompatibleStateImageBehavior = false;
            this.listViewTodaysAddedSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // TodaysAddedSupplierslbl
            // 
            this.TodaysAddedSupplierslbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TodaysAddedSupplierslbl.AutoSize = true;
            this.TodaysAddedSupplierslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TodaysAddedSupplierslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.TodaysAddedSupplierslbl.Location = new System.Drawing.Point(158, 6);
            this.TodaysAddedSupplierslbl.Name = "TodaysAddedSupplierslbl";
            this.TodaysAddedSupplierslbl.Size = new System.Drawing.Size(155, 17);
            this.TodaysAddedSupplierslbl.TabIndex = 0;
            this.TodaysAddedSupplierslbl.Text = "Today\'s Added Suppliers";
            // 
            // TodaysAddedStaffpanel
            // 
            this.TodaysAddedStaffpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TodaysAddedStaffpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TodaysAddedStaffpanel.Controls.Add(this.listViewTodaysAddedStaff);
            this.TodaysAddedStaffpanel.Controls.Add(this.TodaysAddedStafflbl);
            this.TodaysAddedStaffpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodaysAddedStaffpanel.Location = new System.Drawing.Point(3, 232);
            this.TodaysAddedStaffpanel.Name = "TodaysAddedStaffpanel";
            this.TodaysAddedStaffpanel.Size = new System.Drawing.Size(470, 224);
            this.TodaysAddedStaffpanel.TabIndex = 0;
            // 
            // listViewTodaysAddedStaff
            // 
            this.listViewTodaysAddedStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTodaysAddedStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTodaysAddedStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listViewTodaysAddedStaff.HideSelection = false;
            this.listViewTodaysAddedStaff.Location = new System.Drawing.Point(7, 30);
            this.listViewTodaysAddedStaff.Name = "listViewTodaysAddedStaff";
            this.listViewTodaysAddedStaff.Size = new System.Drawing.Size(454, 186);
            this.listViewTodaysAddedStaff.TabIndex = 0;
            this.listViewTodaysAddedStaff.UseCompatibleStateImageBehavior = false;
            this.listViewTodaysAddedStaff.View = System.Windows.Forms.View.Details;
            // 
            // TodaysAddedStafflbl
            // 
            this.TodaysAddedStafflbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TodaysAddedStafflbl.AutoSize = true;
            this.TodaysAddedStafflbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TodaysAddedStafflbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.TodaysAddedStafflbl.Location = new System.Drawing.Point(171, 6);
            this.TodaysAddedStafflbl.Name = "TodaysAddedStafflbl";
            this.TodaysAddedStafflbl.Size = new System.Drawing.Size(127, 17);
            this.TodaysAddedStafflbl.TabIndex = 3;
            this.TodaysAddedStafflbl.Text = "Today\'s Added Staff";
            // 
            // TodaysAddedProductspanel
            // 
            this.TodaysAddedProductspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TodaysAddedProductspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TodaysAddedProductspanel.Controls.Add(this.listViewTodaysAddedProducts);
            this.TodaysAddedProductspanel.Controls.Add(this.TodaysAddedProductslbl);
            this.TodaysAddedProductspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodaysAddedProductspanel.Location = new System.Drawing.Point(3, 3);
            this.TodaysAddedProductspanel.Name = "TodaysAddedProductspanel";
            this.TodaysAddedProductspanel.Size = new System.Drawing.Size(470, 223);
            this.TodaysAddedProductspanel.TabIndex = 1;
            // 
            // listViewTodaysAddedProducts
            // 
            this.listViewTodaysAddedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTodaysAddedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTodaysAddedProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listViewTodaysAddedProducts.FullRowSelect = true;
            this.listViewTodaysAddedProducts.GridLines = true;
            this.listViewTodaysAddedProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTodaysAddedProducts.HideSelection = false;
            this.listViewTodaysAddedProducts.Location = new System.Drawing.Point(9, 30);
            this.listViewTodaysAddedProducts.MultiSelect = false;
            this.listViewTodaysAddedProducts.Name = "listViewTodaysAddedProducts";
            this.listViewTodaysAddedProducts.OwnerDraw = true;
            this.listViewTodaysAddedProducts.Size = new System.Drawing.Size(452, 185);
            this.listViewTodaysAddedProducts.TabIndex = 4;
            this.listViewTodaysAddedProducts.UseCompatibleStateImageBehavior = false;
            this.listViewTodaysAddedProducts.View = System.Windows.Forms.View.Details;
            this.listViewTodaysAddedProducts.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.listViewTodaysAddedProducts.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.listViewTodaysAddedProducts.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListView_DrawSubItem);
            // 
            // TodaysAddedProductslbl
            // 
            this.TodaysAddedProductslbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TodaysAddedProductslbl.AutoSize = true;
            this.TodaysAddedProductslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TodaysAddedProductslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.TodaysAddedProductslbl.Location = new System.Drawing.Point(158, 6);
            this.TodaysAddedProductslbl.Name = "TodaysAddedProductslbl";
            this.TodaysAddedProductslbl.Size = new System.Drawing.Size(154, 17);
            this.TodaysAddedProductslbl.TabIndex = 3;
            this.TodaysAddedProductslbl.Text = "Today\'s Added Products";
            // 
            // lblRecentActivity
            // 
            this.lblRecentActivity.AutoSize = true;
            this.lblRecentActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRecentActivity.Location = new System.Drawing.Point(14, 180);
            this.lblRecentActivity.Name = "lblRecentActivity";
            this.lblRecentActivity.Size = new System.Drawing.Size(120, 21);
            this.lblRecentActivity.TabIndex = 0;
            this.lblRecentActivity.Text = "Recent Activity";
            // 
            // SummaryCardsLabel
            // 
            this.SummaryCardsLabel.AutoSize = true;
            this.SummaryCardsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SummaryCardsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SummaryCardsLabel.Location = new System.Drawing.Point(14, 45);
            this.SummaryCardsLabel.Name = "SummaryCardsLabel";
            this.SummaryCardsLabel.Size = new System.Drawing.Size(124, 21);
            this.SummaryCardsLabel.TabIndex = 3;
            this.SummaryCardsLabel.Text = "Summary Cards";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
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
            this.tblSummaryCards.Location = new System.Drawing.Point(14, 73);
            this.tblSummaryCards.Name = "tblSummaryCards";
            this.tblSummaryCards.RowCount = 1;
            this.tblSummaryCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSummaryCards.Size = new System.Drawing.Size(953, 94);
            this.tblSummaryCards.TabIndex = 5;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainContainer);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(1000, 700);
            this.panelMainContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tblRecentActivity.ResumeLayout(false);
            this.todaysAddedCategorypanel.ResumeLayout(false);
            this.todaysAddedCategorypanel.PerformLayout();
            this.TodaysAddedSupplierspanel.ResumeLayout(false);
            this.TodaysAddedSupplierspanel.PerformLayout();
            this.TodaysAddedStaffpanel.ResumeLayout(false);
            this.TodaysAddedStaffpanel.PerformLayout();
            this.TodaysAddedProductspanel.ResumeLayout(false);
            this.TodaysAddedProductspanel.PerformLayout();
            this.TotalProductspanel.ResumeLayout(false);
            this.TotalProductspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProducrPBX)).EndInit();
            this.TotalStaffpanel.ResumeLayout(false);
            this.TotalStaffpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffPBX)).EndInit();
            this.LowStockItemspanel.ResumeLayout(false);
            this.LowStockItemspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockPBX)).EndInit();
            this.TotalSupplierspanel.ResumeLayout(false);
            this.TotalSupplierspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersPBX)).EndInit();
            this.tblSummaryCards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label SummaryCardsLabel;
        private System.Windows.Forms.Label lblRecentActivity;
        private System.Windows.Forms.Panel TodaysAddedProductspanel;
        private System.Windows.Forms.ListView listViewTodaysAddedProducts;
        private System.Windows.Forms.Label TodaysAddedProductslbl;
        private System.Windows.Forms.Panel todaysAddedCategorypanel;
        private System.Windows.Forms.ListView listViewtodaysAddedCategory;
        private System.Windows.Forms.Label todaysAddedCategorylbl;
        private System.Windows.Forms.Panel TodaysAddedSupplierspanel;
        private System.Windows.Forms.ListView listViewTodaysAddedSuppliers;
        private System.Windows.Forms.Label TodaysAddedSupplierslbl;
        private System.Windows.Forms.Panel TodaysAddedStaffpanel;
        private System.Windows.Forms.ListView listViewTodaysAddedStaff;
        private System.Windows.Forms.Label TodaysAddedStafflbl;
        private System.Windows.Forms.TableLayoutPanel tblRecentActivity;
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