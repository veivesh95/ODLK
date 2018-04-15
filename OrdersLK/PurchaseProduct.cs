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
    public partial class Purchasedproduct : Form
    {
        public Purchasedproduct()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            InventoryANDSupplierHome i = new InventoryANDSupplierHome();
            i.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void PurchaseProduct_Load(object sender, EventArgs e)
        {
            string query = "Select * from Product";
            Functions.ComboWithKey(productcombobox, query, "ProductId", "ProductName");

            string supquery = "select * from Supplier where status='AVAILABLE'";
            Functions.ComboWithKey(supcombobox, supquery, "SupId", "SupName");
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)addproductdgv.Rows[0].Clone();
            row.Cells[0].Value = (((KeyValuePair<String, String>)productcombobox.SelectedItem).Key);
            row.Cells[1].Value = (((KeyValuePair<String, String>)productcombobox.SelectedItem).Value);
            row.Cells[2].Value = int.Parse(quantitybox.Text);
            row.Cells[3].Value = float.Parse(unitpricebox.Text);
            row.Cells[4].Value = float.Parse(sellingpricbox.Text);
            row.Cells[5].Value = int.Parse(quantitybox.Text) * float.Parse(unitpricebox.Text);

            addproductdgv.Rows.Add(row);

            float grandtotal=float.Parse(grandtotlbl.Text) + int.Parse(quantitybox.Text) * float.Parse(unitpricebox.Text);
            grandtotlbl.Text = grandtotal.ToString();

            productcombobox.SelectedIndex = -1;
            quantitybox.Text = "";
            unitpricebox.Text = "";
            sellingpricbox.Text = "";
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int rowsc = addproductdgv.CurrentCell.RowIndex;
            float amount = float.Parse(addproductdgv.Rows[rowsc].Cells[5].Value.ToString());
            addproductdgv.Rows.RemoveAt(rowsc);
            float grandtotal = float.Parse(grandtotlbl.Text) -amount;
            grandtotlbl.Text = grandtotal.ToString();

            //foreach (DataGridViewRow row in addproductdgv.SelectedRows)
            //{
            //    if (!row.IsNewRow)
            //        addproductdgv.Rows.Remove(row);
            //}
        }

        private void addtoproductbtn_Click(object sender, EventArgs e)
        {
            string supplier= (((KeyValuePair<String, String>)supcombobox.SelectedItem).Key);
            float grandtotal = float.Parse(grandtotlbl.Text);
            DateTime date = DateTime.Now;

            string supplierpurchaseid = Functions.getNextID("SPId", "SupplierPurchase", "SPS");
            string supplierpurchasequery = "insert into SupplierPurchase values('" + supplierpurchaseid + "','" + supplier + "','" + date + "',"+grandtotal+")";
            Functions.ExecuteQuery(supplierpurchasequery);

            for (int i = 0; i < addproductdgv.Rows.Count - 1; i++)
            {
                string purchaseproductid = Functions.getNextID("PPId", "PurchaseProduct", "PPT");
                string productid = addproductdgv.Rows[i].Cells[0].Value.ToString();
                int quantity= int.Parse(addproductdgv.Rows[i].Cells[2].Value.ToString());
                float price= float.Parse(addproductdgv.Rows[i].Cells[3].Value.ToString());
                float sellingprice= float.Parse(addproductdgv.Rows[i].Cells[4].Value.ToString());

                string purchaseproductquery = "insert into PurchaseProduct values('" + purchaseproductid + "'," +
                                             "'" + supplierpurchaseid + "','" + productid + "'," + quantity + "," + price + "," + sellingprice + ")";
                Functions.ExecuteQuery(purchaseproductquery);

                string getqtyquery = "Select QuantityAvailable from Product where ProductId= '" + productid + "'";
                int productqty =int.Parse( Functions.getVal("QuantityAvailable",getqtyquery));

                string getunitpricequery = "Select UnitPrice from Product where ProductId= '" + productid + "'";
                float productunitprice = float.Parse(Functions.getVal("UnitPrice", getunitpricequery));

                int newqty = productqty + quantity;
                float newunitprice = ((productqty * productunitprice) + (quantity * price)) / newqty;

                string productupdtqry = "update Product set QuantityAvailable=" + newqty + ",UnitPrice=" + newunitprice + " where ProductId='" + productid + "'";
                Functions.ExecuteQuery(productupdtqry);

            }


            string supplierpaymentid = Functions.getNextID("SupPayId", "SupplierPayment", "SPY");
            string suppayqry = "insert into SupplierPayment values('" + supplierpaymentid + "','"+supplier+"',"+grandtotal+",'"+date+"')";
            Functions.ExecuteQuery(suppayqry);

            string paymentpaidid = Functions.getNextID("PPId", "PaymentPaid", "PAP");
            string paymentquery = "insert into PaymentPaid(PPId,Amount,Date,Supplier) values('" + paymentpaidid + "'," + grandtotal + ",'" + date + "','" + supplierpaymentid + "')";
            Functions.ExecuteQuery(paymentquery);


            grandtotlbl.Text = "0";
            supcombobox.SelectedIndex = -1;
            addproductdgv.Rows.Clear();
        }
    }
}
