using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace OrdersLK
{
    class emailThis
    {
        public Boolean sendMail(string mail, string body)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryFormat = SmtpDeliveryFormat.International;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("busyfatpanda@gmail.com", "4834345v+");

                MailMessage msg = new MailMessage();

                msg.To.Add(mail);
                msg.From = new MailAddress("veivesh95@gmail.com");
                msg.Subject = "Order Details - " + DateTime.Now.ToShortDateString();
                msg.Body = "Order confirmation mail : \n\n" + body + "\n\n\n Thank You from ORDERS.LK Team!";

                client.Send(msg);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
