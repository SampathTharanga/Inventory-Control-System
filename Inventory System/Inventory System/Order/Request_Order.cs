using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Inventory_System
{
    public partial class Request_Order : Form
    {
        public Request_Order()
        {
            InitializeComponent();
        }

        Order_DB_Operetion odr = new Order_DB_Operetion();
        Regex reg_email = new Regex(@"^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$");
        Regex reg_mobile = new Regex("^[0-9X]{10}$");

        private void Request_Order_Load(object sender, EventArgs e)
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
             
           



            int iNo;
            string rNo = odr.requestOdr_no();
            if (rNo.Equals("") || rNo == null)
            {
                iNo = 001000;
            }
            else
            {
                iNo = Convert.ToInt32(rNo);
                iNo = iNo + 1;

            }
            lblOrderNo.Text = Convert.ToString(iNo);
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
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


                try
                {
                    odr.insert_reqstO(lblOrderNo.Text, dp_rest_odr.Value, cbxSupplier.Text, lbl_mob.Text, lbl_email.Text, txtDiscription.Text, "Request",cbx_qty_ctgy.Text,cbx_qty_S_ctgy.Text,cbx_qty_Brand.Text,txt_inme.Text,numericUpDown1.Value,cbx_itmtype.Text);
                    if (MessageBox.Show("Order Request Completed ", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (checkBox_msg.Checked == true)
                        {
                            Rqst_send e_s = new Rqst_send();
                            e_s.ShowDialog();
                        }
                        this.Close();
                    }

                }
                catch (Exception) { }
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

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            ep_sup.SetError(cbxSupplier, "");
           
            ep_dis.SetError(txtDiscription, "");
            

            SqlDataReader suppdr = odr.select_suppD_to_request(cbxSupplier.SelectedItem.ToString());
            if (suppdr.Read())
            {
                lbl_mob.Text = suppdr["Mobile"].ToString();
                lbl_email.Text = suppdr["Email"].ToString();
            }
        }

        private void cbxSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        private void txtDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip1.Show("Plase enter Number and Catactor!", txtDiscription, 0, -50, 700);
                e.Handled = true;
            } 
        }

       

        private void txtDiscription_TextChanged(object sender, EventArgs e)
        {

            ep_sup.SetError(cbxSupplier, "");
           
            ep_dis.SetError(txtDiscription, "");

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
