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
    public partial class UC_Profile : UserControl
    {
        ManageDatabase db = new ManageDatabase();
        string Query = null;
        DataSet ds = null;

        public string Username { set { lblUsername.Text = value; } }
        public UC_Profile()
        {
            InitializeComponent();
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
        }

        public void FillData()
        {
            if (txtName.Text.Length == 0)
            {
                Query = $"SELECT * FROM Users where Username = '{lblUsername.Text}'";
                ds = db.GetData(Query);
            }
                txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
