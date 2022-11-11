using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdminUC
{
    public partial class UC_AddUser : UserControl
    {
        ManageDatabase db = new ManageDatabase();
        string Query = null;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string UserRole = txtUserRole.Text;
            string Name = txtName.Text;
            string Email = txtUserMail.Text;
            string Password = txtPassword.Text;
            Int64 MobileNo = Int64.Parse(txtMobileNo.Text);
            string Username = txtUsername.Text;
            string DOB = txtDateOfBirth.Text;

            try
            {
                Query = $"insert into Users(UserRole, Name, DOB,Mobile,Email,Username,Pass) values ('{UserRole}', '{Name}', '{DOB}','{MobileNo}', '{Email}', '{Username}', '{Password}')";

                db.SetData(Query, "Signup Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
