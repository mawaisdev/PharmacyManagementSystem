using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Admin : Form
    {
        string User = "";
        public Admin()
        {
            InitializeComponent();
        }
        public string Id
        {
            get { return User.ToString(); }
        }
        public Admin(string Username)
        {
            InitializeComponent();
            UsernameLabel.Text = Username;
            User = Username;
            uC_ViewUser1.Id = Id;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Dashboard1.BringToFront();
            uC_Dashboard1.RefreshData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
            uC_ViewUser1.RefershData();
        }
    }
}
