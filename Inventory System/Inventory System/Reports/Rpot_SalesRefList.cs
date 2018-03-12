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
    public partial class Rpot_SalesRefList : Form
    {
        public Rpot_SalesRefList()
        {
            InitializeComponent();
        }

        private void Rpot_SalesRefList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Rpot_view_SaleRef.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
