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
    public partial class Invoice_Details : Form
    {
        public Invoice_Details()
        {
            InitializeComponent();
        }


        DataSet ds;

        Invoive_DB_Operetion Invo = new Invoive_DB_Operetion();
        Customer_DB_Operation NoAuto = new Customer_DB_Operation();
        string pad, toot;
        decimal balce_c;
        string pymnt;

        private void Invoice_Details_Load(object sender, EventArgs e)
        {
            string invono = Find_Invoice.dgvf.CurrentRow.Cells["Invoice_No"].Value.ToString();
            string invoDte = Find_Invoice.dgvf.CurrentRow.Cells["Invoice_Date"].Value.ToString();
            string invocus = Find_Invoice.dgvf.CurrentRow.Cells["Coustomer_No"].Value.ToString();
            lbl_invoNo.Text = invono;
            lbl_invoDate.Text = invoDte;
           

            SqlDataReader cdr = Invo.select_incus(invocus);
            if (cdr.Read())
            {
                lbl_fstNme.Text = cdr["First_Name"].ToString();
                lbl_LstNme.Text = cdr["Last_Name"].ToString();
                lbl_mob.Text = cdr["Mobile"].ToString();
                lbl_email.Text = cdr["Email"].ToString();

            }
            else
            {
                lbl_fstNme.Text = "N/A";
                lbl_LstNme.Text = "N/A";
                lbl_mob.Text = "N/A";
                lbl_email.Text = "N/A";
            }

            SqlDataReader idr = Invo.select_invoNo(invono);
            if (idr.Read())
            {
                lbl_grndT.Text = idr["Grande_total"].ToString();
                lbl_Dis.Text = idr["Discount"].ToString();
                lbl_tax.Text = idr["Tax"].ToString();
                pad = idr["Paid_Price"].ToString();
                toot = idr["Total_Price"].ToString();

                decimal balce = Convert.ToDecimal(toot) - Convert.ToDecimal(pad);
                lbl_balce.Text = balce.ToString();
                lbl_paid.Text = pad;
                lbl_tot.Text = toot;
            }


            ds = Invo.each_Item(invono);
            dgv_Invo_details.DataSource = ds.Tables["tbl_Invoice_details"];


            if (lbl_paid.Text == lbl_tot.Text)
            { 
                lbl_wrtyComplte.Visible = true;
                panel_nPmt.Enabled = false;
            }

           

        }




      

        private void btn_addPayment_Click(object sender, EventArgs e)
        {
            try
            {
                balce_c = 0; pad = ""; toot = ""; pymnt = "";


                SqlDataReader idr = Invo.select_invoNo(lbl_invoNo.Text);
                if (idr.Read())
                {

                    pad = idr["Paid_Price"].ToString();
                    toot = idr["Total_Price"].ToString();
                    balce_c = Convert.ToDecimal(toot) - Convert.ToDecimal(pad);




                    try
                    {
                        decimal dOutput;
                        if (txt_newPay.Text != "" && decimal.TryParse(txt_newPay.Text, out dOutput))
                        {
                            if (Convert.ToDecimal(txt_newPay.Text) <= balce_c)
                            {

                                decimal totPaid = decimal.Parse(txt_newPay.Text) + decimal.Parse(pad);
                                lbl_Newpaid.Text = totPaid.ToString();
                                lbl_newPyment.Text = txt_newPay.Text;
                                lbl_Newbalce.Text = (decimal.Parse(lbl_tot.Text) - totPaid).ToString();

                                if (lbl_Newpaid.Text == lbl_tot.Text)
                                { lbl_wrtyComplte.Visible = true; panel_nPmt.Enabled = false; pymnt = "Ok"; }
                                else { pymnt = "Not Complete"; }
                                

                                Invo.Updte_Invo_Payment(lbl_invoNo.Text, totPaid, Convert.ToDecimal(lbl_Newbalce.Text), pymnt);
                                MessageBox.Show("New Payment added Sucessfully", "Sharp Creations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_newPay.Clear();


                            }
                            else { tp_itmeeror.Show("Invalid Payment", txt_newPay, 1000); }
                        }
                        else { tp_itmeeror.Show("Enter New Payment", txt_newPay, 1000); }
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }



                }
            }
            catch (Exception) { }
        
            


           
            

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Invo_details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_return.Visible = false;
            lbl_chge.Visible = false;

            if (dgv_Invo_details.CurrentRow.Cells["Status"].Value.ToString() == "Return")
            {
                lbl_return.Visible = true;
            }

            if (dgv_Invo_details.CurrentRow.Cells["Status"].Value.ToString() == "Changed")
            {
                lbl_chge.Visible = true;
            }
        }

        private void txt_newPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                tp_itmeeror.Show("Invalid Payment", txt_newPay, 0, -50, 2000);
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
