using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {

        ManageDatabase db = new ManageDatabase();
        string Query = null;
        DataSet ds = null;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            var DataFilled = IsAllFilled();
            if( !DataFilled ) 
            {
                MessageBox.Show("Please Fill All Fields", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else 
            {
                AddToDB();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private bool IsAllFilled()
        {
            if (txtMedicineId.Text == "" || txtMedicineName.Text == "" || txtMedicineNumber.Text == "" || txtPricePerUnit.Text == "" || txtQuantity.Text == "")
                return false;

            return true;
        }
        private void AddToDB()
        {
            string MedicineId = txtMedicineId.Text;
            string MedicineName = txtMedicineName.Text;
            string MedicineNumber = txtMedicineNumber.Text;
            string ManufacturingDate = txtManufacturedDate.Text;
            string ExpireDate = txtExpireDate.Text;
            Int64 Quantity = Int64.Parse(txtQuantity.Text);
            Decimal PricePerUnit = Decimal.Parse(txtPricePerUnit.Text);

            Query = $"INSERT INTO Medicine (MedicineId, MedicineName, MedicineNumber, ManufacturedDate, ExpireDate, Quantity, PricePerUnit) values ('{MedicineId}', '{MedicineName}', '{MedicineNumber}','{ManufacturingDate}', '{ExpireDate}', '{Quantity}', '{PricePerUnit}')";

            db.SetData(Query: Query, Message: "Medicine Added Succfully");
        }
        private void ClearAll()
        {
            txtMedicineId.Text = null;
            txtMedicineName.Text = null;
            txtMedicineNumber.Text = null;
            txtManufacturedDate.Text = null;
            txtExpireDate.Text = null;
            txtQuantity.Text = null;
            txtPricePerUnit.Text = null;
        }
    }
}
