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
    public partial class Add_Items : Form
    {
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);


        public Add_Items()
        {
            InitializeComponent();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Add_Items_KeyPress);
        }

        Item_DB_Operation itemdb = new Item_DB_Operation();
        Order_DB_Operetion odr = new Order_DB_Operetion();
        int iNo,cNo;
        DateTime ddtt1, ddtt2; TimeSpan elap;
       // DataTable dtbl;
        public static TextBox tx_brcde=new TextBox();
        string qqty,q_count;

        private void Add_Items_Load(object sender, EventArgs e)
        {
           
            tx_brcde = txtAddItemBarcode;
         
            
//==================================================From Item Table==========================================================//
            string rNo = itemdb.Itemno();
            if (rNo.Equals("") || rNo == null)
            {
                iNo = 001000;
            }
            else
            {
                iNo = Convert.ToInt32(rNo);
                iNo = iNo + 1;
                //MessageBox.Show(iNo.ToString());

            }

//==============================================================================================================================//

            string rcNo = itemdb.getCusno();
            if (rcNo.Equals("") || rcNo == null)
            {
                cNo = 001000;
            }
            else
            {
                cNo = Convert.ToInt32(rcNo);
                cNo = cNo + 1;
                //MessageBox.Show(cNo.ToString());

            }

            



            int[] numbers = new[] { iNo, cNo };

            int max = numbers.Max();

            lbl_itemNo.Text = Convert.ToString(max);
           


           
            String sql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxAddItemSupplier.Items.Add(ns.Rows[i]["Business_Name"]);
            }


            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbxAddItemCatogory.Items.Add(cdt.Rows[i]["catogory"]);
            }


            //String scsql = "SELECT*FROM tbl_sub_catogory";
            //SqlDataAdapter scget = new SqlDataAdapter(scsql, ConnectionDB.Connection());
            //DataTable scdt = new DataTable();
            //scget.Fill(scdt);
            //for (int i = 0; i < scdt.Rows.Count; i++)
            //{
            //    cbxAddItemSubCatogory.Items.Add(scdt.Rows[i]["sub_catogory"]);
            //}


            String bsql = "SELECT*FROM tbl_brande";
            SqlDataAdapter bget = new SqlDataAdapter(bsql, ConnectionDB.Connection());
            DataTable bdt = new DataTable();
            bget.Fill(bdt);
            for (int i = 0; i < bdt.Rows.Count; i++)
            {
                cbxAddItemBrande.Items.Add(bdt.Rows[i]["Brande"]);
            }



            String tsql = "SELECT*FROM tbl_itype";
            SqlDataAdapter tget = new SqlDataAdapter(tsql, ConnectionDB.Connection());
            DataTable tdt = new DataTable();
            tget.Fill(tdt);
            for (int i = 0; i < tdt.Rows.Count; i++)
            {
                cbxAddItemItemType.Items.Add(tdt.Rows[i]["Item_type"]);
            }


            tp_ad_details.Show("Add Catogaty, Subcatogary, Brande, Type", btn_add_details, 5000);



            cbxAddItemCatogory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxAddItemCatogory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAddItemCatogory.AutoCompleteSource = AutoCompleteSource.ListItems;
           
           

            cbxAddItemBrande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxAddItemBrande.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAddItemBrande.AutoCompleteSource = AutoCompleteSource.ListItems;


            
            

        }

       
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddItemAddItem_Click(object sender, EventArgs e)
        {
            //____________________________________________________________________________________________________________
            
            //____________________________________________________________________________________________________________


            ep_iname.SetError(txtAddItemItemName, "");
            ep_isalePrz.SetError(txtAddItemSalesPrice, "");
            ep_ipuchsPriz.SetError(lbl_p_piz, "");
            ep_isupp.SetError(cbxAddItemSupplier, "");
            ep_ictogry.SetError(cbxAddItemCatogory, "");
            ep_isubCotory.SetError(cbxAddItemSubCatogory, "");
            ep_ibrnd.SetError(cbxAddItemBrande, "");

            

            string warrty;

            if (cb_warnty.Checked == true)
            {
                string wtyNo = cbx_wrty_number.Text;
                string wtydu = cbx_wrty_duretion.Text;
                warrty = wtyNo + " " + wtydu;
            }
            else
            {
                warrty = "No Warranty";

            }



            try
            {
                if (txtAddItemBarcode.Text != "" || txtAddItemSerial.Text != "")
                {
                    if (txtAddItemItemName.Text != "" && txtAddItemSalesPrice.Text != "" && lbl_p_piz.Text != "" && cbxAddItemCatogory.Text != "" && cbxAddItemSubCatogory.Text != "" && cbxAddItemBrande.Text != "" && cbxAddItemSupplier.Text != "")
                    {
                        if (txtAddItemTaxRate.Text == "") { txtAddItemTaxRate.Text = "0.00"; }
                        if (txtAddItemSerial.Text == "") { txtAddItemSerial.Text = txtAddItemBarcode.Text; }
                        //___________________________________________________________________________________________________
                        SqlDataReader srldr = itemdb.select_seril_alrdy(txtAddItemSerial.Text);
                        if (!srldr.Read())
                        {
                            //___________________________________________________________________________________________________
                            if (cb_warnty.Checked == true)
                            {
                                if (cbx_wrty_number.Text != "" && cbx_wrty_duretion.Text != "")
                                {


                                    itemdb.insert(lbl_itemNo.Text, txtAddItemSerial.Text, txtAddItemItemName.Text, Convert.ToDecimal(txtAddItemSalesPrice.Text), Convert.ToDecimal(lbl_p_piz.Text), Convert.ToDecimal(txtAddItemTaxRate.Text), txtAddItemBarcode.Text, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, cbxAddItemItemType.Text, cbxAddItemSupplier.Text, warrty, txtAddItemDiscription.Text);
                                    // MessageBox.Show("Item Added");

                                    if (cbx_stok.Text == "")
                                    {
                                        SqlDataReader dr = itemdb.select_to_Qntity(cbxAddItemCatogory.SelectedItem.ToString(), cbxAddItemSubCatogory.SelectedItem.ToString(), cbxAddItemBrande.SelectedItem.ToString());
                                        if (dr.Read())
                                        {
                                            string qt = dr["Quntity"].ToString();
                                            int q1 = int.Parse(qt);
                                            int q2 = q1 + 1;
                                            string qty = q2.ToString();
                                            itemdb.update_Quntity(qty, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text);
                                            // MessageBox.Show("Quntity Updated");

                                        }
                                        else
                                        {
                                            itemdb.Quntity(txtAddItemItemName.Text, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, "1", lbl_p_piz.Text, txtAddItemSalesPrice.Text);
                                            // MessageBox.Show("quntity Added");
                                        }
                                    }


                                    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                    SqlDataReader stcdr = odr.R_stock_selec(cbx_stok.Text, cbxAddItemSupplier.Text);
                                    if (stcdr.Read())
                                    {
                                        qqty = ""; q_count = "";
                                        qqty = stcdr["Quntity"].ToString();
                                        q_count = stcdr["Add_Count"].ToString();

                                        if (q_count != "")
                                        {
                                            if (Convert.ToDouble(qqty) > Convert.ToDouble(q_count))
                                            { q_count = (Convert.ToDouble(q_count) + 1).ToString(); }



                                        }
                                        else { q_count = "1"; }

                                        odr.Update_R_stok_qty(cbx_stok.Text, cbxAddItemSupplier.Text, q_count);
                                        //MessageBox.Show("addddddd");



                                    }



                                    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



                                    if (MessageBox.Show("New Ttem Added Successfuly.", "New Item", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                    {

                                        SqlDataReader stcdr1 = odr.R_stock_selec(cbx_stok.Text, cbxAddItemSupplier.Text);
                                        if (stcdr1.Read())
                                        {

                                            lbl_a_qty.Text = stcdr1["Quntity"].ToString();
                                            lbl_add_qty.Text = stcdr1["Add_Count"].ToString();
                                        }
                            //____________________________________________________________________________________
                                        if (lbl_a_qty.Text == lbl_add_qty.Text)
                                        {

                                            Main.p1.Controls.Clear();
                                            Add_Items d1 = new Add_Items();
                                            d1.TopLevel = false;
                                            d1.Visible = true;
                                            Main.p1.Controls.Add(d1);

                                        }
                                        else
                                        {

                                            //==================================================From Item Table==========================================================//
                                            string rNo = itemdb.Itemno();
                                            if (rNo.Equals("") || rNo == null)
                                            {
                                                iNo = 001000;
                                            }
                                            else
                                            {
                                                iNo = Convert.ToInt32(rNo);
                                                iNo = iNo + 1;
                                                //MessageBox.Show(iNo.ToString());

                                            }

                                            //==============================================================================================================================//

                                            string rcNo = itemdb.getCusno();
                                            if (rcNo.Equals("") || rcNo == null)
                                            {
                                                cNo = 001000;
                                            }
                                            else
                                            {
                                                cNo = Convert.ToInt32(rcNo);
                                                cNo = cNo + 1;
                                                //MessageBox.Show(cNo.ToString());

                                            }





                                            int[] numbers = new[] { iNo, cNo };

                                            int max = numbers.Max();

                                            lbl_itemNo.Text = Convert.ToString(max);


                                            txtAddItemBarcode.Clear();
                                            txtAddItemSerial.Clear();
                                            txtAddItemBarcode.Focus();

                                        }
                            //_____________________________________________________________________________________



                                    }
                                }

                                else
                                {
                                    ep_wanty.SetError(cbx_wrty_duretion, "Complete warranty");
                                }

                            }

                            else
                            {

                                if (txtAddItemTaxRate.Text == "") { txtAddItemTaxRate.Text = "0.00"; }
                                if (txtAddItemSerial.Text == "") { txtAddItemSerial.Text = txtAddItemBarcode.Text; }

                                itemdb.insert(lbl_itemNo.Text, txtAddItemSerial.Text, txtAddItemItemName.Text, Convert.ToDecimal(txtAddItemSalesPrice.Text), Convert.ToDecimal(lbl_p_piz.Text), Convert.ToDecimal(txtAddItemTaxRate.Text), txtAddItemBarcode.Text, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, cbxAddItemItemType.Text, cbxAddItemSupplier.Text, warrty, txtAddItemDiscription.Text);
                                // MessageBox.Show("Item Added");

                                if (cbx_stok.Text == "")
                                {
                                    SqlDataReader dr = itemdb.select_to_Qntity(cbxAddItemCatogory.SelectedItem.ToString(), cbxAddItemSubCatogory.SelectedItem.ToString(), cbxAddItemBrande.SelectedItem.ToString());
                                    if (dr.Read())
                                    {
                                        string qt = dr["Quntity"].ToString();
                                        int q1 = int.Parse(qt);
                                        int q2 = q1 + 1;
                                        string qty = q2.ToString();
                                        itemdb.update_Quntity(qty, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text);
                                        // MessageBox.Show("Quntity Updated");

                                    }
                                    else
                                    {
                                        itemdb.Quntity(txtAddItemItemName.Text, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, "1", lbl_p_piz.Text, txtAddItemSalesPrice.Text);
                                        // MessageBox.Show("quntity Added");
                                    }
                                }


                                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                SqlDataReader stcdr = odr.R_stock_selec(cbx_stok.Text, cbxAddItemSupplier.Text);
                                if (stcdr.Read())
                                {
                                    qqty = ""; q_count = "";
                                    qqty = stcdr["Quntity"].ToString();
                                    q_count = stcdr["Add_Count"].ToString();

                                    if (q_count != "") 
                                    {
                                        if (Convert.ToDouble(qqty) > Convert.ToDouble(q_count))
                                        { q_count = (Convert.ToDouble(q_count) + 1).ToString(); }
                                    
                                   
                                    
                                    }
                                    else  {q_count = "1";}

                                    odr.Update_R_stok_qty(cbx_stok.Text, cbxAddItemSupplier.Text, q_count);
                                    //MessageBox.Show("addddddd");
                                        
                                    
                                    
                                }



                                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



                                if (MessageBox.Show("New Ttem Added Successfuly.", "New Item", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {

                                    SqlDataReader stcdr1 = odr.R_stock_selec(cbx_stok.Text, cbxAddItemSupplier.Text);
                                    if (stcdr1.Read())
                                    {
                                        
                                        lbl_a_qty.Text = stcdr1["Quntity"].ToString();
                                        lbl_add_qty.Text = stcdr1["Add_Count"].ToString();
                                    }

                                    //____________________________________________________________________________________
                                    if (lbl_a_qty.Text == lbl_add_qty.Text)
                                    {

                                        Main.p1.Controls.Clear();
                                        Add_Items d1 = new Add_Items();
                                        d1.TopLevel = false;
                                        d1.Visible = true;
                                        Main.p1.Controls.Add(d1);

                                    }
                                    else
                                    {

                                        //==================================================From Item Table==========================================================//
                                        string rNo = itemdb.Itemno();
                                        if (rNo.Equals("") || rNo == null)
                                        {
                                            iNo = 001000;
                                        }
                                        else
                                        {
                                            iNo = Convert.ToInt32(rNo);
                                            iNo = iNo + 1;
                                            //MessageBox.Show(iNo.ToString());

                                        }

                                        //==============================================================================================================================//

                                        string rcNo = itemdb.getCusno();
                                        if (rcNo.Equals("") || rcNo == null)
                                        {
                                            cNo = 001000;
                                        }
                                        else
                                        {
                                            cNo = Convert.ToInt32(rcNo);
                                            cNo = cNo + 1;
                                            //MessageBox.Show(cNo.ToString());

                                        }





                                        int[] numbers = new[] { iNo, cNo };

                                        int max = numbers.Max();

                                        lbl_itemNo.Text = Convert.ToString(max);


                                        txtAddItemBarcode.Clear();
                                        txtAddItemSerial.Clear();
                                        txtAddItemBarcode.Focus();

                                    }
                                    //_____________________________________________________________________________________





                                    ////-----------------clear all textbox.text-----------------------
                                    //Action<Control.ControlCollection> func = null;

                                    //func = (controls) =>
                                    //{
                                    //    foreach (Control control in controls)
                                    //        if (control is TextBox)
                                    //            (control as TextBox).Clear();
                                    //        else
                                    //            func(control.Controls);
                                    //};
                                    //func(Controls);



                                    //Main.p1.Controls.Clear();
                                    //Add_Items d1 = new Add_Items();
                                    //d1.TopLevel = false;
                                    //d1.Visible = true;
                                    //Main.p1.Controls.Add(d1);

                                }

                            }
                        }
                        else { toolTip_check.Show("Serial number alrady in Stok", lbl_tp,1500); }


                  

                    }
                    else
                    {
                        if (txtAddItemItemName.Text == "")
                        { ep_iname.SetError(txtAddItemItemName, "Enter Item name"); }

                        if (txtAddItemSalesPrice.Text == "")
                        { ep_isalePrz.SetError(txtAddItemSalesPrice, "Enter Item Sales Price"); }

                        if (lbl_p_piz.Text == "")
                        { ep_ipuchsPriz.SetError(lbl_p_piz, "Enter Item Purchas Price"); }

                        if (cbxAddItemSupplier.Text == "")
                        { ep_isupp.SetError(cbxAddItemSupplier, "Choose Supplier name"); }

                        if (cbxAddItemCatogory.Text == "")
                        { ep_ictogry.SetError(cbxAddItemCatogory, "Choose Item Catogary"); }

                        if (cbxAddItemSubCatogory.Text == "")
                        { ep_isubCotory.SetError(cbxAddItemSubCatogory, "Choose Item sub Catogary"); }

                        if (cbxAddItemBrande.Text == "")
                        { ep_ibrnd.SetError(cbxAddItemBrande, "Choose Item Brande"); }


                        tp_required.Show("Fill Require fileds", btnAddItemAddItem, 5000); 

                    }



                }
                else
                {
                    tp_seril_barcobe.Show("Must Enter Serial or Barcode For Iditify Items",lbl_tp,4000);
                
                }

 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void cbxAddItemSubCatogory_TextChanged(object sender, EventArgs e)
        {
            /*int itemsIndex = 0;
            foreach (string item in cbxAddItemSubCatogory.Items)
            {
                if (item.IndexOf(cbxAddItemSubCatogory.Text) == 0)
                {
                    cbxAddItemSubCatogory.SelectedIndex = itemsIndex;
                    cbxAddItemSubCatogory.Select(cbxAddItemSubCatogory.Text.Length - 1, 0);
                    break;
                }
                itemsIndex++;
            }

            cbxAddItemSubCatogory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxAddItemSubCatogory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAddItemSubCatogory.AutoCompleteSource = AutoCompleteSource.ListItems;*/
            
        }

        private void cbxAddItemCatogory_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void cbxAddItemCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String scsql = "SELECT*FROM tbl_sub_catogory";
            SqlDataAdapter scget = new SqlDataAdapter(scsql, ConnectionDB.Connection());
            DataTable scdt = new DataTable();
            scget.Fill(scdt);
            for (int i = 0; i < scdt.Rows.Count; i++)
            {
                cbxAddItemSubCatogory.Items.Add(scdt.Rows[i]["sub_catogory"]);
            }

            cbxAddItemSubCatogory.Items.Clear();
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='"+cbxAddItemCatogory.Text+"'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxAddItemSubCatogory.Items.Add(ns.Rows[i]["sub_catogory"]);
            }
        }

        private void btnAddItemReset_Click(object sender, EventArgs e)
        {

            ep_iname.SetError(txtAddItemItemName, "");
            ep_isalePrz.SetError(txtAddItemSalesPrice, "");
            ep_ipuchsPriz.SetError(lbl_p_piz, "");
            ep_isupp.SetError(cbxAddItemSupplier, "");
            ep_ictogry.SetError(cbxAddItemCatogory, "");
            ep_isubCotory.SetError(cbxAddItemSubCatogory, "");
            ep_ibrnd.SetError(cbxAddItemBrande, "");
            tp_required.Show("", btnAddItemAddItem, 5000);
            
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

            cbxAddItemBrande.Text = "";
            cbxAddItemCatogory.Text = "";
            cbxAddItemSubCatogory.Text = "";
            cbxAddItemSupplier.Text = "";
            cbxAddItemItemType.Text = "";
            cbx_stok.Text = "";

            cb_warnty.Checked = false;
            cbx_wrty_number.SelectedItem = false; ;
            cbx_wrty_duretion.SelectedItem =false;
        }

        private void btn_add_details_Click(object sender, EventArgs e)
        {
            Item_Details itdil = new Item_Details();
            itdil.ShowDialog();

        }

        private void btn_add_details_MouseEnter(object sender, EventArgs e)
        {
            tp_ad_details.Show("Catogaty,Subcatogary,Brande,Type", btn_add_details, 4000);
        }

        private void btn_add_details_MouseLeave(object sender, EventArgs e)
        {
            tp_ad_details.Show("", btn_add_details, 4000);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ep_iname.SetError(txtAddItemItemName, "");
            ep_isalePrz.SetError(txtAddItemSalesPrice, "");
            ep_ipuchsPriz.SetError(lbl_p_piz, "");
            ep_isupp.SetError(cbxAddItemSupplier, "");
            ep_ictogry.SetError(cbxAddItemCatogory, "");
            ep_isubCotory.SetError(cbxAddItemSubCatogory, "");
            ep_ibrnd.SetError(cbxAddItemBrande, "");
            tp_required.Show("", btnAddItemAddItem, 5000);

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

            cbxAddItemBrande.Text = "";
            cbxAddItemCatogory.Text = "";
            cbxAddItemSubCatogory.Text = "";
            cbxAddItemSupplier.Text = "";
            cbxAddItemItemType.Text = "";





            string rNo = itemdb.Itemno();

            string sql = "SELECT * FROM tbl_Add_Items WHERE Item_No='" + rNo + "'";
            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {

                string itName = dr["Item_Name"].ToString();
                string itSelspriz = dr["Sales_Price"].ToString();
                string itPurpriz = dr["Purchase_Price"].ToString();
                string itSupp = dr["Supplier"].ToString();
                string itTax = dr["Tax_Rate"].ToString();
                string itCtgry = dr["Catogory"].ToString();
                string itSubctgry = dr["Sub_Catogory"].ToString();
                string itBrnd = dr["Brande"].ToString();
                string itType = dr["Item_Type"].ToString();
                string itDiscp = dr["Discription"].ToString();

                if (dr["Warranty"].ToString() != "No Warranty")
                {
                    string wrny = dr["Warranty"].ToString();
                    string[] warray = wrny.Split(' ');
                    string wtyNo = warray[0].ToString();
                    string wtyDu = warray[1].ToString();


                    cbx_wrty_number.Text = "";
                    cbx_wrty_duretion.Text = "";
                    cb_warnty.Checked = true;
                    cbx_wrty_number.Text = wtyNo;
                    cbx_wrty_duretion.Text = wtyDu;
                }
                else
                {
                    cbx_wrty_number.Enabled = false;
                    cbx_wrty_duretion.Enabled = false;
                    cb_warnty.Checked = false;


                }





                txtAddItemItemName.Text = itName;
                txtAddItemSalesPrice.Text = itSelspriz;
                lbl_p_piz.Text = itPurpriz;
                txtAddItemTaxRate.Text = itTax;
                txtAddItemDiscription.Text = itDiscp;
                cbxAddItemBrande.Text = itBrnd;
                cbxAddItemCatogory.Text = itCtgry;
                cbxAddItemSubCatogory.Text = itSubctgry;
                cbxAddItemSupplier.Text = itSupp;
                cbxAddItemItemType.Text=itType;
            }

            txtAddItemBarcode.Focus();


        }

        private void tp_seril_barcobe_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cb_warnty_CheckedChanged(object sender, EventArgs e)
        {
            ep_wanty.SetError(cbx_wrty_duretion, "");

            if (cb_warnty.Checked == true)
            {
                if (cbx_wrty_number.Text != "")
                {
                    cbx_wrty_number.Enabled = true;
                    cbx_wrty_duretion.Enabled = true;
                }
                else
                {
                    cbx_wrty_number.Enabled = true;
                }
            }
            else
            {
                cbx_wrty_number.Enabled = false;
                cbx_wrty_duretion.Enabled = false;
                cbx_wrty_duretion.Text = "";
                cbx_wrty_number.Text = "";
                cbx_wrty_duretion.SelectedItem =null;
                cbx_wrty_number.SelectedItem = null;
            }
        }

        private void cbx_wrty_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_wrty_number.Text != "")
            {
                cbx_wrty_duretion.Enabled = true;
            }
            else
            {
                cbx_wrty_duretion.Enabled = false;
            }
        }

        private void cbx_wrty_duretion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ep_wanty.SetError(cbx_wrty_duretion, "");
        }

        private void txtAddItemSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddItemSerial.Text.Count() == 1 && e.KeyChar == 13) { txtAddItemSerial.Clear(); }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddItemSerial, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddItemItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddItemItemName.Text.Count() == 1 && e.KeyChar == 13) { txtAddItemItemName.Clear(); }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddItemItemName, 0, -50, 700);
                e.Handled = true;
            } 

        }

        private void txtAddItemSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddItemSalesPrice.Text.Count() == 1 && e.KeyChar == 13) { txtAddItemSalesPrice.Clear(); }
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Sales Price", txtAddItemSalesPrice, 0, -50, 2000);
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

        

        private void txtAddItemTaxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddItemTaxRate.Text.Count() == 1 && e.KeyChar == 13) { txtAddItemTaxRate.Clear(); }
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Tax-Rate", txtAddItemTaxRate, 0, -50, 2000);
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

        

        private void txtAddItemDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddItemDiscription.Text.Count() == 1 && e.KeyChar == 13) { txtAddItemDiscription.Clear(); }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddItemItemName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        

        private void cbxAddItemSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       

        private void cbxAddItemItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Add_Items_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
           
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();

            // record keystroke & timestamp
             _barcode.Add(e.KeyChar);
             _lastKeystroke = DateTime.Now;
            

            // process barcode
            if (e.KeyChar == 13 && _barcode.Count > 0)
            {
              
                txtAddItemBarcode.Text = _barcode.ToString();
                _barcode.Clear();
            }
        }

        private void txtAddItemSerial_TextChanged(object sender, EventArgs e)
        {
            if (txtAddItemSerial.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtAddItemSerial.Clear(); }
        }

        private void txtAddItemItemName_TextChanged(object sender, EventArgs e)
        {
            if (txtAddItemItemName.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtAddItemItemName.Clear(); }
        }

        private void txtAddItemSalesPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtAddItemSalesPrice.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtAddItemSalesPrice.Clear(); }
        }

        private void txtAddItemTaxRate_TextChanged(object sender, EventArgs e)
        {
            if (txtAddItemTaxRate.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtAddItemTaxRate.Clear(); }
        }

        private void txtAddItemDiscription_TextChanged(object sender, EventArgs e)
        {
            if (txtAddItemDiscription.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtAddItemDiscription.Clear(); }
        }

        private void cbxAddItemSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            double S_QTY, S_CUNT; string typ;

            cbx_stok.Items.Clear();
            String sql = "SELECT*FROM tbl_Recive_Stock WHERE Supplier='"+cbxAddItemSupplier.Text+"' ";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                S_QTY = Convert.ToDouble(ns.Rows[i]["Quntity"]);
                S_CUNT = Convert.ToDouble(ns.Rows[i]["Add_Count"]);
                typ = ns.Rows[i]["Stock_type"].ToString();
                if (S_CUNT < S_QTY && typ=="Normal") { cbx_stok.Items.Add(ns.Rows[i]["Stock"]); }

                
            }


        }

        private void cbx_stok_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            SqlDataReader stcdr = odr.R_stock_selec(cbx_stok.Text, cbxAddItemSupplier.Text);
            if (stcdr.Read())
            {
                
                lbl_a_qty.Text = stcdr["Quntity"].ToString();
                lbl_add_qty.Text = stcdr["Add_Count"].ToString();

                cbxAddItemCatogory.Text = stcdr["Catogory"].ToString();
                cbxAddItemSubCatogory.Text = stcdr["Sub_Catogory"].ToString();
                cbxAddItemBrande.Text = stcdr["Brande"].ToString();
                lbl_p_piz.Text = stcdr["Unit_purchas_price"].ToString();
                txtAddItemSalesPrice.Text = stcdr["Unit_sale_price"].ToString();
                txtAddItemItemName.Text = stcdr["Item_Name"].ToString();
                cbxAddItemItemType.Text = stcdr["Item_Type"].ToString();
            }

            txtAddItemBarcode.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Item_details mitdl = new Manage_Item_details();
            mitdl.ShowDialog();
        }

        private void lbl_p_piz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddItemSalesPrice.Text.Count() == 1 && e.KeyChar == 13) { txtAddItemSalesPrice.Clear(); }
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Purchase Price", txtAddItemSalesPrice, 0, -50, 2000);
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

        private void lbl_p_piz_TextChanged(object sender, EventArgs e)
        {
            if (lbl_p_piz.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { lbl_p_piz.Clear(); }
        }

        

        

       
       

        

        
        

       
    }
}
