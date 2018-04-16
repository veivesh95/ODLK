
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
        private Boolean checker = false;

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

            if (this.buyerName != "")
            {
                if (Functions.isName(this.buyerName))
                {
                    this.checker = true;
                }
                else
                    this.checker = false;
            }

            if (this.buyerAddress != ".")
            {
                this.checker = true;
            }
            else this.checker = false;

            if (this.buyerContact != "")
            {
                if (Functions.isContact(this.buyerContact))
                {
                    this.checker = true;
                }
            }
            else this.checker = false;

            if ((this.buyerName != "" && Functions.isName(this.buyerName)) && (this.buyerAddress != ".") && ((this.buyerContact != "") && (Functions.isContact(this.buyerContact))))
            {
                if (this.buyerEmail != "")
                {
                    if (Functions.EmailIsValid(this.buyerEmail))
                    {
                        string mailYesQuery = "INSERT into Customer values ('" + buyerId + "','" + buyerName + "','" + buyerAddress + "','" + buyerContact + "','" + buyerEmail + "')";
                        Functions.ExecuteQuery(mailYesQuery);

                        Functions.ClearAllText(this);
                        this.Close();

                        b_home bh1 = new b_home();
                        bh1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please recheck your Email address");
                    }
                }
                else if (this.buyerEmail == "" || this.buyerEmail == null)
                {
                    try
                    {
                        string query_ = "INSERT into Customer (CustomerId, CustomerName, Address, Contact) values ('" + buyerId + "','" + buyerName + "','" + buyerAddress + "','" + buyerContact + "')";
                        Functions.ExecuteQuery(query_);

                        Functions.ClearAllText(this);
                        this.Close();

                        b_home bh = new b_home();
                        bh.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Some Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please recheck your entry!");
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
