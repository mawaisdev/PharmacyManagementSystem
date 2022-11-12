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
    public partial class UC_ViewUser : UserControl
    {
        ManageDatabase db = new ManageDatabase();
        string Query = null;
        DataSet ds= null;
        string CurrentUser = null;

        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public string Id 
        {
            set { CurrentUser = value; }
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            Query = $"SELECT * FROM Users";
            ds = db.GetData(Query);
            UserTable.DataSource = ds.Tables[0];
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length == 0)
                UC_ViewUser_Load(this, null);
            else
            {
                Query = $"SELECT * FROM Users WHERE Username LIKE '{txtUsername.Text}%'";
                ds = db.GetData(Query);
                UserTable.DataSource = ds.Tables[0];
            }
        }
        string Username;
        private void UserTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Username = UserTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CurrentUser != Username)
                {
                    Query = $"DELETE FROM Users WHERE Username = '{Username}'";
                    db.SetData(Query, "User Record Deleted");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to Delete\nYour OWN Profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
        public void RefershData()
        {
            UC_ViewUser_Load(this, null);
        }
    }
}
