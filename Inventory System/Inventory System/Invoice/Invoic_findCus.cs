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
    public partial class Invoic_findCus : Form
    {
        public Invoic_findCus()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataTable dtbl;
        Customer_DB_Operation cusop = new Customer_DB_Operation();

        private void Invoic_findCus_Load(object sender, EventArgs e)
        {


            ds = cusop.all();
            dgvFindCusto.DataSource = ds.Tables["tbl_Add_Customer"];

            string sql = "SELECT * FROM tbl_Add_Customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindCusto.DataSource = bnsue;
            da.Update(dtbl);
        }

        private void txtFindCustoCustoNo_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Coustomer_No like '%" + txtFindCustoCustoNo.Text + "%' ";
            dgvFindCusto.DataSource = dv;
        }

        private void txtFindCustoFirstName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "First_Name like '%" + txtFindCustoFirstName.Text + "%'";
            dgvFindCusto.DataSource = dv;
        }

        private void txtFindCustoLastName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Last_Name like '%" + txtFindCustoLastName.Text + "%'";
            dgvFindCusto.DataSource = dv;
        }

        private void txtFindCusto4n_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Mobile like '%" + txtFindCusto4n.Text + "%'";
            dgvFindCusto.DataSource = dv;
        }

        private void btn_add_invo_Click(object sender, EventArgs e)
        {
            try
            {
                New_invoice.lb_cusN.Text = dgvFindCusto.CurrentRow.Cells["Coustomer_No"].Value.ToString();
                New_invoice.tx_fn.Text = dgvFindCusto.CurrentRow.Cells["First_Name"].Value.ToString();
                New_invoice.tx_ln.Text = dgvFindCusto.CurrentRow.Cells["Last_Name"].Value.ToString();
                New_invoice.tx_ad1.Text = dgvFindCusto.CurrentRow.Cells["Address_Line1"].Value.ToString();
                New_invoice.tx_ad2.Text = dgvFindCusto.CurrentRow.Cells["Address_Line2"].Value.ToString();
                New_invoice.tx_mob.Text = dgvFindCusto.CurrentRow.Cells["Mobile"].Value.ToString();
                New_invoice.tx_emal.Text = dgvFindCusto.CurrentRow.Cells["Email"].Value.ToString();

                this.Close();
            }
            catch (Exception) { }
        }

        private void txtFindCustoCustoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindCustoFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindCustoLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindCusto4n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void btnFindCustoReset_Click(object sender, EventArgs e)
        {
            ds = cusop.all();
            dgvFindCusto.DataSource = ds.Tables["tbl_Add_Customer"];

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }



    }
}
