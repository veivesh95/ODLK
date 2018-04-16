
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

            groupBox2.Visible = false;
            lblStatus.Visible = false;
            cmbStatus.Visible = false;
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
                orderPendingTable.DataSource = Functions.searchPendingOrdersTable("OrderId", SearchKey);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                ordersTable.DataSource = Functions.searchSalesTable("OrderId", SearchKey);
            }
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedIndex != -1)
            {
                string choice = null;
                choice = comboCustomer.Text;

                this.tmpCustomer = Functions.getValue("Customer", "CustomerName", choice, "CustomerId");

                if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
                {
                    orderPendingTable.DataSource = Functions.searchPendingOrdersTable("CustomerId", tmpCustomer);
                }
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
                {
                    ordersTable.DataSource = Functions.searchSalesTable("CustomerId", tmpCustomer);
                }
            }
        }

        private void comboCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            searchQuery.Clear();
            cmbStatus.SelectedIndex = -1;
        }
        
        private void orderPendingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
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
        }

        private void copyAlltoClipboard()
        {
            ordersTable.SelectAll();
            DataObject dataObj = ordersTable.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ordersTable.RowCount != 0)
            {
                try
                {
                    copyAlltoClipboard();
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Microsoft.Office.Interop.Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err);
                }
                finally
                {
                    ordersTable.DataSource = Functions.showTableSales().DefaultView;
                }
            }
            else
                MessageBox.Show("None to export");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                groupBox2.Visible = false;
                lblStatus.Visible = false;
                cmbStatus.Visible = false;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                groupBox2.Visible = true;
                lblStatus.Visible = true;
                cmbStatus.Visible = true;
            }
        }

        private void monthPicker_ValueChanged(object sender, EventArgs e)
        {
            int month = monthPicker.Value.Month;
            ordersTable.DataSource = Functions.showTableSales(month).DefaultView;

            if (ordersTable.RowCount == 0)
            {
                btnExport.Enabled = false;
            }
            else
                btnExport.Enabled = true;
        }

        private void ordersTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in ordersTable.Rows)
            {
                if (Myrow.Cells[2].Value.ToString() == "Cancelled")
                {
                    Myrow.Cells[2].Style.BackColor = Color.LightSalmon;
                }
                else if (Myrow.Cells[2].Value.ToString() == "Confirmed")
                {
                    Myrow.Cells[2].Style.BackColor = Color.LightGreen;
                }
                else if (Myrow.Cells[2].Value.ToString() == "Processing")
                {
                    Myrow.Cells[2].Style.BackColor = Color.Yellow;
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex != -1)
            {
                String choice = cmbStatus.SelectedItem.ToString();
                ordersTable.DataSource = Functions.showTableSales(choice);
            }
        }

        private void searchQuery_MouseClick(object sender, MouseEventArgs e)
        {
            cmbStatus.SelectedIndex = -1;
            comboCustomer.SelectedIndex = -1;
        }

        private void cmbStatus_MouseClick(object sender, MouseEventArgs e)
        {
            searchQuery.Clear();
            comboCustomer.SelectedIndex = -1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                orderPendingTable.DataSource = Functions.showOrderedTableSales().DefaultView;
                searchQuery.Clear();
                comboCustomer.SelectedIndex = -1;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                ordersTable.DataSource = Functions.showTableSales().DefaultView;
                searchQuery.Clear();
                comboCustomer.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
            }
        }
    }
}
