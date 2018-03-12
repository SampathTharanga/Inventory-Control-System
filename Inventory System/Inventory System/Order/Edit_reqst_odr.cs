using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Inventory_System
{
    public partial class Edit_reqst_odr : Form
    {
        public Edit_reqst_odr()
        {
            InitializeComponent();
        }

        Order_DB_Operetion odr = new Order_DB_Operetion();
        Regex reg_email = new Regex(@"^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$");
        Regex reg_mobile = new Regex("^[0-9X]{10}$");

        private void Edit_reqst_odr_Load(object sender, EventArgs e)
        {

            String sql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxSupplier.Items.Add(ns.Rows[i]["Business_Name"]);
            }



            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbx_qty_ctgy.Items.Add(cdt.Rows[i]["catogory"]);
            }





            String bsql = "SELECT*FROM tbl_brande";
            SqlDataAdapter bget = new SqlDataAdapter(bsql, ConnectionDB.Connection());
            DataTable bdt = new DataTable();
            bget.Fill(bdt);
            for (int i = 0; i < bdt.Rows.Count; i++)
            {
                cbx_qty_Brand.Items.Add(bdt.Rows[i]["Brande"]);
            }



            String tsql = "SELECT*FROM tbl_itype";
            SqlDataAdapter tget = new SqlDataAdapter(tsql, ConnectionDB.Connection());
            DataTable tdt = new DataTable();
            tget.Fill(tdt);
            for (int i = 0; i < tdt.Rows.Count; i++)
            {
                cbx_itmtype.Items.Add(tdt.Rows[i]["Item_type"]);
            }


            cbx_qty_ctgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbx_qty_ctgy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_qty_ctgy.AutoCompleteSource = AutoCompleteSource.ListItems;



            cbx_qty_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbx_qty_Brand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_qty_Brand.AutoCompleteSource = AutoCompleteSource.ListItems;


                lblOrderNo.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Order_No"].Value.ToString();
                DateTime Odt = DateTime.Parse(View_Requst_Order.dgv_rqet.CurrentRow.Cells["Order_Date"].Value.ToString());
                dp_rest_odr.Text = Odt.ToShortDateString();

                txtMobile.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Mobile"].Value.ToString();
                txt_email.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Email"].Value.ToString();
                txtDiscription.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Discription"].Value.ToString();
                cbx_qty_ctgy.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Catogory"].Value.ToString();
                cbxSupplier.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Supplier"].Value.ToString();
                cbx_qty_S_ctgy.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                cbx_qty_Brand.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Brande"].Value.ToString();
                cbx_itmtype.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Item_Type"].Value.ToString();
                txt_inme.Text = View_Requst_Order.dgv_rqet.CurrentRow.Cells["Name"].Value.ToString();
                numericUpDown1.Value = Convert.ToDecimal(View_Requst_Order.dgv_rqet.CurrentRow.Cells["Quntity"].Value.ToString());



        }

        private void btnupdte_Click(object sender, EventArgs e)
        {

            ep_sup.SetError(cbxSupplier, "");
            errorProvider1.SetError(cbx_qty_ctgy, "");
            errorProvider2.SetError(cbx_qty_S_ctgy, "");
            errorProvider3.SetError(cbx_qty_Brand, "");
            errorProvider4.SetError(cbx_itmtype, "");
            errorProvider5.SetError(txt_inme, "");
            errorProvider6.SetError(numericUpDown1, "");

            if (cbxSupplier.Text != "" && txt_inme.Text != "" && cbx_itmtype.Text != "" && cbx_qty_Brand.Text != "" && cbx_qty_ctgy.Text != "" && cbx_qty_S_ctgy.Text != "" && numericUpDown1.Value != 0)
            {
                if (reg_mobile.IsMatch(txtMobile.Text) && reg_email.IsMatch(txt_email.Text))
                {

                    try
                    {
                        odr.Update_rqst_odr(lblOrderNo.Text, dp_rest_odr.Text, cbxSupplier.Text, txtMobile.Text, txt_email.Text, txtDiscription.Text,cbx_qty_ctgy.Text,cbx_qty_S_ctgy.Text,cbx_qty_Brand.Text,txt_inme.Text,numericUpDown1.Value,cbx_itmtype.Text);
                        if (MessageBox.Show("Request updated", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Close();
                            DataSet ds = odr.all_request_oder();
                            View_Requst_Order.dgv_rqet.DataSource = ds.Tables["tbl_Request_Order"];
                            //View_Requst_Order.dgv_rqet.Columns["Discription"].Width = 250;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (!reg_mobile.IsMatch(txtMobile.Text))
                    { toolTip_mob.Show("Mobile Number Is Not Correct", txtMobile, 0, -50, 700); }
                    if (!reg_email.IsMatch(txt_email.Text))
                    { toolTip_emal.Show("Invaid Email Address", txt_email, 0, -50, 700); } 

                }
            }
            else
            {



                if (cbxSupplier.Text == "") { ep_sup.SetError(cbxSupplier, "Select Supplier"); }
                if (cbx_qty_ctgy.Text == "") { errorProvider1.SetError(cbx_qty_ctgy, "Select Catagory"); }
                if (cbx_qty_S_ctgy.Text == "") { errorProvider2.SetError(cbx_qty_S_ctgy, "Select sub Catogory"); }
                if (cbx_qty_Brand.Text == "") { errorProvider3.SetError(cbx_qty_Brand, "Select Brand"); }
                if (cbx_itmtype.Text == "") { errorProvider4.SetError(cbx_itmtype, "Select type"); }
                if (txt_inme.Text == "") { errorProvider5.SetError(txt_inme, "Enter Name"); }
                if (numericUpDown1.Text == "" || numericUpDown1.Value <= 0) { errorProvider6.SetError(numericUpDown1, "Invalid Quantity"); }
               
            }


        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip1.Show("Plase enter 10 Number !", txtMobile,0,-50, 1500);
                e.Handled = true;
            }
        }

        private void txtDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip1.Show("Plase enter Number and Catactor!", txtDiscription,0,-50, 1500);
                e.Handled = true;
            } 
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            txtMobile.MaxLength = 10;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //------------clear all textbox.text-----------------
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

            cbxSupplier.Text = "";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader suppdr = odr.select_suppD_to_request(cbxSupplier.SelectedItem.ToString());
            if (suppdr.Read())
            {
                txtMobile.Text = suppdr["Mobile"].ToString();
                txt_email.Text = suppdr["Email"].ToString();
            }
        }

        private void cbx_qty_ctgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_qty_S_ctgy.Items.Clear();
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='" + cbx_qty_ctgy.Text + "'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_qty_S_ctgy.Items.Add(ns.Rows[i]["sub_catogory"]);
            }
        }
    }
}
