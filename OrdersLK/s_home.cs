
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
    public partial class s_home : Form
    {
        private string tmpCustomer;
        private string tmpDate;
        private string tmpOrderId;
        private bool datePickerCheck = false;

        public s_home()
        {
            InitializeComponent();
        }

        private void s_home_Load(object sender, EventArgs e)
        {
            orderPendingTable.DataSource = Functions.showOrderedTableSales().DefaultView;
            this.orderPendingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ordersTable.DataSource = Functions.showTableSales().DefaultView;
            this.ordersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tabControl1.SelectedIndex = 0;
            Functions.LoadComboBoxes("SELECT * FROM Customer", comboCustomer, "CustomerName");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            s_add s = new s_add();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchQuery_TextChanged(object sender, EventArgs e)
        {
            Functions.LoadComboBoxes("SELECT * FROM Customer", comboCustomer, "CustomerName");
            string SearchKey = searchQuery.Text;

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                orderPendingTable.DataSource = Functions.searchSalesTable("OrderId", SearchKey);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                ordersTable.DataSource = Functions.searchSalesTable("OrderId", SearchKey);
            }
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = null;
            choice = comboCustomer.Text;

            this.tmpCustomer = Functions.getValue("Customer", "CustomerName", choice, "CustomerId");

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                orderPendingTable.DataSource = Functions.searchSalesTable("CustomerId", tmpCustomer);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                orderPendingTable.DataSource = Functions.searchSalesTable("CustomerId", tmpCustomer);
            }
        }

        private void comboCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            searchQuery.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.tmpDate = orderDatePicker.Value.ToString();
        }

        private void orderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.orderDatePicker.Checked != datePickerCheck)
            {
                this.tmpDate = orderDatePicker.Value.Date.ToString();
                Console.WriteLine(this.tmpDate);
            }
        }

        private void orderPendingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = this.orderPendingTable.Rows[e.RowIndex];
                this.tmpOrderId = row.Cells["OrderId"].Value.ToString();
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to cancel the order-" + tmpOrderId + " ?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Functions.UpdateCancelledOrder(tmpOrderId);

            }
            else if (dialogResult == DialogResult.No)
            {
                Console.WriteLine("Cancellation cancelled");
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
