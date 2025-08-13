

//using System.Drawing;
//using System.Windows.Forms;

//namespace Inventory_Management_System
//{
//    partial class MainForm
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

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
//            this.Headerpanel = new System.Windows.Forms.Panel();
//            this.userlabel = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.pictureBox8 = new System.Windows.Forms.PictureBox();
//            this.DateLabel = new System.Windows.Forms.Label();
//            this.InventoryManagementSystemLabel = new System.Windows.Forms.Label();
//            this.Leftpanel = new System.Windows.Forms.Panel();
//            this.Logoutbutton = new System.Windows.Forms.Button();
//            this.pictureBox9 = new System.Windows.Forms.PictureBox();
//            this.AddUsersBtn = new System.Windows.Forms.Button();
//            this.pictureBox7 = new System.Windows.Forms.PictureBox();
//            this.pictureBox6 = new System.Windows.Forms.PictureBox();
//            this.pictureBox5 = new System.Windows.Forms.PictureBox();
//            this.pictureBox4 = new System.Windows.Forms.PictureBox();
//            this.pictureBox3 = new System.Windows.Forms.PictureBox();
//            this.pictureBox2 = new System.Windows.Forms.PictureBox();
//            this.Suppliersbtn = new System.Windows.Forms.Button();
//            this.ProductButton = new System.Windows.Forms.Button();
//            this.Staffbutton = new System.Windows.Forms.Button();
//            this.Categorybutton = new System.Windows.Forms.Button();
//            this.Dashboardbutton = new System.Windows.Forms.Button();
//            this.Mainpanel = new System.Windows.Forms.Panel();
//            this.Headerpanel.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
//            this.Leftpanel.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // Headerpanel
//            // 
//            this.Headerpanel.BackColor = System.Drawing.Color.WhiteSmoke;
//            this.Headerpanel.Controls.Add(this.userlabel);
//            this.Headerpanel.Controls.Add(this.label2);
//            this.Headerpanel.Controls.Add(this.pictureBox8);
//            this.Headerpanel.Controls.Add(this.DateLabel);
//            this.Headerpanel.Controls.Add(this.InventoryManagementSystemLabel);
//            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
//            this.Headerpanel.ForeColor = System.Drawing.Color.White;
//            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
//            this.Headerpanel.Name = "Headerpanel";
//            this.Headerpanel.Size = new System.Drawing.Size(884, 60);
//            this.Headerpanel.TabIndex = 0;
//            this.Headerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Headerpanel_MouseDown);
//            // 
//            // userlabel
//            // 
//            this.userlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.userlabel.AutoSize = true;
//            this.userlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.userlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
//            this.userlabel.Location = new System.Drawing.Point(154, 41);
//            this.userlabel.Name = "userlabel";
//            this.userlabel.Size = new System.Drawing.Size(35, 17);
//            this.userlabel.TabIndex = 15;
//            this.userlabel.Text = "User";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(119)))));
//            this.label2.Location = new System.Drawing.Point(70, 41);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(89, 17);
//            this.label2.TabIndex = 14;
//            this.label2.Text = "Current User:";
//            // 
//            // pictureBox8
//            // 
//            this.pictureBox8.Image = global::Inventory_Management_System.Properties.Resources.ChatGPT_Image_Aug_11__2025__02_21_24_PM;
//            this.pictureBox8.Location = new System.Drawing.Point(3, 5);
//            this.pictureBox8.Name = "pictureBox8";
//            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox8.TabIndex = 12;
//            this.pictureBox8.TabStop = false;
//            // 
//            // DateLabel
//            // 
//            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.DateLabel.AutoSize = true;
//            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.DateLabel.Location = new System.Drawing.Point(646, 20);
//            this.DateLabel.Name = "DateLabel";
//            this.DateLabel.Size = new System.Drawing.Size(100, 21);
//            this.DateLabel.TabIndex = 1;
//            this.DateLabel.Text = "11 Aug 2025";
//            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // InventoryManagementSystemLabel
//            // 
//            this.InventoryManagementSystemLabel.AutoSize = true;
//            this.InventoryManagementSystemLabel.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.InventoryManagementSystemLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.InventoryManagementSystemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.InventoryManagementSystemLabel.Location = new System.Drawing.Point(67, 9);
//            this.InventoryManagementSystemLabel.Name = "InventoryManagementSystemLabel";
//            this.InventoryManagementSystemLabel.Size = new System.Drawing.Size(431, 32);
//            this.InventoryManagementSystemLabel.TabIndex = 0;
//            this.InventoryManagementSystemLabel.Text = "INVENTORY MANAGEMENT SYSTEM";
//            this.InventoryManagementSystemLabel.Click += new System.EventHandler(this.InventoryManagementSystemLabel_Click);
//            // 
//            // Leftpanel
//            // 
//            this.Leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
//            this.Leftpanel.Controls.Add(this.Logoutbutton);
//            this.Leftpanel.Controls.Add(this.pictureBox9);
//            this.Leftpanel.Controls.Add(this.AddUsersBtn);
//            this.Leftpanel.Controls.Add(this.pictureBox7);
//            this.Leftpanel.Controls.Add(this.pictureBox6);
//            this.Leftpanel.Controls.Add(this.pictureBox5);
//            this.Leftpanel.Controls.Add(this.pictureBox4);
//            this.Leftpanel.Controls.Add(this.pictureBox3);
//            this.Leftpanel.Controls.Add(this.pictureBox2);
//            this.Leftpanel.Controls.Add(this.Suppliersbtn);
//            this.Leftpanel.Controls.Add(this.ProductButton);
//            this.Leftpanel.Controls.Add(this.Staffbutton);
//            this.Leftpanel.Controls.Add(this.Categorybutton);
//            this.Leftpanel.Controls.Add(this.Dashboardbutton);
//            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
//            this.Leftpanel.Location = new System.Drawing.Point(0, 60);
//            this.Leftpanel.Name = "Leftpanel";
//            this.Leftpanel.Size = new System.Drawing.Size(220, 501);
//            this.Leftpanel.TabIndex = 1;
//            // 
//            // Logoutbutton
//            // 
//            this.Logoutbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.Logoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.Logoutbutton.FlatAppearance.BorderSize = 0;
//            this.Logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.Logoutbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Logoutbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
//            this.Logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Logoutbutton.Location = new System.Drawing.Point(59, 438);
//            this.Logoutbutton.Name = "Logoutbutton";
//            this.Logoutbutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
//            this.Logoutbutton.Size = new System.Drawing.Size(161, 60);
//            this.Logoutbutton.TabIndex = 6;
//            this.Logoutbutton.Text = "LOGOUT";
//            this.Logoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Logoutbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.Logoutbutton.UseVisualStyleBackColor = false;
//            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
//            // 
//            // pictureBox9
//            // 
//            this.pictureBox9.Image = global::Inventory_Management_System.Properties.Resources.IMS_ADMIN;
//            this.pictureBox9.Location = new System.Drawing.Point(3, 300);
//            this.pictureBox9.Name = "pictureBox9";
//            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox9.TabIndex = 13;
//            this.pictureBox9.TabStop = false;
//            // 
//            // AddUsersBtn
//            // 
//            this.AddUsersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.AddUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.AddUsersBtn.FlatAppearance.BorderSize = 0;
//            this.AddUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.AddUsersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.AddUsersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.AddUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.AddUsersBtn.Location = new System.Drawing.Point(59, 290);
//            this.AddUsersBtn.Name = "AddUsersBtn";
//            this.AddUsersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
//            this.AddUsersBtn.Size = new System.Drawing.Size(161, 60);
//            this.AddUsersBtn.TabIndex = 12;
//            this.AddUsersBtn.Text = "ADD ADMIN";
//            this.AddUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.AddUsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.AddUsersBtn.UseVisualStyleBackColor = false;
//            this.AddUsersBtn.Click += new System.EventHandler(this.AddUsersBtn_Click);
//            // 
//            // pictureBox7
//            // 
//            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.pictureBox7.Image = global::Inventory_Management_System.Properties.Resources.IMS_LOGOUT;
//            this.pictureBox7.Location = new System.Drawing.Point(3, 439);
//            this.pictureBox7.Name = "pictureBox7";
//            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox7.TabIndex = 11;
//            this.pictureBox7.TabStop = false;
//            // 
//            // pictureBox6
//            // 
//            this.pictureBox6.Image = global::Inventory_Management_System.Properties.Resources.IMS_CATEGORY;
//            this.pictureBox6.Location = new System.Drawing.Point(3, 64);
//            this.pictureBox6.Name = "pictureBox6";
//            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox6.TabIndex = 10;
//            this.pictureBox6.TabStop = false;
//            // 
//            // pictureBox5
//            // 
//            this.pictureBox5.Image = global::Inventory_Management_System.Properties.Resources.IMS_PRODUCT;
//            this.pictureBox5.Location = new System.Drawing.Point(3, 122);
//            this.pictureBox5.Name = "pictureBox5";
//            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox5.TabIndex = 9;
//            this.pictureBox5.TabStop = false;
//            // 
//            // pictureBox4
//            // 
//            this.pictureBox4.Image = global::Inventory_Management_System.Properties.Resources.IMS_SUPPLIER;
//            this.pictureBox4.Location = new System.Drawing.Point(3, 182);
//            this.pictureBox4.Name = "pictureBox4";
//            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox4.TabIndex = 8;
//            this.pictureBox4.TabStop = false;
//            // 
//            // pictureBox3
//            // 
//            this.pictureBox3.Image = global::Inventory_Management_System.Properties.Resources.IMS_STAFF;
//            this.pictureBox3.Location = new System.Drawing.Point(3, 242);
//            this.pictureBox3.Name = "pictureBox3";
//            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox3.TabIndex = 7;
//            this.pictureBox3.TabStop = false;
//            // 
//            // pictureBox2
//            // 
//            this.pictureBox2.Image = global::Inventory_Management_System.Properties.Resources.IMS_DASHBOARD;
//            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
//            this.pictureBox2.Name = "pictureBox2";
//            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
//            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox2.TabIndex = 0;
//            this.pictureBox2.TabStop = false;
//            // 
//            // Suppliersbtn
//            // 
//            this.Suppliersbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.Suppliersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.Suppliersbtn.FlatAppearance.BorderSize = 0;
//            this.Suppliersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.Suppliersbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Suppliersbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.Suppliersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Suppliersbtn.Location = new System.Drawing.Point(59, 178);
//            this.Suppliersbtn.Name = "Suppliersbtn";
//            this.Suppliersbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
//            this.Suppliersbtn.Size = new System.Drawing.Size(161, 60);
//            this.Suppliersbtn.TabIndex = 4;
//            this.Suppliersbtn.Text = "SUPPLIERS";
//            this.Suppliersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Suppliersbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.Suppliersbtn.UseVisualStyleBackColor = false;
//            this.Suppliersbtn.Click += new System.EventHandler(this.Suppliersbtn_Click);
//            // 
//            // ProductButton
//            // 
//            this.ProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.ProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.ProductButton.FlatAppearance.BorderSize = 0;
//            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.ProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.ProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.ProductButton.Location = new System.Drawing.Point(59, 120);
//            this.ProductButton.Name = "ProductButton";
//            this.ProductButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
//            this.ProductButton.Size = new System.Drawing.Size(161, 60);
//            this.ProductButton.TabIndex = 3;
//            this.ProductButton.Text = "PRODUCTS";
//            this.ProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.ProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.ProductButton.UseVisualStyleBackColor = false;
//            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
//            // 
//            // Staffbutton
//            // 
//            this.Staffbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.Staffbutton.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.Staffbutton.FlatAppearance.BorderSize = 0;
//            this.Staffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.Staffbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Staffbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.Staffbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Staffbutton.Location = new System.Drawing.Point(59, 238);
//            this.Staffbutton.Name = "Staffbutton";
//            this.Staffbutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
//            this.Staffbutton.Size = new System.Drawing.Size(161, 60);
//            this.Staffbutton.TabIndex = 5;
//            this.Staffbutton.Text = "STAFF";
//            this.Staffbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Staffbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.Staffbutton.UseVisualStyleBackColor = false;
//            this.Staffbutton.Click += new System.EventHandler(this.Staffbutton_Click);
//            // 
//            // Categorybutton
//            // 
//            this.Categorybutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.Categorybutton.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.Categorybutton.FlatAppearance.BorderSize = 0;
//            this.Categorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.Categorybutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Categorybutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.Categorybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Categorybutton.Location = new System.Drawing.Point(59, 60);
//            this.Categorybutton.Name = "Categorybutton";
//            this.Categorybutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
//            this.Categorybutton.Size = new System.Drawing.Size(161, 60);
//            this.Categorybutton.TabIndex = 2;
//            this.Categorybutton.Text = "CATEGORIES";
//            this.Categorybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Categorybutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.Categorybutton.UseVisualStyleBackColor = false;
//            this.Categorybutton.Click += new System.EventHandler(this.Categorybutton_Click);
//            // 
//            // Dashboardbutton
//            // 
//            this.Dashboardbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.Dashboardbutton.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.Dashboardbutton.FlatAppearance.BorderSize = 0;
//            this.Dashboardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.Dashboardbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Dashboardbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
//            this.Dashboardbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Dashboardbutton.Location = new System.Drawing.Point(59, 0);
//            this.Dashboardbutton.Name = "Dashboardbutton";
//            this.Dashboardbutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
//            this.Dashboardbutton.Size = new System.Drawing.Size(161, 60);
//            this.Dashboardbutton.TabIndex = 1;
//            this.Dashboardbutton.Text = "DASHBOARD";
//            this.Dashboardbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.Dashboardbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.Dashboardbutton.UseVisualStyleBackColor = false;
//            this.Dashboardbutton.Click += new System.EventHandler(this.Dashboardbutton_Click);
//            // 
//            // Mainpanel
//            // 
//            this.Mainpanel.BackColor = System.Drawing.Color.White;
//            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.Mainpanel.Location = new System.Drawing.Point(220, 60);
//            this.Mainpanel.Name = "Mainpanel";
//            this.Mainpanel.Size = new System.Drawing.Size(664, 501);
//            this.Mainpanel.TabIndex = 2;
//            // 
//            // MainForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(884, 561);
//            this.Controls.Add(this.Mainpanel);
//            this.Controls.Add(this.Leftpanel);
//            this.Controls.Add(this.Headerpanel);
//            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
//            this.MinimumSize = new System.Drawing.Size(900, 600);
//            this.Name = "MainForm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "MainForm";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
//            this.Headerpanel.ResumeLayout(false);
//            this.Headerpanel.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
//            this.Leftpanel.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel Headerpanel;
//        private System.Windows.Forms.Panel Leftpanel;
//        private System.Windows.Forms.Panel Mainpanel;
//        private System.Windows.Forms.Label InventoryManagementSystemLabel;
//        private System.Windows.Forms.Label DateLabel;
//        private System.Windows.Forms.Button Dashboardbutton;
//        private System.Windows.Forms.Button ProductButton;
//        private System.Windows.Forms.Button Staffbutton;
//        private System.Windows.Forms.Button Categorybutton;
//        private System.Windows.Forms.Button Logoutbutton;
//        private System.Windows.Forms.Button Suppliersbtn;
//        private System.Windows.Forms.PictureBox pictureBox2;
//        private System.Windows.Forms.PictureBox pictureBox7;
//        private System.Windows.Forms.PictureBox pictureBox6;
//        private System.Windows.Forms.PictureBox pictureBox5;
//        private System.Windows.Forms.PictureBox pictureBox4;
//        private System.Windows.Forms.PictureBox pictureBox3;
//        private System.Windows.Forms.PictureBox pictureBox8;
//        private System.Windows.Forms.PictureBox pictureBox9;
//        private System.Windows.Forms.Button AddUsersBtn;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label userlabel;
//    }
//}
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.userlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.InventoryManagementSystemLabel = new System.Windows.Forms.Label();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.AddUsersBtn = new System.Windows.Forms.Button();
            this.Staffbutton = new System.Windows.Forms.Button();
            this.Suppliersbtn = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.Categorybutton = new System.Windows.Forms.Button();
            this.Dashboardbutton = new System.Windows.Forms.Button();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.Headerpanel.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.White;
            this.Headerpanel.Controls.Add(this.panelUserInfo);
            this.Headerpanel.Controls.Add(this.InventoryManagementSystemLabel);
            this.Headerpanel.Controls.Add(this.logoPictureBox);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(1200, 65);
            this.Headerpanel.TabIndex = 0;
            this.Headerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Headerpanel_MouseDown);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUserInfo.Controls.Add(this.userlabel);
            this.panelUserInfo.Controls.Add(this.label2);
            this.panelUserInfo.Controls.Add(this.DateLabel);
            this.panelUserInfo.Location = new System.Drawing.Point(879, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(321, 65);
            this.panelUserInfo.TabIndex = 17;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.userlabel.Location = new System.Drawing.Point(109, 36);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(35, 17);
            this.userlabel.TabIndex = 15;
            this.userlabel.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current User:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.DateLabel.Location = new System.Drawing.Point(14, 12);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(91, 20);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "12 Aug 2025";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InventoryManagementSystemLabel
            // 
            this.InventoryManagementSystemLabel.AutoSize = true;
            this.InventoryManagementSystemLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryManagementSystemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.InventoryManagementSystemLabel.Location = new System.Drawing.Point(74, 18);
            this.InventoryManagementSystemLabel.Name = "InventoryManagementSystemLabel";
            this.InventoryManagementSystemLabel.Size = new System.Drawing.Size(378, 30);
            this.InventoryManagementSystemLabel.TabIndex = 0;
            this.InventoryManagementSystemLabel.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.InventoryManagementSystemLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Headerpanel_MouseDown);
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Leftpanel.Controls.Add(this.pictureBox7);
            this.Leftpanel.Controls.Add(this.pictureBox6);
            this.Leftpanel.Controls.Add(this.pictureBox5);
            this.Leftpanel.Controls.Add(this.pictureBox4);
            this.Leftpanel.Controls.Add(this.pictureBox3);
            this.Leftpanel.Controls.Add(this.pictureBox2);
            this.Leftpanel.Controls.Add(this.pictureBox1);
            this.Leftpanel.Controls.Add(this.AddUsersBtn);
            this.Leftpanel.Controls.Add(this.Staffbutton);
            this.Leftpanel.Controls.Add(this.Suppliersbtn);
            this.Leftpanel.Controls.Add(this.ProductButton);
            this.Leftpanel.Controls.Add(this.Categorybutton);
            this.Leftpanel.Controls.Add(this.Dashboardbutton);
            this.Leftpanel.Controls.Add(this.Logoutbutton);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 65);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Leftpanel.Size = new System.Drawing.Size(230, 684);
            this.Leftpanel.TabIndex = 1;
            // 
            // AddUsersBtn
            // 
            this.AddUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUsersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddUsersBtn.FlatAppearance.BorderSize = 0;
            this.AddUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUsersBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.AddUsersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.AddUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUsersBtn.Location = new System.Drawing.Point(0, 270);
            this.AddUsersBtn.Name = "AddUsersBtn";
            this.AddUsersBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AddUsersBtn.Size = new System.Drawing.Size(230, 50);
            this.AddUsersBtn.TabIndex = 12;
            this.AddUsersBtn.Text = "          Users";
            this.AddUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddUsersBtn.UseVisualStyleBackColor = true;
            this.AddUsersBtn.Click += new System.EventHandler(this.AddUsersBtn_Click);
            // 
            // Staffbutton
            // 
            this.Staffbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Staffbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Staffbutton.FlatAppearance.BorderSize = 0;
            this.Staffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staffbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Staffbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.Staffbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Staffbutton.Location = new System.Drawing.Point(0, 220);
            this.Staffbutton.Name = "Staffbutton";
            this.Staffbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Staffbutton.Size = new System.Drawing.Size(230, 50);
            this.Staffbutton.TabIndex = 5;
            this.Staffbutton.Text = "          Staff";
            this.Staffbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Staffbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Staffbutton.UseVisualStyleBackColor = true;
            this.Staffbutton.Click += new System.EventHandler(this.Staffbutton_Click);
            // 
            // Suppliersbtn
            // 
            this.Suppliersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suppliersbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Suppliersbtn.FlatAppearance.BorderSize = 0;
            this.Suppliersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suppliersbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Suppliersbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.Suppliersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Suppliersbtn.Location = new System.Drawing.Point(0, 170);
            this.Suppliersbtn.Name = "Suppliersbtn";
            this.Suppliersbtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Suppliersbtn.Size = new System.Drawing.Size(230, 50);
            this.Suppliersbtn.TabIndex = 4;
            this.Suppliersbtn.Text = "          Suppliers";
            this.Suppliersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Suppliersbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suppliersbtn.UseVisualStyleBackColor = true;
            this.Suppliersbtn.Click += new System.EventHandler(this.Suppliersbtn_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.Location = new System.Drawing.Point(0, 120);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ProductButton.Size = new System.Drawing.Size(230, 50);
            this.ProductButton.TabIndex = 3;
            this.ProductButton.Text = "          Products";
            this.ProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // Categorybutton
            // 
            this.Categorybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Categorybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Categorybutton.FlatAppearance.BorderSize = 0;
            this.Categorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categorybutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Categorybutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.Categorybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categorybutton.Location = new System.Drawing.Point(0, 70);
            this.Categorybutton.Name = "Categorybutton";
            this.Categorybutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Categorybutton.Size = new System.Drawing.Size(230, 50);
            this.Categorybutton.TabIndex = 2;
            this.Categorybutton.Text = "          Categories";
            this.Categorybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categorybutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Categorybutton.UseVisualStyleBackColor = true;
            this.Categorybutton.Click += new System.EventHandler(this.Categorybutton_Click);
            // 
            // Dashboardbutton
            // 
            this.Dashboardbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboardbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboardbutton.FlatAppearance.BorderSize = 0;
            this.Dashboardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboardbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.Dashboardbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbutton.Location = new System.Drawing.Point(0, 20);
            this.Dashboardbutton.Name = "Dashboardbutton";
            this.Dashboardbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Dashboardbutton.Size = new System.Drawing.Size(230, 50);
            this.Dashboardbutton.TabIndex = 1;
            this.Dashboardbutton.Text = "          Dashboard";
            this.Dashboardbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboardbutton.UseVisualStyleBackColor = true;
            this.Dashboardbutton.Click += new System.EventHandler(this.Dashboardbutton_Click);
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoutbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logoutbutton.FlatAppearance.BorderSize = 0;
            this.Logoutbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Logoutbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Logoutbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.Logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbutton.Location = new System.Drawing.Point(0, 634);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Logoutbutton.Size = new System.Drawing.Size(230, 50);
            this.Logoutbutton.TabIndex = 6;
            this.Logoutbutton.Text = "          Logout";
            this.Logoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logoutbutton.UseVisualStyleBackColor = true;
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(230, 65);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(970, 684);
            this.Mainpanel.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox7.Image = global::Inventory_Management_System.Properties.Resources.IMS_LOGOUT;
            this.pictureBox7.Location = new System.Drawing.Point(32, 644);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Inventory_Management_System.Properties.Resources.IMS_DASHBOARD;
            this.pictureBox6.Location = new System.Drawing.Point(32, 281);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Inventory_Management_System.Properties.Resources.IMS_STAFF;
            this.pictureBox5.Location = new System.Drawing.Point(32, 230);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Inventory_Management_System.Properties.Resources.IMS_SUPPLIER;
            this.pictureBox4.Location = new System.Drawing.Point(32, 181);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Inventory_Management_System.Properties.Resources.IMS_PRODUCT;
            this.pictureBox3.Location = new System.Drawing.Point(32, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventory_Management_System.Properties.Resources.IMS_CATEGORY;
            this.pictureBox2.Location = new System.Drawing.Point(32, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.IMS_DASHBOARD;
            this.pictureBox1.Location = new System.Drawing.Point(32, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Inventory_Management_System.Properties.Resources.ChatGPT_Image_Aug_11__2025__02_21_24_PM;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 8);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Headerpanel_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.Leftpanel);
            this.Controls.Add(this.Headerpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 718);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.Leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Label InventoryManagementSystemLabel;
        private System.Windows.Forms.Button Dashboardbutton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button Staffbutton;
        private System.Windows.Forms.Button Categorybutton;
        private System.Windows.Forms.Button Logoutbutton;
        private System.Windows.Forms.Button Suppliersbtn;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button AddUsersBtn;
        private Panel panelUserInfo;
        private Label userlabel;
        private Label label2;
        private Label DateLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}