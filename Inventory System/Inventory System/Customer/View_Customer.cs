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
    public partial class View_Customer : Form
    {
        public View_Customer()
        {
            InitializeComponent();
        }
        Customer_DB_Operation cusview = new Customer_DB_Operation();

        private void View_Customer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
