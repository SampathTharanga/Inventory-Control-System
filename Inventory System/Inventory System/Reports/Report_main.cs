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
    public partial class Report_main : Form
    {
        public Report_main()
        {
            InitializeComponent();
        }

        public static Panel pn_Rpot = new Panel();

        private void Report_main_Load(object sender, EventArgs e)
        {
            pn_Rpot = pnl_rpots;

            pnl_rpots.Controls.Clear();
            Rpot_Sales rsale = new Rpot_Sales();
            rsale.TopLevel = false;
            rsale.Visible = true;
            pnl_rpots.Controls.Add(rsale);

        }

        private void lbl_saleR_MouseEnter(object sender, EventArgs e)
        {
            lbl_saleR.BackColor = Color.PowderBlue;

        }

        private void lbl_saleR_MouseLeave(object sender, EventArgs e)
        {
            lbl_saleR.BackColor = Color.Transparent;
        }

        private void lbl_Incom_MouseEnter(object sender, EventArgs e)
        {
            lbl_Incom.BackColor = Color.PowderBlue;
        }

        private void lbl_Incom_MouseLeave(object sender, EventArgs e)
        {
            lbl_Incom.BackColor = Color.Transparent;
        }


        private void lbl_stokLvalR_MouseEnter(object sender, EventArgs e)
        {
            lbl_stokLvalR.BackColor = Color.PowderBlue;
        }

        private void lbl_stokLvalR_MouseLeave(object sender, EventArgs e)
        {
            lbl_stokLvalR.BackColor = Color.Transparent;
        }

        private void Lbl_ReceiR_MouseEnter(object sender, EventArgs e)
        {
            Lbl_ReceiR.BackColor = Color.PowderBlue;
        }

        private void Lbl_ReceiR_MouseLeave(object sender, EventArgs e)
        {
            Lbl_ReceiR.BackColor = Color.Transparent;
        }

        private void lbl_cusodrR_MouseEnter(object sender, EventArgs e)
        {
            lbl_cusodrR.BackColor = Color.PowderBlue;
        }

        private void lbl_cusodrR_MouseLeave(object sender, EventArgs e)
        {
            lbl_cusodrR.BackColor = Color.Transparent;
        }

        private void lbl_reqstR_MouseEnter(object sender, EventArgs e)
        {
            lbl_reqstR.BackColor = Color.PowderBlue;
        }

        private void lbl_reqstR_MouseLeave(object sender, EventArgs e)
        {
            lbl_reqstR.BackColor = Color.Transparent;
        }

        private void lbl_RetunR_MouseEnter(object sender, EventArgs e)
        {
            lbl_RetunR.BackColor = Color.PowderBlue;
        }

        private void lbl_RetunR_MouseLeave(object sender, EventArgs e)
        {
            lbl_RetunR.BackColor = Color.Transparent;
        }

        private void lbl_warrIR_MouseEnter(object sender, EventArgs e)
        {
            lbl_warrIR.BackColor = Color.PowderBlue;
        }

        private void lbl_warrIR_MouseLeave(object sender, EventArgs e)
        {
            lbl_warrIR.BackColor = Color.Transparent;
        }

        private void lbl_suppR_MouseEnter(object sender, EventArgs e)
        {
            lbl_suppR.BackColor = Color.PowderBlue;
        }

        private void lbl_suppR_MouseLeave(object sender, EventArgs e)
        {
            lbl_suppR.BackColor = Color.Transparent;
        }

        private void lbl_cusR_MouseEnter(object sender, EventArgs e)
        {
            lbl_cusR.BackColor = Color.PowderBlue;
        }

        private void lbl_cusR_MouseLeave(object sender, EventArgs e)
        {
            lbl_cusR.BackColor = Color.Transparent;
        }

        private void lbl_selrefR_MouseEnter(object sender, EventArgs e)
        {
            lbl_selrefR.BackColor = Color.PowderBlue;
        }

        private void lbl_selrefR_MouseLeave(object sender, EventArgs e)
        {
            lbl_selrefR.BackColor = Color.Transparent;
        }

        private void lbl_itmR_MouseEnter(object sender, EventArgs e)
        {
            lbl_itmR.BackColor = Color.PowderBlue;
        }

        private void lbl_itmR_MouseLeave(object sender, EventArgs e)
        {
            lbl_itmR.BackColor = Color.Transparent;
        }

        

        private void lbl_saleR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_Sales rsale = new Rpot_Sales();
            rsale.TopLevel = false;
            rsale.Visible = true;
            pnl_rpots.Controls.Add(rsale);
        }

        private void lbl_Incom_Click(object sender, EventArgs e)
        {


            pnl_rpots.Controls.Clear();
            Rpot_Income rincm = new Rpot_Income();
            rincm.TopLevel = false;
            rincm.Visible = true;
            pnl_rpots.Controls.Add(rincm);
        }
        

       

        private void lbl_stokLvalR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_StockLeval rstokl = new Rpot_StockLeval();
            rstokl.TopLevel = false;
            rstokl.Visible = true;
            pnl_rpots.Controls.Add(rstokl);
        }

        private void Lbl_ReceiR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_ReceivedStock rrceivs = new Rpot_ReceivedStock();
            rrceivs.TopLevel = false;
            rrceivs.Visible = true;
            pnl_rpots.Controls.Add(rrceivs);
        }

        private void lbl_cusodrR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_CusOrder rcuso = new Rpot_CusOrder();
            rcuso.TopLevel = false;
            rcuso.Visible = true;
            pnl_rpots.Controls.Add(rcuso);
        }

        private void lbl_reqstR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_RequestOrder rrqst = new Rpot_RequestOrder();
            rrqst.TopLevel = false;
            rrqst.Visible = true;
            pnl_rpots.Controls.Add(rrqst);
        }

        private void lbl_RetunR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_ReturnItem rrutun = new Rpot_ReturnItem();
            rrutun.TopLevel = false;
            rrutun.Visible = true;
            pnl_rpots.Controls.Add(rrutun);
        }

        private void lbl_warrIR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_WarrantyItem rwarrnt = new Rpot_WarrantyItem();
            rwarrnt.TopLevel = false;
            rwarrnt.Visible = true;
            pnl_rpots.Controls.Add(rwarrnt);


        }

        private void lbl_suppR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_SupplierList rsupp = new Rpot_SupplierList();
            rsupp.TopLevel = false;
            rsupp.Visible = true;
            pnl_rpots.Controls.Add(rsupp);
        }

        private void lbl_cusR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_CustomerList rcusl = new Rpot_CustomerList();
            rcusl.TopLevel = false;
            rcusl.Visible = true;
            pnl_rpots.Controls.Add(rcusl);
        }

        private void lbl_selrefR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_SalesRefList rsaleref = new Rpot_SalesRefList();
            rsaleref.TopLevel = false;
            rsaleref.Visible = true;
            pnl_rpots.Controls.Add(rsaleref);
        }

        private void lbl_itmR_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_ItemList ritem = new Rpot_ItemList();
            ritem.TopLevel = false;
            ritem.Visible = true;
            pnl_rpots.Controls.Add(ritem);
        }

        private void lbl_prizlist_Click(object sender, EventArgs e)
        {
            pnl_rpots.Controls.Clear();
            Rpot_PriceList rpiz = new Rpot_PriceList();
            rpiz.TopLevel = false;
            rpiz.Visible = true;
            pnl_rpots.Controls.Add(rpiz);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.R_Sale_r1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.R_Sale_r;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.R_Stock_r1;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.R_Stock_r;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.R_Order_r1;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.R_Order_r;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.R_warranry_r1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.R_warranry_r;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.R_list_r1;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.R_list_r;
        }

        private void lbl_prizlist_MouseEnter(object sender, EventArgs e)
        {
            lbl_prizlist.BackColor = Color.PowderBlue;
        }

        private void lbl_prizlist_MouseLeave(object sender, EventArgs e)
        {
            lbl_prizlist.BackColor = Color.Transparent;
        }

       

       

        

        

       

       

        
    }
}
