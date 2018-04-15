using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OrdersLK
{
    public partial class AddDelivery : Form
    {
     
        

        public AddDelivery()
        {
            InitializeComponent();
        }

        private void AddDelivery_Load(object sender, EventArgs e)
        {          
            string query = "select * from Orders where OrderStatus='Confirmed'";
            Functions.loadTable(query, ViewOrdersDataGridView1);

            addbtn.Enabled = false;

            chooseDman();

           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewOrdersDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = ViewOrdersDataGridView1.CurrentCell.RowIndex;
            string orderid = ViewOrdersDataGridView1.Rows[row].Cells[0].Value.ToString();
            string customerid = ViewOrdersDataGridView1.Rows[row].Cells[4].Value.ToString();

            string queryorderitem = "select * from OrderItem where OrderId='" + orderid + "'";
            Functions.loadTable(queryorderitem, OrderItemGridView);
            string querycustomer = "select * from Customer where CustomerId='" + customerid + "'";
            Functions.loadTable(querycustomer, CustomerDataGridView3);

            ordidlabel.Text = orderid;
            cutidlabel.Text = customerid;
            addbtn.Enabled = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (delCost.Text != "" && CitycomboBox1.Text != "" && PaymentTypecomboBox2.Text != "")
            {
                string deliveryid = Functions.getNextID("DeliveryId", "Delivery", "DEL");
                float cost = float.Parse(delCost.Text);
                string city = CitycomboBox1.SelectedItem.ToString();
                string deliverystatus = "Processing";
                string deliverytype = PaymentTypecomboBox2.SelectedItem.ToString();
                string Empid = null;
                if (deliverytype!="Post")
                {
                    Empid = (((KeyValuePair<String, String>)DManCombo.SelectedItem).Key);
                }
               
                string orderid = ordidlabel.Text;
                string customerid = cutidlabel.Text;   //'"+  +"'

                int row = ViewOrdersDataGridView1.CurrentCell.RowIndex;
                float totalAmount = float.Parse(ViewOrdersDataGridView1.Rows[row].Cells[6].Value.ToString());

                if(Empid!=null)
                {
                    string deliveryquery1 = "insert into Delivery(DeliveryId,Cost,City,Status,DeliveryType,OrderId,CustomerId,EmployeeId)"
                    + "values('" + deliveryid + "','" + cost + "','" + city + "','" + deliverystatus + "','" + deliverytype + "','" + orderid + "','" + customerid + "', '" + Empid + "')";
                    Functions.ExecuteQuery(deliveryquery1);
                }
                else
                {
                    string deliveryquery = "insert into Delivery(DeliveryId,Cost,City,Status,DeliveryType,OrderId,CustomerId)"
                    + "values('" + deliveryid + "','" + cost + "','" + city + "','" + deliverystatus + "','" + deliverytype + "','" + orderid + "','" + customerid + "')";
                    Functions.ExecuteQuery(deliveryquery);
                }

               

                string orderupdtquery = "update Orders set OrderStatus='" + deliverystatus + "' where OrderId='" + orderid + "'";
                Functions.ExecuteQuery(orderupdtquery);

                string paymentid = Functions.getNextID("PPId", "PaymentPaid", "PAP");


                string delpaymentquery = "insert into PaymentPaid(PPId,Amount,Date,Delivery)"
                    + "values('" + paymentid + "','" + cost + "','" + DateTime.Now + "','" + deliveryid + "')";
                Functions.ExecuteQuery(delpaymentquery);


                delCost.Text = "";
                ordidlabel.Text = "";
                cutidlabel.Text = "";
                CitycomboBox1.SelectedIndex = -1;
                DManCombo.SelectedIndex = -1;
                PaymentTypecomboBox2.SelectedIndex = -1;
                OrderItemGridView.Columns.Clear();
                CustomerDataGridView3.Columns.Clear();

                string query = "select * from Orders where OrderStatus='Confirmed'";
                Functions.loadTable(query, ViewOrdersDataGridView1);
            }
            else
                MessageBox.Show("One or more fields are empty");



        }

        private void cutidlabel_Click(object sender, EventArgs e)
        {

        }

        private void delCost_TextChanged(object sender, EventArgs e)
        {
            string cost = delCost.Text;

            if (Functions.isLetter(cost))
            {
                errorProvider1.SetError(delCost, "can contain only numbers");
                addbtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                addbtn.Enabled = true;

            }
        }

        private void ordidlabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseDman()
        {
            string choosedman = "select Employee.FirstName, Employee.EmpId from Employee where Position = 'Deliveryboy'";
            Functions.ComboWithKey(DManCombo, choosedman, "EmpId", "FirstName");

        }

        private void back_Click(object sender, EventArgs e)
        {
            DeliveryMain mainForm = new DeliveryMain();
            this.Hide();
            mainForm.Show();
        }

        private void PaymentTypecomboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if(PaymentTypecomboBox2.SelectedIndex!=-1)
            {
                if (PaymentTypecomboBox2.SelectedItem.ToString() == "Post")
                {
                    DManCombo.Enabled = false;
                }
                else
                    DManCombo.Enabled = true;
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }//form
}//namespace
