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
    public partial class Add_Warranty : Form
    {
        public Add_Warranty()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dtbl = new DataTable();
        Warranty_DB_Operetion wrty = new Warranty_DB_Operetion();
        public static TextBox tx_bcds = new TextBox();
        public static DataGridView dgvaddw = new DataGridView();
        Regex reg_names = new Regex(@"^[a-zA-Z0-9 ]+$");

        private void Add_Warranty_Load(object sender, EventArgs e)
        {
            tx_bcds = txt_barcode;

            


            ds = wrty.each_Item("Ok","N/A");
            dgv_addwarty.DataSource = ds.Tables["tbl_Invoice_details"];
            dgvaddw = dgv_addwarty;

            
            //for (int ii = 0; ii < dgv_addwarty.Rows.Count; ii++)
            //{

            //    if (Convert.ToString(dgv_addwarty.Rows[ii].Cells["Status"].Value) != "Ok")
            //    {
            //        dgv_addwarty.Rows[ii].Visible = false;
            //    }
            //}

        }

        private void txt_invoNo_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Invoice_No,Invoice_Date,Item_No,Item_Name,Serial_No,Barcode,Sales_Price,Catogory,Sub_Catogory,Brande,Warranty,Supplier FROM tbl_Invoice_details WHERE Status='" + "Ok" + "'AND Serial_No !='" + "N/A" + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_addwarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Invoice_No like '%" + txt_invoNo.Text + "%' ";
            dgv_addwarty.DataSource = dv;
        }

        private void txt_serial_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Invoice_No,Invoice_Date,Item_No,Item_Name,Serial_No,Barcode,Sales_Price,Catogory,Sub_Catogory,Brande,Warranty,Supplier FROM tbl_Invoice_details WHERE Status='" + "Ok" + "'AND Serial_No !='" + "N/A" + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_addwarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Serial_No like '%" + txt_serial.Text + "%' ";
            dgv_addwarty.DataSource = dv;

        }

        private void txt_itmnme_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Invoice_No,Invoice_Date,Item_No,Item_Name,Serial_No,Barcode,Sales_Price,Catogory,Sub_Catogory,Brande,Warranty,Supplier FROM tbl_Invoice_details WHERE Status='" + "Ok" + "'AND Serial_No !='" + "N/A" + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_addwarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Item_Name like '%" + txt_itmnme.Text + "%' ";
            dgv_addwarty.DataSource = dv;


        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Invoice_No,Invoice_Date,Item_No,Item_Name,Serial_No,Barcode,Sales_Price,Catogory,Sub_Catogory,Brande,Warranty,Supplier FROM tbl_Invoice_details WHERE Status='" + "Ok" + "'AND Serial_No !='" + "N/A" + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgv_addwarty.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Barcode like '%" + txt_barcode.Text + "%' ";
            dgv_addwarty.DataSource = dv;


        }

        private void dgv_addwarty_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lbl_wExp.Visible = false;
           


            try
            {

                lbl_invoNo.Text = dgv_addwarty.CurrentRow.Cells["Invoice_No"].Value.ToString();
                lbl_itmNo.Text = dgv_addwarty.CurrentRow.Cells["Item_No"].Value.ToString();
                lbl_itmNme.Text = dgv_addwarty.CurrentRow.Cells["Item_Name"].Value.ToString();
                lbl_warty.Text = dgv_addwarty.CurrentRow.Cells["Warranty"].Value.ToString();
                lbl_supp.Text = dgv_addwarty.CurrentRow.Cells["Supplier"].Value.ToString();


                DateTime wty = DateTime.Parse(dgv_addwarty.CurrentRow.Cells["Invoice_Date"].Value.ToString());
                //DateTime expWty = wty.AddYears(3);
                DateTime today = DateTime.Today;
                lbl_wrtyFrom.Text = wty.ToShortDateString();

                SqlDataReader cdr = wrty.select_cusNo(lbl_invoNo.Text);
                if (cdr.Read())
                {
                    string ccno = cdr["Coustomer_No"].ToString();


                    SqlDataReader cusdr = wrty.select_cus(ccno);
                    if (cusdr.Read())
                    {
                        txt_cusNm.Text = cusdr["First_Name"].ToString();
                        txt_cusMob.Text = cusdr["Mobile"].ToString();


                    }
                    else
                    {
                        txt_cusNm.Text = "N/A";
                        txt_cusMob.Text = "N/A";
                    }

                }


                //================================================================================================================//
                if (dgv_addwarty.CurrentRow.Cells["Warranty"].Value.ToString() != "No Warranty")
                {
                    try
                    {


                        string wrny = dgv_addwarty.CurrentRow.Cells["Warranty"].Value.ToString();
                        string[] warray = wrny.Split(' ');
                        string wtyNo = warray[0].ToString();
                        string wtyDu = warray[1].ToString();

                        if (wtyDu == "Years")
                        {
                            DateTime expWty = wty.AddYears(int.Parse(wtyNo));
                            lbl_wrtyTo.Text = expWty.ToShortDateString();
                            if (expWty < today)
                            { lbl_wExp.Visible = true; }

                        }

                        if (wtyDu == "Months")
                        {
                            DateTime expWty = wty.AddMonths(int.Parse(wtyNo));
                            lbl_wrtyTo.Text = expWty.ToShortDateString();
                            if (expWty < today)
                            { lbl_wExp.Visible = true; }


                        }

                        if (wtyDu == "Days")
                        {
                            DateTime expWty = wty.AddDays(int.Parse(wtyNo));
                            lbl_wrtyTo.Text = expWty.ToShortDateString();
                            if (expWty < today)
                            { lbl_wExp.Visible = true; }


                        }

                        if (wtyDu == "Weeks")
                        {
                            int wekday = int.Parse(wtyNo) * 7;
                            DateTime expWty = wty.AddDays(wekday);
                            lbl_wrtyTo.Text = expWty.ToShortDateString();
                            if (expWty < today)
                            { lbl_wExp.Visible = true; }

                        }
                    }

                    catch (Exception)

                    { tp_itmeeror.Show("Select Item to view Details", lbl_itmNo, 2000); }
                }
                else
                {
                    lbl_warty.Text = "No Warranty";
                }
            }
            catch(Exception )
            {}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_type.SelectedItem.ToString() == "Change")
            {
                if (lbl_invoNo.Text != "")
                {
                    txt_descript.Visible = false;
                    Return_New_item retunitm = new Return_New_item();
                    retunitm.ShowDialog();
                    Return_New_item.tx_brdz.Focus();
                }
                else { toolTip2.Show("Plese Select Item To Change", lbl_invoNo,-10,-10,2500); }
            }

            if (cbx_type.SelectedItem.ToString() == "Warranty")
            {
                txt_descript.Visible = true;
            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_descript,"");
            errorProvider2.SetError(cbx_type, "");
            if (cbx_type.Text != "")
            {

               
                if (cbx_type.Text == "Warranty")
                {

                    if (lbl_invoNo.Text != "")
                    {

                        string wtysrial = dgv_addwarty.CurrentRow.Cells["Serial_No"].Value.ToString();
                        string wtybcode = dgv_addwarty.CurrentRow.Cells["Barcode"].Value.ToString();

                        try
                        {
                            int iNo;
                            string rNo = wrty.AutoWrtyno();
                            if (rNo.Equals("") || rNo == null)
                            {
                                iNo = 001000;
                            }
                            else
                            {
                                iNo = Convert.ToInt32(rNo);
                                iNo = iNo + 1;

                            }
                            if (lbl_invoNo.Text != "")
                            {
                                if (dgv_addwarty.CurrentRow.Cells["Warranty"].Value.ToString() != "No Warranty")
                                {



                                    if (lbl_wExp.Visible == false)
                                    {



                                        if ((txt_descript.Text != "  Enter Warranty Description........") && (txt_descript.Text != ""))
                                        {
                                            if (reg_names.IsMatch(txt_descript.Text))
                                            {

                                                wrty.addWarranty(iNo.ToString(), lbl_invoNo.Text, lbl_itmNo.Text, lbl_itmNme.Text, wtysrial, wtybcode, lbl_supp.Text, lbl_wrtyFrom.Text, lbl_wrtyTo.Text, txt_cusNm.Text, txt_cusMob.Text, txt_descript.Text, "InComplete", "");
                                                wrty.update_item_status(dgv_addwarty.CurrentRow.Cells["Invoice_No"].Value.ToString(), dgv_addwarty.CurrentRow.Cells["Item_No"].Value.ToString(), "Warranty");

                                                if (MessageBox.Show(dgv_addwarty.CurrentRow.Cells["Brande"].Value.ToString() + " " + dgv_addwarty.CurrentRow.Cells["Sub_Catogory"].Value.ToString() + " " + dgv_addwarty.CurrentRow.Cells["Catogory"].Value.ToString() + " Add to Warranry", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                                {
                                                    this.Close();
                                                }
                                            }
                                            else { toolTip1.Show("Enter Description  in alphanumeric characters", txt_descript, 50, -50, 3000); }
                                        }
                                        else
                                        {
                                            errorProvider1.SetError(txt_descript, "Enter warranty details");
                                        }


                                    }


                                    else
                                    {

                                        if (MessageBox.Show("This Item Warranty Was Expired   \nDo you Want to Add warranty..?", "Sharp Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                        {


                                            if ((txt_descript.Text != "  Enter Warranty Description........") && (txt_descript.Text != ""))
                                            {
                                                if (reg_names.IsMatch(txt_descript.Text))
                                                {

                                                    wrty.addWarranty(iNo.ToString(), lbl_invoNo.Text, lbl_itmNo.Text, lbl_itmNme.Text, wtysrial, wtybcode, lbl_supp.Text, lbl_wrtyFrom.Text, lbl_wrtyTo.Text, txt_cusNm.Text, txt_cusMob.Text, txt_descript.Text, "InComplete", "");
                                                    if (MessageBox.Show(dgv_addwarty.CurrentRow.Cells["Brande"].Value.ToString() + " " + dgv_addwarty.CurrentRow.Cells["Sub_Catogory"].Value.ToString() + " " + dgv_addwarty.CurrentRow.Cells["Catogory"].Value.ToString() + " Add to Warranry", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                                    {
                                                        this.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    toolTip1.Show("Enter Description  in alphanumeric characters", txt_descript, 3000);
                                                }
                                            }
                                            else
                                            {
                                                errorProvider1.SetError(txt_descript, "Enter warranty details");
                                            }
                                        }
                                    }

                                }
                                else { MessageBox.Show("This item hasn't Warranty", "Sharp Creations", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                            }
                            else { toolTip2.Show("Plese Select Item To Add Warranty", lbl_invoNo, 3000); }

                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message); }
                    }
                    else { toolTip2.Show("Plese Select Item To Add Warranty", lbl_invoNo, -10, -10, 2500); }

                }
                else if (cbx_type.Text == "Change")
                {
                    this.Close();
                }
            }
            else { errorProvider2.SetError(cbx_type, "select Warranty or Change"); }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_descript_Click(object sender, EventArgs e)
        {
            txt_descript.Clear();
        }

        private void txt_descript_MouseLeave(object sender, EventArgs e)
        {
            if (txt_descript.Text == "")
            {
                txt_descript.Text = "  Enter Warranty Description........";
            }
        }

        private void txt_descript_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void cbx_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_descript_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip1.Show("Plase enter Number and Caractor!", txt_descript, 1, 1, 700);
                e.Handled = true;
            } 
        }

        private void txt_invoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
               e.Handled = true;
            } 
        }

        private void txt_serial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void txt_itmnme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                
                e.Handled = true;
            } 

        }

        private void txt_cusNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_cusNm, 1, 1, 1000);
                e.Handled = true;
            } 
        }

        private void txt_cusMob_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Mobile Number", txt_cusMob, 1, 1, 1000);
                return;
            }
        }

        private void txt_cusMob_TextChanged(object sender, EventArgs e)
        {
            txt_cusMob.MaxLength = 10;
        }

        
        

       
       

        
    }

}
