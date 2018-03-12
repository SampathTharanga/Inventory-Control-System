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
    public partial class Advance_Customer : Form
    {
        public Advance_Customer()
        {
            InitializeComponent();
        }


        Customer_DB_Operation CusOp = new Customer_DB_Operation();
        Regex reg_mobile = new Regex("^[0-9X]{10}$");
        Regex reg_names = new Regex(@"^[a-zA-Z0-9 ]+$");
        Regex reg_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        private void Advance_Customer_Load(object sender, EventArgs e)
        {
            lbl_Addcus_No.Text = New_invoice.lb_cusN.Text;
            txtAddCustoFirstName.Text = New_invoice.tx_fn.Text;
            txtLastAddCustoName.Text = New_invoice.tx_ln.Text;
            txtAddCustoMobile.Text = New_invoice.tx_mob.Text;
            txtAddCustoAddLine1.Text = New_invoice.tx_ad1.Text;
            txtAddCustoAddLine2.Text = New_invoice.tx_ad2.Text;
            txtAddCustoEmail.Text = New_invoice.tx_emal.Text;
        }

        private void btnAddCustoAdd_Click(object sender, EventArgs e)
        {
            ep_fname.SetError(txtAddCustoFirstName, "");
            ep_lname.SetError(txtLastAddCustoName, "");
            ep_add1.SetError(txtAddCustoAddLine1, "");
            ep_add2.SetError(txtAddCustoAddLine2, "");
            ep_mobil.SetError(txtAddCustoMobile, "");


            try
            {

                if (txtAddCustoFirstName.Text != "" && txtLastAddCustoName.Text != "" && txtAddCustoMobile.Text != "" && txtAddCustoAddLine1.Text != "" && txtAddCustoAddLine2.Text != "")
                {
                    if (reg_names.IsMatch(txtAddCustoFirstName.Text))
                    {
                     
                        if (reg_names.IsMatch(txtLastAddCustoName.Text))
                        {
                            if (reg_mobile.IsMatch(txtAddCustoMobile.Text))
                            {
                                if (txtAddCustoEmail.Text != "")
                                {
                                    if (reg_email.IsMatch(txtAddCustoEmail.Text))
                                    {


                                        CusOp.insert(lbl_Addcus_No.Text, txtAddCustoFirstName.Text, txtLastAddCustoName.Text, txtAddCustoBussinessName.Text, txtAddCustoAddLine1.Text, txtAddCustoAddLine2.Text, txtAddCustoCity.Text, txtAddCustoZipPostCode.Text, txtAddCustoPhone.Text, txtAddCustoMobile.Text, txtAddCustoFax.Text, txtAddCustoDiscount.Text, txtAddCustoEmail.Text, txtAddCustoNotes.Text);
                                        if (MessageBox.Show("Customer Added Successfuly.", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                        {

                                            //_________________________________________________________________________________
                                            New_invoice.tx_fn.Text = txtAddCustoFirstName.Text;
                                            New_invoice.tx_ln.Text = txtLastAddCustoName.Text;
                                            New_invoice.tx_ad1.Text = txtAddCustoAddLine1.Text;
                                            New_invoice.tx_ad2.Text = txtAddCustoAddLine2.Text;
                                            New_invoice.tx_mob.Text = txtAddCustoMobile.Text;

                                            //_________________________________________________________________________________

                                            //-----------------clear all textbox.text-----------------------
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

                                            this.Close();

                                        }
                                    }
                                    else { tp_email.Show("Enter Valid Email number", txtAddCustoEmail, 3000); }
                                }
                                else
                                {
                                    CusOp.insert(lbl_Addcus_No.Text, txtAddCustoFirstName.Text, txtLastAddCustoName.Text, txtAddCustoBussinessName.Text, txtAddCustoAddLine1.Text, txtAddCustoAddLine2.Text, txtAddCustoCity.Text, txtAddCustoZipPostCode.Text, txtAddCustoPhone.Text, txtAddCustoMobile.Text, txtAddCustoFax.Text, txtAddCustoDiscount.Text, txtAddCustoEmail.Text, txtAddCustoNotes.Text);
                                    if (MessageBox.Show("Customer Added Successfuly.", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                    {

                                        //_________________________________________________________________________________
                                        New_invoice.tx_fn.Text = txtAddCustoFirstName.Text;
                                        New_invoice.tx_ln.Text = txtLastAddCustoName.Text;
                                        New_invoice.tx_ad1.Text = txtAddCustoAddLine1.Text;
                                        New_invoice.tx_ad2.Text = txtAddCustoAddLine2.Text;
                                        New_invoice.tx_mob.Text = txtAddCustoMobile.Text;

                                        //_________________________________________________________________________________

                                        //-----------------clear all textbox.text-----------------------
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

                                        this.Close();

                                    }
                                
                                
                                }

                            }
                            else { tp_mob.Show("Enter Correct Mobile Number\nMobile must have 10 Number", txtAddCustoMobile, 3000); }
                        }
                        else { tp_lnme.Show("Enter Last Name in alphanumeric characters", txtLastAddCustoName, 3000); }
                    }
                    else { tp_fmne.Show("Enter First Name in alphanumeric characters", txtAddCustoFirstName, 3000); }
  
                }
                else
                {
                    
                    if (txtAddCustoFirstName.Text == "")
                    {
                        ep_fname.SetError(txtAddCustoFirstName, "Enter customer First name ");
                    }

                    if (txtLastAddCustoName.Text == "")
                    {
                        ep_lname.SetError(txtLastAddCustoName, "Enter customer last name ");
                    }

                    if (txtAddCustoAddLine1.Text == "")
                    {
                        ep_add1.SetError(txtAddCustoAddLine1, "Enter customer Address line1 ");
                    }

                    if (txtAddCustoAddLine2.Text == "")
                    {
                        ep_add2.SetError(txtAddCustoAddLine2, "Enter customer Address line2 ");
                    }

                    if (txtAddCustoMobile.Text == "")
                    {
                        ep_mobil.SetError(txtAddCustoMobile, "Enter customer Mobile No ");
                    }


                }
   

            }
            catch (Exception )
            {
                MessageBox.Show("Enter Correct data","Sharp Creation",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAddCustoReset_Click(object sender, EventArgs e)
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

        }

        private void btnAddCustoCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddCustoFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddCustoFirstName,1,0,  700);
                e.Handled = true;
            } 

        }

        private void txtLastAddCustoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtLastAddCustoName, 1, 0, 700);
                e.Handled = true;
            } 

        }

        private void txtAddCustoBussinessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddCustoBussinessName, 1, 0, 700);
                e.Handled = true;
            } 
        }

        private void txtAddCustoAddLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddCustoAddLine1, 1, 0, 700);
                e.Handled = true;
            } 

        }

        private void txtAddCustoAddLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddCustoAddLine2, 1, 0, 700);
                e.Handled = true;
            } 

        }

        private void txtAddCustoCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddCustoCity, 1, 0, 700);
                e.Handled = true;
            } 

        }

        private void txtAddCustoZipPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Postal Code", txtAddCustoZipPostCode, 1, 0, 2000);
                return;
            }
        }

        private void txtAddCustoPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Phone", txtAddCustoPhone, 1, 0, 2000);
                return;
            }
        }

        private void txtAddCustoMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Mobil", txtAddCustoMobile, 1, 0, 2000);
                return;
            }
        }

        private void txtAddCustoFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Fax Number", txtAddCustoFax, 1, 0, 2000);
                return;
            }
        }

        private void txtAddCustoDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Discount", txtAddCustoDiscount, 1, 0, 2000);
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

        private void txtAddCustoEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAddCustoNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 13)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtAddCustoNotes, 1, 0, 700);
                e.Handled = true;
            } 
        }

        private void txtAddCustoPhone_TextChanged(object sender, EventArgs e)
        {
            txtAddCustoPhone.MaxLength = 10;
        }

        private void txtAddCustoMobile_TextChanged(object sender, EventArgs e)
        {
            txtAddCustoMobile.MaxLength = 10;
        }

        private void txtAddCustoFax_TextChanged(object sender, EventArgs e)
        {
            txtAddCustoFax.MaxLength = 10;
        }

        private void txtAddCustoDiscount_TextChanged(object sender, EventArgs e)
        {
            txtAddCustoDiscount.MaxLength = 10;
        }

        private void txtAddCustoZipPostCode_TextChanged(object sender, EventArgs e)
        {
            txtAddCustoZipPostCode.MaxLength = 10;
        }

        
    }
}
