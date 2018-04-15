
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersLK
{
    public partial class b_update : Form
    {
        private string bName;
        private string bAddress;
        private string bContact;
        private string bMail;
        private string bId;

        public b_update()
        {
            InitializeComponent();
        }

        private void b_update_Load(object sender, EventArgs e)
        {
            fillList();
        }

        private void fillList()
        {
            Functions.FillList("Customer", "CustomerName", "CustomerName", listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bId = Functions.getValue("Customer", "CustomerName", listBox1.Text, "CustomerId");
            DataTable tempTable = Functions.GetListData("Customer", "CustomerName", listBox1.Text);

            foreach (DataRow dr in tempTable.Rows)
            {
                bName = dr["CustomerName"].ToString();
                bAddress = dr["Address"].ToString();
                bContact = dr["Contact"].ToString();
                bMail = dr["Email"].ToString();
            }

            txtCusName.Text = bName;
            txtContact.Text = bContact;
            txtMail.Text = bMail;
            txtAddress.Text = bAddress;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if ((txtCusName.Text != "" || !string.IsNullOrEmpty(txtCusName.Text) || !string.IsNullOrWhiteSpace(txtCusName.Text))
            && (!string.IsNullOrEmpty(txtAddress.Text) || !string.IsNullOrWhiteSpace(txtAddress.Text))
            && (!string.IsNullOrEmpty(txtContact.Text) || !string.IsNullOrWhiteSpace(txtContact.Text))
            && (!string.IsNullOrEmpty(txtAddress.Text) || !string.IsNullOrWhiteSpace(txtAddress.Text))

            && Functions.isText(txtCusName.Text)
            && Functions.isValid(txtMail.Text)
            && Functions.isContact(txtContact.Text))
            {
                string query_ = "UPDATE Customer SET CustomerName = '" + txtCusName.Text
                                    + "', Address = '" + txtAddress.Text
                                    + "', Contact = '" + txtContact.Text
                                    + "', Email = '" + txtMail.Text
                                    + "' WHERE CustomerId = '" + this.bId + "'";
                Functions.ExecuteQuery(query_);

                this.listBox1.Items.Clear();
                fillList();
            }

            else
            {
                MessageBox.Show("Invalid information given. Check the entries again.");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            b_home b = new b_home();
            b.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}