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
    public partial class Edit_Supplier : Form
    {
        SupDUpdate SupData;
        public Edit_Supplier(SupDUpdate mds)
        {
            InitializeComponent();
            SupData = mds;
        }
        Supplier_DB_Operetion supOp = new Supplier_DB_Operetion();
        DataTable dtbl;

        Regex reg_mobile = new Regex("^[0-9X]{10}$");
        Regex reg_names = new Regex(@"^[a-zA-Z0-9 ]+$");
        Regex reg_email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        private void Edit_Supplier_Load(object sender, EventArgs e)
        {
            lbl_updatecus_No.Text = SupData.no;
            txt_updateSupFirstName.Text = SupData.Fname;
            txt_updateLastSupName.Text = SupData.lname;
            txt_updateSupBussinessName.Text = SupData.bisname;
            txt_updateSupAddLine1.Text = SupData.add1;
            txt_updateSupAddLine2.Text = SupData.add2;
            txt_updateSupCity.Text = SupData.city;
            txt_updateSupZipPostCode.Text = SupData.zip;
            txt_updateSupFax.Text = SupData.fax;
            txt_updateSupPhone.Text = SupData.phone;
            txt_updateSupMobile.Text = SupData.mobil;
            txt_updateSupNotes.Text = SupData.notes;
            txt_updateSupEmail.Text = SupData.email;

        }
        Supplier_DB_Operetion SupEdit = new Supplier_DB_Operetion();

        private void btnAddCustoAdd_Click(object sender, EventArgs e)
        {
            ep_cty.SetError(txt_updateSupCity, "");
            ep_bisname.SetError(txt_updateSupBussinessName, "");
            ep_email.SetError(txt_updateSupEmail, "");
            ep_fname.SetError(txt_updateSupFirstName, "");
            ep_lname.SetError(txt_updateLastSupName, "");
            ep_mobil.SetError(txt_updateSupMobile, "");


            try
            {
                if (txt_updateSupFirstName.Text != "" && txt_updateLastSupName.Text != "" && txt_updateSupBussinessName.Text != "" && txt_updateSupCity.Text != "" && txt_updateSupMobile.Text != "" && txt_updateSupEmail.Text != "")
                {
                    if (reg_mobile.IsMatch(txt_updateSupMobile.Text) && reg_email.IsMatch(txt_updateSupEmail.Text))
                    {
                        SupEdit.update(lbl_updatecus_No.Text, txt_updateSupFirstName.Text, txt_updateLastSupName.Text, txt_updateSupBussinessName.Text, txt_updateSupAddLine1.Text, txt_updateSupAddLine2.Text, txt_updateSupCity.Text, txt_updateSupPhone.Text, txt_updateSupMobile.Text, txt_updateSupFax.Text, txt_updateSupZipPostCode.Text, txt_updateSupEmail.Text, txt_updateSupNotes.Text);
                        if (MessageBox.Show("Update completed", "Supplier update", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Close();
                            DataSet ds = supOp.all();
                            View_Suppliers.dgv.DataSource = ds.Tables["tbl_AddS_Supplier"];

                        }

                    }
                    else
                    {
                        if (!reg_email.IsMatch(txt_updateSupEmail.Text))
                        { toolTip_check.Show("Invalid Email!", txt_updateSupEmail, 0, -50, 1000); }

                        if (!reg_mobile.IsMatch(txt_updateSupMobile.Text))
                        { toolTip_check1.Show("Incorrect Mobile Number!", txt_updateSupMobile, 0, -50, 1000); }

                    }
                }

                else
                {


                    tp_error.Show("Enter details to Add Supplier ", btnAddCustoAdd, 4000);


                    if (txt_updateSupCity.Text == "")
                    {
                        ep_cty.SetError(txt_updateSupCity, "Enter supplier city ");
                    }


                    if (txt_updateSupBussinessName.Text == "")
                    {
                        ep_bisname.SetError(txt_updateSupBussinessName, "Enter supplier Bisness name ");
                    }


                    if (txt_updateSupEmail.Text == "")
                    {
                        ep_email.SetError(txt_updateSupEmail, "Enter Email ");
                    }


                    if (txt_updateSupFirstName.Text == "")
                    {
                        ep_fname.SetError(txt_updateSupFirstName, "Enter First Name");
                    }


                    if (txt_updateLastSupName.Text == "")
                    {
                        ep_lname.SetError(txt_updateLastSupName, "Enter Last Name ");
                    }


                    if (txt_updateSupMobile.Text == "")
                    {
                        ep_mobil.SetError(txt_updateSupMobile, "Enter Mobile ");
                    }

                }
            }
            catch (Exception)
            { MessageBox.Show("Enter Correct Data ", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }

        private void btnAddCustoCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_updateSupPhone_TextChanged(object sender, EventArgs e)
        {
            txt_updateSupPhone.MaxLength = 10;
        }

        private void txt_updateSupMobile_TextChanged(object sender, EventArgs e)
        {
            txt_updateSupMobile.MaxLength = 10;
        }

        private void txt_updateSupFax_TextChanged(object sender, EventArgs e)
        {
            txt_updateSupFax.MaxLength = 10;
        }

        private void txt_updateSupZipPostCode_TextChanged(object sender, EventArgs e)
        {
            txt_updateSupZipPostCode.MaxLength = 10;
        }

        private void txt_updateSupFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_updateSupFirstName, 0, -50, 700);
                e.Handled = true;
            }

        }

        private void txt_updateLastSupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_updateLastSupName, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_updateSupBussinessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_updateSupBussinessName, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_updateSupAddLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Space)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_updateSupAddLine1, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_updateSupAddLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Space)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_updateSupAddLine2, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_updateSupCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Space)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_updateSupCity, 0, -50, 700);
                e.Handled = true;
            }
        }

        private void txt_updateSupZipPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Postal Code", txt_updateSupZipPostCode, 0, -50, 2000);
                return;
            }
        }

        private void txt_updateSupPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid phone", txt_updateSupPhone, 0, -50, 2000);
                return;
            }
        }

        private void txt_updateSupMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Mobile", txt_updateSupMobile, 0, -50, 2000);
                return;
            }
        }

        private void txt_updateSupFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                toolTip_check.Show("Invalid Fax", txt_updateSupFax, 0, -50, 2000);
                return;
            }
        }

        private void txt_updateSupNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txt_updateSupNotes, 1, 1, 700);
                e.Handled = true;
            }

        }
    }
}
