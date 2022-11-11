﻿using System;
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
        public UC_ViewUser()
        {
            InitializeComponent();
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
    }
}
