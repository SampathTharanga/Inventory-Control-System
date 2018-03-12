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
    public partial class Manage_Item_details : Form
    {
        public Manage_Item_details()
        {
            InitializeComponent();
        }
        Item_DB_Operation itop = new Item_DB_Operation();
        string chose;
        DataTable dtbl;

        
        private void Manage_Item_details_Load(object sender, EventArgs e)
        {
           
           // string chose=cbx_choose.SelectedItem.ToString();
        }

        private void cbx_choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Enabled = true;
            chose = cbx_choose.SelectedItem.ToString();
            
            if (chose == "Catogory")
            {
                DataSet ds = itop.show_Catogory();
                dgv_item_details.DataSource = ds.Tables["tbl_catogory"];


               

            }
            if (chose == "Sub catogory")
            {
                DataSet ds = itop.show_SubCatogory();
                dgv_item_details.DataSource = ds.Tables["tbl_sub_catogory"];
            }

            if (chose == "Brande")
            {
                DataSet ds = itop.show_Brande();
                dgv_item_details.DataSource = ds.Tables["tbl_brande"];
            }

            if (chose == "Item type")
            {
                DataSet ds = itop.show_itype();
                dgv_item_details.DataSource = ds.Tables["tbl_itype"];
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            
            chose = cbx_choose.SelectedItem.ToString();

            if (chose == "Catogory")
            {
                string sql = "SELECT * FROM tbl_catogory";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgv_item_details.DataSource = bnsue;
                da.Update(dtbl);

                DataView dv = new DataView(dtbl);
                dv.RowFilter = "catogory like '%" + txt_Search.Text + "%' ";
                dgv_item_details.DataSource = dv;

            }

            if (chose == "Sub catogory")
            {
                string sql = "SELECT * FROM tbl_sub_catogory";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgv_item_details.DataSource = bnsue;
                da.Update(dtbl);

                DataView dv = new DataView(dtbl);
                dv.RowFilter = "sub_catogory like '%" + txt_Search.Text + "%' ";
                dgv_item_details.DataSource = dv;

            }


            if (chose == "Brande")
            {
                string sql = "SELECT * FROM tbl_brande";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgv_item_details.DataSource = bnsue;
                da.Update(dtbl);

                DataView dv = new DataView(dtbl);
                dv.RowFilter = "Brande like '%" + txt_Search.Text + "%' ";
                dgv_item_details.DataSource = dv;

            }

            if (chose == "Item type")
            {
                string sql = "SELECT * FROM tbl_itype";
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
                dtbl = new DataTable();
                da.Fill(dtbl);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dtbl;
                dgv_item_details.DataSource = bnsue;
                da.Update(dtbl);

                DataView dv = new DataView(dtbl);
                dv.RowFilter = "Item_type like '%" + txt_Search.Text + "%' ";
                dgv_item_details.DataSource = dv;

            }



        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                chose = cbx_choose.SelectedItem.ToString();

                if (chose == "Catogory")
                {
                    if (MessageBox.Show("Delete Catogory " + dgv_item_details.CurrentRow.Cells[0].Value.ToString(), "Delete catogory", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        itop.delete_catogory(dgv_item_details.CurrentRow.Cells["catogory"].Value.ToString());
                        DataSet ds = itop.show_Catogory();
                        dgv_item_details.DataSource = ds.Tables["tbl_catogory"];
                    }



                }

                if (chose == "Sub catogory")
                {
                    if (MessageBox.Show("Delete Sub Catogory " + dgv_item_details.CurrentRow.Cells[0].Value.ToString(), "Delete Sub catogory", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        itop.delete_Subcatogory(dgv_item_details.CurrentRow.Cells["sub_catogory"].Value.ToString());
                        DataSet ds = itop.show_SubCatogory();
                        dgv_item_details.DataSource = ds.Tables["tbl_sub_catogory"];
                    }



                }


                if (chose == "Brande")
                {
                    if (MessageBox.Show("Delete Brande " + dgv_item_details.CurrentRow.Cells[0].Value.ToString(), "Delete Brande", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        itop.delete_Brande(dgv_item_details.CurrentRow.Cells["Brande"].Value.ToString());
                        DataSet ds = itop.show_Brande();
                        dgv_item_details.DataSource = ds.Tables["tbl_brande"];
                    }



                }


                if (chose == "Item type")
                {
                    if (MessageBox.Show("Delete Item type " + dgv_item_details.CurrentRow.Cells[0].Value.ToString(), "Delete Item type", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        itop.delete_Type(dgv_item_details.CurrentRow.Cells["Item_type"].Value.ToString());
                        DataSet ds = itop.show_itype();
                        dgv_item_details.DataSource = ds.Tables["tbl_itype"];
                    }



                }
            }
            catch (Exception) { }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                
                e.Handled = true;
            } 
        }
    }
}
