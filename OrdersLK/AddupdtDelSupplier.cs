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
    public partial class AddupdtDelSupplier : Form
    {
        public AddupdtDelSupplier()
        {
            InitializeComponent();
            addsupplierforinventrybtn.Visible = false;
        }

        ComboBox scb;
        public AddupdtDelSupplier(ComboBox cb)
        {
            InitializeComponent();
            scb = cb;
           
            addbtn.Visible = false;
            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = true;
        }

        private void InventorySupplierHome_Load(object sender, EventArgs e)
        {
            string query = "select SupId,SupName,Address,Contact from Supplier where status = 'AVAILABLE'";
            Functions.loadTable(query, supplierdgv);

           string  newsupId = Functions.getNextID("SupId", "Supplier", "SUP");
            SupIdLabel.Text = newsupId;

            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;
            
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string supid = SupIdLabel.Text;
            string name = namebox.Text;
            string address = addressbox.Text;
            string contact = contactbox.Text;
            string status = "AVAILABLE";
            //double creditbalance = 0;

            string query = "insert into Supplier values('" + supid + "','" + name + "','" + address + "','" + contact + "','" + status + "')";
            Functions.ExecuteQuery(query);


            string query1 = "select SupId,SupName,Address,Contact from Supplier where status = 'AVAILABLE'";
            Functions.loadTable(query1, supplierdgv);

            string newsupId = Functions.getNextID("SupId", "Supplier", "SUP");
            SupIdLabel.Text = newsupId;

            namebox.Text = "";
            addressbox.Text = "";
            contactbox.Text = "";

        }

        private void supplierdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addbtn.Visible = false;
            updtbtn.Visible = true;
            delbtn.Visible = true;
            cancelbtn.Visible = true;

            int row = supplierdgv.CurrentCell.RowIndex;
            string Supid = supplierdgv.Rows[row].Cells[0].Value.ToString();
            string name = supplierdgv.Rows[row].Cells[1].Value.ToString();
            string address = supplierdgv.Rows[row].Cells[2].Value.ToString();
            string contact = supplierdgv.Rows[row].Cells[3].Value.ToString();

            SupIdLabel.Text = Supid;
            namebox.Text = name;
            addressbox.Text = address;
            contactbox.Text = contact;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;

            string newsupId = Functions.getNextID("SupId", "Supplier", "SUP");
            SupIdLabel.Text = newsupId;

            namebox.Text = "";
            addressbox.Text = "";
            contactbox.Text = "";
        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            string supid = SupIdLabel.Text;
            string name = namebox.Text;
            string address = addressbox.Text;
            string contact = contactbox.Text;

            string query = "update Supplier set SupName='" + name + "',Address='" + address + "',"
                + "Contact='" + contact + "' where SupId='" + supid + "'";
            Functions.ExecuteQuery(query);



            string query1 = "select SupId,SupName,Address,Contact from Supplier where status = 'AVAILABLE'";
            Functions.loadTable(query1, supplierdgv);

            string newsupId = Functions.getNextID("SupId", "Supplier", "SUP");
            SupIdLabel.Text = newsupId;

            namebox.Text = "";
            addressbox.Text = "";
            contactbox.Text = "";
            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string supid = SupIdLabel.Text;
           
            string query = "update Supplier set status='NOT AVAILABLE' where SupId='" + supid + "'";
            Functions.ExecuteQuery(query);



            string query1 = "select SupId,SupName,Address,Contact from Supplier where status = 'AVAILABLE'";
            Functions.loadTable(query1, supplierdgv);

            string newsupId = Functions.getNextID("SupId", "Supplier", "SUP");
            SupIdLabel.Text = newsupId;

            namebox.Text = "";
            addressbox.Text = "";
            contactbox.Text = "";
            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            InventoryANDSupplierHome a = new InventoryANDSupplierHome();
            a.Show();
            this.Hide();
        }

        private void addsupplierforinventrybtn_Click(object sender, EventArgs e)
        {
            string supid = SupIdLabel.Text;
            string name = namebox.Text;
            string address = addressbox.Text;
            string contact = contactbox.Text;
            string status = "AVAILABLE";
            //double creditbalance = 0;

            string query = "insert into Supplier values('" + supid + "','" + name + "','" + address + "','" + contact + "','" + status + "')";
            Functions.ExecuteQuery(query);


            string supplierquery = "Select SupId,SupName from Supplier where status= 'AVAILABLE'";
            Functions.ComboWithKey(scb, supplierquery, "SupId", "SupName");

            this.Hide();
        }
    }
}
