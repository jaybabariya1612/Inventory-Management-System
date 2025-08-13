namespace Inventory_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginMicrosoft = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UsernameIcon = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordIcon = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginMicrosoft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            this.panelLeft.Controls.Add(this.AppNameLabel);
            this.panelLeft.Controls.Add(this.WelcomeLabel);
            this.panelLeft.Controls.Add(this.LogoPictureBox);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(350, 550);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseDown);
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.ForeColor = System.Drawing.Color.White;
            this.AppNameLabel.Location = new System.Drawing.Point(55, 330);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(252, 30);
            this.AppNameLabel.TabIndex = 2;
            this.AppNameLabel.Text = "MANAGEMENT SYSTEM";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(83, 300);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(193, 30);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "WELCOME TO THE";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Inventory_Management_System.Properties.Resources.ChatGPT_Image_Aug_11__2025__02_21_24_PM;
            this.LogoPictureBox.Location = new System.Drawing.Point(90, 125);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(170, 150);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.CloseButton);
            this.panelRight.Controls.Add(this.SignInLabel);
            this.panelRight.Controls.Add(this.UserNameLabel);
            this.panelRight.Controls.Add(this.UsernameIcon);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.panelUsername);
            this.panelRight.Controls.Add(this.PasswordLabel);
            this.panelRight.Controls.Add(this.PasswordIcon);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.panelPassword);
            this.panelRight.Controls.Add(this.ShowPasswordCheckBox);
            this.panelRight.Controls.Add(this.LoginButton);
            this.panelRight.Controls.Add(this.ErrorLabel);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(350, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 550);
            this.panelRight.TabIndex = 1;
            this.panelRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnLoginMicrosoft);
            this.panel1.Location = new System.Drawing.Point(80, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 40);
            this.panel1.TabIndex = 28;
            // 
            // btnLoginMicrosoft
            // 
            this.btnLoginMicrosoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginMicrosoft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoginMicrosoft.Image = global::Inventory_Management_System.Properties.Resources.ms_symbollockup_signin_dark;
            this.btnLoginMicrosoft.Location = new System.Drawing.Point(0, 0);
            this.btnLoginMicrosoft.Name = "btnLoginMicrosoft";
            this.btnLoginMicrosoft.Size = new System.Drawing.Size(215, 40);
            this.btnLoginMicrosoft.TabIndex = 0;
            this.btnLoginMicrosoft.TabStop = false;
            this.btnLoginMicrosoft.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::Inventory_Management_System.Properties.Resources.IMS_CLOSE_ICON;
            this.CloseButton.Location = new System.Drawing.Point(363, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 13;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(98)))));
            this.SignInLabel.Location = new System.Drawing.Point(40, 80);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(320, 40);
            this.SignInLabel.TabIndex = 14;
            this.SignInLabel.Text = "Login to your account";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserNameLabel.Location = new System.Drawing.Point(43, 160);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(83, 21);
            this.UserNameLabel.TabIndex = 16;
            this.UserNameLabel.Text = "Username";
            // 
            // UsernameIcon
            // 
            this.UsernameIcon.Image = global::Inventory_Management_System.Properties.Resources.user;
            this.UsernameIcon.Location = new System.Drawing.Point(47, 195);
            this.UsernameIcon.Name = "UsernameIcon";
            this.UsernameIcon.Size = new System.Drawing.Size(25, 25);
            this.UsernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsernameIcon.TabIndex = 23;
            this.UsernameIcon.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(80, 195);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 22);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Text = "JAYBABARIYA";
            this.txtUsername.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.LightGray;
            this.panelUsername.Location = new System.Drawing.Point(47, 223);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(303, 2);
            this.panelUsername.TabIndex = 25;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordLabel.Location = new System.Drawing.Point(43, 250);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(79, 21);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.Image = global::Inventory_Management_System.Properties.Resources.password;
            this.PasswordIcon.Location = new System.Drawing.Point(47, 285);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(25, 25);
            this.PasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordIcon.TabIndex = 24;
            this.PasswordIcon.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(80, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 22);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "Admin@1234";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.LightGray;
            this.panelPassword.Location = new System.Drawing.Point(47, 313);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(303, 2);
            this.panelPassword.TabIndex = 26;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(47, 335);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(118, 21);
            this.ShowPasswordCheckBox.TabIndex = 15;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(47, 390);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(303, 45);
            this.LoginButton.TabIndex = 17;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(47, 450);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(303, 20);
            this.ErrorLabel.TabIndex = 21;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginMicrosoft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // --- Left Panel for Branding ---
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label AppNameLabel;

        // --- Right Panel for Login Controls ---
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox UsernameIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panelUsername; // Underline for TextBox
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox PasswordIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelPassword; // Underline for TextBox
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnLoginMicrosoft;
    }
}
