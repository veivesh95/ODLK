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
    public partial class AddupdtDelCategory : Form
    {
        ComboBox cbs;
        public AddupdtDelCategory(ComboBox cb)
        {
            InitializeComponent();
            cbs = cb;
        }

        private void catergoryidlbl_Load(object sender, EventArgs e)
        {
            string catergoryquery = "select * from ProductCategory";
            Functions.loadTable(catergoryquery, ctergorydgv);

            string catergoryId = Functions.getNextID("CatergoryId", "ProductCategory", "CAT");
            catergoridlable.Text = catergoryId;

            updtbtn.Visible = false;
            delbtn.Visible = false;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string catid = catergoridlable.Text;
            string catname = catergorynamebox.Text;

            string query = "insert into ProductCategory values('" + catid + "','" + catname + "')";
            Functions.ExecuteQuery(query);


            string catergoryId = Functions.getNextID("CatergoryId", "ProductCategory", "CAT");
            catergoridlable.Text = catergoryId;
            catergorynamebox.Text = "";


            string query1 = "Select * from ProductCategory";
            Functions.ComboWithKey(this.cbs, query1, "CatergoryId", "CatergoryName");

            string catergoryquery = "select * from ProductCategory";
            Functions.loadTable(catergoryquery, ctergorydgv);
            this.Hide();
        }

        private void ctergorydgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addbtn.Visible = false;
            updtbtn.Visible = true;
            delbtn.Visible = true;

            int row = ctergorydgv.CurrentCell.RowIndex;
            string catid = ctergorydgv.Rows[row].Cells[0].Value.ToString();
            string catname = ctergorydgv.Rows[row].Cells[1].Value.ToString();

            catergoridlable.Text = catid;
            catergorynamebox.Text = catname;



        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            string catid = catergoridlable.Text;
            string catname = catergorynamebox.Text;

            string query = "update ProductCategory set CatergoryName='" + catname + "' where CatergoryId='" + catid + "'";
            Functions.ExecuteQuery(query);

            string catergoryquery = "select * from ProductCategory";
            Functions.loadTable(catergoryquery, ctergorydgv);

            string catergoryId = Functions.getNextID("CatergoryId", "ProductCategory", "CAT");
            catergoridlable.Text = catergoryId;
            catergorynamebox.Text = "";

            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string catid = catergoridlable.Text;
           
            string query = "Delete from ProductCategory where CatergoryId= '" + catid+"'";
            Functions.ExecuteQuery(query);

            string catergoryquery = "select * from ProductCategory";
            Functions.loadTable(catergoryquery, ctergorydgv);

            string catergoryId = Functions.getNextID("CatergoryId", "ProductCategory", "CAT");
            catergoridlable.Text = catergoryId;
            catergorynamebox.Text = "";

            addbtn.Visible = true;
            updtbtn.Visible = false;
            delbtn.Visible = false;
        }
    }
}
