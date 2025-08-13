using Inventory_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Inventory_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartClock();

            UCDashboard DashboardControl = new UCDashboard();
            DashboardControl.Dock = DockStyle.Fill;

            Mainpanel.Controls.Clear();

            Mainpanel.Controls.Add(DashboardControl);

            userlabel.Text = Program.CurrentUserName;

        }
        private void StartClock()
        {
            DateLabel.Text = DateTime.Now.ToString("MMMM d, yyyy hh:mm:ss tt");

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("MMMM d, yyyy hh:mm:ss tt");
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to LogOut?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        private void LoadFormInPanel(UserControl selectedForm)
        {
            Mainpanel.Controls.Clear();
            selectedForm.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(selectedForm);
            selectedForm.Show();
        }

        private void Dashboardbutton_Click(object sender, EventArgs e)
        {
            UCDashboard DashboardForm = new UCDashboard();
            LoadFormInPanel(DashboardForm);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            UCProductForm ProductsForm = new UCProductForm();
            LoadFormInPanel(ProductsForm);
        }

        private void Categorybutton_Click(object sender, EventArgs e)
        {
            UCCategoryForm CategoryForm = new UCCategoryForm();
            LoadFormInPanel(CategoryForm);
        }

        private void Staffbutton_Click(object sender, EventArgs e)
        {
           UCStaffForm StaffForm = new UCStaffForm();
            LoadFormInPanel(StaffForm);
        }
        private void Headerpanel_MouseDown(object sender, MouseEventArgs e)
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
        private void NavigationButton_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != Dashboardbutton) // Don't change active button
            {
                button.BackColor = Color.FromArgb(70, 70, 90);
            }
        }

        private void NavigationButton_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != Dashboardbutton) // Don't change active button
            {
                button.BackColor = Color.Transparent;
            }
        }

        private void Suppliersbtn_Click(object sender, EventArgs e)
        {
            UCSuppliersForm suppliersForm = new UCSuppliersForm();
            LoadFormInPanel(suppliersForm);
        }

        private void InventoryManagementSystemLabel_Click(object sender, EventArgs e)
        {
            UCDashboard DashboardForm = new UCDashboard();
            LoadFormInPanel(DashboardForm);
        }

        private void AddUsersBtn_Click(object sender, EventArgs e)
        {
            UCAdminForm adminForm = new UCAdminForm();
            LoadFormInPanel(adminForm);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            // Exits the application cleanly.
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, System.EventArgs e)
        {
            // Check if the window is already maximized.
            if (this.WindowState == FormWindowState.Maximized)
            {
                // If it is, restore it to its normal size.
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // If it's not maximized, maximize it.
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            // Minimize the form.
            this.WindowState = FormWindowState.Minimized;
        }


    }
}