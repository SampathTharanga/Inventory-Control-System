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
    public partial class Invoice_findItem : Form
    {
        public Invoice_findItem()
        {
            InitializeComponent();
        }

        
        Item_DB_Operation itemdb = new Item_DB_Operation();
        DataTable dtbl;
        DataSet ds;
        Invoive_DB_Operetion Invo = new Invoive_DB_Operetion();

        private void Invoice_findItem_Load(object sender, EventArgs e)
        {
            DataSet ds = itemdb.all();
            dgvFindItem.DataSource = ds.Tables["tbl_Add_Items"];



            String sql = "SELECT*FROM tbl_brande";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxFindItemBrande.Items.Add(ns.Rows[i]["Brande"]);
            }


            String csql = "SELECT*FROM tbl_catogory";
            SqlDataAdapter cget = new SqlDataAdapter(csql, ConnectionDB.Connection());
            DataTable cdt = new DataTable();
            cget.Fill(cdt);
            for (int i = 0; i < cdt.Rows.Count; i++)
            {
                cbxFindItemCategory.Items.Add(cdt.Rows[i]["catogory"]);
            }



            cbxFindItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxFindItemCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxFindItemCategory.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxFindItemBrande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxFindItemBrande.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxFindItemBrande.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //if (dgvFindItem.CurrentRow.Cells["Item_No"].Value.ToString() != "")
            //{
            try
            {

                string ino, serial, iname, tax, barcode, catogory, subCatory, brande, woraty, selsPrice, purchPrice, supi, itpe, descri;

                ino = dgvFindItem.CurrentRow.Cells["Item_No"].Value.ToString();
                serial = dgvFindItem.CurrentRow.Cells["Serial_No"].Value.ToString();
                iname = dgvFindItem.CurrentRow.Cells["Item_Name"].Value.ToString();
                selsPrice = dgvFindItem.CurrentRow.Cells["Sales_Price"].Value.ToString();
                purchPrice = dgvFindItem.CurrentRow.Cells["Purchase_Price"].Value.ToString();
                tax = dgvFindItem.CurrentRow.Cells["Tax_Rate"].Value.ToString();
                barcode = dgvFindItem.CurrentRow.Cells["Barcode"].Value.ToString();
                catogory = dgvFindItem.CurrentRow.Cells["Catogory"].Value.ToString();
                subCatory = dgvFindItem.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                brande = dgvFindItem.CurrentRow.Cells["Brande"].Value.ToString();
                woraty = dgvFindItem.CurrentRow.Cells["Warranty"].Value.ToString();
                supi = dgvFindItem.CurrentRow.Cells["Supplier"].Value.ToString();
                itpe = dgvFindItem.CurrentRow.Cells["Item_Type"].Value.ToString();
                descri = dgvFindItem.CurrentRow.Cells["Discription"].Value.ToString();




                Invo.insert_Invo_item(ino, serial, iname, Convert.ToDecimal(selsPrice), Convert.ToDecimal(purchPrice), Convert.ToDecimal(tax), barcode, catogory, subCatory, brande, woraty, supi, itpe, descri, "1", "Nomal", Convert.ToDecimal(selsPrice));

                lbl_add.Text = brande + " " + subCatory + " " + catogory + " " + "Add";
            }
            catch (Exception) { }
            //}

            //else { toolTip1.Show("Plese Select Item to Add Invoice ", txtFindItemDiscription, 1500); }

            if (Return_New_item.btn_clik_c == true)
            {
                DataSet dsi = Invo.all_Item();
                Return_New_item.dgv_change.DataSource = dsi.Tables["tbl_Invoice_Item"];

            }

            if (Return_stock_item.btn_clikStk == true)
            {
                DataSet dsi = Invo.all_Item();
                Return_stock_item.dgvFind_warrny.DataSource = dsi.Tables["tbl_Invoice_Item"];

            }
            if(New_invoice.btn_clikin==true)
            {

                New_invoice.dtvw.Columns[0].Width = 65;
                New_invoice.dtvw.Columns[6].Width = 50;
                DataSet dsi = Invo.all_Item();
                New_invoice.dtvw.DataSource = dsi.Tables["tbl_Invoice_Item"];
            }
        }

        private void cbxFindItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxFindItemSubCategory.Items.Clear();
            cbxFindItemSubCategory.Text = "";
            String sql = "SELECT sub_catogory FROM tbl_sub_catogory WHERE catogory='" + cbxFindItemCategory.Text + "'";
            SqlDataAdapter get = new SqlDataAdapter(sql, ConnectionDB.Connection());
            DataTable ns = new DataTable();
            get.Fill(ns);
            for (int i = 0; i < ns.Rows.Count; i++)
            {
                cbxFindItemSubCategory.Items.Add(ns.Rows[i]["sub_catogory"]);
            }


            string sqlfilter_catgory = "SELECT * FROM tbl_Add_Items";
            SqlDataAdapter da = new SqlDataAdapter(sqlfilter_catgory, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindItem.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Catogory like '%" + cbxFindItemCategory.SelectedItem + "%' ";
            dgvFindItem.DataSource = dv;


            

        }

        private void cbxFindItemSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Add_Items";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindItem.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Sub_Catogory like '%" + cbxFindItemSubCategory.SelectedItem + "%' ";
            dgvFindItem.DataSource = dv;

            

        }

        private void txtFindItemItemName_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Add_Items";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindItem.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Item_Name like '%" + txtFindItemItemName.Text + "%' ";
            dgvFindItem.DataSource = dv;
        }

        private void txtFindItemDiscription_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Add_Items";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindItem.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Discription like '%" + txtFindItemDiscription.Text + "%' ";
            dgvFindItem.DataSource = dv;
        }

        private void txtFindItemItemSerial_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Add_Items";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindItem.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Serial_No like '%" + txtFindItemItemSerial.Text + "%' ";
            dgvFindItem.DataSource = dv;
        }

        private void txtFindItemItemSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void cbxFindItemCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void cbxFindItemSubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindItemItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void cbxFindItemBrande_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void txtFindItemDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        private void cbxFindItemBrande_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_Add_Items";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionDB.Connection());
            dtbl = new DataTable();
            da.Fill(dtbl);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dtbl;
            dgvFindItem.DataSource = bnsue;
            da.Update(dtbl);

            DataView dv = new DataView(dtbl);
            dv.RowFilter = "Brande like '%" + cbxFindItemBrande.SelectedItem + "%' ";
            dgvFindItem.DataSource = dv;


           

        }

        private void btnFindItemReset_Click(object sender, EventArgs e)
        {
            ds = itemdb.all();
            dgvFindItem.DataSource = ds.Tables["tbl_Add_Items"];
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

            cbxFindItemBrande.Text = "";
            cbxFindItemCategory.Text = "";
            cbxFindItemSubCategory.Text = "";
        }

       
    }
}
