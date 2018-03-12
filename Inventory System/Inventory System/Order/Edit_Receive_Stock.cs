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
    public partial class Edit_Receive_Stock : Form
    {
        SupAcc_update supA;
        public Edit_Receive_Stock(SupAcc_update supB)
        {
            InitializeComponent();
            supA = supB;
        }
        Supplier_DB_Operetion supOp=new Supplier_DB_Operetion();
        Sup_account_get getacDetails = new Sup_account_get();

        string stktyp;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible=false;

            Sup_account_get getacDetails = new Sup_account_get();
            getacDetails.sp_acNo = View_Suppliers.dgv.CurrentRow.Cells["Supplier_No"].Value.ToString();
            getacDetails.sp_acFnme = View_Suppliers.dgv.CurrentRow.Cells["First_Name"].Value.ToString();
            getacDetails.sp_acLnme = View_Suppliers.dgv.CurrentRow.Cells["Last_Name"].Value.ToString();
            getacDetails.sp_acBisnme = View_Suppliers.dgv.CurrentRow.Cells["Business_Name"].Value.ToString();
            getacDetails.sp_acMob = View_Suppliers.dgv.CurrentRow.Cells["Mobile"].Value.ToString();
            getacDetails.sp_acemail = View_Suppliers.dgv.CurrentRow.Cells["Email"].Value.ToString();

            Supplier_Account SupACC = new Supplier_Account(getacDetails);
            SupACC.ShowDialog(this);

        }

        private void Edit_Receive_Stock_Load(object sender, EventArgs e)
        {
            //--------------------------------Supplier_Account Close-----------------------------------//
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[1].Name == "Supplier_Account")

                {
                    Application.OpenForms[1].Close();
                }
            }
            //---------------------------------------------------------------------------------//



            lbl_s_no.Text = supA.stNo;
            dtp_AccUp.Text = supA.stDate;
            txtDiscription.Text = supA.st_descrip;
            txtPurchasePrice.Text = supA.purchPriz;
            lbl_totPaid.Text = supA.paid;
            txt_paid.Text = supA.paid;
            cbx_supp.Text = supA.stSup;
            cbx_pymetd.Text = supA.payMethd;
            txt_inme.Text = supA.nme;
            cbx_qty_ctgy.Text = supA.catgy;
            cbx_qty_S_ctgy.Text = supA.subcgy;
            cbx_qty_Brand.Text = supA.brand;
            cbx_itmtype.Text = supA.itype;
            txt_u_p_priz.Text = supA.un_piz;
            txt_u_s_priz.Text = supA.un_sal;
            numericUpDown1.Value = Convert.ToDecimal(supA.qqty);




            String sql = "SELECT*FROM tbl_AddS_Supplier";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_supp.Items.Add(ns.Rows[i]["Business_Name"]);
            }

//////////////////////////////////////////////////////////////////////////////////////
           SqlDataReader dr = supOp.selectB(lbl_s_no.Text);
           if (dr.Read())
           {




               string tot, paid, balnce;
               decimal tot1, paid1, balnce1;
               tot = dr["Purchase_Price"].ToString();
               paid =dr["Payment"].ToString();
               tot1 = decimal.Parse(tot);
               paid1 = decimal.Parse(paid);
               balnce1 = (tot1 - paid1);
               balnce = balnce1.ToString();

               lbl_old_blnc.Text = balnce;
               lbl_Balance.Text = "Rs : " + balnce;
               lblNew_paid.Text = "Rs : " + paid;
               if (balnce1 == 0)
               {
                   groupBox_pay.Enabled = false;
                   lbl_completed.Visible = true;
               
               }


           }




           String csql = "SELECT*FROM tbl_catogory";
           SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
           DataTable cdt = new DataTable();
           cget.Fill(cdt);
           for (int i = 0; i < cdt.Rows.Count; i++)
           {
               cbx_qty_ctgy.Items.Add(cdt.Rows[i]["catogory"]);
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




        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (radioButton_nmal.Checked) { stktyp = "Normal"; }
            if (radioButton_qty.Checked) { stktyp = "Quantity"; }

            try
            {
                if (dtp_AccUp.Text != ""   && cbx_pymetd.Text != "" && cbx_supp.Text != ""&& cbx_qty_ctgy.Text!=""&&cbx_qty_S_ctgy.Text!=""&&cbx_qty_Brand.Text!=""&& txt_paid.Text!="" && txt_u_p_priz.Text!=""&&txt_u_s_priz.Text!="" &&numericUpDown1.Value!=0 &&cbx_itmtype.Text!="")
                {
                    supOp.Update_SupAcc(lbl_s_no.Text, dtp_AccUp.Value, cbx_supp.Text, txtDiscription.Text, cbx_pymetd.Text, Convert.ToDecimal(txtPurchasePrice.Text), Convert.ToDecimal(txt_paid.Text), cbx_qty_ctgy.Text, cbx_qty_S_ctgy.Text, cbx_qty_Brand.Text, Convert.ToDecimal(txt_u_p_priz.Text), Convert.ToDecimal(txt_u_s_priz.Text), numericUpDown1.Value, cbx_itmtype.Text, stktyp);
                    MessageBox.Show("Stock Details Updated sucessfully","Sharp Creations",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    this.Visible = false;
                    Sup_account_get getacDetails = new Sup_account_get();
                    getacDetails.sp_acNo = View_Suppliers.dgv.CurrentRow.Cells["Supplier_No"].Value.ToString();
                    getacDetails.sp_acFnme = View_Suppliers.dgv.CurrentRow.Cells["First_Name"].Value.ToString();
                    getacDetails.sp_acLnme = View_Suppliers.dgv.CurrentRow.Cells["Last_Name"].Value.ToString();
                    getacDetails.sp_acBisnme = View_Suppliers.dgv.CurrentRow.Cells["Business_Name"].Value.ToString();
                    getacDetails.sp_acMob = View_Suppliers.dgv.CurrentRow.Cells["Mobile"].Value.ToString();
                    getacDetails.sp_acemail = View_Suppliers.dgv.CurrentRow.Cells["Email"].Value.ToString();

                    Supplier_Account SupACC = new Supplier_Account(getacDetails);
                    SupACC.ShowDialog(this);

                }

                else
                {
                    errorProvider1.SetError(cbx_supp, "");
                    errorProvider2.SetError(txtDiscription, "");
                    
                    errorProvider5.SetError(cbx_pymetd, "");
                    errorProvider6.SetError(dtp_AccUp, "");


                    if (dtp_AccUp.Text == "")
                    {
                        errorProvider6.SetError(dtp_AccUp, "Enter supplier city ");
                    }
                    else { }



                    

                    

                    if (cbx_supp.Text == "")
                    {
                        errorProvider1.SetError(cbx_supp, "Choose Supplier Name ");
                    }
                    else { }


                    if (cbx_pymetd.Text == "")
                    {
                        errorProvider5.SetError(cbx_pymetd, "Choose Paid Method ");
                    }
                    else { }


                
                }
            }




            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Sup_account_get getacDetails = new Sup_account_get();
            getacDetails.sp_acNo = View_Suppliers.dgv.CurrentRow.Cells["Supplier_No"].Value.ToString();
            getacDetails.sp_acFnme = View_Suppliers.dgv.CurrentRow.Cells["First_Name"].Value.ToString();
            getacDetails.sp_acLnme = View_Suppliers.dgv.CurrentRow.Cells["Last_Name"].Value.ToString();
            getacDetails.sp_acBisnme = View_Suppliers.dgv.CurrentRow.Cells["Business_Name"].Value.ToString();
            getacDetails.sp_acMob = View_Suppliers.dgv.CurrentRow.Cells["Mobile"].Value.ToString();
            getacDetails.sp_acemail = View_Suppliers.dgv.CurrentRow.Cells["Email"].Value.ToString();

            Supplier_Account SupACC = new Supplier_Account(getacDetails);
            SupACC.ShowDialog(this);
        }

        private void btn_add_pyment_Click(object sender, EventArgs e)
        {
            try
            {



                SqlDataReader dr = supOp.selectB(lbl_s_no.Text);
                if (dr.Read())
                {
                    if (txt_new_paid.Text != "")
                    {

                        try
                        {

                            string nwPaid, paid, balnce, tot;
                            decimal nwpd, pd, blnc, balnce1;

                            tot = dr["Purchase_Price"].ToString();
                            paid = dr["Payment"].ToString();
                            balnce1 = Convert.ToDecimal(tot) - Convert.ToDecimal(paid);
                            nwPaid = txt_new_paid.Text;

                            nwpd = decimal.Parse(nwPaid);
                            pd = decimal.Parse(paid);
                            blnc = (nwpd + pd);
                            balnce = blnc.ToString();
                            if (nwpd <= balnce1)
                            {

                                supOp.update_paid(Convert.ToDecimal(balnce), lbl_s_no.Text);
                                MessageBox.Show("Stock Payment Updated Sucessfuly", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                            else { toolTip1.Show("Enter Correct currency value", txt_new_paid, 3000); }

                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("Enter Currency Correctly");
                            toolTip1.Show("Enter Correct currency value", txt_new_paid, 3000);
                        }
                    }

                    else
                    {
                        toolTip1.Show("Enter Correct currency value", txt_new_paid, 3000);
                        //MessageBox.Show("Enter Currency");
                    }
                }

                //------------------------------------------------------------------------------------------------------//


                SqlDataReader drr = supOp.selectNB(lbl_s_no.Text);
                if (drr.Read())
                {
                    string tot, paid, balnce;
                    decimal tot1, paid1, balnce1;
                    tot = drr["Purchase_Price"].ToString();
                    paid = drr["Payment"].ToString();
                    tot1 = decimal.Parse(tot);
                    paid1 = decimal.Parse(paid);
                    balnce1 = (tot1 - paid1);
                    balnce = balnce1.ToString();

                    lbl_Balance.Text = "";
                    lblNew_paid.Text = "";
                    lbl_Balance.Text = "Rs : " + balnce;
                    lblNew_paid.Text = "Rs : " + paid;


                    if (tot == paid)
                    {
                        txt_new_paid.Clear();
                        lbl_completed.Visible = true;
                        groupBox_pay.Enabled = false;
                    }
                    else
                    {
                        txt_new_paid.Clear();
                        lbl_completed.Visible = false;
                        groupBox_pay.Enabled = true;
                    }

                }
                //--------------------------------------------------------------------------------------------//


                btnok.Enabled = false;
            }
            catch (Exception) { }
        }

        private void btn_kk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;

                Sup_account_get getacDetails = new Sup_account_get();
                getacDetails.sp_acNo = View_Suppliers.dgv.CurrentRow.Cells["Supplier_No"].Value.ToString();
                getacDetails.sp_acFnme = View_Suppliers.dgv.CurrentRow.Cells["First_Name"].Value.ToString();
                getacDetails.sp_acLnme = View_Suppliers.dgv.CurrentRow.Cells["Last_Name"].Value.ToString();
                getacDetails.sp_acBisnme = View_Suppliers.dgv.CurrentRow.Cells["Business_Name"].Value.ToString();
                getacDetails.sp_acMob = View_Suppliers.dgv.CurrentRow.Cells["Mobile"].Value.ToString();
                getacDetails.sp_acemail = View_Suppliers.dgv.CurrentRow.Cells["Email"].Value.ToString();

                Supplier_Account SupACC = new Supplier_Account(getacDetails);
                SupACC.ShowDialog(this);
            }
            catch (Exception) { }
        }

        private void txt_new_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                
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

        private void cbx_supp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip1.Show("Plase enter Number and Caractor!", txtDiscription, 0, -50, 700);
                e.Handled = true;
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
