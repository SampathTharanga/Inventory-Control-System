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
    public partial class warranty_newItem : Form
    {
        public warranty_newItem()
        {
            InitializeComponent();
        }

        DataSet ds;

        Item_DB_Operation itemdb = new Item_DB_Operation();
        Warranty_DB_Operetion wrty = new Warranty_DB_Operetion();
        Invoive_DB_Operetion Invo = new Invoive_DB_Operetion();
        string inmee, ides, ccno, pymnt, ipmthd;
        int iNo, iiNo, cNo;
        DateTime InvDt;
        string inme, iserial, iselpiz, ipurpiz, ictgry, isubctgry, ibrnd, ibcode, iwrrty, isuppl, itpe, idescri, inom, iqty;
        string invoNo, cusnom, fname, lnme, add1, add2, mobl, grantota, disc, tax, total, paid, paymethd, blnc, itmno, itmseril, itmNme, itmctgy, itmsbctgy, itmbrnd, itsalepriz, itmwarrty;
        DateTime invodate;



        private void warranty_newItem_Load(object sender, EventArgs e)
        {



            //-------------------------------------------Auto Invoice Number--------------------------------------------------------//
            string rNo = Invo.InvoiceNo();
            if (rNo.Equals("") || rNo == null)
            {
                iNo = 001000;
            }
            else
            {
                iNo = Convert.ToInt32(rNo);
                iNo = iNo + 1;


            }

            //---------------------------------------------Auto Itm No------------------------------------------------------------------------//

            string riNo = itemdb.Itemno();
            if (riNo.Equals("") || riNo == null)
            {
                iiNo = 001000;
            }
            else
            {
                iiNo = Convert.ToInt32(rNo);
                iiNo = iiNo + 1;
                //MessageBox.Show(iiNo.ToString());

            }




            string rcNo = itemdb.getCusno();
            if (rcNo.Equals("") || rcNo == null)
            {
                cNo = 001000;
            }
            else
            {
                cNo = Convert.ToInt32(rcNo);
                cNo = cNo + 1;
               // MessageBox.Show(cNo.ToString());

            }





            int[] numbers = new[] { iiNo, cNo };

            int max = numbers.Max();
            lbl_itNo.Text = max.ToString();

            

            //---------------------------------------------------------------------------------------------------------------------//

            String sql = "SELECT*FROM tbl_brande";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxAddItemBrande.Items.Add(ns.Rows[i]["Brande"]);
            }


            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbxAddItemCatogory.Items.Add(cdt.Rows[i]["catogory"]);
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



        private void btn_ok_Click(object sender, EventArgs e)
        {
            ep_iname.SetError(txtAddItemItemName, "");
            ep_isupp.SetError(cbxAddItemItemType, "");
            ep_ibrnd.SetError(cbxAddItemBrande, "");
            ep_ictogry.SetError(cbxAddItemCatogory, "");
            ep_isubCotory.SetError(cbxAddItemSubCatogory, "");
           

            SqlDataReader cdr = wrty.select_cusNo(Warranty_Details.dgvw.CurrentRow.Cells["Invoice_No"].Value.ToString());
            if (cdr.Read())
            {
                ccno = cdr["Coustomer_No"].ToString();
                InvDt = Convert.ToDateTime(cdr["Invoice_Date"]);
                ipmthd = cdr["Payment_Method"].ToString();
            }
           

            //try
            //{

                if (txtAddItemBarcode.Text != "" || txtAddItemSerial.Text != "")
                {
                    if (txtAddItemItemName.Text != "" && cbxAddItemCatogory.Text != "" && cbxAddItemSubCatogory.Text != "" && cbxAddItemBrande.Text != "")
                    {
                        if (txtAddItemSerial.Text == "") { txtAddItemSerial.Text = txtAddItemBarcode.Text; }

                        SqlDataReader ddr = wrty.select_invo_backI(Warranty_Details.dgvw.CurrentRow.Cells["Item_No"].Value.ToString(), Warranty_Details.dgvw.CurrentRow.Cells["Invoice_No"].Value.ToString());
                        if (ddr.Read())
                        {


                            inom = ddr["Item_No"].ToString();
                            inme = ddr["Item_Name"].ToString();
                            iserial = ddr["Serial_No"].ToString();
                            iselpiz = ddr["Sales_Price"].ToString();
                            ipurpiz = ddr["Purchase_Price"].ToString();
                            ictgry = ddr["Catogory"].ToString();
                            isubctgry = ddr["Sub_Catogory"].ToString();
                            ibrnd = ddr["Brande"].ToString();
                            ibcode = ddr["Barcode"].ToString();
                            iwrrty = ddr["Warranty"].ToString();
                            isuppl = ddr["Supplier"].ToString();
                            itpe = ddr["Item_Type"].ToString();
                            idescri = ddr["Discription"].ToString();


                            wrty.insert_retn_itm(inom, iserial, inme, Convert.ToDecimal(iselpiz), Convert.ToDecimal(ipurpiz), Convert.ToDecimal("0"), ibcode, ictgry, isubctgry, ibrnd, itpe, isuppl, iwrrty, idescri);
                            //MessageBox.Show("add to return item");

                        }

                        decimal pfit = (Convert.ToDecimal(iselpiz)) - (Convert.ToDecimal(ipurpiz));


                        Invo.insert_Invoice_detalis(iNo.ToString(), InvDt, lbl_itNo.Text, txtAddItemSerial.Text, txtAddItemItemName.Text, Convert.ToDecimal(iselpiz), Convert.ToDecimal(ipurpiz), txtAddItemBarcode.Text, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, iwrrty, isuppl, cbxAddItemItemType.Text, txtAddItemDiscription.Text, pfit, "Ok", "1");
                        // MessageBox.Show("new itttttttttmss changgggg");


                        Invo.insert_Invoice(iNo.ToString(), InvDt, Convert.ToDecimal(iselpiz), (Convert.ToDecimal(iselpiz)), Convert.ToDecimal("0"), ipmthd,"*"+txtAddItemItemName.Text, New_invoice.sref.Text, ccno, Convert.ToDecimal(iselpiz), Convert.ToDecimal("0"), Convert.ToDecimal("0"), "Ok");
                        //MessageBox.Show("ADd new invo");

                        wrty.update_item_status(Warranty_Details.dgvw.CurrentRow.Cells["Invoice_No"].Value.ToString(), Warranty_Details.dgvw.CurrentRow.Cells["Item_No"].Value.ToString(), "Return");
                       //MessageBox.Show("update oled invo");


                        wrty.addWary_foundItm(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString(), Warranty_Details.dgvw.CurrentRow.Cells["Invoice_No"].Value.ToString(), lbl_itNo.Text, txtAddItemItemName.Text, txtAddItemSerial.Text, txtAddItemBarcode.Text, cbxAddItemCatogory.Text, cbxAddItemSubCatogory.Text, cbxAddItemBrande.Text, cbxAddItemItemType.Text, txtAddItemDiscription.Text);
                        // MessageBox.Show("warranty found item");

                        wty_dtail_inconplete.anorItm = true;
                        if (MessageBox.Show("Warranty complted by another Item", "Sharp creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            if (cb_printi.Checked == true)
                            {



                                //==========================================================================================================================

                                SqlDataReader ziddr = Invo.select_invoNo(iNo.ToString());
                                if (ziddr.Read())
                                {
                                    invodate = Convert.ToDateTime(ziddr["Invoice_Date"].ToString());
                                    total = ziddr["Total_Price"].ToString();
                                    paid = ziddr["Paid_Price"].ToString();
                                    blnc = ziddr["Balance"].ToString();
                                    cusnom = ziddr["Coustomer_No"].ToString();
                                    paymethd = ziddr["Payment_Method"].ToString();
                                    grantota = ziddr["Grande_total"].ToString();
                                    disc = ziddr["Discount"].ToString();
                                    tax = ziddr["Tax"].ToString();



                                }

                                SqlDataReader zdrcus = Invo.select_incus(cusnom);
                                if (zdrcus.Read())
                                {
                                    fname = zdrcus["First_Name"].ToString();
                                    lnme = zdrcus["Last_Name"].ToString();
                                    add1 = zdrcus["Address_Line1"].ToString();
                                    add2 = zdrcus["Address_Line2"].ToString();
                                    mobl = zdrcus["Mobile"].ToString();


                                }
                                else
                                {
                                    fname = "N/A";
                                    lnme = "N/A";
                                    add1 = "N/A";
                                    add2 = "N/A";
                                    mobl = "N/A";
                                }




                                String ibsql = "SELECT*FROM tbl_Invoice_details WHERE Invoice_No='" + iNo + "'";
                                SqlDataAdapter ibget = new SqlDataAdapter(ibsql, ConnectionDB.Connection());
                                DataTable ibns = new DataTable();
                                ibget.Fill(ibns);
                                for (int ib = 0; ib < ibns.Rows.Count; ib++)
                                {
                                    itmno = ibns.Rows[ib]["Item_No"].ToString();
                                    itmNme = ibns.Rows[ib]["Item_Name"].ToString();
                                    itmseril = ibns.Rows[ib]["Serial_No"].ToString();
                                    itsalepriz = ibns.Rows[ib]["Sales_Price"].ToString();
                                    itmctgy = ibns.Rows[ib]["Catogory"].ToString();
                                    itmsbctgy = ibns.Rows[ib]["Sub_Catogory"].ToString();
                                    itmbrnd = ibns.Rows[ib]["Brande"].ToString();
                                    itmwarrty = ibns.Rows[ib]["Warranty"].ToString();


                                    iqty = ibns.Rows[ib]["Quntity"].ToString();



                                    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ check- is bill table Null...? ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                                    String emty_ibl = "SELECT*FROM tbl_Invoice_bill";
                                    SqlDataAdapter iigemty_bil = new SqlDataAdapter(emty_ibl, ConnectionDB.Connection());
                                    DataTable iemty_bil = new DataTable();
                                    iigemty_bil.Fill(iemty_bil);
                                    if (0 != iemty_bil.Rows.Count) // does not exist
                                    {
                                        //___________________________________________________________________________________________________________________________
                                        SqlDataReader slct_billDR = Invo.select_invtmp_bil(itmctgy, itmsbctgy, itmbrnd);
                                        if (slct_billDR.Read())
                                        {
                                            string bsril, bqtyy, u_piz; decimal n_qty;

                                            bsril = slct_billDR["Serial_No"].ToString();
                                            bqtyy = slct_billDR["Quantity"].ToString();
                                            u_piz = slct_billDR["Unit_Price"].ToString();
                                            n_qty = Convert.ToDecimal(bqtyy) + Convert.ToDecimal(iqty);

                                            Invo.Updte_invc_bill(itmctgy, itmsbctgy, itmbrnd, n_qty, (Convert.ToDecimal(u_piz) * n_qty), bsril + "," + itmseril);
                                            //MessageBox.Show("update_Dtail");


                                        }
                                        else
                                        {
                                            try
                                            {
                                                Invo.insert_Invoice_Bill(iNo.ToString(), invodate, fname + " " + lnme, add1 + " " + add2, mobl, Convert.ToDecimal(grantota), Convert.ToDecimal(disc), Convert.ToDecimal(tax), Convert.ToDecimal(total), Convert.ToDecimal(paid), paymethd, Convert.ToDecimal(blnc), itmseril, itmctgy, itmsbctgy, itmbrnd, itmbrnd + " " + itmNme + " " + itmctgy + " " + itmsbctgy + " \nWarranty- " + itmwarrty, Convert.ToDecimal(Convert.ToDecimal(itsalepriz) / Convert.ToDecimal(iqty)), Convert.ToDecimal(iqty), Convert.ToDecimal(itsalepriz));

                                                //MessageBox.Show("Invoice bill add");
                                            }
                                            catch (Exception ex)
                                            { MessageBox.Show(ex.Message); }

                                        }

                                        //___________________________________________________________________________________________________________________________


                                    }
                                    else
                                    {

                                        try
                                        {
                                            Invo.insert_Invoice_Bill(iNo.ToString(), invodate, fname + " " + lnme, add1 + " " + add2, mobl, Convert.ToDecimal(grantota), Convert.ToDecimal(disc), Convert.ToDecimal(tax), Convert.ToDecimal(total), Convert.ToDecimal(paid), paymethd, Convert.ToDecimal(blnc), itmseril, itmctgy, itmsbctgy, itmbrnd, itmbrnd + " " + itmNme + " " + itmctgy + " " + itmsbctgy + " \nWarranty- " + itmwarrty, Convert.ToDecimal(Convert.ToDecimal(itsalepriz) / Convert.ToDecimal(iqty)), Convert.ToDecimal(iqty), Convert.ToDecimal(itsalepriz));

                                            //MessageBox.Show("Invoice bill add");
                                        }
                                        catch (Exception ex)
                                        { MessageBox.Show(ex.Message); }

                                    }


                                }

                                Bill invoBil = new Bill();
                                invoBil.ShowDialog();




                                //============================================================================================================================








                                //============================================================================================================================







                            }

        //============================================================================================================================



                            wty_dtail_inconplete.bt_save = true;
                           
                            this.Close();
                        }
                    }
                    else
                    {
                        if (txtAddItemItemName.Text == "")
                        { ep_iname.SetError(txtAddItemItemName, "Enter Item name"); }
                        if (cbxAddItemItemType.Text == "")
                        { ep_isupp.SetError(cbxAddItemItemType, "Choose type"); }
                        if (cbxAddItemBrande.Text == "")
                        { ep_ibrnd.SetError(cbxAddItemBrande, "Choose Item Brande"); }
                        if(cbxAddItemCatogory.Text=="")
                        { ep_ictogry.SetError(cbxAddItemCatogory, "Choose Item Catogary"); }
                        if (cbxAddItemSubCatogory.Text == "")
                        { ep_isubCotory.SetError(cbxAddItemSubCatogory, "Choose Item sub Catogary"); }
                        
                        
                        tp_required.Show("Fill Require fileds", btn_ok, 5000);



                       

                    }
                }

                else
                {
                    tp_seril_barcobe.Show("Must Enter Serial or Barcode For Iditify Items", txtAddItemSerial, 4000);

                }


            //}
            //catch (Exception ee)
            //{ MessageBox.Show(ee.Message); }
        }

       

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            cbxAddItemSubCatogory.Text = "";
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
                toolTip_haddle.Show("Plase enter Number and Catactor!", txtAddItemSerial, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txtAddItemItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_haddle.Show("Plase enter Number and Caractor!", txtAddItemItemName, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txtAddItemDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_haddle.Show("Plase enter Number and Catactor!", txtAddItemDiscription, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void cbxAddItemItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; ;
        }

        private void cbxAddItemSubCatogory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
               
                e.Handled = true;
            }

        }

        private void cbxAddItemCatogory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {

                e.Handled = true;
            }
        }

        private void cbxAddItemBrande_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {

                e.Handled = true;
            }
        }

        
        

       

        

        
    }
}
