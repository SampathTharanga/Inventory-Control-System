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
    public partial class Return_New_item : Form
    {
        public Return_New_item()
        {
            InitializeComponent();
        }
        DataSet ds;
      
        Item_DB_Operation itemdb = new Item_DB_Operation();
        Warranty_DB_Operetion wrty = new Warranty_DB_Operetion();
        Invoive_DB_Operetion Invo = new Invoive_DB_Operetion();

        string iinme, iiserial, iiselpiz, iipurpiz, iictgry, iisubctgry, iibrnd, iibcode, iiwrrty, iisuppl,iitpe,iidescri;
        string inme, iserial, iselpiz, ipurpiz, ictgry, isubctgry, ibrnd, ibcode, iwrrty, isuppl, itpe, descri, inom, iqty,icty;
        int iNo, iiNo,cNo;
        string invoNo, cusnom, fname, lnme, add1, add2, mobl, grantota, disc, tax, total, paid, paymethd, blnc, itmno, itmseril, itmNme, itmctgy, itmsbctgy, itmbrnd, itsalepriz, itmwarrty;
        DateTime invodate;
        decimal iqqqty;
        
        public static DataGridView dgv_change = new DataGridView();
        public static bool btn_clik_c;
        string inmee, ides, ccno, pymnt;
        public static TextBox tx_brdz = new TextBox();

        private void Return_New_item_Load(object sender, EventArgs e)
        {
            string sqlTrunc = "TRUNCATE TABLE " + "tbl_Invoice_Item";
            SqlCommand cmd = new SqlCommand(sqlTrunc, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();

            lbl_CurrentMoney.Text = Add_Warranty.dgvaddw.CurrentRow.Cells["Sales_Price"].Value.ToString();
            dgv_change = dgvFindItem;
            btn_clik_c = true;
           

            ds = Invo.all_Item();
            dgvFindItem.DataSource = ds.Tables["tbl_Invoice_Item"];


            txt_balnce.Enabled = false;
            txt_paid.Enabled = false;
            tx_brdz = txt_bcrde;


            txt_bcrde.Focus();
         
        }


        private void btn_chnge_Click(object sender, EventArgs e)
        {
            errorProvider2.SetError(txt_paid, "");
            errorProvider3.SetError(txt_balnce, "");
            errorProvider1.SetError(cbx_payMethord, "");
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
           // MessageBox.Show(iNo.ToString());

            //---------------------------------------------------------------------------------------------------------------------//
            //===========================================Item No  ============================================================================//


            string riNo = itemdb.Itemno();
            if (riNo.Equals("") || riNo == null)
            {
                iiNo = 001000;
            }
            else
            {
                iiNo = Convert.ToInt32(riNo);
                iiNo = iiNo + 1;


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
            //lbl_itNo.Text = max.ToString();
            



            //============================================================================================================================//

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++check tablen is Null++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
            String emty = "SELECT*FROM tbl_Invoice_Item";
            SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
            DataTable iemty = new DataTable();
            iigemty.Fill(iemty);
            if (0 != iemty.Rows.Count) // does not exist
            {
   //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                if (cbx_payMethord.Text != "" && txt_paid.Text!="")
                {
                   

                        if (txt_balnce.Text != "Invalaid payment..!")
                        {

                            //====================================================================================================================================//
                            String iisql = "SELECT*FROM tbl_Invoice_Item";
                            SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
                            DataTable iins = new DataTable();
                            iiget.Fill(iins);
                            for (int ii = 0; ii < iins.Rows.Count; ii++)
                            {
                                inom = iins.Rows[ii]["Item_No"].ToString();
                                inme = iins.Rows[ii]["Item_Name"].ToString();
                                iserial = iins.Rows[ii]["Serial_No"].ToString();
                                iselpiz = iins.Rows[ii]["Sales_Price"].ToString();
                                ipurpiz = iins.Rows[ii]["Purchase_Price"].ToString();
                                ictgry = iins.Rows[ii]["Catogory"].ToString();
                                isubctgry = iins.Rows[ii]["Sub_Catogory"].ToString();
                                ibrnd = iins.Rows[ii]["Brande"].ToString();
                                ibcode = iins.Rows[ii]["Barcode"].ToString();
                                iwrrty = iins.Rows[ii]["Warranty"].ToString();
                                isuppl = iins.Rows[ii]["Supplier"].ToString();
                                itpe = iins.Rows[ii]["Item_Type"].ToString();
                                descri = iins.Rows[ii]["Discription"].ToString();


                                decimal pfit = (Convert.ToDecimal(iselpiz)) - (Convert.ToDecimal(ipurpiz));

                                try
                                {

                                    Invo.insert_Invoice_detalis(iNo.ToString(), DateTime.Now, inom, iserial, inme, Convert.ToDecimal(iselpiz), Convert.ToDecimal(ipurpiz), ibcode, ictgry, isubctgry, ibrnd, iwrrty, isuppl, itpe, descri, pfit, "Ok","1");
                                    // MessageBox.Show("new itttttttttmss changgggg");
                                }
                                catch (Exception ee)
                                {
                                    MessageBox.Show(ee.Message);
                                }

                            }

                            //===================================================================================================================================//

                            //-----------------------------------------------for description-------------------------------------------------------------//

                            String sql = "SELECT DISTINCT Catogory FROM tbl_Invoice_Item";
                            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
                            DataTable ns = new DataTable();
                            get.Fill(ns);
                            for (int i = 0; i < ns.Rows.Count; i++)
                            {
                                iqqqty = 0;
                                icty = ns.Rows[i]["Catogory"].ToString();

                                String idsql = "SELECT Quntity FROM tbl_Invoice_Item WHERE Catogory='" + icty + "'";
                                SqlDataAdapter idget = new SqlDataAdapter(idsql, ConnectionDB.Connection());
                                DataTable idns = new DataTable();
                                idget.Fill(idns);
                                for (int idi = 0; idi < idns.Rows.Count; idi++)
                                {
                                    decimal qttt = Convert.ToDecimal(idns.Rows[idi]["Quntity"].ToString());
                                    iqqqty += qttt;
                                }

                                ides += icty + iqqqty.ToString() + " ";


                            }
                            //---------------------------------------------------------------------------------------------------------------------------//


                            //===============================================================================================================================//

                            SqlDataReader cdr = wrty.select_cusNo(Add_Warranty.dgvaddw.CurrentRow.Cells["Invoice_No"].Value.ToString());
                            if (cdr.Read())
                            {
                                ccno = cdr["Coustomer_No"].ToString();
                            }

                            if (txt_balnce.Text == "0.00")
                            {
                                pymnt = "Ok";
                            }
                            else
                            {
                                pymnt = "Not Complete";
                            }


                            //================================================================================================================================//

                            try
                            {
                                Invo.insert_Invoice(iNo.ToString(), DateTime.Now, Convert.ToDecimal(txt_Total.Text), (Convert.ToDecimal(txt_paid.Text)) + (Convert.ToDecimal(lbl_CurrentMoney.Text)), Convert.ToDecimal(txt_balnce.Text), cbx_payMethord.Text, ides, New_invoice.sref.Text, ccno, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), pymnt);
                                // MessageBox.Show("ADd new invo");
                                wrty.update_item_status(Add_Warranty.dgvaddw.CurrentRow.Cells["Invoice_No"].Value.ToString(), Add_Warranty.dgvaddw.CurrentRow.Cells["Item_No"].Value.ToString(), "Changed");
                                // MessageBox.Show("update oled invo");
                            }
                            catch (Exception eee)
                            {
                                MessageBox.Show(eee.Message);
                            }



                            //--------------------------------------------------Remove Invoiced items From tbl_Add_Items Table---------------------------------// 

                            String dsql = "SELECT*FROM tbl_Invoice_Item";
                            SqlDataAdapter dget = new SqlDataAdapter(dsql, ConnectionDB.Connection());
                            DataTable dns = new DataTable();
                            dget.Fill(dns);
                            for (int di = 0; di < dns.Rows.Count; di++)
                            {

                                SqlDataReader drm = itemdb.select_to_Qntity(dns.Rows[di]["Catogory"].ToString(), dns.Rows[di]["Sub_Catogory"].ToString(), dns.Rows[di]["Brande"].ToString());
                                if (drm.Read())
                                {
                                    string qqt = drm["Quntity"].ToString();
                                    int qq1 = int.Parse(qqt);
                                    int qq2 = qq1 - 1;
                                    string qty = qq2.ToString();
                                    itemdb.update_Quntity(qty, dns.Rows[di]["Catogory"].ToString(), dns.Rows[di]["Sub_Catogory"].ToString(), dns.Rows[di]["Brande"].ToString());
                                    itemdb.delete_item(dns.Rows[di]["Item_No"].ToString());
                                    // MessageBox.Show("Quntity Updated");
                                }

                            }


                            //---------------------------------------------------------------------------------------------------------------------------------//



                            //========================================Add old item back to item table   &   qty updated================================================//



                            SqlDataReader bdr = wrty.select_invo_backI(Add_Warranty.dgvaddw.CurrentRow.Cells["Item_No"].Value.ToString(), Add_Warranty.dgvaddw.CurrentRow.Cells["Invoice_No"].Value.ToString());
                            if (bdr.Read())
                            {

                                iinme = bdr["Item_Name"].ToString();
                                iiserial = bdr["Serial_No"].ToString();
                                iiselpiz = bdr["Sales_Price"].ToString();
                                iipurpiz = bdr["Purchase_Price"].ToString();
                                iictgry = bdr["Catogory"].ToString();
                                iisubctgry = bdr["Sub_Catogory"].ToString();
                                iibrnd = bdr["Brande"].ToString();
                                iibcode = bdr["Barcode"].ToString();
                                iiwrrty = bdr["Warranty"].ToString();
                                iisuppl = bdr["Supplier"].ToString();
                                iitpe = bdr["Item_Type"].ToString();
                                iidescri = bdr["Discription"].ToString();

                                //*********************************************************************************//
                                wrty.insert_back_item(max.ToString(), iiserial, iinme, Convert.ToDecimal(iiselpiz), Convert.ToDecimal(iipurpiz), Convert.ToDecimal("0"), iibcode, iictgry, iisubctgry, iibrnd, iisuppl, iiwrrty, iitpe, iidescri);
                                //  MessageBox.Show("item back");


                                SqlDataReader dr = itemdb.select_to_Qntity(iictgry, iisubctgry, iibrnd);
                                if (dr.Read())
                                {
                                    string qt = dr["Quntity"].ToString();
                                    int q1 = int.Parse(qt);
                                    int q2 = q1 + 1;
                                    string qty = q2.ToString();
                                    itemdb.update_Quntity(qty, iictgry, iisubctgry, iibrnd);
                                    //  MessageBox.Show("Quntity Updated");

                                }
                                else
                                {
                                    itemdb.Quntity(iinme,iictgry, iisubctgry, iibrnd, "1",iipurpiz,iiselpiz);
                                    // MessageBox.Show("quntity Added");
                                }

                            }




                            if (MessageBox.Show(" Item Change Completed", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
                                this.Close();
                            }

                              

                            //=========================================================================================================================================//


                        }
                        else
                        {
                            errorProvider2.SetError(txt_paid, "Invalid payment");
                            errorProvider3.SetError(txt_balnce, "Invalid payment");

                        }
                    
     //==============================================================================================================

                   
                    
                    
     //============================================================================================================
                    
                }
                else
                {
                    if (cbx_payMethord.Text=="")
                    {
                        errorProvider1.SetError(cbx_payMethord, "Complete warranty");
                    }

                    if (txt_paid.Text == "")
                    {
                        toolTipselect.Show("No Payment Enter", txt_paid, 1000);
                    }
                }
            }
            else { toolTipselect.Show("Select items to Change", button_SearchItem, 0, 75, 2500); }
        }




        private void btnFindItemCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button_SearchItem_Click(object sender, EventArgs e)
        {
            Invoice_findItem invoItem = new Invoice_findItem();
            invoItem.ShowDialog();
        }

        private void button_deleteitem_Click(object sender, EventArgs e)
        {
            try
            {
                Invo.delete_Invo_item(dgvFindItem.CurrentRow.Cells["Item_No"].Value.ToString());
                ds = Invo.all_Item();
                dgvFindItem.DataSource = ds.Tables["tbl_Invoice_Item"];
            }
            catch (Exception) { }
        }

        private void button_ResetItem_Click(object sender, EventArgs e)
        {
            string sqlTrunc = "TRUNCATE TABLE " + "tbl_Invoice_Item";
            SqlCommand cmd = new SqlCommand(sqlTrunc, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();

            ds = Invo.all_Item();
            dgvFindItem.DataSource = ds.Tables["tbl_Invoice_Item"];
        }

        private void dgvFindItem_DataSourceChanged(object sender, EventArgs e)
        {
            
           
           
            txt_tax.Text = "0";
            txt_discount.Text = "0";
            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgvFindItem.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvFindItem.Rows[i].Cells["Sales_Price"].Value);
            }
            txt_Total.Text = sum.ToString();
            txt_granTotal.Text = sum.ToString();
           
            //---------------------------------------------------------------------------------------------------------------//

            decimal dOutput;
            if (txt_Total.Text != "" && txt_Total.Text != "0" && decimal.TryParse(txt_Total.Text, out dOutput))
            {
                decimal blnce = (Convert.ToDecimal(txt_Total.Text)) - (Convert.ToDecimal(lbl_CurrentMoney.Text));
                lbl_balnce.Text = blnce.ToString();
            }

            if (lbl_balnce.Text != "0.00")
            {
                txt_paid.Enabled = true;
                txt_balnce.Enabled = true;
                txt_tax.Enabled = true;
                txt_discount.Enabled = true;
            }
            else
            {
                txt_paid.Enabled = false;
                txt_balnce.Enabled = false;
                txt_tax.Enabled = false;
                txt_discount.Enabled = false;
                txt_paid.Text = ("0.00");
                txt_balnce.Text = ("0.00");
            }



            


            

            
        }


        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            txt_paid.MaxLength = 10;
            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgvFindItem.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvFindItem.Rows[i].Cells["Sales_Price"].Value);
            }
            txt_Total.Text = sum.ToString();
            txt_granTotal.Text = sum.ToString();

            //---------------------------------------------------------------------------------------------------------------//

            //---------------------------------------------Discount------------------------------------------------------------//
            decimal dOutput;
            if (txt_discount.Text != "" && decimal.TryParse(txt_discount.Text, out dOutput))
            {
                decimal dis, gT, dTot, fTot;
                dis = Convert.ToDecimal(txt_discount.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                dTot = (gT / 100) * dis;
                fTot = gT - dTot;
                txt_Total.Text = fTot.ToString();
            }


            //---------------------------------------------------------------------------------------------------------------//

            //----------------------------------------------Tax---------------------------------------------------------------//


            if (txt_tax.Text != "" && decimal.TryParse(txt_tax.Text, out dOutput))
            {
                decimal tax, gT, dTot, fTot, totall;
                tax = Convert.ToDecimal(txt_tax.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                totall = Convert.ToDecimal(txt_Total.Text);
                dTot = (gT / 100) * tax;
                fTot = totall + dTot;
                txt_Total.Text = fTot.ToString();
            }
            //---------------------------------------------------------------------------------------------------------------//



            if (txt_Total.Text != "" && txt_Total.Text != "0" && decimal.TryParse(txt_Total.Text, out dOutput))
            {
                decimal blnce = (Convert.ToDecimal(txt_Total.Text)) - (Convert.ToDecimal(lbl_CurrentMoney.Text));
                lbl_balnce.Text = blnce.ToString();
            }

            if (lbl_balnce.Text != "0.00")
            {
                txt_paid.Enabled = true;
                txt_balnce.Enabled = true;
            }
            else
            {
                txt_paid.Enabled = false;
                txt_balnce.Enabled = false;
            }


            if (txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                decimal bln = ((Convert.ToDecimal(lbl_balnce.Text)) - (Convert.ToDecimal(txt_paid.Text)));
                if (bln >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = bln.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }
            }

            else 
            {
                txt_balnce.Text = lbl_balnce.Text;
                txt_paid.Text = "0.00";
            }
           
        }

        private void dgvFindItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgvFindItem.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvFindItem.Rows[i].Cells["Sales_Price"].Value);
            }
            txt_Total.Text = sum.ToString();
            txt_granTotal.Text = sum.ToString();

            //---------------------------------------------------------------------------------------------------------------//

            //---------------------------------------------Discount------------------------------------------------------------//
            decimal dOutput;
            if (txt_discount.Text != "" && decimal.TryParse(txt_discount.Text, out dOutput))
            {
                decimal dis, gT, dTot, fTot;
                dis = Convert.ToDecimal(txt_discount.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                dTot = (gT / 100) * dis;
                fTot = gT - dTot;
                txt_Total.Text = fTot.ToString();
            }


            //---------------------------------------------------------------------------------------------------------------//

            //----------------------------------------------Tax---------------------------------------------------------------//


            if (txt_tax.Text != "" && decimal.TryParse(txt_tax.Text, out dOutput))
            {
                decimal tax, gT, dTot, fTot, totall;
                tax = Convert.ToDecimal(txt_tax.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                totall = Convert.ToDecimal(txt_Total.Text);
                dTot = (gT / 100) * tax;
                fTot = totall + dTot;
                txt_Total.Text = fTot.ToString();
            }
            //---------------------------------------------------------------------------------------------------------------//


            
            if (txt_Total.Text != "" && txt_Total.Text != "0" && decimal.TryParse(txt_Total.Text, out dOutput))
            {
                decimal blnce = (Convert.ToDecimal(txt_Total.Text)) - (Convert.ToDecimal(lbl_CurrentMoney.Text));
                lbl_balnce.Text = blnce.ToString();
            }

            if (lbl_balnce.Text != "0.00")
            {
                txt_paid.Enabled = true;
                txt_balnce.Enabled = true;
                txt_tax.Enabled = true;
                txt_discount.Enabled = true;
            }
            else
            {
                txt_paid.Enabled = false;
                txt_balnce.Enabled = false;
                txt_tax.Enabled = false;
                txt_discount.Enabled = false;
                txt_paid.Text = ("0.00");
                txt_balnce.Text = ("0.00");
            }


            if (txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                decimal bln = ((Convert.ToDecimal(lbl_balnce.Text)) - (Convert.ToDecimal(txt_paid.Text)));
                if (bln >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = bln.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }
            }

            if (lbl_balnce.Text == "0.00")
            {
                txt_paid.Enabled = false;
                txt_balnce.Enabled = false;
            }
        }

        private void txt_tax_TextChanged(object sender, EventArgs e)
        {
            txt_tax.MaxLength = 4;
            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgvFindItem.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvFindItem.Rows[i].Cells["Sales_Price"].Value);
            }
            txt_Total.Text = sum.ToString();
            txt_granTotal.Text = sum.ToString();

            //---------------------------------------------------------------------------------------------------------------//

            //---------------------------------------------Discount------------------------------------------------------------//
            decimal dOutput;
            if (txt_discount.Text != "" && decimal.TryParse(txt_discount.Text, out dOutput))
            {
                decimal dis, gT, dTot, fTot;
                dis = Convert.ToDecimal(txt_discount.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                dTot = (gT / 100) * dis;
                fTot = gT - dTot;
                txt_Total.Text = fTot.ToString();
            }


            //---------------------------------------------------------------------------------------------------------------//

            //----------------------------------------------Tax---------------------------------------------------------------//


            if (txt_tax.Text != "" && decimal.TryParse(txt_tax.Text, out dOutput))
            {
                decimal tax, gT, dTot, fTot, totall;
                tax = Convert.ToDecimal(txt_tax.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                totall = Convert.ToDecimal(txt_Total.Text);
                dTot = (gT / 100) * tax;
                fTot = totall + dTot;
                txt_Total.Text = fTot.ToString();
            }
            //---------------------------------------------------------------------------------------------------------------//



            if (txt_Total.Text != "" && txt_Total.Text != "0" && decimal.TryParse(txt_Total.Text, out dOutput))
            {
                decimal blnce = (Convert.ToDecimal(txt_Total.Text)) - (Convert.ToDecimal(lbl_CurrentMoney.Text));
                lbl_balnce.Text = blnce.ToString();
            }

            if (lbl_balnce.Text != "0.00")
            {
                txt_paid.Enabled = true;
                txt_balnce.Enabled = true;
            }


            if (txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                decimal bln = ((Convert.ToDecimal(lbl_balnce.Text)) - (Convert.ToDecimal(txt_paid.Text)));
                if (bln >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = bln.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            txt_discount.MaxLength = 4;

            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgvFindItem.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dgvFindItem.Rows[i].Cells["Sales_Price"].Value);
            }
            txt_Total.Text = sum.ToString();
            txt_granTotal.Text = sum.ToString();

            //---------------------------------------------------------------------------------------------------------------//

            //---------------------------------------------Discount------------------------------------------------------------//
            decimal dOutput;
            if (txt_discount.Text != "" && decimal.TryParse(txt_discount.Text, out dOutput))
            {
                decimal dis, gT, dTot, fTot;
                dis = Convert.ToDecimal(txt_discount.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                dTot = (gT / 100) * dis;
                fTot = gT - dTot;
                txt_Total.Text = fTot.ToString();
            }


            //---------------------------------------------------------------------------------------------------------------//

            //----------------------------------------------Tax---------------------------------------------------------------//


            if (txt_tax.Text != "" && decimal.TryParse(txt_tax.Text, out dOutput))
            {
                decimal tax, gT, dTot, fTot, totall;
                tax = Convert.ToDecimal(txt_tax.Text);
                gT = Convert.ToDecimal(txt_granTotal.Text);
                totall = Convert.ToDecimal(txt_Total.Text);
                dTot = (gT / 100) * tax;
                fTot = totall + dTot;
                txt_Total.Text = fTot.ToString();
            }
            //---------------------------------------------------------------------------------------------------------------//



            if (txt_Total.Text != "" && txt_Total.Text != "0" && decimal.TryParse(txt_Total.Text, out dOutput))
            {
                decimal blnce = (Convert.ToDecimal(txt_Total.Text)) - (Convert.ToDecimal(lbl_CurrentMoney.Text));
                lbl_balnce.Text = blnce.ToString();
            }

            if (lbl_balnce.Text != "0.00")
            {
                txt_paid.Enabled = true;
                txt_balnce.Enabled = true;
            }


            if (txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                decimal bln = ((Convert.ToDecimal(lbl_balnce.Text)) - (Convert.ToDecimal(txt_paid.Text)));
                if (bln >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = bln.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }
            }
        }

        private void Return_New_item_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_clik_c = false;
        }

        private void txt_tax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_tax.Show("Invalid Tax-Rate ", txt_tax, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                e.Handled = true;
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_dis.Show("Invalid Discount", txt_discount, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

            

        }

        private void txt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_paid.Show("Invalid Payment", txt_paid, 0, -50, 2000);
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txt_tax_Click(object sender, EventArgs e)
        {
            if (txt_tax.Text == "0")
            {
                txt_tax.Clear();
            }
        }

        private void txt_discount_Click(object sender, EventArgs e)
        {
             if(txt_discount.Text == "0")
            {
                txt_discount.Clear();
            }
        }

        private void txt_tax_MouseLeave(object sender, EventArgs e)
        {
            if (txt_tax.Text == "")
            {
                txt_tax.Text = "0";
            }

        }

        private void txt_discount_MouseLeave(object sender, EventArgs e)
        {
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }
        }

        private void txt_paid_Click(object sender, EventArgs e)
        {
            if (txt_paid.Text == "0.00")
            {
                txt_paid.Clear();
            }
        }

        private void txt_paid_MouseLeave(object sender, EventArgs e)
        {
            //if (txt_paid.Text == "")
            //{
            //    txt_paid.Text = "0.00";
            //}
        }

        private void cbx_payMethord_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        private void txt_bcrde_Click(object sender, EventArgs e)
        {
            txt_bcrde.Clear();
        }

        private void txt_bcrde_TextChanged(object sender, EventArgs e)
        {
            if (txt_bcrde.Text != "")
            {


                try
                {
                    SqlDataReader bcdr = itemdb.select_frm_barcode(txt_bcrde.Text);
                    if (bcdr.Read())
                    {
                        string inot, serialt, inamet, taxt, barcodet, catogoryt, subCatoryt, brandet, woratyt, selsPricet, purchPricet, supit, itpet, descrit;

                        inot = bcdr["Item_No"].ToString();
                        serialt = bcdr["Serial_No"].ToString();
                        inamet = bcdr["Item_Name"].ToString();
                        selsPricet = bcdr["Sales_Price"].ToString();
                        purchPricet = bcdr["Purchase_Price"].ToString();
                        taxt = bcdr["Tax_Rate"].ToString();
                        barcodet = bcdr["Barcode"].ToString();
                        catogoryt = bcdr["Catogory"].ToString();
                        subCatoryt = bcdr["Sub_Catogory"].ToString();
                        brandet = bcdr["Brande"].ToString();
                        woratyt = bcdr["Warranty"].ToString();
                        supit = bcdr["Supplier"].ToString();
                        itpet = bcdr["Item_Type"].ToString();
                        descrit = bcdr["Discription"].ToString();

                        Invo.insert_Invo_item(inot, serialt, inamet, Convert.ToDecimal(selsPricet), Convert.ToDecimal(purchPricet), Convert.ToDecimal(taxt), barcodet, catogoryt, subCatoryt, brandet, woratyt, supit, itpet, descrit, "1", "Nomal", Convert.ToDecimal(selsPricet));
                        ds = Invo.all_Item();
                        dgvFindItem.DataSource = ds.Tables["tbl_Invoice_Item"];
                        txt_bcrde.Clear();

                    }


                    else
                    {
                        txt_bcrde.ForeColor = Color.Red;
                        //toolTip_barcode.Show("Can't find Item", textBox1, 1000);


                    }


                }
                catch (Exception)
                {


                    txt_bcrde.ForeColor = Color.Red;
                    toolTip_barcode.Show("Item allrady exits", txt_bcrde, 2000);
                    txt_bcrde.Clear();
                }
                //}

            }
        }

        
        

       

        

        
    }
}
