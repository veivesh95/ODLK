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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(Login.EmpPosition== "Salesman")
            {
                deliverybtn.Enabled = false;
                accountsbtn.Enabled = false;
                
                productbtn.Enabled = false;
            }
            if (Login.EmpPosition == "Deliveryboy")
            {
                accountsbtn.Enabled = false;
                
                productbtn.Enabled = false;
                salesbtn.Enabled = false;
            }
            if (Login.EmpPosition == "StockKeeper")
            {
                accountsbtn.Enabled = false;
                
                salesbtn.Enabled = false;
                deliverybtn.Enabled = false;
            }



        }

        private void deliverybtn_Click(object sender, EventArgs e)
        {
            DeliveryMain d = new DeliveryMain();
            d.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void accountsbtn_Click(object sender, EventArgs e)
        {
            AccountsPage accpage = new AccountsPage();
            this.Hide();
            accpage.Show();
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            mianform m = new mianform();
            m.Show();
            this.Hide();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            InventoryANDSupplierHome i = new InventoryANDSupplierHome();
            i.Show();
            this.Hide();
        }

        private void salesbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


