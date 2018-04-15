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
    public partial class b_update_single : Form
    {
        s_add sa = new s_add();
        private string bName;
        private string bContact;
        private string bMail;
        private string bId;

        public b_update_single()
        {
            InitializeComponent();
        }

        private void b_update_single_Load(object sender, EventArgs e)
        {
            this.bId = sa.buyerObj;
            DataTable tempTable = Functions.GetListData("Customer", "CustomerId", this.bId);

            foreach (DataRow dr in tempTable.Rows)
            {
                bName = dr["CustomerName"].ToString();
                bContact = dr["Contact"].ToString();
                bMail = dr["Email"].ToString();
            }

            txtCusName.Text = bName;
            txtContact.Text = bContact;
            txtMail.Text = bMail;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Functions.isValid(txtMail.Text))
            {
                string query_ = "UPDATE Customer SET Email = '" + txtMail.Text + "' WHERE CustomerId = '" + this.bId + "'";

                try
                {
                    Functions.ExecuteQuery(query_);
                    txtMail.Enabled = false;
                    this.Close();
                }
                catch (Exception)
                {
                    throw;
                }

            }

            else
            {
                MessageBox.Show("Invalid data. Please recheck.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
