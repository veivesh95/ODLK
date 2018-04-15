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
    public partial class AccountsPage : Form
    {
        public AccountsPage()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void statementbtn_Click(object sender, EventArgs e)
        {
            Statementpage stpg = new Statementpage();
            this.Hide();
            stpg.Show();
        }

        private void pettycashdetails_Click(object sender, EventArgs e)
        {
            PettyCashPage pcp = new PettyCashPage();
            this.Hide();
            pcp.Show();
        }

        private void AccountsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
