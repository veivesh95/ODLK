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
    public partial class DeliveryMain : Form
    {
        public DeliveryMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDelivery add = new AddDelivery();
            this.Hide();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewConfirmedDeliveryDetails view = new ViewConfirmedDeliveryDetails();
            this.Hide();
            view.Show();
        }

        private void checkDelivery_Click(object sender, EventArgs e)
        {
            CheckDeliveryByDeliveryboy checkdel = new CheckDeliveryByDeliveryboy();
            this.Hide();
            checkdel.Show();
        }

        private void DeliveryMain_Load(object sender, EventArgs e)
        {
            if(Login.EmpPosition=="Deliveryboy" )
            {
                button1.Visible = false;
                button2.Visible = false;
                checkDelivery.Visible = true;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                checkDelivery.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
