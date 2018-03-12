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
    public partial class Item_Details : Form
    {
        public Item_Details()
        {
            InitializeComponent();
        }
        PictureBox pb = new PictureBox();
        Item_DB_Operation itop = new Item_DB_Operation();
        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_ctrgory_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_catogory.Text != "")
                {
                    itop.catogary(txt_catogory.Text);
                    pbx_ctogory.Visible = true;
                    txt_catogory.Clear();
                }
                else 
                {
                    pbx_ctogay_wong.Visible = true;
                }

            }
            catch
            {
                pbx_ctogay_wong.Visible = true;
            }

            cbx_choose_ctgy.Items.Clear();

            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbx_choose_ctgy.Items.Add(cdt.Rows[i]["catogory"]);
            }
        }

        private void txt_catogory_Click(object sender, EventArgs e)
        {
           
            pbx_ctogory.Visible = false;
            pbx_subcatory.Visible = false;
            pbx_type.Visible = false;
            pbx_brnde.Visible = false;
            pbx_ctogay_wong.Visible = false;
            pbx_Subctogay_wong.Visible = false;
            pbx_itype_wrong.Visible = false;
            pbx_brande_wrong.Visible = false;

            txt_subcatogory.Clear();
            txt_brande.Clear();
            txt_type.Clear();
            cbx_choose_ctgy.Text = "";


        }

        private void txt_subcatogory_Click(object sender, EventArgs e)
        {
            pbx_ctogory.Visible = false;
            pbx_subcatory.Visible = false;
            pbx_type.Visible = false;
            pbx_brnde.Visible = false;
            pbx_ctogay_wong.Visible = false;
            pbx_Subctogay_wong.Visible = false;
            pbx_itype_wrong.Visible = false;
            pbx_brande_wrong.Visible = false;

            txt_brande.Clear();
            txt_type.Clear();
            txt_catogory.Clear();

        }

        private void txt_type_Click(object sender, EventArgs e)
        {
            pbx_ctogory.Visible = false;
            pbx_subcatory.Visible = false;
            pbx_type.Visible = false;
            pbx_brnde.Visible = false;
            pbx_ctogay_wong.Visible = false;
            pbx_Subctogay_wong.Visible = false;
            pbx_itype_wrong.Visible = false;
            pbx_brande_wrong.Visible = false;

            txt_brande.Clear();
            txt_subcatogory.Clear();
            txt_catogory.Clear();
            cbx_choose_ctgy.Text = "";

        }

        private void txt_brande_Click(object sender, EventArgs e)
        {
            pbx_ctogory.Visible = false;
            pbx_subcatory.Visible = false;
            pbx_type.Visible = false;
            pbx_brnde.Visible = false;
            pbx_ctogay_wong.Visible = false;
            pbx_Subctogay_wong.Visible = false;
            pbx_itype_wrong.Visible = false;
            pbx_brande_wrong.Visible = false;

            txt_subcatogory.Clear();
            txt_catogory.Clear();
            txt_type.Clear();
            cbx_choose_ctgy.Text = "";

        }

        private void btn_Subctrgory_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_subcatogory.Text != ""&&cbx_choose_ctgy.Text!="")
                {
                    itop.Subcatogary(txt_subcatogory.Text,cbx_choose_ctgy.Text);
                    pbx_subcatory.Visible = true;
                    txt_subcatogory.Clear();
                }
                else
                {
                    pbx_Subctogay_wong.Visible = true;
                }

            }
            catch
            {
                pbx_Subctogay_wong.Visible = true;
            }

           // cbx_choose_ctgy.Text = "";
        }

        private void btn_type_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_type.Text != "")
                {
                    itop.itype(txt_type.Text);
                    pbx_type.Visible = true;
                    txt_type.Clear();
                }
                else
                {
                    pbx_itype_wrong.Visible = true;
                }

            }
            catch
            {
                pbx_itype_wrong.Visible = true;
            }
            
        }

        private void btn_brande_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_brande.Text != "")
                {
                    itop.brande(txt_brande.Text);
                    pbx_brnde.Visible = true;
                    txt_brande.Clear();
                }
                else
                {
                    pbx_brande_wrong.Visible = true;
                }

            }
            catch
            {
                pbx_brande_wrong.Visible = true;
            }

        }

        private void Item_Details_Load(object sender, EventArgs e)
        {
            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbx_choose_ctgy.Items.Add(cdt.Rows[i]["catogory"]);
            }
        }

        private void txt_catogory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase Use Number and Catactor!", txt_catogory, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void cbx_choose_ctgy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_subcatogory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase Use Number and Catactor!", txt_subcatogory, 0, -50, 700);
                e.Handled = true;
            } 

        }

        private void txt_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase Use Number and Catactor!", txt_type, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txt_brande_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                toolTip_check.Show("Plase use Number and Catactor!", txt_brande, 0, -50, 700);
                e.Handled = true;
            } 
        }
    }
}
