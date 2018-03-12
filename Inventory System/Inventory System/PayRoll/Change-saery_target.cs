using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Change_saery_target : Form
    {
        public Change_saery_target()
        {
            InitializeComponent();
        }


        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();


        private void Change_saery_target_Load(object sender, EventArgs e)
        {
            

            if (User_Account.firt_set == true)
            {
                btn_set.Visible = true;
                btn_chnge.Visible = false;

            }
            else
            {
                btn_set.Visible = false;
                btn_chnge.Visible = true;
            }

            if (Set_ref_salary_taget.edt == true)
            {

                txt_sal.Text = Set_ref_salary_taget.dgvus.CurrentRow.Cells["Monthly_Salary"].Value.ToString();
                txt_tget.Text = Set_ref_salary_taget.dgvus.CurrentRow.Cells["Monthly_Trget"].Value.ToString();
            }
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            decimal dOutput;
            if (txt_sal.Text != "" && decimal.TryParse(txt_sal.Text, out dOutput) && txt_tget.Text != "" && decimal.TryParse(txt_tget.Text, out dOutput))
            {
                User_Account.m_sal = Convert.ToDecimal(txt_sal.Text);
                User_Account.m_targt = Convert.ToDecimal(txt_tget.Text);
                this.Close();
            }
            else
            {
                if (txt_sal.Text == "")
                { errorProvider1.SetError(txt_sal, "Enter Correct salary"); }

                if (txt_tget.Text == "")
                { errorProvider2.SetError(txt_tget, "Enter Correct Target"); }
            }


        }

        private void Change_saery_target_FormClosed(object sender, FormClosedEventArgs e)
        {
            Set_ref_salary_taget.edt = false;
        }

        private void btn_chnge_Click(object sender, EventArgs e)
        {
            decimal dOutput;
            if (txt_sal.Text != "" && decimal.TryParse(txt_sal.Text, out dOutput) && txt_tget.Text != "" && decimal.TryParse(txt_tget.Text, out dOutput))
            {

                try
                {

                    pay_op.update_sal_and_taget(Set_ref_salary_taget.dgvus.CurrentRow.Cells["User_Name"].Value.ToString(), Convert.ToDecimal(txt_sal.Text), Convert.ToDecimal(txt_tget.Text));
                    if (MessageBox.Show("\"" + Set_ref_salary_taget.dgvus.CurrentRow.Cells["User_Name"].Value.ToString() + "\"" + " Salary And Target Updated Sucessfully", "Sharp Creation", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                        DataSet dsa = pay_op.all();
                        Set_ref_salary_taget.dgvus.DataSource = dsa.Tables["tbl_Salary_And_Target"];
                    }
                }

                catch (Exception)
                {

                }
            }
            else
            {
                if (txt_sal.Text == "")
                { errorProvider1.SetError(txt_sal, "Enter Correct salary"); }

                if (txt_tget.Text == "")
                { errorProvider2.SetError(txt_tget, "Enter Correct Target"); }
            }

        }

        private void txt_sal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_ss.Show(" Salary Not Valid ", txt_sal, 0, -50, 2000);
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

        private void txt_tget_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_ss.Show("Target not Valid ", txt_tget, 0, -50, 2000);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
