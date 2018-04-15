using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OrdersLK
{
    public partial class incomestatement : Form
    {
        public incomestatement()
        {
            InitializeComponent();
        }

       
       

        private void btn_Click(object sender, EventArgs e)
        {
            DateTime fromdate = fromdatepicker.Value;
            fromdate = new DateTime(fromdate.Year, fromdate.Month, 1);
            DateTime todate = todatepicker.Value;
            todate = new DateTime(todate.Year, todate.Month, DateTime.DaysInMonth(todate.Year, todate.Month)).AddHours(23);
            double totalSales = 0;
            double salesCost = 0;
            double profit = 0;
            double pettycash = 0;
            double delivery = 0;
            double salary = 0;
            double totalexpenses = 0;

            if (fromdate != null || todate != null)
            {
                string query = "select SUM(p.SellingPrice*oi.Quantity) as TotalSales," +
                          "SUM(p.UnitPrice*oi.Quantity) as TotalSalesCost," +
                          "SUM(p.SellingPrice*oi.Quantity)-SUM(p.UnitPrice*oi.Quantity) as Profit" +
                          " from Orderitem oi,Product p, Orders o" +
                          " where o.OrderId = oi.OrderId AND oi.ProductId = p.ProductId AND " +
                          "o.OrderDate BETWEEN '" + fromdate + "' AND '" + todate + "'";

                DataTable dt = Functions.getData(query);
                //Functions.loadTable(query, dataGridView1);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr.ItemArray.GetValue(0).ToString() != "")
                    {
                        var aaa = dr.ItemArray.GetValue(0).ToString();
                        totalSales = double.Parse(dr["TotalSales"].ToString());
                        salesCost = double.Parse(dr["TotalSalesCost"].ToString());
                    }

                }

                string pettyquery = "select SUM(Amount)as Amount from PaymentPaid where PettyCash is not null AND Date BETWEEN '" + fromdate + "' AND '" + todate + "'";
                pettycash = double.Parse(Functions.getVal("Amount", pettyquery));
                string deliveryquery = "select SUM(Amount) as Amount from PaymentPaid where Delivery is not null AND Date BETWEEN '" + fromdate + "' AND '" + todate + "'";
                delivery= double.Parse(Functions.getVal("Amount", deliveryquery));
                string salaryqyery = "select SUM(Amount) as Amount from PaymentPaid where Salary is not null AND Date BETWEEN '" + fromdate + "' AND '" + todate + "'";
                salary= double.Parse(Functions.getVal("Amount", salaryqyery));

                totalexpenses = salesCost + pettycash + delivery + salary;
                profit = totalSales - totalexpenses;

                datelbel.Text = DateTime.Now.ToShortDateString();
                totsaleslabel.Text = totalSales.ToString();
                costofsaleslabel.Text = salesCost.ToString();
                pettycashlabel.Text = pettycash.ToString();
                deliverylabel.Text = delivery.ToString();
                salarylabel.Text = salary.ToString();
                totexpenseslabel.Text = totalexpenses.ToString();
                netprofitlabel.Text = profit.ToString();
                fromlabel.Text = fromdate.ToShortDateString();
                tolabel.Text = todate.ToShortDateString();
                panel1.Visible = true;
            }


        }



        private void IncomeStatement_Load(object sender, EventArgs e)
        {
            this.panel1.Visible = false;

            fromdatepicker.MaxDate = DateTime.Now;
            todatepicker.MaxDate = DateTime.Now;


           

        }

        private void fromdatepicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromdate1 = fromdatepicker.Value;
            fromdate1= new DateTime(fromdate1.Year, fromdate1.Month, 1);

            todatepicker.MinDate = fromdate1;
        }

        private void todatepicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime todate1 = todatepicker.Value;
            todate1= new DateTime(todate1.Year, todate1.Month, DateTime.DaysInMonth(todate1.Year, todate1.Month)).AddHours(23);

            fromdatepicker.MaxDate = todate1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string filename = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "-" + DateTime.Now.Hour + "." + DateTime.Now.Minute;
            //    Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            //    PdfWriter pdfwri = PdfWriter.GetInstance(doc, new FileStream("G:\\" + filename + ".pdf", FileMode.Create));


                
            //    doc.Open();
            //    //doc.AddDocListener(panel1);
            //    //doc.Add(panel1);
                
            //    // doc.AddHeader("Orders.lk", p.ToString());
            //    doc.Close();
            //    System.Diagnostics.Process.Start("G:\\" + filename + ".pdf");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statementpage p = new Statementpage();
            p.Show();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
