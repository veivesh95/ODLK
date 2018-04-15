
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
    public partial class b_add : Form
    {
        private string buyerId;
        private string buyerName;
        private string buyerAddress;
        private string buyerContact;
        private string buyerEmail;

        public b_add()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.buyerId = Functions.getNextID("CustomerId", "Customer", "CUS");
            this.buyerName = customerName.Text;
            this.buyerContact = customerContact.Text;
            this.buyerEmail = customerEmail.Text;

            string secondaryAddress = "";


            if (customerAddress2.Text != "" || !string.IsNullOrEmpty(customerAddress2.Text) || !string.IsNullOrWhiteSpace(customerAddress2.Text))
            {
                secondaryAddress += ", " + customerAddress2.Text;
            }

            if (customerAddress3.Text != "" || !string.IsNullOrEmpty(customerAddress3.Text) || !string.IsNullOrWhiteSpace(customerAddress3.Text))
            {
                secondaryAddress += ", " + customerAddress3.Text;
            }

            if (customerAddress4.Text != "" || !string.IsNullOrEmpty(customerAddress4.Text) || !string.IsNullOrWhiteSpace(customerAddress4.Text))
            {
                secondaryAddress += ", " + customerAddress4.Text;
            }


            this.buyerAddress = customerAddress1.Text + secondaryAddress + ".";

            if (
                !string.IsNullOrEmpty(this.buyerId)
                && (customerName.Text != "" || !string.IsNullOrEmpty(this.buyerName) || !string.IsNullOrWhiteSpace(this.buyerName))
                && (!string.IsNullOrEmpty(this.buyerAddress) || !string.IsNullOrWhiteSpace(this.buyerAddress))
                && (!string.IsNullOrEmpty(this.buyerContact) || customerContact.Text == "" || !string.IsNullOrWhiteSpace(this.buyerContact))

                && Functions.isText(this.buyerName)
                && Functions.isValid(this.buyerEmail)
                && Functions.isContact(this.buyerContact)
                )
            {
                string query_ = "INSERT into Customer values ('" + buyerId + "','" + buyerName + "','" + buyerAddress + "','" + buyerContact + "','" + buyerEmail + "')";
                Functions.ExecuteQuery(query_);

                Functions.ClearAllText(this);
                this.Close();

                b_home bh = new b_home();
                bh.Show();
            }
            else
            {
                MessageBox.Show("Please fill correct information before saving");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string customerObj
        {
            get { return buyerName; }
        }

        private void b_add_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            b_home b = new b_home();
            b.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
