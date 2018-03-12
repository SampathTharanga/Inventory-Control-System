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
    public partial class Edti_Items : Form
    {
        Item_update itup;
        public Edti_Items(Item_update iut)
        {
            InitializeComponent();
            itup = iut;
        }

        private void Edti_Items_Load(object sender, EventArgs e)
        {
            lbl_itemNo.Text = itup.no;
            txtAddItemBarcode.Text = itup.barcode;
            txtAddItemDiscription.Text = itup.discrip;
            txtAddItemItemName.Text = itup.name;
            txtAddItemPurchasePrice.Text = itup.purchPiz;
            txtAddItemSalesPrice.Text = itup.selsPiz;
            txtAddItemSerial.Text = itup.serial;
            txtAddItemTaxRate.Text = itup.tax;
            cbxAddItemBrande.Text = itup.Brande;
            cbxAddItemCatogory.Text = itup.catogy;
            cbxAddItemItemType.Text = itup.typ;
            cbxAddItemSubCatogory.Text = itup.subCatogy;
            cbxAddItemSupplier.Text = itup.supp;

            if (itup.wranty != "No Warranty")
            {
                string wrny = itup.wranty;
                string[] warray = wrny.Split(' ');
                string wtyNo = warray[0].ToString();
                string wtyDu = warray[1].ToString();

                cb_warnty.Checked = true;
                cbx_wrty_number.Text = wtyNo;
                cbx_wrty_duretion.Text = wtyDu;
            }
            else
            {
                cbx_wrty_number.Enabled = false;
                cbx_wrty_duretion.Enabled = false;


            }


            





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


            cbxAddItemCatogory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxAddItemCatogory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAddItemCatogory.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxAddItemBrande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxAddItemBrande.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxAddItemBrande.AutoCompleteSource = AutoCompleteSource.ListItems;
            

        }
        Item_DB_Operation itemdb = new Item_DB_Operation();
        private void btnAddItemAddItem_Click(object sender, EventArgs e)
        {

            ep_iname.SetError(txtAddItemItemName, "");
            ep_isalePrz.SetError(txtAddItemSalesPrice, "");
            ep_ipuchsPriz.SetError(txtAddItemPurchasePrice, "");
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
                    if (txtAddItemItemName.Text != "" && txtAddItemSalesPrice.Text != "" && txtAddItemPurchasePrice.Text != "" && cbxAddItemCatogory.Text != "" && cbxAddItemSubCatogory.Text != "" && cbxAddItemBrande.Text != "" && cbxAddItemSupplier.Text != "")
                    {
                        if (cb_warnty.Checked == true)
                        {
                            if (cbx_wrty_number.Text != "" && cbx_wrty_duretion.Text != "")
                            {
                                string sql = "UPDATE tbl_Add_Items SET Serial_No='" + txtAddItemSerial.Text + "',Item_Name='" + txtAddItemItemName.Text + "',Sales_Price='" +Convert.ToDecimal( txtAddItemSalesPrice.Text) + "',Purchase_Price='" +Convert.ToDecimal( txtAddItemPurchasePrice.Text )+ "',Tax_Rate='" + Convert.ToDecimal( txtAddItemTaxRate.Text )+ "',Barcode='" + txtAddItemBarcode.Text + "',Catogory='" + cbxAddItemCatogory.Text + "',Sub_Catogory='" + cbxAddItemSubCatogory.Text + "',Brande='" + cbxAddItemBrande.Text + "',Item_Type='" + cbxAddItemItemType.Text + "',Supplier='" + cbxAddItemSupplier.Text + "',Warranty='" + warrty + "',Discription='" + txtAddItemDiscription.Text + "' WHERE Item_No='" + lbl_itemNo.Text + "'";
                                SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
                                com.ExecuteNonQuery();

                                // MessageBox.Show("Item Added");

                                //SqlDataReader dr = itemdb.select_to_Qntity(cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text);
                                //if (dr.Read())
                                //{
                                //    string qt = dr["Quntity"].ToString();
                                //    int q1 = int.Parse(qt);
                                //    int q2 = q1 + 1;
                                //    string qty = q2.ToString();
                                //    itemdb.update_Quntity(qty, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text);
                                //    //  MessageBox.Show("Quntity Updated");

                                //}
                                //else
                                //{
                                //    itemdb.Quntity(txtAddItemItemName.Text,cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, "1",txtAddItemPurchasePrice.Text,txtAddItemSalesPrice.Text);
                                //    // MessageBox.Show("quntity Added");
                                //}


                                //SqlDataReader drm = itemdb.select_to_Qntity(itup.catogy, itup.subCatogy, itup.Brande);
                                //if (drm.Read())
                                //{
                                //    string qqt = drm["Quntity"].ToString();
                                //    int qq1 = int.Parse(qqt);
                                //    int qq2 = qq1 - 1;
                                //    string qty = qq2.ToString();
                                //    itemdb.update_Quntity(qty, itup.catogy, itup.subCatogy, itup.Brande);
                                //    //  MessageBox.Show("Quntity Updated");

                                //}



                                if (MessageBox.Show("Item Updated Successfuly.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {

                                    this.Close();
                                    Main.p1.Controls.Clear();
                                    Find_item d1 = new Find_item();
                                    d1.TopLevel = false;
                                    d1.Visible = true;
                                    Main.p1.Controls.Add(d1);

                                }


                            }

                            else
                            {
                                ep_warrnty.SetError(cbx_wrty_duretion, "Complete warranty");
                            }
                        }


                        else 
                        {
                            string sql = "UPDATE tbl_Add_Items SET Serial_No='" + txtAddItemSerial.Text + "',Item_Name='" + txtAddItemItemName.Text + "',Sales_Price='" + txtAddItemSalesPrice.Text + "',Purchase_Price='" + txtAddItemPurchasePrice.Text + "',Tax_Rate='" + txtAddItemTaxRate.Text + "',Barcode='" + txtAddItemBarcode.Text + "',Catogory='" + cbxAddItemCatogory.Text + "',Sub_Catogory='" + cbxAddItemSubCatogory.Text + "',Brande='" + cbxAddItemBrande.Text + "',Item_Type='" + cbxAddItemItemType.Text + "',Supplier='" + cbxAddItemSupplier.Text + "',Warranty='" + warrty + "',Discription='" + txtAddItemDiscription.Text + "' WHERE Item_No='" + lbl_itemNo.Text + "'";
                            SqlCommand com = new SqlCommand(sql, ConnectionDB.Connection());
                            com.ExecuteNonQuery();

                            // MessageBox.Show("Item Added");

                            SqlDataReader dr = itemdb.select_to_Qntity(cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text);
                            if (dr.Read())
                            {
                                string qt = dr["Quntity"].ToString();
                                int q1 = int.Parse(qt);
                                int q2 = q1 + 1;
                                string qty = q2.ToString();
                                itemdb.update_Quntity(qty, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text);
                                //  MessageBox.Show("Quntity Updated");

                            }
                            else
                            {
                                itemdb.Quntity(txtAddItemItemName.Text, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, "1", txtAddItemPurchasePrice.Text, txtAddItemSalesPrice.Text);
                                // MessageBox.Show("quntity Added");
                            }


                            SqlDataReader drm = itemdb.select_to_Qntity(itup.catogy, itup.subCatogy, itup.Brande);
                            if (drm.Read())
                            {
                                string qqt = drm["Quntity"].ToString();
                                int qq1 = int.Parse(qqt);
                                int qq2 = qq1 - 1;
                                string qty = qq2.ToString();
                                itemdb.update_Quntity(qty, itup.catogy, itup.subCatogy, itup.Brande);
                                //  MessageBox.Show("Quntity Updated");

                            }



                            if (MessageBox.Show("Item Updated Successfuly.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {

                                this.Close();
                                Main.p1.Controls.Clear();
                                Find_item d1 = new Find_item();
                                d1.TopLevel = false;
                                d1.Visible = true;
                                Main.p1.Controls.Add(d1);

                            }
                        
                        }
                    }
                    else
                    {
                        


                        if (txtAddItemItemName.Text == "")
                        { ep_iname.SetError(txtAddItemItemName, "Enter Item name"); }

                        if (txtAddItemSalesPrice.Text == "")
                        { ep_isalePrz.SetError(txtAddItemSalesPrice, "Enter Item Sales Price"); }

                        if (txtAddItemPurchasePrice.Text == "")
                        { ep_ipuchsPriz.SetError(txtAddItemPurchasePrice, "Enter Item Purchas Price"); }

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
                    tp_seril_barcobe.Show("Must Enter Serial or Barcode For Iditify Items", lbl_tp, 4000);

                }



            }


           








            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='" + cbxAddItemCatogory.Text + "'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxAddItemSubCatogory.Items.Add(ns.Rows[i]["sub_catogory"]);
            }
        }

        

        private void tp_seril_barcobe_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tp_ad_details_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cbxAddItemSubCatogory_Click(object sender, EventArgs e)
        {
            cbxAddItemSubCatogory.Items.Clear();
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='" + cbxAddItemCatogory.Text + "'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxAddItemSubCatogory.Items.Add(ns.Rows[i]["sub_catogory"]);
            }
        }

        private void cbxAddItemBrande_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnAddItemReset_Click(object sender, EventArgs e)
        {
            ep_iname.SetError(txtAddItemItemName, "");
            ep_isalePrz.SetError(txtAddItemSalesPrice, "");
            ep_ipuchsPriz.SetError(txtAddItemPurchasePrice, "");
            ep_isupp.SetError(cbxAddItemSupplier, "");
            ep_ictogry.SetError(cbxAddItemCatogory, "");
            ep_isubCotory.SetError(cbxAddItemSubCatogory, "");
            ep_ibrnd.SetError(cbxAddItemBrande, "");
            tp_required.Show("", btnAddItemAddItem, 5000);

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
        }

        private void btnAddItemCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_warnty_CheckedChanged(object sender, EventArgs e)
        {
            ep_warrnty.SetError(cbx_wrty_duretion, "");

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
            ep_warrnty.SetError(cbx_wrty_duretion, "");
        }

        private void cbxAddItemCatogory_SelectedIndexChanged_1(object sender, EventArgs e)
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
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='" + cbxAddItemCatogory.Text + "'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxAddItemSubCatogory.Items.Add(ns.Rows[i]["sub_catogory"]);
            }
        }

        private void txtAddItemSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddItemSerial, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddItemItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddItemItemName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddItemSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtAddItemPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid purchase Price", txtAddItemPurchasePrice, 0, -50, 2000);
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
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddItemDiscription, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void cb_warnty_CheckedChanged_1(object sender, EventArgs e)
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
                cbx_wrty_duretion.SelectedItem = null;
                cbx_wrty_number.SelectedItem = null;
            }
        }

        private void cbx_wrty_number_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cbx_wrty_duretion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ep_wanty.SetError(cbx_wrty_duretion, "");
        }
    }
}
