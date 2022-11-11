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
    public partial class UC_Dashboard : UserControl
    {
        ManageDatabase db = new ManageDatabase();
        string Query = null;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            Query = $"SELECT COUNT(UserRole) FROM Users where UserRole = 'Admin' ";
            ds = db.GetData(Query);
            SetLabel(ds, AdminLabel);

            Query = $"SELECT COUNT(UserRole) FROM Users where UserRole = 'Pharmacist' ";
            ds = db.GetData(Query);
            SetLabel(ds, PharmacistLabel);
            
            Query = $"SELECT COUNT(UserRole) FROM Users where UserRole = 'Customer' ";
            ds = db.GetData(Query);
            SetLabel(ds, CustomerLabel);


        }
        private void SetLabel(DataSet ds, Label label) 
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                label.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                label.Text = "0";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }
    }
}
