using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Inventory_System
{
    public partial class Email_comfiger : Form
    {
        public Email_comfiger()
        {
            InitializeComponent();
        }


        public void email(string to, string subjct, string body,string frm,string pass)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(frm);
                message.To.Add(new MailAddress(to));
                message.Subject = subjct;
                message.Body = "This Email added to Mars Computer System's Inventory Control  ";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(frm, pass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("Email Sucessfuly configured " + to);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Email address or Password.....! \n"+ex.Message);
            }

        }

        private void Email_comfiger_Load(object sender, EventArgs e)
        {

        }

    }
}
