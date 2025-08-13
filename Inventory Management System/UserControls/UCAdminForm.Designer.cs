namespace Inventory_Management_System.UserControls
{
    partial class UCAdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelProductList = new System.Windows.Forms.Panel();
            this.UsersdataGridView = new System.Windows.Forms.DataGridView();
            this.panelSearchContainer = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelTitleContainer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBottomControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanelControls = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Duplicatebtn = new System.Windows.Forms.Button();
            this.Exportbtn = new System.Windows.Forms.Button();
            this.ImportdataBtn = new System.Windows.Forms.Button();
            this.panelMainContainer.SuspendLayout();
            this.panelProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView)).BeginInit();
            this.panelSearchContainer.SuspendLayout();
            this.panelTitleContainer.SuspendLayout();
            this.panelBottomControls.SuspendLayout();
            this.tableLayoutPanelControls.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMainContainer.Controls.Add(this.panelProductList);
            this.panelMainContainer.Controls.Add(this.panelBottomControls);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Padding = new System.Windows.Forms.Padding(15);
            this.panelMainContainer.Size = new System.Drawing.Size(1000, 597);
            this.panelMainContainer.TabIndex = 3;
            // 
            // panelProductList
            // 
            this.panelProductList.BackColor = System.Drawing.Color.White;
            this.panelProductList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductList.Controls.Add(this.UsersdataGridView);
            this.panelProductList.Controls.Add(this.panelSearchContainer);
            this.panelProductList.Controls.Add(this.panelTitleContainer);
            this.panelProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductList.Location = new System.Drawing.Point(15, 15);
            this.panelProductList.Name = "panelProductList";
            this.panelProductList.Padding = new System.Windows.Forms.Padding(10);
            this.panelProductList.Size = new System.Drawing.Size(970, 448);
            this.panelProductList.TabIndex = 25;
            // 
            // UsersdataGridView
            // 
            this.UsersdataGridView.AllowUserToAddRows = false;
            this.UsersdataGridView.AllowUserToDeleteRows = false;
            this.UsersdataGridView.AllowUserToResizeRows = false;
            this.UsersdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.UsersdataGridView.ColumnHeadersHeight = 40;
            this.UsersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersdataGridView.DefaultCellStyle = dataGridViewCellStyle29;
            this.UsersdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersdataGridView.EnableHeadersVisualStyles = false;
            this.UsersdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.UsersdataGridView.Location = new System.Drawing.Point(10, 79);
            this.UsersdataGridView.MultiSelect = false;
            this.UsersdataGridView.Name = "UsersdataGridView";
            this.UsersdataGridView.ReadOnly = true;
            this.UsersdataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersdataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.UsersdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.UsersdataGridView.RowTemplate.Height = 35;
            this.UsersdataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersdataGridView.Size = new System.Drawing.Size(948, 357);
            this.UsersdataGridView.TabIndex = 4;
            this.UsersdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersdataGridView_CellContentClick);
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.Controls.Add(this.txtSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(10, 46);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panelSearchContainer.Size = new System.Drawing.Size(948, 33);
            this.panelSearchContainer.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(948, 25);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "Search Users...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelTitleContainer
            // 
            this.panelTitleContainer.Controls.Add(this.panel9);
            this.panelTitleContainer.Controls.Add(this.lblTitle);
            this.panelTitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleContainer.Location = new System.Drawing.Point(10, 10);
            this.panelTitleContainer.Name = "panelTitleContainer";
            this.panelTitleContainer.Size = new System.Drawing.Size(948, 36);
            this.panelTitleContainer.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTitle.Location = new System.Drawing.Point(9, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "User Manager";
            // 
            // panelBottomControls
            // 
            this.panelBottomControls.Controls.Add(this.tableLayoutPanelControls);
            this.panelBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomControls.Location = new System.Drawing.Point(15, 463);
            this.panelBottomControls.Name = "panelBottomControls";
            this.panelBottomControls.Size = new System.Drawing.Size(970, 119);
            this.panelBottomControls.TabIndex = 2;
            // 
            // tableLayoutPanelControls
            // 
            this.tableLayoutPanelControls.ColumnCount = 4;
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelControls.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelControls.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelControls.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanelControls.Controls.Add(this.txtUserName, 1, 0);
            this.tableLayoutPanelControls.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanelControls.Controls.Add(this.txtRole, 1, 2);
            this.tableLayoutPanelControls.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanelControls.Controls.Add(this.btnUpdate, 3, 0);
            this.tableLayoutPanelControls.Controls.Add(this.btnDelete, 2, 1);
            this.tableLayoutPanelControls.Controls.Add(this.btnClear, 3, 1);
            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelControls.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
            this.tableLayoutPanelControls.RowCount = 3;
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelControls.Size = new System.Drawing.Size(970, 119);
            this.tableLayoutPanelControls.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(94, 8);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(606, 25);
            this.txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(94, 47);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(606, 25);
            this.txtPassword.TabIndex = 9;
            // 
            // txtRole
            // 
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(94, 86);
            this.txtRole.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(606, 25);
            this.txtRole.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(715, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(845, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(715, 44);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Remove User";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(845, 44);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.tableLayoutPanel7);
            this.panel9.Location = new System.Drawing.Point(366, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(579, 33);
            this.panel9.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.52632F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.47368F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel7.Controls.Add(this.ImportdataBtn, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.Exportbtn, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.Duplicatebtn, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(579, 33);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // Duplicatebtn
            // 
            this.Duplicatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Duplicatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Duplicatebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Duplicatebtn.FlatAppearance.BorderSize = 0;
            this.Duplicatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Duplicatebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Duplicatebtn.ForeColor = System.Drawing.Color.White;
            this.Duplicatebtn.Location = new System.Drawing.Point(3, 3);
            this.Duplicatebtn.Name = "Duplicatebtn";
            this.Duplicatebtn.Size = new System.Drawing.Size(167, 27);
            this.Duplicatebtn.TabIndex = 7;
            this.Duplicatebtn.Text = "Remove Duplicate Data";
            this.Duplicatebtn.UseVisualStyleBackColor = false;
            this.Duplicatebtn.Click += new System.EventHandler(this.Duplicatebtn_Click);
            // 
            // Exportbtn
            // 
            this.Exportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.Exportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exportbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exportbtn.FlatAppearance.BorderSize = 0;
            this.Exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exportbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Exportbtn.ForeColor = System.Drawing.Color.White;
            this.Exportbtn.Location = new System.Drawing.Point(176, 3);
            this.Exportbtn.Name = "Exportbtn";
            this.Exportbtn.Size = new System.Drawing.Size(201, 27);
            this.Exportbtn.TabIndex = 8;
            this.Exportbtn.Text = "Export Data (Excel Format)";
            this.Exportbtn.UseVisualStyleBackColor = false;
            this.Exportbtn.Click += new System.EventHandler(this.Exportbtn_Click);
            // 
            // ImportdataBtn
            // 
            this.ImportdataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ImportdataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportdataBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportdataBtn.FlatAppearance.BorderSize = 0;
            this.ImportdataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImportdataBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ImportdataBtn.ForeColor = System.Drawing.Color.White;
            this.ImportdataBtn.Location = new System.Drawing.Point(383, 3);
            this.ImportdataBtn.Name = "ImportdataBtn";
            this.ImportdataBtn.Size = new System.Drawing.Size(193, 27);
            this.ImportdataBtn.TabIndex = 9;
            this.ImportdataBtn.Text = "Import Data From Excel File";
            this.ImportdataBtn.UseVisualStyleBackColor = false;
            this.ImportdataBtn.Click += new System.EventHandler(this.ImportdataBtn_Click);
            // 
            // UCAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainContainer);
            this.Name = "UCAdminForm";
            this.Size = new System.Drawing.Size(1000, 597);
            this.panelMainContainer.ResumeLayout(false);
            this.panelProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView)).EndInit();
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelTitleContainer.ResumeLayout(false);
            this.panelTitleContainer.PerformLayout();
            this.panelBottomControls.ResumeLayout(false);
            this.tableLayoutPanelControls.ResumeLayout(false);
            this.tableLayoutPanelControls.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelSearchContainer;
        private System.Windows.Forms.Panel panelTitleContainer;
        private System.Windows.Forms.Panel panelBottomControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panelProductList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel Tablelayoutpaneldatagrid;
        private System.Windows.Forms.DataGridView UsersdataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button Duplicatebtn;
        private System.Windows.Forms.Button Exportbtn;
        private System.Windows.Forms.Button ImportdataBtn;
    }
}


