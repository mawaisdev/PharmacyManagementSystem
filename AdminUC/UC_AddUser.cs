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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length == 0) 
            {
                PicUserFound.Image = null;
            }
            else
            {
                Query = $"SELECT * FROM Users WHERE Username = '{txtUsername.Text}'";
                var ds = db.GetData(Query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    PicUserFound.ImageLocation = @"C:\Users\Awais\Downloads\C# Pharmacy Management System\Pharmacy Management System in C#\no.png";
                }
                else
                {
                    PicUserFound.ImageLocation = @"C:\Users\Awais\Downloads\C# Pharmacy Management System\Pharmacy Management System in C#\yes.png";
                }
            }
        }

        public void ClearAll()
        {
            txtName.Clear();
            txtDateOfBirth.ResetText();
            txtMobileNo.Clear();
            txtUserRole.SelectedIndex = -1;
            txtPassword.Clear();
            txtUserMail.Clear();
            txtUsername.Clear();
            PicUserFound.Image = null;
        }

        private void PicUserFound_Click(object sender, EventArgs e)
        {

        }
    }
}
