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
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        Supplier_DB_Operetion suppOp = new Supplier_DB_Operetion();
        Regex reg_mobile = new Regex("^[0-9X]{10}$");
        Regex reg_names = new Regex(@"^[a-zA-Z0-9 ]+$");
        Regex reg_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public static TextBox tx_fnnms = new TextBox();

        private void btnAddSuppAdd_Click(object sender, EventArgs e)
        {
            ep_cty.SetError(txtAddSuppCity, "");
            ep_bisname.SetError(txtAddSuppBsinessName, "");
            ep_email.SetError(txtAddSuppEmail, "");
            ep_fname.SetError(txtAddSuppFirstName, "");
            ep_lname.SetError(txtAddSuppLastName, "");
            ep_mobil.SetError(txtAddSuppMobile, "");


            try
            {
                if (txtAddSuppFirstName.Text != "" && txtAddSuppLastName.Text != "" && txtAddSuppBsinessName.Text != "" && txtAddSuppCity.Text != "" && txtAddSuppMobile.Text != "" && txtAddSuppEmail.Text != "")
                {
                    if (reg_mobile.IsMatch(txtAddSuppMobile.Text) && reg_email.IsMatch(txtAddSuppEmail.Text))
                    {
                        suppOp.insert(lbl_supNo.Text, txtAddSuppFirstName.Text, txtAddSuppLastName.Text, txtAddSuppBsinessName.Text, txtAddSuppAddLine1.Text, txtAddSuppAddLine2.Text, txtAddSuppCity.Text, txtAddSuppPhone.Text, txtAddSuppMobile.Text, txtAddSuppFax.Text, txtAddSuppZipPostalCode.Text, txtAddSuppEmail.Text, txtAddSuppNotes.Text);
                        if (MessageBox.Show("Supplier Added Successfuly.", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Main.p1.Controls.Clear();
                            Add_Supplier d1 = new Add_Supplier();
                            d1.TopLevel = false;
                            d1.Visible = true;
                            Main.p1.Controls.Add(d1);
                        
                        }
                    }
                    else 
                    {
                        if (!reg_email.IsMatch(txtAddSuppEmail.Text))
                        { toolTip_check.Show("Invalid Email!", txtAddSuppEmail, 0, -50, 1000); }

                        if (!reg_mobile.IsMatch(txtAddSuppMobile.Text))
                        { toolTip_check1.Show("Incorrect Mobile Number!", txtAddSuppMobile, 0, -50, 1000); }
                    
                    }
                }

                else
                {
                    

                        tp_error.Show("Enter details to Add Supplier ", btnAddSuppAdd, 4000);


                    if (txtAddSuppCity.Text == "")
                    {
                      ep_cty.SetError(txtAddSuppCity, "Enter supplier city ");
                    }
                        

                    if (txtAddSuppBsinessName.Text == "")
                    {
                        ep_bisname.SetError(txtAddSuppBsinessName, "Enter supplier Bisness name ");
                    }
                    

                    if (txtAddSuppEmail.Text == "")
                    {
                        ep_email.SetError(txtAddSuppEmail, "Enter Email ");
                    }
                   

                    if (txtAddSuppFirstName.Text == "")
                    {
                        ep_fname.SetError(txtAddSuppFirstName, "Enter First Name");
                    }
                   

                    if (txtAddSuppLastName.Text == "")
                    {
                        ep_lname.SetError(txtAddSuppLastName, "Enter Last Name ");
                    }
                   

                    if (txtAddSuppMobile.Text == "")
                    {
                        ep_mobil.SetError(txtAddSuppMobile, "Enter Mobile ");
                    }
                   
                }
            }
            catch (Exception )
            { MessageBox.Show("Enter Correct Data ","Sharp Creation",MessageBoxButtons.OK,MessageBoxIcon.Error); }

            //Main.p1.Controls.Clear();
            //Add_Supplier d1 = new Add_Supplier();
            //d1.TopLevel = false;
            //d1.Visible = true;
            //Main.p1.Controls.Add(d1);
        }

        private void btnAddSuppCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddSuppZipPostalCode_TextChanged(object sender, EventArgs e)
        {
            txtAddSuppZipPostalCode.MaxLength = 10;
        }

        private void txtAddSuppFirstName_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Add_Supplier_Load(object sender, EventArgs e)
        {
            int iNo;
            string rNo = suppOp.Suppno();
            if (rNo.Equals("") || rNo == null)
            {
                iNo = 001000;
            }
            else
            {
                iNo = Convert.ToInt32(rNo);
                iNo = iNo + 1;

            }
            lbl_supNo.Text = Convert.ToString(iNo);

            tx_fnnms = txtAddSuppFirstName;
        }

        private void btnAddSuppReset_Click(object sender, EventArgs e)
        {
            //------------clear all textbox.text-----------------
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

            ep_cty.SetError(txtAddSuppCity, "");
            ep_bisname.SetError(txtAddSuppBsinessName, "");
            ep_email.SetError(txtAddSuppEmail, "");
            ep_fname.SetError(txtAddSuppFirstName, "");
            ep_lname.SetError(txtAddSuppLastName, "");
            ep_mobil.SetError(txtAddSuppMobile, "");
        }

        private void txtAddSuppFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddSuppFirstName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddSuppLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddSuppLastName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddSuppBsinessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddSuppBsinessName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddSuppAddLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddSuppAddLine1, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddSuppAddLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddSuppAddLine2, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddSuppCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddSuppCity, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddSuppPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 ))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid phone", txtAddSuppPhone, 0, -50, 2000);
                return;
            }
        }

        private void txtAddSuppMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Mobil", txtAddSuppMobile, 0, -50, 2000);
                return;
            }
        }

        private void txtAddSuppFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Fax", txtAddSuppFax, 0, -50, 2000);
                return;
            }
        }

        private void txtAddSuppZipPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Zip Code", txtAddSuppFax, 0, -50, 2000);
                return;
            }
        }

        private void txtAddSuppEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAddSuppNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txtAddSuppNotes, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtAddSuppMobile_TextChanged(object sender, EventArgs e)
        {
            txtAddSuppMobile.MaxLength = 10;
        }

        private void txtAddSuppPhone_TextChanged(object sender, EventArgs e)
        {
            txtAddSuppPhone.MaxLength = 10;
        }

        private void txtAddSuppFax_TextChanged(object sender, EventArgs e)
        {
            txtAddSuppFax.MaxLength = 10;
        }

        
    }
}
