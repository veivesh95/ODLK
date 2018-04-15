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
using Excel = Microsoft.Office.Interop.Excel;

namespace OrdersLK
{
    public partial class ViewConfirmedDeliveryDetails : Form
    {
        string ordId;
        string deliveryId;
        public ViewConfirmedDeliveryDetails()
        {
            InitializeComponent();
        }

        private void ViewConfirmedDeliveryDetails_Load(object sender, EventArgs e)
        {
            string veiwConfirmedDeliveryQuery = "select d.DeliveryId,d.Cost,d.City,d.Status,d.DeliveryType,d.OrderId,d.CustomerId,E.FirstName as 'Delivery Employee' from Delivery d LEFT JOIN Employee E ON D.EmployeeId=E.EmpId";
            Functions.loadTable(veiwConfirmedDeliveryQuery, ViewDeliverydataGridView1);

            cancelDelivery.Enabled = false;
            Update.Enabled = false;

        }

        private void copyAlltoClipboard()
        {
            ViewDeliverydataGridView1.SelectAll();
            DataObject dataObj = ViewDeliverydataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);  
        }

        
        private void ViewDeliverydataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int row = ViewDeliverydataGridView1.CurrentCell.RowIndex;
            ordId = ViewDeliverydataGridView1.Rows[row].Cells[5].Value.ToString();
            deliveryId = ViewDeliverydataGridView1.Rows[row].Cells[0].Value.ToString();
            string Status = ViewDeliverydataGridView1.Rows[row].Cells[3].Value.ToString();

            if (Status == "Cancelled" || Status == "Delivered")
            {
                cancelDelivery.Enabled = false;
                Update.Enabled = false;
            }
            else {
                cancelDelivery.Enabled = true;
                Update.Enabled = true;
            }
        }

        private void cancelDelivery_Click(object sender, EventArgs e)
        {
            String deliveryStatus = "Cancelled";
            int row = ViewDeliverydataGridView1.CurrentCell.RowIndex;
            
            string orderQuery = "update Delivery set Status = '" + deliveryStatus + "' where DeliveryId = '" + deliveryId + "'";
            Functions.ExecuteQuery(orderQuery);

            string showupdatedquery = "select * from Delivery";
            Functions.loadTable(showupdatedquery, ViewDeliverydataGridView1);

            string orderupdtqry = "update Orders set OrderStatus = '" + deliveryStatus + "' where OrderId = '" + ordId + "'";
            Functions.ExecuteQuery(orderupdtqry);


            string orderitemquery = "Select * from OrderItem where OrderId = '" + ordId + "'";
            Functions.delOrderItems(orderitemquery);

            string veiwConfirmedDeliveryQuery = "select d.DeliveryId,d.Cost,d.City,d.Status,d.DeliveryType,d.OrderId,d.CustomerId,E.FirstName as 'Delivery Employee' from Delivery d LEFT JOIN Employee E ON D.EmployeeId=E.EmpId";
            Functions.loadTable(veiwConfirmedDeliveryQuery, ViewDeliverydataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string selectDeliveryCost = "select Cost from Delivery where DeliveryId = '" + deliveryId + "'";
            float DelCost = float.Parse(Functions.getVal("Cost", selectDeliveryCost));

            string selectSalesAmount = "select TotalAmount from Orders where OrderId ='" + ordId + "'";
            float OrderAmt = float.Parse(Functions.getVal("TotalAmount", selectSalesAmount));

            float total = DelCost + OrderAmt;

            string paymentid = Functions.getNextID("PRId", "PaymentReceived", "PYR");


            string delpaymentquery = "insert into PaymentReceived "
                + "values('" + paymentid + "','" + date + "','" + total + "','" + ordId + "')";
            Functions.ExecuteQuery(delpaymentquery);

           

            string updateDelivery = "Delivered";
            string updateDelQuery = "update Delivery set Status = '" + updateDelivery + "' where DeliveryId ='" + deliveryId + "' ";
            Functions.ExecuteQuery(updateDelQuery);

            string veiwConfirmedDeliveryQuery = "select d.DeliveryId,d.Cost,d.City,d.Status,d.DeliveryType,d.OrderId,d.CustomerId,E.FirstName as 'Delivery Employee' from Delivery d LEFT JOIN Employee E ON D.EmployeeId=E.EmpId";
            Functions.loadTable(veiwConfirmedDeliveryQuery, ViewDeliverydataGridView1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            DeliveryMain mainForm = new DeliveryMain();
            this.Hide();
            mainForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
