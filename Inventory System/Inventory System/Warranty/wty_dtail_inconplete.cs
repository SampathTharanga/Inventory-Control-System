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
    public partial class wty_dtail_inconplete : Form
    {
        public wty_dtail_inconplete()
        {
            InitializeComponent();
        }


        DataSet ds = new DataSet();
        DataTable dtbl = new DataTable();
        Warranty_DB_Operetion wrty = new Warranty_DB_Operetion();
        Invoive_DB_Operetion Invo = new Invoive_DB_Operetion();
        string iinnvvoo, iittmmoo;
        public static string salPriz;
        public static bool bt_save,newItm,anorItm;
        public static Button btClick_save = new Button();



        private void wty_dtail_inconplete_Load(object sender, EventArgs e)
        {
            btClick_save = btn_save;  

        }


        private void cbx_wtyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_wtyCheck.Checked == true)
            {
                cbx_wrycond.Enabled = true;
                btn_save.Enabled = true;
            }
            else
            {
                cbx_wrycond.Enabled = false;
                btn_save.Enabled = false;
            }

          
          

        }

        private void cbx_wrycond_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider_selet.SetError(cbx_wrycond,"");

            if (cbx_wrycond.Text == "Another Item")
            {
                warranty_newItem wnew = new warranty_newItem();
                wnew.ShowDialog();
            }

            else if (cbx_wrycond.Text == "New Item")
            {
              
                iinnvvoo = Warranty_Details.dgvw.CurrentRow.Cells["Invoice_No"].Value.ToString();
                iittmmoo = Warranty_Details.dgvw.CurrentRow.Cells["Item_No"].Value.ToString();

                SqlDataReader ddrr = Invo.select_itmPriz(iinnvvoo, iittmmoo);
                if (ddrr.Read())
                {
                   // MessageBox.Show(ddrr["Sales_Price"].ToString());
                salPriz= ddrr["Sales_Price"].ToString();


                    Return_stock_item rnstok = new Return_stock_item();
                    rnstok.ShowDialog();
                    Return_stock_item.tx_berd.Focus();

                }


            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //int di = Warranty_Details.dgvw.CurrentRow.Index;
            if (cbx_wrycond.Text == "Item Rapaired")
            {
                wrty.updt_waty(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString(), cbx_wrycond.Text, "Complete");
                //MessageBox.Show("Updte");
                wrty.update_item_status(Warranty_Details.dgvw.CurrentRow.Cells["Invoice_No"].Value.ToString(), Warranty_Details.dgvw.CurrentRow.Cells["Item_No"].Value.ToString(), "Ok");
                // MessageBox.Show("update oled invo");
                if (MessageBox.Show("Warranty Completed ", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ds = wrty.allWarty();
                    Warranty_Details.dgvw.DataSource = ds.Tables["tbl_Warranty"];


                    Warranty_Details.ppw.Controls.Clear();
                    wty_dtail_Conplete comte = new wty_dtail_Conplete();
                    comte.TopLevel = false;
                    comte.Visible = true;
                    Warranty_Details.ppw.Controls.Add(comte);


                }
            }

            else if (cbx_wrycond.Text == "Another Item")
            {
                if (anorItm == true)
                {
                    wrty.updt_waty(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString(), cbx_wrycond.Text, "Complete");
                    // MessageBox.Show("Updte");
                    if (MessageBox.Show("Warranty Completed ", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ds = wrty.allWarty();
                        Warranty_Details.dgvw.DataSource = ds.Tables["tbl_Warranty"];


                        Warranty_Details.ppw.Controls.Clear();
                        wty_dtail_Conplete comte = new wty_dtail_Conplete();
                        comte.TopLevel = false;
                        comte.Visible = true;
                        Warranty_Details.ppw.Controls.Add(comte);


                    }
                }
                else
                {
                    cbx_wrycond.SelectedItem = null;
                    toolTip_selet.Show("Enter item details \nThat is use to Complete this warranty", cbx_wrycond, 2500);
                    errorProvider_selet.SetError(cbx_wrycond, "Enter item details \nThat is use to Complete this warranty");
                
                }
            }

            else if (cbx_wrycond.Text == "New Item")
            {
                if (newItm == true)
                {
                    wrty.updt_waty(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString(), cbx_wrycond.Text, "Complete");
                    //MessageBox.Show("Updte");
                    if (MessageBox.Show("Warranty Completed ", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ds = wrty.allWarty();
                        Warranty_Details.dgvw.DataSource = ds.Tables["tbl_Warranty"];


                        Warranty_Details.ppw.Controls.Clear();
                        wty_dtail_Conplete comte = new wty_dtail_Conplete();
                        comte.TopLevel = false;
                        comte.Visible = true;
                        Warranty_Details.ppw.Controls.Add(comte);


                    }
                    
                }
                else
                {
                    cbx_wrycond.SelectedItem = null;
                    toolTip_selet.Show("Enter item details from stock \nThat is use to Complete this warranty", cbx_wrycond, 2500);
                    errorProvider_selet.SetError(cbx_wrycond, "Enter item details from stock \nThat is use to Complete this warranty");

                }
               
            }


           

          bt_save = false;
        }

        private void wty_dtail_inconplete_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void wty_dtail_inconplete_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Return_stock_item.btn_warrtySave == true)
            //{
            //    bt_save = true;
            //}
            //if (bt_save == true)
            //{
            //    if (MessageBox.Show("Save change and exit", "Sharp creation", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            //    {
            //        //int di = Warranty_Details.dgvw.CurrentRow.Index;
            //        if (cbx_wrycond.Text == "Item Rapaired")
            //        {
            //            wrty.updt_waty(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString(), cbx_wrycond.Text, "Complete");
            //            //MessageBox.Show("Updte");
            //        }

            //        else if (cbx_wrycond.Text == "Another Item")
            //        {
            //            wrty.updt_waty(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString(), cbx_wrycond.Text, "Complete");
            //            // MessageBox.Show("Updte");
            //        }

            //        else if (cbx_wrycond.Text == "New Item")
            //        {
            //            wrty.updt_waty(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString(), cbx_wrycond.Text, "Complete");
            //            ///MessageBox.Show("Updte");
            //        }



            //    }
            //}
            //bt_save = false;
            //Return_stock_item.btn_warrtySave = false;
        }

        

       

        
    }
}
