using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersLK
{
    public partial class InventoryANDSupplierHome : Form
    {
        public InventoryANDSupplierHome()
        {
            InitializeComponent();
        }

        private void supplierbtn_Click(object sender, EventArgs e)
        {
            AddupdtDelSupplier a = new AddupdtDelSupplier();
            a.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            AddInventory a = new AddInventory();
            a.Show();
            this.Hide();
        }

        private void purchasedproductbtn_Click(object sender, EventArgs e)
        {
            Purchasedproduct p = new Purchasedproduct();
            p.Show();
            this.Hide();
        }
    }
}

