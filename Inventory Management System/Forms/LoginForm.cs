using Microsoft.Identity.Client;
using School_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_Management_System
{
    public partial class LoginForm : Form
    {
        private string _clientId = "51f299cd-8c76-4ffa-beb8-a22013aab2ed"; // Replace with Azure App Client ID
        private string _tenantId = "229d8030-8280-40bf-95ba-793bdec12b3e"; // or your tenant ID
        private string[] _scopes = new[] { "User.Read" }; // Microsoft Graph scope

        private IPublicClientApplication _pca;
        public LoginForm()
        {
            InitializeComponent();
            // Initialize MSAL client
            _pca = PublicClientApplicationBuilder.Create(_clientId)
                .WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient")
                .Build();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ErrorLabel.Text = "Please enter username and password.";
                return;
            }
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?""{}|<>]).{8,}$";
            if (!Regex.IsMatch(txtPassword.Text, passwordPattern))
            {
                MessageBox.Show("Password must be at least 8 characters long and include 1 uppercase, 1 lowercase, 1 number, and 1 special character.",
                                "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            //string hashedPassword = PasswordHelper.HashPassword(PasswordTextBox.Text);
            string username = "";

            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                string query = "SELECT Username,Password,Role FROM IMS_Users WHERE Username=@user AND Password=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                conn.Open();
                Program.CurrentUserName = txtUsername.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    username = txtUsername.Text;
                    MessageBox.Show("Login Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    ErrorLabel.Text = "Invalid username or password.";
                }
            }

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == txtUsername)
            {
                panelUsername.BackColor = Color.FromArgb(0, 122, 204);
            }
            else if (textBox == txtPassword)
            {
                panelPassword.BackColor = Color.FromArgb(0, 122, 204);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == txtUsername)
            {
                panelUsername.BackColor = Color.FromArgb(224, 224, 224);
            }
            else if (textBox == txtPassword)
            {
                panelPassword.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        // Add this to enable form dragging
        private void LoginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }

        internal static class NativeMethods
        {
            public const int WM_NCLBUTTONDOWN = 0xA1;
            public const int HT_CAPTION = 0x2;

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool ReleaseCapture();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void SaveMicrosoftUserToDB(AuthenticationResult result)
        {
            try
            {
                using (SqlConnection con = DatabaseService.GetConnection())
                {
                    con.Open(); // Open connection first

                    // 1️⃣ Check if user already exists
                    string checkQuery = "SELECT COUNT(*) FROM MicrosoftUsers WHERE MicrosoftId = @MicrosoftId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@MicrosoftId", result.Account.HomeAccountId.Identifier);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists == 0)
                        {
                            // 2️⃣ Insert new user if not exists
                            string insertQuery = @"
                        INSERT INTO MicrosoftUsers (MicrosoftId, DisplayName, Email)
                        VALUES (@MicrosoftId, @DisplayName, @Email)";

                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@MicrosoftId", result.Account.HomeAccountId.Identifier);
                                insertCmd.Parameters.AddWithValue("@DisplayName", result.Account.Username);
                                insertCmd.Parameters.AddWithValue("@Email", result.Account.Username);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 3️⃣ Set current user and open main form
                    Program.CurrentUserName = result.Account.Username;
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save user data: " + ex.Message);
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            btnLoginMicrosoft.Enabled = false; // Prevent multiple clicks

            try
            {
                var accounts = await _pca.GetAccountsAsync();
                AuthenticationResult result = null;

                try
                {
                    result = await _pca.AcquireTokenSilent(_scopes, accounts.FirstOrDefault())
                        .ExecuteAsync();
                }
                catch (MsalUiRequiredException)
                {
                    result = await _pca.AcquireTokenInteractive(_scopes)
                        .WithPrompt(Prompt.SelectAccount)
                        .ExecuteAsync();
                }

                // Login successful
                MessageBox.Show($"Hello {result.Account.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Store user in DB
                SaveMicrosoftUserToDB(result);

                // TODO: Navigate to Admin Panel
            }
            catch (MsalClientException ex) when (ex.Message.Contains("429"))
            {
                MessageBox.Show("Too many login attempts. Please wait a moment.", "Login Throttled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLoginMicrosoft.Enabled = true;
            }
        }
    }
}
