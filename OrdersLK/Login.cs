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
    public partial class Login : Form
    {
        public static string EmpId="";
        public static string EmpPosition="";
        public static string userid = "";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text;
            string password = passwordbox.Text;
            

            string query = "select * from Users where Username='" + username + "' AND Password='" + password + "' COLLATE Latin1_General_CS_AS";
            userid = Functions.getVal("UserId", query);

            if (userid != "0")
            {
                string empquery = "select EmpId from Users where UserId='" + userid + "'";
                string results = Functions.getVal("EmpId", empquery);

                if(results!="0")
                {
                    EmpId = results;
                    string empposquery = "select Position from Employee where EmpId='" + results + "'";
                    EmpPosition = Functions.getVal("Position", empposquery);

                }
                else
                {
                    EmpId = "ADMIN";
                    EmpPosition = "ADMIN";
                }


                Home home = new Home();
                this.Hide();
                home.Show();

            }
            else
            {
                MessageBox.Show("Invalid Credential");
            }




            //if (usernamebox.Text.ToLower() == "adil" && passwordbox.Text == "12345678")
            //{
            //Home home = new Home();
            //this.Hide();
            //home.Show();
            //}
            //else
            //    MessageBox.Show("Invalid Credential");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
