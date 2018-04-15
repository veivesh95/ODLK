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
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            string query = "Select * from ProductCategory";
            Functions.ComboWithKey(catergorycombobox, query, "CatergoryId", "CatergoryName");

            string supplierquery = "Select SupId,SupName from Supplier where status= 'AVAILABLE'";
            Functions.ComboWithKey(supcombobox, supplierquery, "SupId", "SupName");

            string productquery = "select p.ProductId,p.ProductName,p.QuantityAvailable,p.SellingPrice,p.UnitPrice,pc.CatergoryId,pc.CatergoryName"
                                    +" from Product p,ProductCategory pc where p.CatergoryId = pc.CatergoryId";
            Functions.loadTable(productquery, productdgv);

            productidlbl.Text = Functions.getNextID("ProductId", "Product", "PRD");

            updtbtn.Visible = false;
           
            cancelbtn.Visible = false;

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string productid = productidlbl.Text;
            string productname = productnamebox.Text;
            int quantity = int.Parse(quantitybox.Text);
            double sellingprice = double.Parse(sellingpricebox.Text);
            double unitprice = double.Parse(unitpricebox.Text);
            string catergory= (((KeyValuePair<String, String>)catergorycombobox.SelectedItem).Key);
            string supplier = (((KeyValuePair<String, String>)supcombobox.SelectedItem).Key);
            double amount = unitprice * quantity;
            //adding to product table
            string addproductquery = "insert into Product values('" + productid + "','" + productname + "'," + quantity + "," + sellingprice + "," +
                                   "" + unitprice + ",'" + catergory + "')";
            Functions.ExecuteQuery(addproductquery);

            //adding to supplierpurchase table
            string SPId = Functions.getNextID("SPId", "SupplierPurchase", "SPS");
            string supplierpurchasequery = "insert into SupplierPurchase values('"+SPId+"','"+supplier+"','"+DateTime.Now+"',"+amount+")";
            Functions.ExecuteQuery(supplierpurchasequery);

            //adding to purchase product table
            string PPId = Functions.getNextID("PPId", "PurchaseProduct", "PPT");
            string purchaseproductquery = "insert into PurchaseProduct(PPId,SPId,ProductId,Quantity,price,SellingPrice) " +
                "values('" + PPId + "','" + SPId + "','" + productid + "'," + quantity + "," + unitprice + "," + sellingprice + ")";
            Functions.ExecuteQuery(purchaseproductquery);

            //adding to supplier payment table
            string supplierpaymentid = Functions.getNextID("SupPayId", "SupplierPayment", "SPY");
           
            string supplierpaymentquery = "insert into SupplierPayment(SupPayId,SupId,Amount,PayDate) values " +
                "('" + supplierpaymentid + "','" + supplier + "'," + amount + ",'" + DateTime.Now + "')";
            Functions.ExecuteQuery(supplierpaymentquery);

            //adding to payment paid table
            string paymentpaaidid = Functions.getNextID("PPId", "PaymentPaid", "PAP");
            string paymentpaidquery = "insert into PaymentPaid(PPId,Amount,Date,Supplier) " +
                                    "values('" + paymentpaaidid + "','" + amount + "','" + DateTime.Now + "','" + supplierpaymentid + "')";
            Functions.ExecuteQuery(paymentpaidquery);

            string productquery = "select p.ProductId,p.ProductName,p.QuantityAvailable,p.SellingPrice,p.UnitPrice,pc.CatergoryId,pc.CatergoryName"
                                   + " from Product p,ProductCategory pc where p.CatergoryId = pc.CatergoryId";
            Functions.loadTable(productquery, productdgv);


            productidlbl.Text= Functions.getNextID("ProductId", "Product", "PRD");
            productnamebox.Text="";
            quantitybox.Text="";
            sellingpricebox.Text = "";
            unitpricebox.Text = "";
            catergorycombobox.SelectedIndex = -1;
            supcombobox.SelectedIndex = -1;

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            InventoryANDSupplierHome ias = new InventoryANDSupplierHome();
            ias.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void newcatergortbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddupdtDelCategory ad = new AddupdtDelCategory(catergorycombobox);
            ad.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddupdtDelSupplier sp = new AddupdtDelSupplier(supcombobox);
            sp.Show();
        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            string productname = productnamebox.Text;
            float sellingprice = float.Parse(sellingpricebox.Text);
            string productid = productidlbl.Text;

            string query = "update Product set ProductName='" + productname + "', SellingPrice=" + sellingprice + " where ProductId= '" + productid + "'";
            Functions.ExecuteQuery(query);

            label5.Visible = true;
            supcombobox.Visible = true;
            linkLabel1.Visible = true;

            label1.Visible = true;
            catergorycombobox.Visible = true;
            newcatergortbtn.Visible = true;

            addbtn.Visible = true;
            updtbtn.Visible = false;

            cancelbtn.Visible = false;

            quantitybox.Enabled = true;
            unitpricebox.Enabled = true;

            productidlbl.Text = Functions.getNextID("ProductId", "Product", "PRD");
            productnamebox.Text = "";
            quantitybox.Text = "";
            unitpricebox.Text = ""; ;
            sellingpricebox.Text = "";

            string productquery = "select p.ProductId,p.ProductName,p.QuantityAvailable,p.SellingPrice,p.UnitPrice,pc.CatergoryId,pc.CatergoryName"
                                  + " from Product p,ProductCategory pc where p.CatergoryId = pc.CatergoryId";
            Functions.loadTable(productquery, productdgv);
        }

        private void productdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = productdgv.CurrentCell.RowIndex;
           // string catid = productdgv.Rows[row].Cells[0].Value.ToString();
            //string catname = productdgv.Rows[row].Cells[1].Value.ToString();

           
            catergorycombobox.SelectedItem= productdgv.Rows[row].Cells[6].Value.ToString();
            productidlbl.Text= productdgv.Rows[row].Cells[0].Value.ToString();
            productnamebox.Text= productdgv.Rows[row].Cells[1].Value.ToString();
            quantitybox.Text = productdgv.Rows[row].Cells[2].Value.ToString(); 
            unitpricebox.Text= productdgv.Rows[row].Cells[4].Value.ToString();
            sellingpricebox.Text= productdgv.Rows[row].Cells[3].Value.ToString();

            label5.Visible = false;
            supcombobox.Visible = false;
            linkLabel1.Visible = false;

            label1.Visible = false;
            catergorycombobox.Visible = false;
            newcatergortbtn.Visible = false;

            quantitybox.Enabled = false;
            unitpricebox.Enabled = false;

            addbtn.Visible = false;
            updtbtn.Visible = true;
           
            cancelbtn.Visible=true;


            //string productquery = "select p.ProductId,p.ProductName,p.QuantityAvailable,p.SellingPrice,p.UnitPrice,pc.CatergoryId,pc.CatergoryName"
            //                       + " from Product p,ProductCategory pc where p.CatergoryId = pc.CatergoryId";
            // Functions.loadTable(productquery, productdgv);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            supcombobox.Visible = true;
            linkLabel1.Visible = true;

            label1.Visible = true;
            catergorycombobox.Visible = true;
            newcatergortbtn.Visible = true;

            addbtn.Visible = true;
            updtbtn.Visible = false;
           
            cancelbtn.Visible = false;

            quantitybox.Enabled = true;
            unitpricebox.Enabled = true;

            productidlbl.Text = Functions.getNextID("ProductId", "Product", "PRD");
            productnamebox.Text = "";
            quantitybox.Text = "";
            unitpricebox.Text = ""; ;
            sellingpricebox.Text = "";
        }
    }
}
