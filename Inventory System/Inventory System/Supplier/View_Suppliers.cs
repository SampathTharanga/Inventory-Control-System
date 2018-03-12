using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_System
{
    public partial class View_Suppliers : Form
    {
        public View_Suppliers()
        {
            InitializeComponent();
        }

        public static DataGridView dgv = new DataGridView();
        
        Supplier_DB_Operetion supOp = new Supplier_DB_Operetion();
        DataTable dtbl;

        private void View_Suppliers_Load(object sender, EventArgs e)
        {
            dgv = dgvViewSupp;
            DataSet ds = supOp.all();
            dgvViewSupp.DataSource = ds.Tables["tbl_AddS_Supplier"];



            string sql = "SELECT * FROM tbl_AddS_Supplier";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvViewSupp.DataSource = bnsue;
            da.Update(dtbl);


            if (Main.UT1 == "Standard User")
            {
                btnViewSuppViewAcc.Enabled = false;

            }

        }

        public void btnViewSuppViewAcc_Click(object sender, EventArgs e)
        {
            try
            {


                Sup_account_get getacDetails = new Sup_account_get();
                getacDetails.sp_acNo = dgvViewSupp.CurrentRow.Cells["Supplier_No"].Value.ToString();
                getacDetails.sp_acFnme = dgvViewSupp.CurrentRow.Cells["First_Name"].Value.ToString();
                getacDetails.sp_acLnme = dgvViewSupp.CurrentRow.Cells["Last_Name"].Value.ToString();
                getacDetails.sp_acBisnme = dgvViewSupp.CurrentRow.Cells["Business_Name"].Value.ToString();
                getacDetails.sp_acMob = dgvViewSupp.CurrentRow.Cells["Mobile"].Value.ToString();
                getacDetails.sp_acemail = dgvViewSupp.CurrentRow.Cells["Email"].Value.ToString();



                Supplier_Account SupACC = new Supplier_Account(getacDetails);
                SupACC.ShowDialog(this);
            }
            catch (Exception) { }


        }

        private void btnViewSuppEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                SupDUpdate UpDsup = new SupDUpdate();
                UpDsup.no = dgvViewSupp.CurrentRow.Cells["Supplier_No"].Value.ToString();
                UpDsup.Fname = dgvViewSupp.CurrentRow.Cells["First_Name"].Value.ToString();
                UpDsup.lname = dgvViewSupp.CurrentRow.Cells["Last_Name"].Value.ToString();
                UpDsup.bisname = dgvViewSupp.CurrentRow.Cells["Business_Name"].Value.ToString();
                UpDsup.add1 = dgvViewSupp.CurrentRow.Cells["Address_Line1"].Value.ToString();
                UpDsup.add2 = dgvViewSupp.CurrentRow.Cells["Address_Line2"].Value.ToString();
                UpDsup.city = dgvViewSupp.CurrentRow.Cells["City"].Value.ToString();
                UpDsup.phone = dgvViewSupp.CurrentRow.Cells["Phone"].Value.ToString();
                UpDsup.mobil = dgvViewSupp.CurrentRow.Cells["Mobile"].Value.ToString();
                UpDsup.fax = dgvViewSupp.CurrentRow.Cells["Fax"].Value.ToString();
                UpDsup.zip = dgvViewSupp.CurrentRow.Cells["Zip_Postal_Code"].Value.ToString();
                UpDsup.email = dgvViewSupp.CurrentRow.Cells["Email"].Value.ToString();
                UpDsup.notes = dgvViewSupp.CurrentRow.Cells["Notes"].Value.ToString();

                Edit_Supplier css = new Edit_Supplier(UpDsup);
                css.ShowDialog(this);
            }
            catch (Exception) { }
        }

        private void btnViewSuppDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete Supplier " + dgvViewSupp.CurrentRow.Cells[1].Value.ToString() + " " + dgvViewSupp.CurrentRow.Cells[2].Value.ToString(), "Delete Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    supOp.delete_sup(dgvViewSupp.CurrentRow.Cells["Supplier_No"].Value.ToString());
                    MessageBox.Show("Supplier removed successfuly", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Main.p1.Controls.Clear();
                View_Suppliers finsup = new View_Suppliers();
                finsup.TopLevel = false;
                finsup.Visible = true;
                Main.p1.Controls.Add(finsup);
            }
            catch (Exception) { }
        }

        private void txtFindSupNo_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Supplier_No like '%" + txtFindSupNo.Text + "%' ";
            dgvViewSupp.DataSource = dv;
        }

        private void txtFindSupFirstName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "First_Name like '%" + txtFindSupFirstName.Text + "%' ";
            dgvViewSupp.DataSource = dv;
        }

        private void txtFindSupLastName_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Last_Name like '%" + txtFindSupLastName.Text + "%' ";
            dgvViewSupp.DataSource = dv;
        }

        private void txtFindSup4n_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Mobile like '%" + txtFindSup4n.Text + "%' ";
            dgvViewSupp.DataSource = dv;
        }

        private void txtFindSupNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindSupLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindSupFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindSup4n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        

        

        

        
    }
}
