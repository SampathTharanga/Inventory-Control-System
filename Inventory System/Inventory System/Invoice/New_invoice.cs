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
    public partial class New_invoice : Form
    {
        string un1, ut1;
        public New_invoice(string un2, string ut2)
        {
            InitializeComponent();
            un1 = un2;
            ut1 = ut2;
        }

        public static DataGridView dtvw = new DataGridView();
        public static Label lb_cusN = new Label();
        public static TextBox tx_fn = new TextBox();
        public static TextBox tx_ln = new TextBox();
        public static TextBox tx_ad1 = new TextBox();
        public static TextBox tx_ad2 = new TextBox();
        public static TextBox tx_mob = new TextBox();
        public static TextBox tx_emal= new TextBox();
        public static TextBox tx_bcrd = new TextBox();
        

        int iNo,cNo;
        DataSet ds;
        Invoive_DB_Operetion Invo = new Invoive_DB_Operetion();
        Customer_DB_Operation NoAuto = new Customer_DB_Operation();
        Item_DB_Operation itemdb = new Item_DB_Operation();
        public static Label sref = new Label();
        public static bool btn_clikin;
        bool alrady;
        decimal q_pRiz, q_sRiz, qty_avible; string qiinme;


        Regex reg_email = new Regex(@"^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$");


        private void New_invoice_Load(object sender, EventArgs e)
        {


  //-------------------------------------   clear tbl_Invoice_Item  &   tbl_Invoice_Bill   Tables   --------------------------//
            string sqlTrunc = "TRUNCATE TABLE " + "tbl_Invoice_Item";
            SqlCommand cmd = new SqlCommand(sqlTrunc, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();



            string sqlTruncBill = "TRUNCATE TABLE " + "tbl_Invoice_bill";
            SqlCommand cmdB = new SqlCommand(sqlTruncBill, ConnectionDB.Connection());
            cmdB.ExecuteNonQuery();


            
           
 //-------------------------------------------------------------------------------------------------------------------------//

           

            dtvw = dgv_Invo_item;

            lb_cusN = lbl_CustomerNo;
            tx_fn = txt_firstnme;
            tx_ln = txt_laNme;
            tx_ad1 = txt_add1;
            tx_ad2 = txt_add2;
            tx_mob = txt_mobile;
            tx_emal = txt_email;
            tx_bcrd = textBox1;

            timer_add_Invo.Start();

            lblSelsRefnm.Text = un1;
            lblSelsRefTyp.Text = ut1;

            


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
            lblInvoiceNo.Text = Convert.ToString(iNo);
//---------------------------------------------------------------------------------------------------------------------//


//-------------------------------------------Auto Customer No----------------------------------------------------------//
            string rcNo = NoAuto.getCusno();
            if (rcNo.Equals("") || rcNo == null)
            {
                cNo = 001000;
            }
            else
            {
                cNo = Convert.ToInt32(rcNo);
                cNo = cNo + 1;

            }
            lbl_CustomerNo.Text = Convert.ToString(cNo);        


//---------------------------------------------------------------------------------------------------------------------//

            ds = Invo.all_Item();
            dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];

            txt_discount.Text = "0";
            txt_tax.Text = "0";
            txt_Total.Text = "0";
            txt_paid.Text = "0";


            sref = lblSelsRefnm;

            textBox1.Focus();
            rd_invoic.Checked = true;
            rbtn_nml_itm.Checked = true;


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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_add_Invo_Tick(object sender, EventArgs e)
        {
           // lblInvoiceDate.Text = (DateTime.Today.Year +"/"+ DateTime.Today.Month +"/"+ DateTime.Today.Day).ToString();
           //lblInvoiceTime.Text = (DateTime.Now.Hour +":"+ DateTime.Now.Minute).ToString();
            lblInvoiceTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button_seach_Cus_Click(object sender, EventArgs e)
        {
            Invoic_findCus invo_cus = new Invoic_findCus();
            invo_cus.ShowDialog();
            

        }

        private void button_reset_Cus_Click(object sender, EventArgs e)
        {
            txt_firstnme.Clear();
            txt_laNme.Clear();
            txt_add1.Clear();
            txt_add2.Clear();
            txt_mobile.Clear();
            txt_email.Clear();



            //-------------------------------------------Auto Customer No----------------------------------------------------------//
            string rcNo = NoAuto.getCusno();
            if (rcNo.Equals("") || rcNo == null)
            {
                cNo = 001000;
            }
            else
            {
                cNo = Convert.ToInt32(rcNo);
                cNo = cNo + 1;

            }
            lbl_CustomerNo.Text = Convert.ToString(cNo);


            //---------------------------------------------------------------------------------------------------------------------//
        }

        private void button_SearchItem_Click(object sender, EventArgs e)
        {
            btn_clikin = true;
            Invoice_findItem invoItem = new Invoice_findItem();
            invoItem.ShowDialog();
        }

        private void button_ResetItem_Click(object sender, EventArgs e)
        {
            string sqlTrunc = "TRUNCATE TABLE " + "tbl_Invoice_Item";
            SqlCommand cmd = new SqlCommand(sqlTrunc,ConnectionDB.Connection());
            cmd.ExecuteNonQuery();

            ds = Invo.all_Item();
            dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];
        }
        
       

        private void dgv_Invo_item_DataSourceChanged(object sender, EventArgs e)
        {

            


 //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgv_Invo_item.Rows.Count; ++i)
            {
                decimal inqy=Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Quntity"].Value);
                sum += Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Sales_Price"].Value)*inqy;
            }
            txt_granTotal.Text = sum.ToString();
            txt_Total.Text = sum.ToString();
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


            txt_balnce.Text = txt_Total.Text;



 


        }

        private void button_deleteitem_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            String emty = "SELECT*FROM tbl_Invoice_Item";
            SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
            DataTable iemty = new DataTable();
            iigemty.Fill(iemty);
            if (0 != iemty.Rows.Count) // does not exist
            {
                Invo.delete_Invo_item(dgv_Invo_item.CurrentRow.Cells["Item_No"].Value.ToString());
                ds = Invo.all_Item();
                dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];
            }
            else { tool_tip_emty.Show("There are No item Choosed for Delete", button_SearchItem, 1, 70, 2500); }

        }

        private void dgv_Invo_item_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgv_Invo_item.AllowUserToDeleteRows = true;
            dgv_Invo_item.AllowUserToAddRows = true;


            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgv_Invo_item.Rows.Count; ++i)
            {
                decimal inqy = Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Quntity"].Value);
                sum += Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Sales_Price"].Value)*inqy;
            }
            txt_granTotal.Text = sum.ToString();
            txt_Total.Text = sum.ToString();
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





            //--------------------------------------------------Balance------------------------------------------------------//
            if (txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                decimal pad, TT, BTot;
                pad = Convert.ToDecimal(txt_paid.Text);
                TT = Convert.ToDecimal(txt_Total.Text);
                BTot = TT - pad;
                //txt_balnce.Text = BTot.ToString();
                if (BTot >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = BTot.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }
            }
            else { txt_balnce.Text = txt_Total.Text; }

            //---------------------------------------------------------------------------------------------------------------//

           
           

            for (int i = 0; i < dgv_Invo_item.Rows.Count; i++)
            {

                try
                {
                    string Iino, Iserial, Iiname, Itaxx, Ibarcode, Icatogory, IsubCatory, Ibrande, Iworaty, IselsPrice, IpurchPrice,Isupp,Itpe,Idescri;

                    Iino = dgv_Invo_item.CurrentRow.Cells["Item_No"].Value.ToString();
                    Iserial = dgv_Invo_item.CurrentRow.Cells["Serial_No"].Value.ToString();
                    Iiname = dgv_Invo_item.CurrentRow.Cells["Item_Name"].Value.ToString();
                    IselsPrice = dgv_Invo_item.CurrentRow.Cells["Sales_Price"].Value.ToString();
                    IpurchPrice = dgv_Invo_item.CurrentRow.Cells["Purchase_Price"].Value.ToString();
                    Itaxx = dgv_Invo_item.CurrentRow.Cells["Tax_Rate"].Value.ToString();
                    Ibarcode = dgv_Invo_item.CurrentRow.Cells["Barcode"].Value.ToString();
                    Icatogory = dgv_Invo_item.CurrentRow.Cells["Catogory"].Value.ToString();
                    IsubCatory = dgv_Invo_item.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                    Ibrande = dgv_Invo_item.CurrentRow.Cells["Brande"].Value.ToString();
                    Iworaty = dgv_Invo_item.CurrentRow.Cells["Warranty"].Value.ToString();
                    Isupp = dgv_Invo_item.CurrentRow.Cells["Supplier"].Value.ToString();
                    Itpe = dgv_Invo_item.CurrentRow.Cells["Item_Type"].Value.ToString();
                    Idescri = dgv_Invo_item.CurrentRow.Cells["Discription"].Value.ToString();

                    Invo.Updte_Invo_item(Iino, Iserial, Iiname, Convert.ToDecimal(IselsPrice), Convert.ToDecimal(IpurchPrice), Convert.ToDecimal(Itaxx), Ibarcode, Icatogory, IsubCatory, Ibrande, Iworaty, Isupp, Itpe, Idescri, "1", Convert.ToDecimal(IselsPrice));
                    ds = Invo.all_Item();
                    dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }



            }




            



        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            txt_discount.MaxLength = 5;

            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgv_Invo_item.Rows.Count; ++i)
            {
                decimal inqy = Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Quntity"].Value);
                sum += Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Sales_Price"].Value)*inqy;
            }
            txt_granTotal.Text = sum.ToString();
            txt_Total.Text = sum.ToString();
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


           

            //--------------------------------------------------Balance------------------------------------------------------//
            if (txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                decimal pad, TT, BTot;
                pad = Convert.ToDecimal(txt_paid.Text);
                TT = Convert.ToDecimal(txt_Total.Text);
                BTot = TT - pad;
                //txt_balnce.Text = BTot.ToString();
                if (BTot >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = BTot.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }
            }
            else { txt_balnce.Text = txt_Total.Text; }

            //---------------------------------------------------------------------------------------------------------------//
            if (txt_discount.Text == "") { txt_discount.Text = "0"; }


        }

        private void txt_tax_TextChanged(object sender, EventArgs e)
        {
            txt_tax.MaxLength = 5;

            //----------------------------------------------Grande Total-----------------------------------------------------//
            decimal sum = 0;
            for (int i = 0; i < dgv_Invo_item.Rows.Count; ++i)
            {
                decimal inqy = Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Quntity"].Value);
                sum += Convert.ToDecimal(dgv_Invo_item.Rows[i].Cells["Sales_Price"].Value)*inqy;
            }
            txt_granTotal.Text = sum.ToString();
            txt_Total.Text = sum.ToString();
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


            //--------------------------------------------------Balance------------------------------------------------------//
            if (txt_paid.Text != "" && decimal.TryParse(txt_paid.Text, out dOutput))
            {
                decimal pad, TT, BTot;
                pad = Convert.ToDecimal(txt_paid.Text);
                TT = Convert.ToDecimal(txt_Total.Text);
                BTot = TT - pad;
                //txt_balnce.Text = BTot.ToString();
                if (BTot >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = BTot.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }
            }
            else { txt_balnce.Text = txt_Total.Text; }

            //---------------------------------------------------------------------------------------------------------------//

            if (txt_tax.Text == "") { txt_tax.Text = "0"; }

        }
        string icty, ides;
        decimal iqqqty;
        string iino, iiserial, iiname, iiselsPrice, iipuchPrice, iibarcode, iicatogory, iisubCatory, iibrande, iiworaty, iisupp, iitpe, iidescri, bqty, amont, iitqty;
        private void button_CompletInvoice_Click(object sender, EventArgs e)
        {


        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            txt_paid.MaxLength = 10;
            
  //----------------------------------------------------------Balance----------------------------------------------------------------//          
            double dOutput;
            if (txt_paid.Text != "" && double.TryParse(txt_paid.Text, out dOutput))
            {
                double pad, TT, BTot;
                pad = Convert.ToDouble(txt_paid.Text);
                TT = Convert.ToDouble(txt_Total.Text);
                BTot = TT - pad;
                //txt_balnce.Text = BTot.ToString();
                if (BTot >= 0)
                {
                    txt_balnce.ForeColor = Color.Black;
                    txt_balnce.Text = BTot.ToString();
                }
                else
                {
                    txt_balnce.Text = "Invalaid payment..!";
                    txt_balnce.ForeColor = Color.Red;
                }

            }
            else
            { txt_balnce.Text = txt_Total.Text; }


            
//-------------------------------------------------------------------------------------------------------------------------------//

        }

        private void button_PrintInvoice_Click(object sender, EventArgs e)
        {
            if (rd_invoic.Checked == true)
            {


                errorProvider_invo_cus_nm.SetError(txt_firstnme, "");
                errorProvider_invo_cus_ln.SetError(txt_laNme, "");
                errorProvider_invo_add.SetError(txt_add1, "");
                errorProvider_invo_cusMOb.SetError(txt_mobile, "");
                errorProvider_paid.SetError(txt_paid, "");
                errorProvider_payMted.SetError(cbx_payMethord, "");


                if (txt_firstnme.Text != "" && txt_laNme.Text != "" && txt_add1.Text != "" && txt_mobile.Text != "")
                {

                    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++check tablen is Null++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                    String emty = "SELECT*FROM tbl_Invoice_Item";
                    SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
                    DataTable iemty = new DataTable();
                    iigemty.Fill(iemty);
                    if (0 != iemty.Rows.Count) // does not exist
                    {


                        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                        if (cbx_payMethord.Text != "" && txt_paid.Text != "")
                        {
                            if (txt_balnce.Text != "Invalaid payment..!")
                            {
                                if (txt_paid.Text != "0")
                                {




                                    SqlDataReader cdr = Invo.select_incus(lbl_CustomerNo.Text);
                                    if (!cdr.Read())
                                    {
                                        Invo.insertCus(lbl_CustomerNo.Text, txt_firstnme.Text, txt_laNme.Text, txt_add1.Text, txt_add2.Text, txt_mobile.Text, txt_email.Text);
                                        //MessageBox.Show("New cus Add");

                                    }


                                    //=======================================================================================================================//
                                    String iisql = "SELECT*FROM tbl_Invoice_Item";
                                    SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
                                    DataTable iins = new DataTable();
                                    iiget.Fill(iins);
                                    for (int ii = 0; ii < iins.Rows.Count; ii++)
                                    {
                                        iino = iins.Rows[ii]["Item_No"].ToString();
                                        iiname = iins.Rows[ii]["Item_Name"].ToString();
                                        iiserial = iins.Rows[ii]["Serial_No"].ToString();
                                        iibarcode = iins.Rows[ii]["Barcode"].ToString();
                                        iiselsPrice = iins.Rows[ii]["Sales_Price"].ToString();
                                        iipuchPrice = iins.Rows[ii]["Purchase_Price"].ToString();
                                        iicatogory = iins.Rows[ii]["Catogory"].ToString();
                                        iisubCatory = iins.Rows[ii]["Sub_Catogory"].ToString();
                                        iibrande = iins.Rows[ii]["Brande"].ToString();
                                        iiworaty = iins.Rows[ii]["Warranty"].ToString();
                                        iisupp = iins.Rows[ii]["Supplier"].ToString();
                                        iitpe = iins.Rows[ii]["Item_Type"].ToString();
                                        iitqty = iins.Rows[ii]["Quntity"].ToString();
                                        iidescri = iins.Rows[ii]["Discription"].ToString();


                                        decimal pfit = (Convert.ToDecimal(iiselsPrice) * Convert.ToDecimal(iitqty)) - (Convert.ToDecimal(iipuchPrice) * Convert.ToDecimal(iitqty));

                                        try
                                        {
                                            Invo.insert_Invoice_detalis(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), iino, iiserial, iiname, Convert.ToDecimal(iiselsPrice) * Convert.ToDecimal(iitqty), Convert.ToDecimal(iipuchPrice) * Convert.ToDecimal(iitqty), iibarcode, iicatogory, iisubCatory, iibrande, iiworaty, iisupp, iitpe, iidescri, pfit, "Ok", iitqty);

                                        }
                                        catch (Exception ex)
                                        { MessageBox.Show(ex.Message); }

                                    }




                                    //-----------------------------------------------for description-------------------------------------------------------------//

                                    String sql = "SELECT DISTINCT Catogory FROM tbl_Invoice_Item";
                                    SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
                                    DataTable ns = new DataTable();
                                    get.Fill(ns);
                                    for (int i = 0; i < ns.Rows.Count; i++)
                                    {
                                        iqqqty=0;
                                        icty = ns.Rows[i]["Catogory"].ToString();

                                        String idsql = "SELECT Quntity FROM tbl_Invoice_Item WHERE Catogory='"+icty+"'";
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

                                    string pymnt;
                                    if (txt_balnce.Text == "0")
                                    {
                                        pymnt = "Ok";
                                    }
                                    else
                                    {
                                        pymnt = "Not Complete";
                                    }

                                    try
                                    {
                                        Invo.insert_Invoice(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), Convert.ToDecimal(txt_balnce.Text), cbx_payMethord.Text, ides, lblSelsRefnm.Text, lbl_CustomerNo.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), pymnt);

                                    }
                                    catch (Exception ex)
                                    { MessageBox.Show(ex.Message); }


                                    //MessageBox.Show("Invoice Saved");


//-------------------------------------Insert to tbl_Invoice_bill Tempoery table----------------------------------------------------//

                                    String ibsql = "SELECT*FROM tbl_Invoice_Item";
                                    SqlDataAdapter ibget = new SqlDataAdapter(ibsql, ConnectionDB.Connection());
                                    DataTable ibns = new DataTable();
                                    ibget.Fill(ibns);
                                    for (int ib = 0; ib < ibns.Rows.Count; ib++)
                                    {
                                        iino = ibns.Rows[ib]["Item_No"].ToString();
                                        iiname = ibns.Rows[ib]["Item_Name"].ToString();
                                        iiserial = ibns.Rows[ib]["Serial_No"].ToString();
                                        iiselsPrice = ibns.Rows[ib]["Sales_Price"].ToString();
                                        iicatogory = ibns.Rows[ib]["Catogory"].ToString();
                                        iisubCatory = ibns.Rows[ib]["Sub_Catogory"].ToString();
                                        iibrande = ibns.Rows[ib]["Brande"].ToString();
                                        iiworaty = ibns.Rows[ib]["Warranty"].ToString();
                                        bqty = ibns.Rows[ib]["Quntity"].ToString();
                                        amont = ibns.Rows[ib]["Amount"].ToString();
                                        
                                 //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ check- is bill table Null...? ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                                        String emty_ibl = "SELECT*FROM tbl_Invoice_bill";
                                        SqlDataAdapter iigemty_bil = new SqlDataAdapter(emty_ibl, ConnectionDB.Connection());
                                         DataTable iemty_bil = new DataTable();
                                        iigemty_bil.Fill(iemty_bil);
                                        if (0 != iemty_bil.Rows.Count) // does not exist
                                        {
                                            //___________________________________________________________________________________________________________________________
                                            SqlDataReader slct_billDR = Invo.select_invtmp_bil(iicatogory, iisubCatory, iibrande);
                                            if (slct_billDR.Read())
                                            {
                                                string bsril, bqtyy, u_piz; decimal n_qty;

                                                bsril = slct_billDR["Serial_No"].ToString();
                                                bqtyy = slct_billDR["Quantity"].ToString();
                                                u_piz = slct_billDR["Unit_Price"].ToString();
                                                n_qty=Convert.ToDecimal(bqtyy)+Convert.ToDecimal( bqty);

                                                Invo.Updte_invc_bill(iicatogory, iisubCatory, iibrande, n_qty, (Convert.ToDecimal(u_piz) * n_qty), bsril + "," + iiserial);
                                                //MessageBox.Show("update_Dtail");


                                            }
                                            else
                                            {
                                                try
                                                {
                                                    Invo.insert_Invoice_Bill(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), txt_firstnme.Text + " " + txt_laNme.Text, txt_add1.Text + " " + txt_add2.Text, txt_mobile.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), cbx_payMethord.Text, Convert.ToDecimal(txt_balnce.Text), iiserial, iicatogory, iisubCatory, iibrande, iibrande + " " + iiname + " " + iisubCatory + " " + iicatogory + " \nWarranty- " + iiworaty, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal(bqty), Convert.ToDecimal(amont));

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
                                                Invo.insert_Invoice_Bill(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), txt_firstnme.Text + " " + txt_laNme.Text, txt_add1.Text + " " + txt_add2.Text, txt_mobile.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), cbx_payMethord.Text, Convert.ToDecimal(txt_balnce.Text), iiserial, iicatogory, iisubCatory, iibrande, iibrande + " " + iiname + " " + iisubCatory + " " + iicatogory + " \nWarranty- " + iiworaty, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal( bqty),Convert.ToDecimal( amont));

                                                //MessageBox.Show("Invoice bill add");
                                            }
                                            catch (Exception ex)
                                            { MessageBox.Show(ex.Message); }
                                        
                                        }

                    
                                 //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//

                                        



                                    }

 //------------------------------------------------------------------------------------------------------------------------------------//


                          





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
                                            decimal mqty = Convert.ToDecimal(dns.Rows[di]["Quntity"].ToString());
                                           
                                            decimal qqt = Convert.ToDecimal(drm["Quntity"].ToString());
                                           
                                            decimal qq2 = qqt - mqty;
                                            string qty = qq2.ToString();
                                            itemdb.update_Quntity(qty, dns.Rows[di]["Catogory"].ToString(), dns.Rows[di]["Sub_Catogory"].ToString(), dns.Rows[di]["Brande"].ToString());
                                            itemdb.delete_item(dns.Rows[di]["Item_No"].ToString());
                                            //MessageBox.Show("Quntity Updated");
                                        }
                                    }

                                    //---------------------------------------------------------------------------------------------------------------------------------//



                                    MessageBox.Show("Invoice Completed", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                    Bill invoBil = new Bill();
                                    invoBil.ShowDialog();
                                    btn_clikin = false;

                                    Main.p1.Controls.Clear();
                                    New_invoice addinvoice = new New_invoice(Main.un, Main.UT1);
                                    addinvoice.TopLevel = false;
                                    addinvoice.Visible = true;
                                    Main.p1.Controls.Add(addinvoice);
                                    New_invoice.tx_bcrd.Focus();

                                }
                                else
                                {
                                    if (MessageBox.Show("No payment Enter for this Invoice Do you Want to Continue?", "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                    {
                                        //===========================++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++========================================================================================================//



                                        SqlDataReader cdr = Invo.select_incus(lbl_CustomerNo.Text);
                                        if (!cdr.Read())
                                        {
                                            Invo.insertCus(lbl_CustomerNo.Text, txt_firstnme.Text, txt_laNme.Text, txt_add1.Text, txt_add2.Text, txt_mobile.Text, txt_email.Text);
                                            //MessageBox.Show("New cus Add");

                                        }


                                        //=======================================================================================================================//
                                        String iisql = "SELECT*FROM tbl_Invoice_Item";
                                        SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
                                        DataTable iins = new DataTable();
                                        iiget.Fill(iins);
                                        for (int ii = 0; ii < iins.Rows.Count; ii++)
                                        {
                                            iino = iins.Rows[ii]["Item_No"].ToString();
                                            iiname = iins.Rows[ii]["Item_Name"].ToString();
                                            iiserial = iins.Rows[ii]["Serial_No"].ToString();
                                            iibarcode = iins.Rows[ii]["Barcode"].ToString();
                                            iiselsPrice = iins.Rows[ii]["Sales_Price"].ToString();
                                            iipuchPrice = iins.Rows[ii]["Purchase_Price"].ToString();
                                            iicatogory = iins.Rows[ii]["Catogory"].ToString();
                                            iisubCatory = iins.Rows[ii]["Sub_Catogory"].ToString();
                                            iibrande = iins.Rows[ii]["Brande"].ToString();
                                            iiworaty = iins.Rows[ii]["Warranty"].ToString();
                                            iisupp = iins.Rows[ii]["Supplier"].ToString();
                                            iitpe = iins.Rows[ii]["Item_Type"].ToString();
                                            iidescri = iins.Rows[ii]["Discription"].ToString();
                                            iitqty = iins.Rows[ii]["Quntity"].ToString();


                                            decimal pfit = (Convert.ToDecimal(iiselsPrice)) - (Convert.ToDecimal(iipuchPrice));

                                            try
                                            {
                                                Invo.insert_Invoice_detalis(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), iino, iiserial, iiname, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal(iipuchPrice), iibarcode, iicatogory, iisubCatory, iibrande, iiworaty, iisupp, iitpe, iidescri, pfit, "Ok", iitqty);

                                            }
                                            catch (Exception ex)
                                            { MessageBox.Show(ex.Message); }

                                        }




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

                                        string pymnt;
                                        if (txt_balnce.Text == "0")
                                        {
                                            pymnt = "Ok";
                                        }
                                        else
                                        {
                                            pymnt = "Not Complete";
                                        }

                                        try
                                        {
                                            Invo.insert_Invoice(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), Convert.ToDecimal(txt_balnce.Text), cbx_payMethord.Text, ides, lblSelsRefnm.Text, lbl_CustomerNo.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), pymnt);

                                        }
                                        catch (Exception ex)
                                        { MessageBox.Show(ex.Message); }


                                        //MessageBox.Show("Invoice Saved");




          //-------------------------------------Insert to tbl_Invoice_bill Tempoery table----------------------------------------------------//

                                        String ibsql = "SELECT*FROM tbl_Invoice_Item";
                                        SqlDataAdapter ibget = new SqlDataAdapter(ibsql, ConnectionDB.Connection());
                                        DataTable ibns = new DataTable();
                                        ibget.Fill(ibns);
                                        for (int ib = 0; ib < ibns.Rows.Count; ib++)
                                        {
                                            iino = ibns.Rows[ib]["Item_No"].ToString();
                                            iiname = ibns.Rows[ib]["Item_Name"].ToString();
                                            iiserial = ibns.Rows[ib]["Serial_No"].ToString();
                                            iiselsPrice = ibns.Rows[ib]["Sales_Price"].ToString();
                                            iicatogory = ibns.Rows[ib]["Catogory"].ToString();
                                            iisubCatory = ibns.Rows[ib]["Sub_Catogory"].ToString();
                                            iibrande = ibns.Rows[ib]["Brande"].ToString();
                                            iiworaty = ibns.Rows[ib]["Warranty"].ToString();
                                            bqty = ibns.Rows[ib]["Quntity"].ToString();
                                            amont = ibns.Rows[ib]["Amount"].ToString();

                                            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ check- is bill table Null...? ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                                            String emty_ibl = "SELECT*FROM tbl_Invoice_bill";
                                            SqlDataAdapter iigemty_bil = new SqlDataAdapter(emty_ibl, ConnectionDB.Connection());
                                            DataTable iemty_bil = new DataTable();
                                            iigemty_bil.Fill(iemty_bil);
                                            if (0 != iemty_bil.Rows.Count) // does not exist
                                            {
                                                //___________________________________________________________________________________________________________________________
                                                SqlDataReader slct_billDR = Invo.select_invtmp_bil(iicatogory, iisubCatory, iibrande);
                                                if (slct_billDR.Read())
                                                {
                                                    string bsril, bqtyy, u_piz; decimal n_qty;

                                                    bsril = slct_billDR["Serial_No"].ToString();
                                                    bqtyy = slct_billDR["Quantity"].ToString();
                                                    u_piz = slct_billDR["Unit_Price"].ToString();
                                                    n_qty = Convert.ToDecimal(bqtyy) + Convert.ToDecimal(bqty);

                                                    Invo.Updte_invc_bill(iicatogory, iisubCatory, iibrande, n_qty, (Convert.ToDecimal(u_piz) * n_qty), bsril + "," + iiserial);
                                                    //MessageBox.Show("update_Dtail");


                                                }
                                                else
                                                {
                                                    try
                                                    {
                                                        Invo.insert_Invoice_Bill(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), txt_firstnme.Text + " " + txt_laNme.Text, txt_add1.Text + " " + txt_add2.Text, txt_mobile.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), cbx_payMethord.Text, Convert.ToDecimal(txt_balnce.Text), iiserial, iicatogory, iisubCatory, iibrande, iibrande + " " + iiname + " " + iisubCatory + " " + iicatogory + " \nWarranty- " + iiworaty, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal(bqty), Convert.ToDecimal(amont));

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
                                                    Invo.insert_Invoice_Bill(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), txt_firstnme.Text + " " + txt_laNme.Text, txt_add1.Text + " " + txt_add2.Text, txt_mobile.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), cbx_payMethord.Text, Convert.ToDecimal(txt_balnce.Text), iiserial, iicatogory, iisubCatory, iibrande, iibrande + " " + iiname + " " + iisubCatory + " " + iicatogory + " \nWarranty- " + iiworaty, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal(bqty), Convert.ToDecimal(amont));

                                                    //MessageBox.Show("Invoice bill add");
                                                }
                                                catch (Exception ex)
                                                { MessageBox.Show(ex.Message); }

                                            }


                                            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//





                                        }

        //------------------------------------------------------------------------------------------------------------------------------------//








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
                                                decimal mqty = Convert.ToDecimal(dns.Rows[di]["Quntity"].ToString());

                                                decimal qqt = Convert.ToDecimal(drm["Quntity"].ToString());

                                                decimal qq2 = qqt - mqty;
                                                string qty = qq2.ToString();
                                                itemdb.update_Quntity(qty, dns.Rows[di]["Catogory"].ToString(), dns.Rows[di]["Sub_Catogory"].ToString(), dns.Rows[di]["Brande"].ToString());
                                                itemdb.delete_item(dns.Rows[di]["Item_No"].ToString());
                                                //MessageBox.Show("Quntity Updated");
                                            }
                                        }

                                        //---------------------------------------------------------------------------------------------------------------------------------//




                                        MessageBox.Show("Invoice Completed", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                        Bill invoBil = new Bill();
                                        invoBil.ShowDialog();
                                        btn_clikin = false;


                                        Main.p1.Controls.Clear();
                                        New_invoice addinvoice = new New_invoice(Main.un, Main.UT1);
                                        addinvoice.TopLevel = false;
                                        addinvoice.Visible = true;
                                        Main.p1.Controls.Add(addinvoice);
                                        New_invoice.tx_bcrd.Focus();

                                        //====================================+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++==================================================================================================//

                                    }
                                    else { toolTip_paid.Show("Enter Payment", txt_paid, 0, -50, 2000); }
                                }
                            }
                            else { toolTip_paid.Show("Invalid Payment", txt_paid, 0, -50, 2000); }
                        }
                        else
                        {
                            if (txt_paid.Text == "")
                            {
                                errorProvider_paid.SetError(txt_paid, "Enter Payment");
                            }

                            if (cbx_payMethord.Text == "")
                            {
                                toolTip_mthd.Show("Choose payment methord", cbx_payMethord, 1000);
                                errorProvider_payMted.SetError(cbx_payMethord, "Choose payment methord");
                            }


                        }
                    }
                    else { tool_tip_emty.Show("Plase Select Item to sale", button_SearchItem, 1, 70, 2500); }

                }
                else
                {
                    if (txt_firstnme.Text == "")
                    {
                        errorProvider_invo_cus_nm.SetError(txt_firstnme, "Enter first name");
                    }
                    if (txt_laNme.Text == "")
                    {
                        errorProvider_invo_cus_ln.SetError(txt_laNme, "Enter last name");
                    }
                    if (txt_add1.Text == "")
                    {
                        errorProvider_invo_add.SetError(txt_add1, "Enter  Address");
                    }
                    if (txt_mobile.Text == "")
                    {
                        errorProvider_invo_cusMOb.SetError(txt_mobile, "Enter Mobile No");
                    }







                }
            }
//____bill print_______________________________________________________________________________________________________________________

            if (rd_bill.Checked == true)
               

            {
                errorProvider_payMted.SetError(cbx_payMethord, "");
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++check tablen is Null++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                    String emty = "SELECT*FROM tbl_Invoice_Item";
                    SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
                    DataTable iemty = new DataTable();
                    iigemty.Fill(iemty);
                    if (0 != iemty.Rows.Count) // does not exist
                    {
                        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                        if (txt_balnce.Text == "0" && txt_balnce.Text != "Invalaid payment..!")
                        {

                            if (cbx_payMethord.Text != "")
                            {
//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::




 //=======================================================================================================================//
                                String iisql = "SELECT*FROM tbl_Invoice_Item";
                                SqlDataAdapter iiget = new SqlDataAdapter(iisql, ConnectionDB.Connection());
                                DataTable iins = new DataTable();
                                iiget.Fill(iins);
                                for (int ii = 0; ii < iins.Rows.Count; ii++)
                                {
                                    iino = iins.Rows[ii]["Item_No"].ToString();
                                    iiname = iins.Rows[ii]["Item_Name"].ToString();
                                    iiserial = iins.Rows[ii]["Serial_No"].ToString();
                                    iibarcode = iins.Rows[ii]["Barcode"].ToString();
                                    iiselsPrice = iins.Rows[ii]["Sales_Price"].ToString();
                                    iipuchPrice = iins.Rows[ii]["Purchase_Price"].ToString();
                                    iicatogory = iins.Rows[ii]["Catogory"].ToString();
                                    iisubCatory = iins.Rows[ii]["Sub_Catogory"].ToString();
                                    iibrande = iins.Rows[ii]["Brande"].ToString();
                                    iiworaty = iins.Rows[ii]["Warranty"].ToString();
                                    iisupp = iins.Rows[ii]["Supplier"].ToString();
                                    iitpe = iins.Rows[ii]["Item_Type"].ToString();
                                    iidescri = iins.Rows[ii]["Discription"].ToString();
                                    iitqty = iins.Rows[ii]["Quntity"].ToString();


                                    decimal pfit = (Convert.ToDecimal(iiselsPrice)) - (Convert.ToDecimal(iipuchPrice));

                                    try
                                    {
                                        Invo.insert_Invoice_detalis(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), iino, iiserial, iiname, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal(iipuchPrice), iibarcode, iicatogory, iisubCatory, iibrande, iiworaty, iisupp, iitpe, iidescri, pfit, "Ok", iitqty);

                                    }
                                    catch (Exception ex)
                                    { MessageBox.Show(ex.Message); }

                                }




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

                                try
                                {
                                    Invo.insert_Invoice(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), Convert.ToDecimal(txt_balnce.Text), cbx_payMethord.Text, ides, lblSelsRefnm.Text, "N/A", Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), "Ok");

                                }
                                catch (Exception ex)
                                { MessageBox.Show(ex.Message); }


                                //MessageBox.Show("Invoice Saved");




    //-------------------------------------Insert to tbl_Invoice_bill Tempoery table----------------------------------------------------//

                                String ibsql = "SELECT*FROM tbl_Invoice_Item";
                                SqlDataAdapter ibget = new SqlDataAdapter(ibsql, ConnectionDB.Connection());
                                DataTable ibns = new DataTable();
                                ibget.Fill(ibns);
                                for (int ib = 0; ib < ibns.Rows.Count; ib++)
                                {
                                    iino = ibns.Rows[ib]["Item_No"].ToString();
                                    iiname = ibns.Rows[ib]["Item_Name"].ToString();
                                    iiserial = ibns.Rows[ib]["Serial_No"].ToString();
                                    iiselsPrice = ibns.Rows[ib]["Sales_Price"].ToString();
                                    iicatogory = ibns.Rows[ib]["Catogory"].ToString();
                                    iisubCatory = ibns.Rows[ib]["Sub_Catogory"].ToString();
                                    iibrande = ibns.Rows[ib]["Brande"].ToString();
                                    iiworaty = ibns.Rows[ib]["Warranty"].ToString();
                                    bqty = ibns.Rows[ib]["Quntity"].ToString();
                                    amont = ibns.Rows[ib]["Amount"].ToString();

                                    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ check- is bill table Null...? ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
                                    String emty_ibl = "SELECT*FROM tbl_Invoice_bill";
                                    SqlDataAdapter iigemty_bil = new SqlDataAdapter(emty_ibl, ConnectionDB.Connection());
                                    DataTable iemty_bil = new DataTable();
                                    iigemty_bil.Fill(iemty_bil);
                                    if (0 != iemty_bil.Rows.Count) // does not exist
                                    {
                                        //___________________________________________________________________________________________________________________________
                                        SqlDataReader slct_billDR = Invo.select_invtmp_bil(iicatogory, iisubCatory, iibrande);
                                        if (slct_billDR.Read())
                                        {
                                            string bsril, bqtyy, u_piz; decimal n_qty;

                                            bsril = slct_billDR["Serial_No"].ToString();
                                            bqtyy = slct_billDR["Quantity"].ToString();
                                            u_piz = slct_billDR["Unit_Price"].ToString();
                                            n_qty = Convert.ToDecimal(bqtyy) + Convert.ToDecimal(bqty);

                                            Invo.Updte_invc_bill(iicatogory, iisubCatory, iibrande, n_qty, (Convert.ToDecimal(u_piz) * n_qty), bsril + "," + iiserial);
                                            //MessageBox.Show("update_Dtail");


                                        }
                                        else
                                        {
                                            try
                                            {
                                                Invo.insert_Invoice_Bill(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), txt_firstnme.Text + " " + txt_laNme.Text, txt_add1.Text + " " + txt_add2.Text, txt_mobile.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), cbx_payMethord.Text, Convert.ToDecimal(txt_balnce.Text), iiserial, iicatogory, iisubCatory, iibrande, iibrande + " " + iiname + " " + iisubCatory + " " + iicatogory + " \nWarranty- " + iiworaty, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal(bqty), Convert.ToDecimal(amont));

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
                                            Invo.insert_Invoice_Bill(lblInvoiceNo.Text, Convert.ToDateTime(dtp_Date.Value), txt_firstnme.Text + " " + txt_laNme.Text, txt_add1.Text + " " + txt_add2.Text, txt_mobile.Text, Convert.ToDecimal(txt_granTotal.Text), Convert.ToDecimal(txt_discount.Text), Convert.ToDecimal(txt_tax.Text), Convert.ToDecimal(txt_Total.Text), Convert.ToDecimal(txt_paid.Text), cbx_payMethord.Text, Convert.ToDecimal(txt_balnce.Text), iiserial, iicatogory, iisubCatory, iibrande, iibrande + " " + iiname + " " + iisubCatory + " " + iicatogory + " \nWarranty- " + iiworaty, Convert.ToDecimal(iiselsPrice), Convert.ToDecimal(bqty), Convert.ToDecimal(amont));

                                            //MessageBox.Show("Invoice bill add");
                                        }
                                        catch (Exception ex)
                                        { MessageBox.Show(ex.Message); }

                                    }


                                    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//





                                }

  //------------------------------------------------------------------------------------------------------------------------------------//



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
                                        decimal mqty = Convert.ToDecimal(dns.Rows[di]["Quntity"].ToString());

                                        decimal qqt = Convert.ToDecimal(drm["Quntity"].ToString());

                                        decimal qq2 = qqt - mqty;
                                        string qty = qq2.ToString();
                                        itemdb.update_Quntity(qty, dns.Rows[di]["Catogory"].ToString(), dns.Rows[di]["Sub_Catogory"].ToString(), dns.Rows[di]["Brande"].ToString());
                                        itemdb.delete_item(dns.Rows[di]["Item_No"].ToString());
                                        //MessageBox.Show("Quntity Updated");
                                    }
                                }

                                //---------------------------------------------------------------------------------------------------------------------------------//




                                MessageBox.Show("Invoice Completed", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);




                                Bill invoBil = new Bill();
                                invoBil.ShowDialog();
                                btn_clikin = false;

                                Main.p1.Controls.Clear();
                                New_invoice addinvoice = new New_invoice(Main.un, Main.UT1);
                                addinvoice.TopLevel = false;
                                addinvoice.Visible = true;
                                Main.p1.Controls.Add(addinvoice);
                                New_invoice.tx_bcrd.Focus();







//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::


                            }
                            else { toolTip_mthd.Show("Choose payment methord", cbx_payMethord, 1000); errorProvider_payMted.SetError(cbx_payMethord, "Choose payment methord"); }
                        }
                        else
                        {
                            if (txt_balnce.Text == "Invalaid payment..!") { toolTip_paid.Show("Invalid Payment", txt_paid, 0, -50, 2000); }
                            else { toolTip_paid.Show("Enter Full Payment", txt_paid, 0, -50, 2000); }
                        }
   
                    }
                    else { tool_tip_emty.Show("Plase Select Item to sale", button_SearchItem, 1, 70, 2500); }
            }


//_______________________________________________________________________________________________________________________________



        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void New_invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_clikin = false;
        }

        private void txt_firstnme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_Invoice.Show("Plase enter Number and Catactor!", txt_firstnme, 0, -50, 700);
                e.Handled = true;
            } 
           
        }

        private void txt_laNme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_Invoice.Show("Plase enter Number and Catactor!", txt_laNme, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_add1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_Invoice.Show("Plase enter Number and Catactor!", txt_add1, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_Invoice.Show("Plase enter 10 Number !", txt_mobile, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (reg_email.IsMatch(txt_email.Text))
            {
                toolTip_Invoice.Show("Plase enter Valide Email", txt_email, 0, -50, 700);
            }
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
            txt_mobile.MaxLength = 10;
        }

        private void txt_add2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_Invoice.Show("Plase enter Number and Catactor!", txt_add2, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip_paid.Show("Invalid Payment", txt_paid, 0, -50, 2000);
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
                {
                    e.Handled = true;
                }
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
                {
                    e.Handled = true;
                }
            }

        }

        private void btn_Advac_Cus_Click(object sender, EventArgs e)
        {
            Advance_Customer adcus = new Advance_Customer();
            adcus.ShowDialog();
        }

        private void dgv_Invo_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 


        }

        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(30);

       

        private void New_invoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox1.Clear();
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
                string msg = new String(_barcode.ToArray());
                // MessageBox.Show(msg);
                textBox1.Text = msg;
                _barcode.Clear();
            }
        }

        private void btnBaradd_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {

                 //String ibsql = "SELECT*FROM tbl_Invoice_Item";
                 //SqlDataAdapter ibget = new SqlDataAdapter(ibsql, ConnectionDB.Connection());
                 //DataTable ibns = new DataTable();
                 //ibget.Fill(ibns);
                 //for (int ib = 0; ib < ibns.Rows.Count; ib++)
                 //{
                 //    string brdc = ibns.Rows[ib]["Barcode"].ToString();
                 //    if (brdc == textBox1.Text)
                 //    {
                 //     alrady = true;
                 //    }
                 //}

                 //if (alrady == false)
                 //{


                     try
                     {
                         SqlDataReader bcdr = itemdb.select_frm_barcode(textBox1.Text);
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
                             dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];
                             textBox1.Clear();
                            
                         }


                         else
                         {
                             textBox1.ForeColor = Color.Red;
                             //toolTip_barcode.Show("Can't find Item", textBox1, 1000);
                            

                         }


                     }
                     catch (Exception)
                     {


                         textBox1.ForeColor = Color.Red;
                         toolTip_barcode.Show("Item allrady exits", textBox1, 2000);
                         textBox1.Clear();
                     }
                 //}
                
            }
        }

        private void rd_bill_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider_invo_cus_nm.SetError(txt_firstnme, "");
            errorProvider_invo_cus_ln.SetError(txt_laNme, "");
            errorProvider_invo_add.SetError(txt_add1, "");
            errorProvider_invo_cusMOb.SetError(txt_mobile, "");
            pnl_cus.Enabled = false;
        }

        private void rd_invoic_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cus.Enabled = true;
        }

        private void txt_paid_Click(object sender, EventArgs e)
        {
            if (txt_paid.Text == "0") { txt_paid.Clear(); }
        }

        private void rbtn_nml_itm_CheckedChanged(object sender, EventArgs e)
        {
            pnl_itm_qty.Visible = false;
            pnl_itm_nml.Visible = true;
        }

        private void rbtn_qty_itm_CheckedChanged(object sender, EventArgs e)
        {
            pnl_itm_qty_pt2.Visible = false;
            pnl_itm_nml.Visible = false;
            pnl_itm_qty.Visible = true;
            
            cbx_qty_Brand.Text = ""; cbx_qty_ctgy.Text = ""; cbx_qty_S_ctgy.Text = ""; lbl_availble.Text = "";numericUpDown_qty.Value=1;
            cbx_qty_S_ctgy.Items.Clear();
            errorProvider_ctgy.SetError(cbx_qty_ctgy, "");
            errorProvider_sctgy.SetError(cbx_qty_S_ctgy, ""); 
            

            
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

        private void cbx_qty_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider_ctgy.SetError(cbx_qty_ctgy, ""); 
            errorProvider_sctgy.SetError(cbx_qty_S_ctgy, ""); 

            if (cbx_qty_ctgy.Text != "" && cbx_qty_S_ctgy.Text != "")
            {

                pnl_itm_qty_pt2.Visible = true;
                SqlDataReader qtslet = itemdb.select_to_Qntity(cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text);
                if (qtslet.Read())
                {
                    qty_avible = Convert.ToDecimal(qtslet["Quntity"].ToString());
                    q_pRiz = Convert.ToDecimal(qtslet["Unit_purchas_price"].ToString());
                    q_sRiz = Convert.ToDecimal(qtslet["Unit_sale_price"].ToString());

                    lbl_availble.Text = qty_avible.ToString();
                    txt_u_pchs.Text = q_pRiz.ToString();
                    txt_u_sale.Text = q_sRiz.ToString();


                }
                else
                {
                    lbl_availble.Text = "0";

                }
            }
            else
            {
                if (cbx_qty_ctgy.Text == "") { errorProvider_ctgy.SetError(cbx_qty_ctgy, "Select Catagary First"); }
                if (cbx_qty_S_ctgy.Text == "") { errorProvider_sctgy.SetError(cbx_qty_S_ctgy, "Then Select Sub Catagary "); }

            }
        }
        
        private void btn_qty_add_Click(object sender, EventArgs e)
        {
            int qiiNo = 0; int qcNo = 0; int qiiNoa = 0; qiinme = ""; decimal qsalpiz = 0; decimal qpchpiz = 0;
            //===========================================Item No  ============================================================================//
            

            string qriNo = itemdb.Itemno();
            if (qriNo.Equals("") || qriNo == null)
            {
                qiiNo = 001000;
            }
            else
            {
                qiiNo = Convert.ToInt32(qriNo);
                qiiNo = qiiNo + 1;


            }


            string qrcNo = itemdb.getCusno();
            if (qrcNo.Equals("") || qrcNo == null)
            {
                qcNo = 001000;
            }
            else
            {
                qcNo = Convert.ToInt32(qrcNo);
                qcNo = qcNo + 1;
                // MessageBox.Show(cNo.ToString());

            }



            string qriNoa = Invo.Invoice_itm_No();
            if (qriNoa.Equals("") || qriNoa == null)
            {
                qiiNoa = 001000;
            }
            else
            {
                qiiNoa = Convert.ToInt32(qriNoa);
                qiiNoa = qiiNoa + 1;


            }



            int[] numbers = new[] { qiiNo, qcNo,qiiNoa };

            int qmax = numbers.Max();
            //lbl_itNo.Text = max.ToString();
            



            //============================================================================================================================//
            
            SqlDataReader qtydr=itemdb.select_to_Qntity(cbx_qty_ctgy.Text,cbx_qty_S_ctgy.Text,cbx_qty_Brand.Text);
            if(qtydr.Read())
            {
            qiinme=qtydr["Item_Name"].ToString();
            }
            decimal dOutput;
            if (txt_u_sale.Text != "" && decimal.TryParse(txt_u_sale.Text, out dOutput))
            {
                //___________priz_____________________________________________________________________________________________________________
                qsalpiz = Convert.ToDecimal(txt_u_sale.Text) * numericUpDown_qty.Value;
            }
            

            //____________________________________________________________________________________________________________________________

            SqlDataReader add_Qdr = Invo.select_inItm_qtyy(cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text, "Quntity");
            if (add_Qdr.Read())
            {
                if (numericUpDown_qty.Value <= Convert.ToDecimal(lbl_availble.Text)&&numericUpDown_qty.Value!=0)
                {
                    Invo.Updte_Invo_item_qty(cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text, "Quntity", Convert.ToDecimal(txt_u_sale.Text), Convert.ToDecimal(txt_u_pchs.Text), numericUpDown_qty.Value.ToString(), qsalpiz);
                }
                else { toolTip_qtty.Show("Quantity Not Availlable", numericUpDown_qty, 1500); }

            }
            else
            {
                if (numericUpDown_qty.Value <= Convert.ToDecimal(lbl_availble.Text) && numericUpDown_qty.Value != 0)
                {
                    Invo.insert_Invo_item(qmax.ToString(), "N/A", qiinme, Convert.ToDecimal(txt_u_sale.Text), Convert.ToDecimal(txt_u_pchs.Text), 0, "N/A", cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text, "No Warranty", "N/A", "N/A", "N/A", numericUpDown_qty.Value.ToString(), "Quntity", qsalpiz);
                }
                else { toolTip_qtty.Show("Quantity Not Availlable", numericUpDown_qty, 1500); }
            }
                ds = Invo.all_Item();
                dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];
            

        }

        private void dgv_Invo_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Invo_item.CurrentRow.Cells["Selct"].Value.ToString() == "Quntity")
            {
                rbtn_qty_itm.Checked = true;
                pnl_itm_qty_pt2.Visible = true;
                cbx_qty_ctgy.Text = dgv_Invo_item.CurrentRow.Cells["Catogory"].Value.ToString();
                cbx_qty_S_ctgy.Text = dgv_Invo_item.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                cbx_qty_Brand.Text = dgv_Invo_item.CurrentRow.Cells["Brande"].Value.ToString();
                numericUpDown_qty.Value = Convert.ToDecimal(dgv_Invo_item.CurrentRow.Cells["Quntity"].Value.ToString());

                SqlDataReader qtslet= itemdb.select_to_Qntity(cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text);
                if (qtslet.Read())
                {
                    lbl_availble.Text = qtslet["Quntity"].ToString();
                }

            
            }
            else { rbtn_nml_itm.Checked = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlTrunc = "TRUNCATE TABLE " + "tbl_Invoice_Item";
            SqlCommand cmd = new SqlCommand(sqlTrunc, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();

            ds = Invo.all_Item();
            dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            String emty = "SELECT*FROM tbl_Invoice_Item";
            SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
            DataTable iemty = new DataTable();
            iigemty.Fill(iemty);
            if (0 != iemty.Rows.Count) // does not exist
            {
                Invo.delete_Invo_item(dgv_Invo_item.CurrentRow.Cells["Item_No"].Value.ToString());
                ds = Invo.all_Item();
                dgv_Invo_item.DataSource = ds.Tables["tbl_Invoice_Item"];
            }
            else { tool_tip_emty.Show("There are No item Choosed for Delete", button_SearchItem, 1, 70, 2500); }

        }

        private void txt_u_pchs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip_paid.Show("Invalid Payment", txt_u_pchs, 0, -50, 2000);
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

        private void txt_u_sale_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip_paid.Show("Invalid Payment", txt_u_sale, 0, -50, 2000);
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
