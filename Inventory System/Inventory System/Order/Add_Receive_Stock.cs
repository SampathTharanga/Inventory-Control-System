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
    public partial class Add_Receive_Strock : Form
    {
        public Add_Receive_Strock()
        {
            InitializeComponent();
        }

     //  SqlDataAdapter da;
      // DataSet ds = new DataSet();

        

        Order_DB_Operetion odr = new Order_DB_Operetion();
        Item_DB_Operation itemdb = new Item_DB_Operation();
        public static bool cbx_selet_request;

        public static TextBox tx_descri,tx_nme = new TextBox();
        public static ComboBox cb_supplier,cb_cty,cb_subcty,cb_brnd,cb_typ = new ComboBox();
        public static DateTimePicker drp_odr = new DateTimePicker();
        public static Label lb_roNo = new Label();
        public static NumericUpDown nmb_qt = new NumericUpDown();
        string stktyp;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            errorProvider1.SetError(cbx_supp, "");
            errorProvider2.SetError(txtDiscription, "");
            errorProvider3.SetError(txt_paid, "");
            errorProvider4.SetError(txtPurchasePrice, "");
            errorProvider5.SetError(cbx_pymetd, "");
            errorProvider5.SetError(cbx_pymetd, ""); 
            errorProvider6.SetError(cbx_qty_ctgy, ""); 
            errorProvider7.SetError(cbx_qty_S_ctgy, ""); 
            errorProvider8.SetError(cbx_qty_Brand, ""); 
            errorProvider9.SetError(txt_inme, ""); 
            errorProvider10.SetError(txt_u_p_priz, ""); 
            errorProvider11.SetError(txt_u_s_priz, ""); 
            errorProvider12.SetError(numericUpDown1, "");
            errorProvider13.SetError(cbx_itmtype, ""); 

            if(radioButton_nmal.Checked){stktyp="Normal";} 
            if(radioButton_qty.Checked){stktyp="Quantity";}

            try
            {
                if (cbx_reqst.Text != "")
                {

                    if (dtp_sDate.Text != "" && txt_paid.Text != "" && txtPurchasePrice.Text != "" && cbx_pymetd.Text != "" && cbx_supp.Text != "" &&cbx_qty_Brand.Text!=""&&cbx_qty_S_ctgy.Text!=""&&cbx_qty_Brand.Text!=""&&cbx_itmtype.Text!=""&&txt_inme.Text!=""&&numericUpDown1.Value!=0)
                    {
                        if (lbl_blnc.Text != "Invalid payment")
                        {


                            odr.insert_stock(lbl_s_no.Text, Convert.ToDateTime(dtp_sDate.Value), cbx_supp.Text, txtDiscription.Text, cbx_pymetd.Text, Convert.ToDecimal(txtPurchasePrice.Text), Convert.ToDecimal(txt_paid.Text),cbx_qty_ctgy.Text,cbx_qty_S_ctgy.Text,cbx_qty_Brand.Text,Convert.ToInt32(numericUpDown1.Value),(dtp_sDate.Text+"-"+cbx_qty_Brand.Text+" "+cbx_qty_S_ctgy.Text+" "+cbx_qty_ctgy.Text+"- "+numericUpDown1.Value.ToString()),Convert.ToDecimal(txt_u_p_priz.Text),Convert.ToDecimal(txt_u_s_priz.Text),cbx_itmtype.Text,txt_inme.Text,"0",stktyp);
                            if (cbx_selet_request == true)
                            {

                                odr.Update_rqst_odr2(Lbl_rqstNo.Text, "Oder Received");
                            }

                            //____________________________________________________________________________________________________
                            SqlDataReader dr = itemdb.select_to_Qntity(cbx_qty_ctgy.SelectedItem.ToString(), cbx_qty_S_ctgy.SelectedItem.ToString(), cbx_qty_Brand.SelectedItem.ToString());
                            if (dr.Read())
                            {
                                string qt = dr["Quntity"].ToString();
                                int q1 = int.Parse(qt);
                                int q2 = q1 + Convert.ToInt32(numericUpDown1.Value);
                                string qty = q2.ToString();
                                itemdb.update_Quntity_add(txt_inme.Text,qty, cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text,txt_u_p_priz.Text,txt_u_s_priz.Text);
                                // MessageBox.Show("Quntity Updated");

                            }
                            else
                            {
                                itemdb.Quntity( txt_inme.Text,cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text,numericUpDown1.Value.ToString(), txt_u_p_priz.Text, txt_u_s_priz.Text);
                                // MessageBox.Show("quntity Added");
                            }





                            //___________________________________________________________________________________________________________




                            if (MessageBox.Show("New Stock added", "Sharp Cration", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            //==================================================================================================================================================//     
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

                                cbx_pymetd.Text = "";
                                cbx_reqst.SelectedItem = null;
                                cbx_supp.Text = "";
                                cbx_itmtype.Text = "";
                                cbx_qty_ctgy.Text = "";
                                cbx_qty_S_ctgy.Text = "";
                                cbx_qty_Brand.Text = "";



                                //------------set maxNo+1 to lblOrderNo----------------//
                                string rNo = odr.stockno();
                                if (rNo.Equals("") || rNo == null)
                                {
                                    cNo = 001000;
                                }
                                else
                                {
                                    cNo = Convert.ToInt32(rNo);
                                    cNo = cNo + 1;

                                }
                                lbl_s_no.Text = Convert.ToString(cNo);
                                //---------------------------------------------------------------//



                                numericUpDown1.Value = 0;



                            }
                        }
                        else { toolTip_p.Show("Invalid Payment ", txt_paid, 1000); errorProvider3.SetError(txt_paid, "Enter Valid Paid Price"); }
                   //=====================================================================================================================================================//
                    }
                    else
                    {
                        if (cbx_supp.Text == "") { errorProvider1.SetError(cbx_supp, "Chosse Supplier Name"); }
                        if (txt_paid.Text == "") { errorProvider3.SetError(txt_paid, "Enter Paid Price"); }
                        if (txtPurchasePrice.Text == "") { errorProvider4.SetError(txtPurchasePrice, "Enter Purchase Price"); }
                        if (cbx_pymetd.Text == "") { errorProvider5.SetError(cbx_pymetd, "Chosse Item Catagary"); }
                        if (cbx_qty_ctgy.Text == "") { errorProvider6.SetError(cbx_qty_ctgy, "Chosse pay Method"); }
                        if (cbx_qty_S_ctgy.Text == "") { errorProvider7.SetError(cbx_qty_S_ctgy, "Chosse Item Sub Catagory"); }
                        if (cbx_qty_Brand.Text == "") { errorProvider8.SetError(cbx_qty_Brand, "Chosse Item Brand"); }
                        if (txt_inme.Text == "") { errorProvider9.SetError(txt_inme, "DateTime Invalid"); }
                        if (txt_u_p_priz.Text == "") { errorProvider10.SetError(txt_u_p_priz, "Enter Unit Purchas Price"); }
                        if (txt_u_s_priz.Text == "") { errorProvider11.SetError(txt_u_s_priz, "Enter Unit sale Price"); }
                        if (numericUpDown1.Value == 0) { errorProvider12.SetError(numericUpDown1, "Enter Quantity"); }
                        if (cbx_itmtype.Text == "") { errorProvider13.SetError(cbx_itmtype, "Chosse stock type"); }
                        
                    }
                }
                else { toolTip1.Show("Select this Order is Request order Or Received Order ", cbx_reqst, 1000); }

                
            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if (cbx_selet_request == true)
            //{

            //    odr.Update_rqst_odr2(Lbl_rqstNo.Text, "Oder Received");
            //    //this.Close();
            //}



        }

        int cNo;
        private void Add_Receive_Strock_Load(object sender, EventArgs e)
        {
            //------------set maxNo+1 to lblOrderNo----------------//
            string rNo = odr.stockno();
            if (rNo.Equals("") || rNo == null)
            {
                cNo = 001000;
            }
            else
            {
                cNo = Convert.ToInt32(rNo);
                cNo = cNo + 1;

            }
            lbl_s_no.Text = Convert.ToString(cNo);
            //---------------------------------------------------------------//


            tx_descri = txtDiscription;
            cb_supplier = cbx_supp;
            drp_odr = dtp_sDate;
            lb_roNo = Lbl_rqstNo;
            cb_brnd = cbx_qty_Brand;
            cb_cty = cbx_qty_ctgy;
            cb_subcty = cbx_qty_S_ctgy;
            cb_typ = cbx_itmtype;
            nmb_qt = numericUpDown1;
            tx_nme = txt_inme;


            DataSet log = new System.Data.DataSet();
            String sql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter get = new SqlDataAdapter(sql,ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_supp.Items.Add(ns.Rows[i]["Business_Name"]);
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
             
                         
        }

        private void cbx_reqst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_reqst.Text == "Yes")
            {
                cbx_selet_request = true;
                View_Requst_Order rstO = new View_Requst_Order();
                rstO.ShowDialog();
            }
        }

        private void Add_Receive_Strock_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbx_selet_request = false;
        }

        private void cbx_supp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip1.Show("Invalid Price", txtPurchasePrice, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {

                    e.Handled = true;
                }

            }
        }

        private void txt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip1.Show("Invalid Payment", txt_paid, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {

                    e.Handled = true;
                }

            }
        }

        private void cbx_pymetd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbx_supp, "");
            errorProvider2.SetError(txtDiscription, "");
            errorProvider3.SetError(txt_paid, "");
            errorProvider4.SetError(txtPurchasePrice, "");
            errorProvider5.SetError(cbx_pymetd, "");



            //-----------------clear all textbox.text-----------------------
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

            cb_supplier.Text = "";
            cbx_pymetd.Text = "";
            cbx_reqst.SelectedItem=null;
        }

        private void txtDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 46)
            {
                toolTip1.Show("Plase enter Number and Caractor!", txtDiscription, 0, -50, 700);
                e.Handled = true;
            } 

        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.SetError(txt_paid,"");

            decimal dOutput;
            if (txtPurchasePrice.Text != "" && decimal.TryParse(txtPurchasePrice.Text, out dOutput) && txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                lbl_blnc.Text = (Convert.ToDecimal(txtPurchasePrice.Text) - Convert.ToDecimal(txt_paid.Text)).ToString();
                lbl_blnc.ForeColor = Color.Blue;
                if (Convert.ToDecimal(txt_paid.Text) > Convert.ToDecimal(txtPurchasePrice.Text))
                {
                    lbl_blnc.Text = "Invalid payment";
                    lbl_blnc.ForeColor = Color.Red;

                }
            }
            else { lbl_blnc.Text = txtPurchasePrice.Text; }
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.SetError(txt_paid, "");

            decimal dOutput;
            if (txtPurchasePrice.Text != "" && decimal.TryParse(txtPurchasePrice.Text, out dOutput) && txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                lbl_blnc.Text = (Convert.ToDecimal(txtPurchasePrice.Text) - Convert.ToDecimal(txt_paid.Text)).ToString();
                lbl_blnc.ForeColor = Color.Blue;
                if (Convert.ToDecimal(txt_paid.Text) > Convert.ToDecimal(txtPurchasePrice.Text))
                {
                    lbl_blnc.Text = "Invalid payment";
                    lbl_blnc.ForeColor = Color.Red;

                }
            }
            else { lbl_blnc.Text = txtPurchasePrice.Text; }
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

        private void txt_u_p_priz_TextChanged(object sender, EventArgs e)
        {
            decimal dOutput;
            if (txt_u_p_priz.Text != "" && decimal.TryParse(txt_u_p_priz.Text, out dOutput))
            {
                txtPurchasePrice.Text = (Convert.ToDecimal(txt_u_p_priz.Text) * numericUpDown1.Value).ToString();
            }
            else { txtPurchasePrice.Text = "0"; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal dOutput;
            if (txt_u_p_priz.Text != "" && decimal.TryParse(txt_u_p_priz.Text, out dOutput))
            {
                txtPurchasePrice.Text = (Convert.ToDecimal(txt_u_p_priz.Text) * numericUpDown1.Value).ToString();
            }
            else { txtPurchasePrice.Text = "0"; }

        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            decimal dOutput;
            if (txt_u_p_priz.Text != "" && decimal.TryParse(txt_u_p_priz.Text, out dOutput))
            {
                txtPurchasePrice.Text = (Convert.ToDecimal(txt_u_p_priz.Text) * numericUpDown1.Value).ToString();
            }
            else { txtPurchasePrice.Text = "0"; }

        }

        private void txt_inme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 46)
            {
                toolTip1.Show("Plase enter Number and Caractor!", txtDiscription, 0, -50, 700);
                e.Handled = true;
            } 

        }

        private void txt_u_p_priz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip1.Show("Invalid Price", txt_u_p_priz, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {

                    e.Handled = true;
                }

            }
        }

        private void txt_u_s_priz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip1.Show("Invalid Price", txt_u_s_priz, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {

                    e.Handled = true;
                }

            }
        }

        
    }
}
