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
    public partial class Tget_settings : Form
    {
        public Tget_settings()
        {
            InitializeComponent();
        }

        Payroll_DB_Oparetion pay_op = new Payroll_DB_Oparetion();
        bool sseet;
        private void Tget_settings_Load(object sender, EventArgs e)
        {
            String sql = "SELECT*FROM tbl_UserAccount";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbx_usernn.Items.Add(ns.Rows[i]["User_Name"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_to_select_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_usernn.Text != "")
                {
                    SqlDataReader tdr = pay_op.select_tgt_rte(cbx_usernn.Text);
                    if (tdr.Read())
                    {
                        pay_op.Update_tgt_rte(cbx_usernn.Text, Convert.ToDecimal(txt_tgtrte.Text));
                        MessageBox.Show("\"" + cbx_usernn.Text + "\" Rate Updated Sucessfully", "Sharp Creations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        pay_op.Insert_payrol_setting(cbx_usernn.Text, Convert.ToDecimal(txt_tgtrte.Text));
                        MessageBox.Show("\"" + cbx_usernn.Text + "\" Rate Set Sucessfully", "Sharp Creations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { toolTip_tgt.Show("Select User name", cbx_usernn, 1500); }
            }
            catch (Exception) { }
        }

        private void btn_ok_to_all_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT*FROM tbl_UserAccount";
                SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
                DataTable ns = new DataTable();
                get.Fill(ns);
                for (int i = 0; i < ns.Rows.Count; i++)
                {
                    string unme = ns.Rows[i]["User_Name"].ToString();

                    SqlDataReader tdr = pay_op.select_tgt_rte(unme);
                    if (tdr.Read())
                    {
                        pay_op.Update_tgt_rte(unme, Convert.ToDecimal(txt_tgtrte.Text));
                        //MessageBox.Show("ok Updated");
                        sseet = true;
                    }
                    else
                    {
                        pay_op.Insert_payrol_setting(unme, Convert.ToDecimal(txt_tgtrte.Text));
                        //MessageBox.Show("ok insert");
                        sseet = true;
                    }


                }
                if (sseet == true)
                {
                    if (MessageBox.Show("Rate Updated for all User Sucessfully", "Sharp Creations", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    { this.Close(); }
                }
            }
            catch (Exception) { }
        }

        private void cbx_usernn_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader rtedr = pay_op.select_tgt_rte(cbx_usernn.Text);
            if (rtedr.Read())
            {
                txt_tgtrte.Text =rtedr["Target_rate"].ToString();
            }

        }

        private void txt_tgtrte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                toolTip_tgt.Show("Invalid Rate ", txt_tgtrte, 0, -50, 2000);
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
