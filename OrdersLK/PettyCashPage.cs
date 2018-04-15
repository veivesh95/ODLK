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
    public partial class PettyCashPage : Form
    {
        public PettyCashPage()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AccountsPage ap = new AccountsPage();
            this.Hide();
            ap.Show();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
           
            string pettychadId = Functions.getNextID("PcId", "PettyCash", "PCI");
            string pccatergory = catergorycombobox.SelectedItem.ToString();
            string Description = descbox.Text;
            float amount = float.Parse(amountbox.Text);
            DateTime date = DateTime.Now;

            
            string query = "insert into PettyCash VALUES('"+ pettychadId + "','"+ pccatergory + "','"+ Description + "','"+ amount + "','"+date+"')";
            Functions.ExecuteQuery(query);

            string paymentid = Functions.getNextID("PPId", "PaymentPaid", "PAP");
            string payementquery = "insert into PaymentPaid(PPId,Amount,Date,PettyCash)values('" + paymentid + "'," + amount + ",'" + date + "','" + pettychadId + "')";
            Functions.ExecuteQuery(payementquery);

            Functions.DisplayData("PettyCash", PettyCashGridView);

            Functions.LoadComboBox("PettyCash", ctgrycombobox, "Catergory");

            catergorycombobox.SelectedIndex = -1;
            descbox.Clear();
            amountbox.Clear();

        }

        private void PettyCashPage_Load(object sender, EventArgs e)
        {



            Functions.DisplayData("PettyCash", PettyCashGridView);

            Functions.LoadComboBox("PettyCash", ctgrycombobox, "Catergory");


            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;
            pclabel.Visible = false;
            pettcashidlabel.Visible = false;
        }

        private void PettyCashGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addbtn.Visible = false;
            updtbtn.Visible = true;
            delbtn.Visible = true;
            cancelbtn.Visible = true;
            pclabel.Visible = true;
            pettcashidlabel.Visible = true;

            int row = PettyCashGridView.CurrentCell.RowIndex;
            string pcid= PettyCashGridView.Rows[row].Cells[0].Value.ToString();
            string catergory= PettyCashGridView.Rows[row].Cells[1].Value.ToString();
            string description= PettyCashGridView.Rows[row].Cells[2].Value.ToString();
            string amount= PettyCashGridView.Rows[row].Cells[3].Value.ToString();

            pettcashidlabel.Text = pcid;
            catergorycombobox.SelectedItem = catergory;
            descbox.Text = description;
            amountbox.Text = amount;

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;
            pclabel.Visible = false;
            pettcashidlabel.Visible = false;

            catergorycombobox.SelectedIndex = -1;
            descbox.Clear();
            amountbox.Clear();


        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            string pettychadId = pettcashidlabel.Text;
            string pccatergory = catergorycombobox.SelectedItem.ToString();
            string Description = descbox.Text;
            float amount = float.Parse(amountbox.Text);

            string query = "update PettyCash set Catergory='"+ pccatergory + "',Description='"+ Description + "',"
                +"Amount='"+ amount + "' where PcId='"+ pettychadId + "'";
            Functions.ExecuteQuery(query);

            string updtpaymentquery = "update PaymentPaid set Amount=" + amount + " where PettyCash='" + pettychadId + "'";
            Functions.ExecuteQuery(updtpaymentquery);

            Functions.DisplayData("PettyCash", PettyCashGridView);

            Functions.LoadComboBox("PettyCash", ctgrycombobox, "Catergory");

            catergorycombobox.SelectedIndex = -1;
            descbox.Clear();
            amountbox.Clear();
            pettcashidlabel.Text = "      ";
            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;
            pclabel.Visible = false;
            pettcashidlabel.Visible = false;


        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            AccountsPage ap = new AccountsPage();
            ap.Show();
            this.Hide();
        }

        private void homebtn_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string pettycashId = pettcashidlabel.Text;

            string dltquery= "delete from PettyCash where PcId='"+pettycashId+"'";
            Functions.ExecuteQuery(dltquery);

            string delpaymentquery = "delete from PaymentPaid where PettyCash='" + pettycashId + "'";
            Functions.ExecuteQuery(delpaymentquery);

            Functions.DisplayData("PettyCash", PettyCashGridView);

            Functions.LoadComboBox("PettyCash", ctgrycombobox, "Catergory");

            catergorycombobox.SelectedIndex = -1;
            descbox.Clear();
            amountbox.Clear();
            pettcashidlabel.Text = "      ";
            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
            cancelbtn.Visible = false;
            pclabel.Visible = false;
            pettcashidlabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchvalue = ctgrycombobox.SelectedItem.ToString();
            //Functions.SearchGridview(PettyCashGridView, searchvalue);
            string query= "select * from PettyCash order by Date Desc";
            if (searchvalue != "ALL")
                query = "select * from PettyCash where Catergory= '" + searchvalue + "' order by Date Desc";

            Functions.loadTable(query, PettyCashGridView);


        }

        private void ctgrycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchvalue = ctgrycombobox.SelectedItem.ToString();
            //Functions.SearchGridview(PettyCashGridView, searchvalue);
            string query = "select * from PettyCash order by Date Desc";
            if (searchvalue != "ALL")
                query = "select * from PettyCash where Catergory= '" + searchvalue + "' order by Date Desc";

            Functions.loadTable(query, PettyCashGridView);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void filterbtn_Click(object sender, EventArgs e)
        {
            DateTime fromdate = fromdatepicker.Value.Date;
            DateTime todate = todatepicker.Value.Date.AddHours(23);
            

            if(ctgrycombobox.SelectedIndex==-1 || ctgrycombobox.SelectedItem.ToString()=="ALL")
            {
                string query = "select * from PettyCash where Date BETWEEN '" + fromdate + "' AND '" + todate + "' Order by Date Desc";
                Functions.loadTable(query, PettyCashGridView);
            }
            else
            {
                string searchvalue = ctgrycombobox.SelectedItem.ToString();
                string query = "select * from PettyCash where Catergory= '" + searchvalue + "' AND Date BETWEEN '" + fromdate + "' AND '" + todate + "' Order by Date Desc";
                Functions.loadTable(query, PettyCashGridView);
            }

        }
    }
}
