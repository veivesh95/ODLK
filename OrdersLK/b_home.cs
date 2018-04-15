
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
    public partial class b_home : Form
    {
        public b_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b_add bh = new b_add();
            bh.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b_update bu = new b_update();
            bu.Show();
            this.Close();
        }

        private void b_home_Load(object sender, EventArgs e)
        {
            customerTable.DataSource = Functions.showTable("Customer").DefaultView;
            this.customerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            radio_contact.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchQuery_TextChanged(object sender, EventArgs e)
        {
            string SearchKey = searchQuery.Text;

            if (!radio_address.Checked || !radio_contact.Checked || !radio_email.Checked || !radio_name.Checked)
            {
                if (radio_contact.Checked)
                {
                    customerTable.DataSource = Functions.searchTable("Customer", "Contact", SearchKey);
                }

                if (radio_email.Checked)
                {
                    customerTable.DataSource = Functions.searchTable("Customer", "Email", SearchKey);
                }

                if (radio_name.Checked)
                {
                    customerTable.DataSource = Functions.searchTable("Customer", "CustomerName", SearchKey);
                }

                if (radio_address.Checked)
                {
                    customerTable.DataSource = Functions.searchTable("Customer", "Address", SearchKey);
                }
            }

            else
            {
                MessageBox.Show("Please check an option before entering a query");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
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
