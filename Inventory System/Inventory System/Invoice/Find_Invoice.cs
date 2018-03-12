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
    public partial class Find_Invoice : Form
    {
        public Find_Invoice()
        {
            InitializeComponent();
        }

        DataTable dt;
        DataSet ds;
        Invoive_DB_Operetion Invo = new Invoive_DB_Operetion();
        public static DataGridView dgvf = new DataGridView();
        string  invoNo,cusnom, fname, lnme, add1, add2, mobl, grantota, disc, tax, total, paid, paymethd, blnc, itmno,iqty, itmseril, itmNme, itmctgy, itmsbctgy, itmbrnd, itsalepriz,itmwarrty;
        DateTime invodate;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String emty = "SELECT Invoice_No FROM tbl_Invoice";
                SqlDataAdapter iigemty = new SqlDataAdapter(emty, ConnectionDB.Connection());
                DataTable iemty = new DataTable();
                iigemty.Fill(iemty);
                if (0 != iemty.Rows.Count) // does not exist
                {

                    Invoice_Details invoDls = new Invoice_Details();
                    invoDls.ShowDialog();
                }
                else { tool_tip_emty.Show("There are No Invoices for a View Deails", txtFindInvoInvoNo, 1, 70, 2500); }
            }


            catch (Exception) { }
        

        }

        private void Find_Invoice_Load(object sender, EventArgs e)
        {
            dgvf = dgv_Invoice;
            
            ds = Invo.all_Invoice();
            dgv_Invoice.DataSource = ds.Tables["tbl_Invoice"];


            DateTime tdy = DateTime.Now.AddDays(1);
            dateTimePicker_to.Text = tdy.ToShortDateString();
            



            
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            //ds = Invo.all_Invoice_date(dateTimePicker_From.Text, dateTimePicker_to.Text);
            //dgv_Invoice.DataSource = ds.Tables["tbl_Invoice"];


            ////string query = "SELECT * FROM tbl_Invoice WHERE Invoice_Date BETWEEN @SDate AND @EDate";<------------This Quert is Correct & Run----------->
            //string query = "SELECT * FROM tbl_Invoice WHERE Invoice_Date >= @SDate AND Invoice_Date <= @EDate";
            //SqlCommand cmd = new SqlCommand(query, ConnectionDB.Connection());
            //cmd.Parameters.AddWithValue("@SDate", dateTimePicker_From.Value);
            //cmd.Parameters.AddWithValue("@EDate", dateTimePicker_to.Value);
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //ds.Tables.Clear();
            //da.Fill(ds, "tbl_Invoice");
            //dgv_Invoice.DataSource = ds.Tables["tbl_Invoice"];
        }

        

        private void txtFindInvoInvoNo_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Invoice_No,Invoice_Date,Description,Total_Price,Paid_Price,Coustomer_No,Seals_ref,Payment FROM tbl_Invoice";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dt = new DataTable();
            da.Fill(dt);
            BindingSource binso = new BindingSource();
            binso.DataSource = dt;
            dgv_Invoice.DataSource = binso;
            da.Update(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "Invoice_No like '%" + txtFindInvoInvoNo.Text + "%' ";
            dgv_Invoice.DataSource = dv;
        }

        private void txtFindInvoBarcode_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Invoice_No,Invoice_Date,Description,Total_Price,Paid_Price,Coustomer_No,Seals_ref,Payment FROM tbl_Invoice";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dt = new DataTable();
            da.Fill(dt);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dt;
            dgv_Invoice.DataSource = bnsue;
            da.Update(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "Description like '%" + txtFindInvoBarcode.Text + "%' ";
            dgv_Invoice.DataSource = dv;

        }

        private void cbx_payComple_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFindInvoInvoNo.Clear();
            txtFindInvoBarcode.Clear();

            if (cbx_payComple.SelectedItem.ToString() == "Payment Complete")
            {
                string sql = "SELECT Invoice_No,Invoice_Date,Description,Total_Price,Paid_Price,Coustomer_No,Seals_ref,Payment FROM tbl_Invoice WHERE Invoice_Date >='" + dateTimePicker_From.Text + "' AND Invoice_Date <='" + dateTimePicker_to.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dt = new DataTable();
                da.Fill(dt);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dt;
                dgv_Invoice.DataSource = bnsue;
                da.Update(dt);

                DataView dv = new DataView(dt);
                dv.RowFilter = "Payment like '%" + "Ok" + "%' ";
                dgv_Invoice.DataSource = dv;
            }

            else if (cbx_payComple.SelectedItem.ToString() == "Payment InComplete")
            {
                string sql = "SELECT Invoice_No,Invoice_Date,Description,Total_Price,Paid_Price,Coustomer_No,Seals_ref,Payment FROM tbl_Invoice WHERE Invoice_Date >='" + dateTimePicker_From.Text + "' AND Invoice_Date <='" + dateTimePicker_to.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dt = new DataTable();
                da.Fill(dt);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dt;
                dgv_Invoice.DataSource = bnsue;
                da.Update(dt);

                DataView dv = new DataView(dt);
                dv.RowFilter = "Payment like '%" + "Not Complete" + "%' ";
                dgv_Invoice.DataSource = dv;
            }

            else
            {
                ds = Invo.all_Invoice_date(dateTimePicker_From.Text, dateTimePicker_to.Text);
                dgv_Invoice.DataSource = ds.Tables["tbl_Invoice"];
            }

                
           

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {


                invoNo = dgv_Invoice.CurrentRow.Cells["Invoice_No"].Value.ToString();
                SqlDataReader iddr = Invo.select_invoNo(invoNo);
                if (iddr.Read())
                {
                    invodate = Convert.ToDateTime(iddr["Invoice_Date"].ToString());
                    total = iddr["Total_Price"].ToString();
                    paid = iddr["Paid_Price"].ToString();
                    blnc = iddr["Balance"].ToString();
                    cusnom = iddr["Coustomer_No"].ToString();
                    paymethd = iddr["Payment_Method"].ToString();
                    grantota = iddr["Grande_total"].ToString();
                    disc = iddr["Discount"].ToString();
                    tax = iddr["Tax"].ToString();

                }

                SqlDataReader drcus = Invo.select_incus(cusnom);
                if (drcus.Read())
                {
                    fname = drcus["First_Name"].ToString();
                    lnme = drcus["Last_Name"].ToString();
                    add1 = drcus["Address_Line1"].ToString();
                    add2 = drcus["Address_Line2"].ToString();
                    mobl = drcus["Mobile"].ToString();
                }
                else
                {
                    fname = "N/A";
                    lnme = "N/A";
                    add1 = "N/A";
                    add2 = "N/A";
                    mobl = "N/A";

                }




                String ibsql = "SELECT*FROM tbl_Invoice_details WHERE Invoice_No='" + invoNo + "'";
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
                                Invo.insert_Invoice_Bill(invoNo, invodate, fname + " " + lnme, add1 + " " + add2, mobl, Convert.ToDecimal(grantota), Convert.ToDecimal(disc), Convert.ToDecimal(tax), Convert.ToDecimal(total), Convert.ToDecimal(paid), paymethd, Convert.ToDecimal(blnc), itmseril, itmctgy, itmsbctgy, itmbrnd, itmbrnd + " " + itmNme + " " + itmctgy + " " + itmsbctgy + " \nWarranty- " + itmwarrty, Convert.ToDecimal(Convert.ToDecimal(itsalepriz) / Convert.ToDecimal(iqty)), Convert.ToDecimal(iqty), Convert.ToDecimal(itsalepriz));

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
                            Invo.insert_Invoice_Bill(invoNo, invodate, fname + " " + lnme, add1 + " " + add2, mobl, Convert.ToDecimal(grantota), Convert.ToDecimal(disc), Convert.ToDecimal(tax), Convert.ToDecimal(total), Convert.ToDecimal(paid), paymethd, Convert.ToDecimal(blnc), itmseril, itmctgy, itmsbctgy, itmbrnd, itmbrnd + " " + itmNme + " " + itmctgy + " " + itmsbctgy + " \nWarranty- " + itmwarrty, Convert.ToDecimal(Convert.ToDecimal(itsalepriz) / Convert.ToDecimal(iqty)), Convert.ToDecimal(iqty), Convert.ToDecimal(itsalepriz));

                            //MessageBox.Show("Invoice bill add");
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message); }

                    }

                }

                Bill invoBil = new Bill();
                invoBil.Show();



            }
            catch (Exception) { }

            // else { toolTip_Invoice.Show("Plese Select Invoice For Print", dgv_Invoice, 1500); }
            
        }

        private void dateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {

            //ds = Invo.all_Invoice_date(dateTimePicker_From.Text,dateTimePicker_to.Text);
            //dgv_Invoice.DataSource = ds.Tables["tbl_Invoice"];



            ////string query = "SELECT * FROM tbl_Invoice WHERE Invoice_Date BETWEEN @SDate AND @EDate";<------------This Quert is Correct & Run----------->
            //string query = "SELECT * FROM tbl_Invoice WHERE Invoice_Date >= @SDate AND Invoice_Date <= @EDate";
            //SqlCommand cmd = new SqlCommand(query, ConnectionDB.Connection());
            //cmd.Parameters.AddWithValue("@SDate", dateTimePicker_From.Value);
            //cmd.Parameters.AddWithValue("@EDate", dateTimePicker_to.Value);
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //ds.Tables.Clear();
            //da.Fill(ds, "tbl_Invoice");
            //dgv_Invoice.DataSource = ds.Tables["tbl_Invoice"];
        }

        private void btnFindInvoCancel_Click(object sender, EventArgs e)
        {
            Main.p1.Controls.Clear();
            Find_Invoice invofind = new Find_Invoice();
            invofind.TopLevel = false;
            invofind.Visible = true;
            Main.p1.Controls.Add(invofind);
            Find_Invoice.dgvf.Columns["Description"].Width = 250;
        }

        private void txtFindInvoInvoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 

        }

        private void txtFindInvoBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void cbx_payComple_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        
        
       
        
    }
}
