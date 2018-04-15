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
    public partial class mianform : Form
    {
        public mianform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           RegisterEmployee form = new RegisterEmployee();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             ViewEmployee form = new ViewEmployee();
             form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchUpdateDeleteEmployee form = new SearchUpdateDeleteEmployee();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeaveRequest form = new LeaveRequest();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            directorleaverequestapproval form = new directorleaverequestapproval();
            form.Show();
            this.Hide();
;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Salary form = new Salary();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewApprovals form = new ViewApprovals();
            form.Show();
            this.Hide();
        }

        private void mianform_Load(object sender, EventArgs e)
        {
            if(Login.EmpId=="ADMIN" && Login.EmpPosition=="ADMIN")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = false;
                button7.Visible = false;            


            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button4.Visible = true;
                button7.Visible = true;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
