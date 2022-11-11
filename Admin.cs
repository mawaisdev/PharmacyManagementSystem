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
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(string Username)
        {
            InitializeComponent();
            UsernameLabel.Text = Username;
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
        }
    }
}
