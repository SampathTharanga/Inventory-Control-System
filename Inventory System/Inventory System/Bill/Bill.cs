using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Printing;








namespace Inventory_System
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            
        }
       
        

        private void Bill_Load(object sender, EventArgs e)
        {
           

          

            // TODO: This line of code loads data into the 'DSet_Rpot_Bill.tbl_Invoice_bill' table. You can move, or remove it, as needed.
            this.tbl_Invoice_billTableAdapter.Fill(this.DSet_Rpot_Bill.tbl_Invoice_bill);
            //this.reportViewer_invo.RefreshReport();

            //System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            //pg.Margins.Top = 100;
            //pg.Margins.Bottom = 100;
            //pg.Margins.Left = 100;
            //pg.Margins.Right = 100;
            //System.Drawing.Printing.PaperSize size = new PaperSize();
            //size.RawKind = (int)PaperKind.A4;
            //pg.PaperSize = size;
            //reportViewer_invo.SetPageSettings(pg);
            this.reportViewer_invo.RefreshReport();
            

            ConnectionDB.Connection();
           
        }

        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sqlTrunc = "TRUNCATE TABLE " + "tbl_Invoice_Item";
            SqlCommand cmd = new SqlCommand(sqlTrunc, ConnectionDB.Connection());
            cmd.ExecuteNonQuery();



            string sqlTruncBill = "TRUNCATE TABLE " + "tbl_Invoice_bill";
            SqlCommand cmdB = new SqlCommand(sqlTruncBill, ConnectionDB.Connection());
            cmdB.ExecuteNonQuery();

        }

        private void Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer_invo.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
