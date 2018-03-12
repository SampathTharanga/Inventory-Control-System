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
    public partial class wty_dtail_Conplete : Form
    {
        public wty_dtail_Conplete()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dtbl = new DataTable();
        Warranty_DB_Operetion wrty = new Warranty_DB_Operetion();

        private void wty_dtail_Conplete_Load(object sender, EventArgs e)
        {
            if (Warranty_Details.dgvw.CurrentRow.Cells["Completed_by"].Value.ToString() == "Item Rapaired")
            {
                lbl_itmm.Text = "Item Rapaired";
                dgv_wtycomplete.Visible = false;
            }
            else if (Warranty_Details.dgvw.CurrentRow.Cells["Completed_by"].Value.ToString() == "Another Item")
            {
                lbl_itmm.Text = "Another Item";
            }
            else if (Warranty_Details.dgvw.CurrentRow.Cells["Completed_by"].Value.ToString() == "New Item")
            {
                lbl_itmm.Text = "New Item";
            }

            ds = wrty.wtyFounditm(Warranty_Details.dgvw.CurrentRow.Cells["Warranty_No"].Value.ToString());
            dgv_wtycomplete.DataSource = ds.Tables["tbl_warrnty_found_Item"];

        }
    }
}
