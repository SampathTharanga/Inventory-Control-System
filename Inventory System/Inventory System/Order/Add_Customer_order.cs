using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Inventory_System
{
    public partial class Add_Customer_order : Form
    {
        public Add_Customer_order()
        {
            InitializeComponent();
        }

        Order_DB_Operetion odr = new Order_DB_Operetion();
        int cNo;
        Regex reg_mobile = new Regex("^[0-9X]{10}$");

        private void Add_Customer_order_Load(object sender, EventArgs e)
        {
            //------------set maxNo+1 to lblOrderNo----------------//
            string rNo = odr.cusodr_no();
            if (rNo.Equals("") || rNo == null)
            {
                cNo = 001000;
            }
            else
            {
                cNo = Convert.ToInt32(rNo);
                cNo = cNo + 1;

            }
            lblOrderNo.Text = Convert.ToString(cNo);
            //---------------------------------------------------------------//

            //txtOrderDate.Text = (DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day).ToString();





        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ep_nm.SetError(txtName, "");
            ep_mob.SetError(txtMobile, "");
            ep_dis.SetError(txtDiscription, "");
            try
            {

                if (txtName.Text != "" && txtMobile.Text != "" && txtDiscription.Text != "")
                {
                    if (reg_mobile.IsMatch(txtMobile.Text))
                    {
                        odr.insert(lblOrderNo.Text, dateT_p.Text, txtName.Text, txtMobile.Text, txtDiscription.Text);
                        if (MessageBox.Show("Customer Order Added", "Sharp Cration", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        { this.Close(); }
                    }
                    else { toolTip_check.Show("Invalid Mobile", txtMobile, 0, -50, 1000); }
                }
                else
                {
                    if (txtName.Text == "")
                    {
                        ep_nm.SetError(txtName, "Enter Customer's Name");
                    }
                    if (txtMobile.Text == "")
                    {
                        ep_mob.SetError(txtMobile, "Enter Customer's Mobile");
                    }

                    if (txtDiscription.Text == "")
                    {

                        ep_dis.SetError(txtDiscription, "Enter Order Description");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 )
            {
                e.Handled = true;
            } 
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Mobil", txtMobile, 0, -50, 1000);
                return;
            }
        }

        private void txtDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && !char.IsWhiteSpace(e.KeyChar))
            {
               
                e.Handled = true;
            } 
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            txtMobile.MaxLength = 10;
        }

        
    }
}
