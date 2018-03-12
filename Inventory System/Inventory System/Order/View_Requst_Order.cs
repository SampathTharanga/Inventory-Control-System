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
    public partial class View_Requst_Order : Form
    {
        public View_Requst_Order()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        Order_DB_Operetion odr = new Order_DB_Operetion();
        public static DataGridView dgv_rqet = new DataGridView();
        

        private void View_Requst_Order_Load(object sender, EventArgs e)
        {
            dgv_rqet = dgv_reqst_odr;

            if (Add_Receive_Strock.cbx_selet_request == true)
            {
                btn_select.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                cbx_view.Visible = false;

                DataSet ds = odr.only_Not_Receiv_request_oder("Request");
                dgv_reqst_odr.DataSource = ds.Tables["tbl_Request_Order"];
                //dgv_reqst_odr.Columns["Discription"].Width = 250;




            }
            else
            {

                
                DataSet ds = odr.all_request_oder();
                dgv_reqst_odr.DataSource = ds.Tables["tbl_Request_Order"];
                //dgv_reqst_odr.Columns["Discription"].Width = 250;

            }



            String sql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxSupplier.Items.Add(ns.Rows[i]["Business_Name"]);
            }

           

           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_reqst_odr.CurrentRow != null)
                {
                    

                    Edit_reqst_odr edirst = new Edit_reqst_odr();
                    edirst.ShowDialog();
                }
                else
                {
                    toolTip1.Show("Select Request Order", txtOrdorNo, 1, 100, 2500);
                }

            }
            catch (Exception) { }
            
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {

                Add_Receive_Strock.cb_supplier.Text = dgv_reqst_odr.CurrentRow.Cells["Supplier"].Value.ToString();
                Add_Receive_Strock.cb_cty.Text = dgv_reqst_odr.CurrentRow.Cells["Catogory"].Value.ToString();
                Add_Receive_Strock.cb_subcty.Text = dgv_reqst_odr.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                Add_Receive_Strock.cb_brnd.Text = dgv_reqst_odr.CurrentRow.Cells["Brande"].Value.ToString();
                Add_Receive_Strock.cb_typ.Text = dgv_reqst_odr.CurrentRow.Cells["Item_Type"].Value.ToString();
                Add_Receive_Strock.tx_nme.Text = dgv_reqst_odr.CurrentRow.Cells["Name"].Value.ToString();
                Add_Receive_Strock.nmb_qt.Text = dgv_reqst_odr.CurrentRow.Cells["Quntity"].Value.ToString();
                Add_Receive_Strock.tx_descri.Text = dgv_reqst_odr.CurrentRow.Cells["Discription"].Value.ToString();
                Add_Receive_Strock.drp_odr.Text = dgv_reqst_odr.CurrentRow.Cells["Order_Date"].Value.ToString();
                Add_Receive_Strock.lb_roNo.Text = dgv_reqst_odr.CurrentRow.Cells["Order_No"].Value.ToString();

                this.Close();
            }
            catch(Exception)

            
            { toolTip1.Show("Select Request Order", txtOrdorNo, 1, 100, 2500); }
        }

        private void dgv_reqst_odr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_oNot.Visible = false;
            lbl_oYes.Visible = false;
            if (dgv_reqst_odr.CurrentRow.Cells["Oder"].Value.ToString() == "Oder Received")
            {
                lbl_oYes.Visible = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                lbl_oNot.Visible = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtOrdorNo_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Request_Order";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_reqst_odr.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Order_No like '%" + txtOrdorNo.Text + "%' ";
            dgv_reqst_odr.DataSource = dv;

            
        }

        private void txt_descrip_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Request_Order";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_reqst_odr.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Discription like '%" + txt_descrip.Text + "%' ";
            dgv_reqst_odr.DataSource = dv;
        }

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Request_Order";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_reqst_odr.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Supplier like '%" + cbxSupplier.Text + "%' ";
            dgv_reqst_odr.DataSource = dv;
        }

        private void cbx_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_oNot.Visible = false;
            lbl_oYes.Visible = false;

            if (cbx_view.SelectedItem.ToString() == "Received")
            {
                string sql = "SELECT * FROM tbl_Request_Order";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgv_reqst_odr.DataSource = bnsue;
                da.Update(dtbl);

                DataView dv = new DataView(dtbl);
                dv.RowFilter = "Oder like '%" + "Oder Received" + "%' ";
                dgv_reqst_odr.DataSource = dv;
            }

            else if (cbx_view.SelectedItem.ToString() == "Not Received")
            {
                string sql = "SELECT * FROM tbl_Request_Order";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgv_reqst_odr.DataSource = bnsue;
                da.Update(dtbl);

                DataView dv = new DataView(dtbl);
                dv.RowFilter = "Oder like '%" + "Request" + "%' ";
                dgv_reqst_odr.DataSource = dv;
            }

            else 
            {
                DataSet ds = odr.all_request_oder();
                dgv_reqst_odr.DataSource = ds.Tables["tbl_Request_Order"];
                dgv_reqst_odr.Columns["Discription"].Width = 250;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgv_reqst_odr.CurrentRow != null)
                {
                    if (MessageBox.Show("Do you Want to Delete " + dgv_reqst_odr.CurrentRow.Cells["Order_No"].Value.ToString() + " Order", "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        odr.delete_rqst_odr(dgv_reqst_odr.CurrentRow.Cells["Order_No"].Value.ToString());
                        MessageBox.Show("Order Removed Successful", "Shap Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataSet ds = odr.only_Not_Receiv_request_oder("Request");
                        dgv_reqst_odr.DataSource = ds.Tables["tbl_Request_Order"];
                    }
                }
                else
                { toolTip1.Show("Select Order to Delete", txtOrdorNo, 1, 100, 2500); }
            }
            catch (Exception)
            { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbx_view_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtOrdorNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
               e.Handled = true;
            } 
        }

        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            } 
        }
    }
}
