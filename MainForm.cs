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
    public partial class MainForm : Form
    {

        ManageDatabase db = new ManageDatabase();
        string Query = null;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            Query = $"SELECT * FROM Users";
            ds = db.GetData(Query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtPassword.Text == "root" && txtUsername.Text == "root")
                {
                    Admin admin = new Admin(txtUsername.Text);
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                Query = $"SELECT * FROM Users WHERE Username = '{txtUsername.Text}' AND Pass = '{txtPassword.Text}' ";
                ds= db.GetData(Query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    string Role = ds.Tables[0].Rows[0][1].ToString();
                    if(Role == "Admin")
                    {
                        Admin admin = new Admin(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (Role == "Pharmacist")
                    {
                        Pharmacist pharmacist = new Pharmacist();
                        pharmacist.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Credentials", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }




        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
