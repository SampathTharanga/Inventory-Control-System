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
    public partial class Find_item : Form
    {
        public Find_item()
        {
            InitializeComponent();
        }
        DataSet ds;
        Item_DB_Operation itemdb = new Item_DB_Operation();
        Warranty_DB_Operetion wrty = new Warranty_DB_Operetion();
        DataTable dtbl;
        string iinme, iiserial, iiselpiz, iipurpiz, iictgry, iisubctgry, iibrnd, iibcode, iiwrrty, iisuppl, iitpe, iidescri,iino,iitax;
        DateTime ddtt1, ddtt2; TimeSpan elap;
        public static TextBox tx_bcde = new TextBox();

        private void Find_item_Load(object sender, EventArgs e)
        {
            ds = itemdb.all();
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


            //String scsql = "SELECT*FROM tbl_sub_catogory";
            //SqlDataAdapter scget = new SqlDataAdapter(scsql, ConnectionDB.Connection());
            //DataTable scdt = new DataTable();
            //scget.Fill(scdt);
            //for (int i = 0; i < scdt.Rows.Count; i++)
            //{
            //    cbxFindItemSubCategory.Items.Add(scdt.Rows[i]["sub_catogory"]);
            //}



            cbxFindItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxFindItemCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxFindItemCategory.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxFindItemBrande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbxFindItemBrande.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxFindItemBrande.AutoCompleteSource = AutoCompleteSource.ListItems;

            tx_bcde = txtFindItemBarcode;
        }

        

       

       

        private void dgvFindItem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFindItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            SqlDataReader drr = itemdb.select_to_Qntity(dgvFindItem.CurrentRow.Cells["Catogory"].Value.ToString(), dgvFindItem.CurrentRow.Cells["Sub_Catogory"].Value.ToString(), dgvFindItem.CurrentRow.Cells["Brande"].Value.ToString());
            if (drr.Read())
            {
                string qnty = drr["Quntity"].ToString();
                string ctory = drr["Item_catogory"].ToString();
                string subctory = drr["Item_sub_catogory"].ToString();
                string brnd = drr["Item_Brande"].ToString();
                lbl_Qntity_Details.Text = brnd + " " + subctory + " " + ctory + "  : " + qnty;
                int lowqty = int.Parse(qnty);

                if (lowqty < 5)
                {
                    lbl_low_leval.Visible = true;
                }
                else
                {
                    lbl_low_leval.Visible = false;
                }

            }

        }
        Item_update itup = new Item_update();
        private void btnFindItemEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                itup.no = dgvFindItem.CurrentRow.Cells["Item_No"].Value.ToString();
                itup.serial = dgvFindItem.CurrentRow.Cells["Serial_No"].Value.ToString();
                itup.name = dgvFindItem.CurrentRow.Cells["Item_Name"].Value.ToString();
                itup.selsPiz = dgvFindItem.CurrentRow.Cells["Sales_Price"].Value.ToString();
                itup.purchPiz = dgvFindItem.CurrentRow.Cells["Purchase_Price"].Value.ToString();
                itup.tax = dgvFindItem.CurrentRow.Cells["Tax_Rate"].Value.ToString();
                itup.barcode = dgvFindItem.CurrentRow.Cells["Barcode"].Value.ToString();
                itup.catogy = dgvFindItem.CurrentRow.Cells["Catogory"].Value.ToString();
                itup.subCatogy = dgvFindItem.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                itup.Brande = dgvFindItem.CurrentRow.Cells["Brande"].Value.ToString();
                itup.typ = dgvFindItem.CurrentRow.Cells["Item_Type"].Value.ToString();
                itup.supp = dgvFindItem.CurrentRow.Cells["Supplier"].Value.ToString();
                itup.wranty = dgvFindItem.CurrentRow.Cells["Warranty"].Value.ToString();
                itup.discrip = dgvFindItem.CurrentRow.Cells["Discription"].Value.ToString();

                Edti_Items editi = new Edti_Items(itup);
                editi.ShowDialog();
            }
            catch (Exception) { }

            
        }

        private void btnFindItemDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                iino = dgvFindItem.CurrentRow.Cells["Item_No"].Value.ToString();
                iiserial = dgvFindItem.CurrentRow.Cells["Serial_No"].Value.ToString();
                iinme = dgvFindItem.CurrentRow.Cells["Item_Name"].Value.ToString();
                iiselpiz = dgvFindItem.CurrentRow.Cells["Sales_Price"].Value.ToString();
                iipurpiz = dgvFindItem.CurrentRow.Cells["Purchase_Price"].Value.ToString();
                iitax = dgvFindItem.CurrentRow.Cells["Tax_Rate"].Value.ToString();
                iibcode = dgvFindItem.CurrentRow.Cells["Barcode"].Value.ToString();
                iictgry = dgvFindItem.CurrentRow.Cells["Catogory"].Value.ToString();
                iisubctgry = dgvFindItem.CurrentRow.Cells["Sub_Catogory"].Value.ToString();
                iibrnd = dgvFindItem.CurrentRow.Cells["Brande"].Value.ToString();
                iitpe = dgvFindItem.CurrentRow.Cells["Item_Type"].Value.ToString();
                iisuppl = dgvFindItem.CurrentRow.Cells["Supplier"].Value.ToString();
                iiwrrty = dgvFindItem.CurrentRow.Cells["Warranty"].Value.ToString();
                iidescri = dgvFindItem.CurrentRow.Cells["Discription"].Value.ToString();




                if (MessageBox.Show("Do you Want to Remove Item  " + dgvFindItem.CurrentRow.Cells["Brande"].Value.ToString() + " " + dgvFindItem.CurrentRow.Cells["Sub_Catogory"].Value.ToString() + " " + dgvFindItem.CurrentRow.Cells["Catogory"].Value.ToString() + " to Return list", "Sharp Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    SqlDataReader drm = itemdb.select_to_Qntity(dgvFindItem.CurrentRow.Cells["Catogory"].Value.ToString(), dgvFindItem.CurrentRow.Cells["Sub_Catogory"].Value.ToString(), dgvFindItem.CurrentRow.Cells["Brande"].Value.ToString());
                    if (drm.Read())
                    {
                        string qqt = drm["Quntity"].ToString();
                        int qq1 = int.Parse(qqt);
                        int qq2 = qq1 - 1;
                        string qty = qq2.ToString();
                        try
                        {

                            itemdb.update_Quntity(qty, dgvFindItem.CurrentRow.Cells["Catogory"].Value.ToString(), dgvFindItem.CurrentRow.Cells["Sub_Catogory"].Value.ToString(), dgvFindItem.CurrentRow.Cells["Brande"].Value.ToString());
                            //  MessageBox.Show("Quntity Updated");

                            wrty.insert_retn_itm(iino, iiserial, iinme, Convert.ToDecimal(iiselpiz), Convert.ToDecimal(iipurpiz), Convert.ToDecimal(iitax), iibcode, iictgry, iisubctgry, iibrnd, iitpe, iisuppl, iiwrrty, iidescri);
                            // MessageBox.Show("add to return list");



                            itemdb.delete_item(dgvFindItem.CurrentRow.Cells["Item_No"].Value.ToString());
                            //  MessageBox.Show("Item Deleted");
                        }
                        catch (Exception) { }


                    }


                }
                Main.p1.Controls.Clear();
                Find_item finit = new Find_item();
                finit.TopLevel = false;
                finit.Visible = true;
                Main.p1.Controls.Add(finit);
            }
            catch (Exception) { }
        }

       

        private void dgvFindItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


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

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
        }

        private void txtFindItemItemName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbxFindItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            String scsql = "SELECT*FROM tbl_sub_catogory";
            SqlDataAdapter scget = new SqlDataAdapter(scsql, ConnectionDB.Connection());
            DataTable scdt = new DataTable();
            scget.Fill(scdt);
            for (int i = 0; i < scdt.Rows.Count; i++)
            {
                cbxFindItemSubCategory.Items.Add(scdt.Rows[i]["sub_catogory"]);
            }


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

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
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

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
        }

        private void txtFindItemItemSerial_TextChanged_1(object sender, EventArgs e)
        {
            if (txtFindItemItemSerial.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtFindItemItemSerial.Clear(); }

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

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
        }

        private void txtFindItemBarcode_TextChanged(object sender, EventArgs e)
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
            dv.RowFilter = "Barcode like '%" + txtFindItemBarcode.Text + "%' ";
            dgvFindItem.DataSource = dv;

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
        }

        private void txtFindItemItemName_TextChanged(object sender, EventArgs e)
        {
            if (txtFindItemItemName.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtFindItemItemName.Clear(); }

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

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
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

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
    }

        private void txtFindItemDiscription_TextChanged(object sender, EventArgs e)
        {
            if (txtFindItemDiscription.Text.Count() == 1) { ddtt1 = DateTime.Now; }
            else { ddtt2 = DateTime.Now; elap = ddtt2 - ddtt1; }
            if (elap.TotalMilliseconds < 100 && ddtt2 > ddtt1) { txtFindItemDiscription.Clear(); }

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

            lbl_low_leval.Visible = false;
            lbl_Qntity_Details.Text = "";
        }

       

        private void txtFindItemItemSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFindItemItemSerial.Text.Count() == 1 && e.KeyChar == 13) { txtFindItemItemSerial.Clear(); }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtFindItemItemSerial, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtFindItemItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFindItemItemName.Text.Count() == 1 && e.KeyChar == 13) { txtFindItemItemName.Clear(); }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtFindItemItemName, 0, -50, 700);
                e.Handled = true;
            } 
        }

        private void txtFindItemDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFindItemDiscription.Text.Count() == 1 && e.KeyChar == 13) { txtFindItemDiscription.Clear(); }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                toolTip_check.Show("Plase enter Number and Caractor!", txtFindItemDiscription, 0, -50, 700);
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

        private void cbxFindItemCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            } 
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
