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
    public partial class Rqst_send : Form
    {
        public Rqst_send()
        {
            InitializeComponent();
        }

        private void Rqst_send_Load(object sender, EventArgs e)
        {

        }


        public void email(string to,string frm, string subjct, string body)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(frm);
                message.To.Add(new MailAddress(to));
                message.Subject = subjct;
                message.Body = body;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("sharpinfor@gmail.com","00000");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("Email Sucessfuly send to "+txt_to.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
        
        }

        private void btn_snd_Click(object sender, EventArgs e)
        {

        }
       
    }
}
