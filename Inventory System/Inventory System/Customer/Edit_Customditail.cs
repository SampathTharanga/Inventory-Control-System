using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Edit_Customer : Form
    {


        cusDupdate cusData;
        
        public Edit_Customer(cusDupdate mdc)
        {
           
            InitializeComponent();
            cusData = mdc;
        }
        Regex reg_mobile = new Regex("^[0-9X]{10}$");
        Regex reg_names = new Regex(@"^[a-zA-Z0-9 ]+$");
        Regex reg_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


        private void Edit_Customer_Load(object sender, EventArgs e)
        {
             
            lbl_updatecus_No.Text = cusData.no;
            txt_updateCustoFirstName.Text = cusData.Fname;
            txt_updateLastCustoName.Text = cusData.lname;
            txt_updateCustoBussinessName.Text = cusData.bisname;
            txt_updateCustoAddLine1.Text = cusData.add1;
            txt_updateCustoAddLine2.Text = cusData.add2;
            txt_updateCustoCity.Text = cusData.city;
            txt_updateCustoZipPostCode.Text = cusData.zip;
            txt_updateCustoFax.Text = cusData.fax;
            txt_updateCustoPhone.Text = cusData.phone;
            txt_updateCustoMobile.Text = cusData.mobil;
            txt_updateCustoDiscount.Text = cusData.discount;
            txt_updateCustoNotes.Text = cusData.notes;
            txt_updateCustoEmail.Text = cusData.email;
            
        }
        Customer_DB_Operation cusEDit = new Customer_DB_Operation();

        private void btnAddCustoAdd_Click(object sender, EventArgs e)
        {

            ep_fname.SetError(txt_updateCustoFirstName, "");
            ep_lname.SetError(txt_updateLastCustoName, "");
            ep_add1.SetError(txt_updateCustoAddLine1, "");
            ep_add2.SetError(txt_updateCustoAddLine2, "");
            ep_mobil.SetError(txt_updateCustoMobile, "");


            try
            {

                if (txt_updateCustoFirstName.Text != "" && txt_updateLastCustoName.Text != "" && txt_updateCustoMobile.Text != "" && txt_updateCustoAddLine1.Text != "" && txt_updateCustoAddLine2.Text != "")
                {
                    if (reg_names.IsMatch(txt_updateCustoFirstName.Text))
                    {

                        if (reg_names.IsMatch(txt_updateLastCustoName.Text))
                        {
                            if (reg_mobile.IsMatch(txt_updateCustoMobile.Text))
                            {


                                cusEDit.updete(lbl_updatecus_No.Text, txt_updateCustoFirstName.Text, txt_updateLastCustoName.Text, txt_updateCustoBussinessName.Text, txt_updateCustoAddLine1.Text, txt_updateCustoAddLine2.Text, txt_updateCustoCity.Text, txt_updateCustoZipPostCode.Text, txt_updateCustoPhone.Text, txt_updateCustoMobile.Text, txt_updateCustoFax.Text, txt_updateCustoDiscount.Text, txt_updateCustoEmail.Text, txt_updateCustoNotes.Text);
                                if (MessageBox.Show("Customer Updated Successfuly.", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {

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
                                    Main.p1.Controls.Clear();
                                    Find_Customer findcus = new Find_Customer();
                                    findcus.TopLevel = false;
                                    findcus.Visible = true;
                                    Main.p1.Controls.Add(findcus);

                                }

                            }
                            else { tp_mob.Show("Enter Correct Mobile Number\nMobile must have 10 Number", txt_updateCustoMobile, 3000); }
                        }
                        else { tp_lnme.Show("Enter Last Name in alphanumeric characters", txt_updateLastCustoName, 3000); }
                    }
                    else { tp_fmne.Show("Enter First Name in alphanumeric characters", txt_updateCustoFirstName, 3000); }

                }
                else
                {

                    if (txt_updateCustoFirstName.Text == "")
                    {
                        ep_fname.SetError(txt_updateCustoFirstName, "Enter customer First name ");
                    }

                    if (txt_updateLastCustoName.Text == "")
                    {
                        ep_lname.SetError(txt_updateLastCustoName, "Enter customer last name ");
                    }

                    if (txt_updateCustoAddLine1.Text == "")
                    {
                        ep_add1.SetError(txt_updateCustoAddLine1, "Enter customer Address line1 ");
                    }

                    if (txt_updateCustoAddLine2.Text == "")
                    {
                        ep_add2.SetError(txt_updateCustoAddLine2, "Enter customer Address line2 ");
                    }

                    if (txt_updateCustoMobile.Text == "")
                    {
                        ep_mobil.SetError(txt_updateCustoMobile, "Enter customer Mobile No ");
                    }


                }


            }
            catch (Exception)
            {
                MessageBox.Show("Enter Correct data", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txt_updateCustoFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txt_updateCustoFirstName, 1, 1, 700);
                e.Handled = true;
            } 
        }

        private void txt_updateLastCustoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txt_updateLastCustoName, 1, 1, 700);
                e.Handled = true;
            } 
        }

        private void txt_updateCustoBussinessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txt_updateCustoBussinessName, 1, 1, 700);
                e.Handled = true;
            } 
        }

        private void txt_updateCustoAddLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txt_updateCustoAddLine1, 1, 1, 700);
                e.Handled = true;
            } 
        }

        private void txt_updateCustoAddLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txt_updateCustoAddLine2, 1, 1, 700);
                e.Handled = true;
            } 
        }

        private void txt_updateCustoCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txt_updateCustoCity, 1, 1, 700);
                e.Handled = true;
            } 

        }

        private void txt_updateCustoZipPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Postal Code", txt_updateCustoZipPostCode, 1, 1, 2000);
                return;
            }
        }

        private void txt_updateCustoPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Phone", txt_updateCustoPhone, 1, 1, 2000);
                return;
            }
        }

        private void txt_updateCustoMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Mobil", txt_updateCustoMobile, 1, 1, 2000);
                return;
            }

        }

        private void txt_updateCustoFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Fax Number", txt_updateCustoFax, 1, 1, 2000);
                return;
            }
        }

        private void txt_updateCustoDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace,Delete and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 127))
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Discount", txt_updateCustoDiscount, 1, 1, 2000);
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

        

        private void txt_updateCustoNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Catactor!", txt_updateCustoNotes, 1, 1, 700);
                e.Handled = true;
            } 
        }
    }
}
