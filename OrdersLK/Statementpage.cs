using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OrdersLK
{
    public partial class Statementpage : Form
    {
        public Statementpage()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AccountsPage ap = new AccountsPage();
            this.Hide();
            ap.Show();

        }

        private void Statementpage_Load(object sender, EventArgs e)
        {
            fromdatepicker.MaxDate = DateTime.Now;
            todatepicker.MaxDate = DateTime.Now;

            paycatergorycombo.SelectedIndex = 0;

            string query = "select * from PaymentPaid";
            Functions.loadTable(query, paymentsdgv);

            pdfbtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            incomestatement icstmnt = new incomestatement();
            icstmnt.Show();
            //DateTime fromdate = fromdatepicker.Value;
            //DateTime todate = todatepicker.Value;
            //double totalSales=0;
            //double salesCost=0;
            //double profit=0;

            //string query = "select SUM(p.SellingPrice*oi.Quantity) as TotalSales," +
            //              "SUM(p.UnitPrice*oi.Quantity) as TotalSalesCost," +
            //              "SUM(p.SellingPrice*oi.Quantity)-SUM(p.UnitPrice*oi.Quantity) as Profit" +
            //              " from Orderitem oi,Product p, Orders o" +
            //              " where o.OrderId = oi.OrderId AND oi.ProductId = p.ProductId AND " +
            //              "o.OrderDate BETWEEN '" + fromdate + "' AND '" + todate + "'";

            //DataTable dt = Functions.getData(query);
            ////Functions.loadTable(query, dataGridView1);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    if (dr.ItemArray.GetValue(0).ToString()!="")
            //    {
            //        var aaa = dr.ItemArray.GetValue(0).ToString();
            //        totalSales = double.Parse(dr["TotalSales"].ToString());
            //        salesCost = double.Parse(dr["TotalSalesCost"].ToString());
            //        profit = double.Parse(dr["Profit"].ToString());
            //    }

            //}

            //string text = "Total Sales \t" + totalSales + System.Environment.NewLine+
            //              "Total Cost \t" + salesCost + System.Environment.NewLine +
            //              "Profit \t\t" + profit +System.Environment.NewLine;

            //textBox1.Text = text;

        }

        private void pdfbtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string filename = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month+ "_" + DateTime.Now.Day+ "-" + DateTime.Now.Hour + "." + DateTime.Now.Minute;
            //    Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            //    PdfWriter pdfwri = PdfWriter.GetInstance(doc, new FileStream("G:\\"+ filename + ".pdf", FileMode.Create));
            //    doc.Open();
            //    Paragraph p = new Paragraph(textBox1.Text);
            //    doc.Add(p);
            //   // doc.AddHeader("Orders.lk", p.ToString());
            //    doc.Close();
            //    System.Diagnostics.Process.Start("G:\\" + filename + ".pdf");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
           
        }

        private void fromdatepicker_ValueChanged(object sender, EventArgs e)
        {
            todatepicker.MinDate = fromdatepicker.Value;
        }

        private void todatepicker_ValueChanged(object sender, EventArgs e)
        {
            fromdatepicker.MaxDate = todatepicker.Value;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            DateTime fromdate = fromdatepicker.Value;
            DateTime todate = todatepicker.Value.AddHours(23);
            string caterogry=paycatergorycombo.SelectedItem.ToString();

            if (caterogry == "ALL")
            {
                string query = "select * from PaymentPaid where Date BETWEEN '" + fromdate + "' AND '" + todate + "'";
                Functions.loadTable(query, paymentsdgv);
            }
            else
            {
                string query = "select * from PaymentPaid where "+caterogry+" IS NOT NULL AND Date BETWEEN '" + fromdate + "' AND '" + todate + "'";
                Functions.loadTable(query, paymentsdgv);
            }

            
        }

        private void paycatergorycombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catergory = paycatergorycombo.SelectedItem.ToString();

            if (catergory == "ALL")
            {
                string query = "select * from PaymentPaid";
                Functions.loadTable(query, paymentsdgv);
            }
            else
            {
                string query = "select * from PaymentPaid where " + catergory + " IS NOT NULL";
                Functions.loadTable(query, paymentsdgv);
            }
        }
    }
}