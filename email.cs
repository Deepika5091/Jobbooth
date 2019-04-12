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

namespace JobBooth
{
    public partial class email : Form
    {

        /* MailMessage message;
         SmtpClient smtp;*/
        public email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  try

              {

                  button1.Enabled = false;

                  //btnCancel.Visible = true;

                  message = new MailMessage();



                  if (IsValidEmail(textBox2.Text))

                  {

                      message.To.Add(textBox2.Text);

                  }



                  string femail = textBox1.Text;

                  message.Subject = textBox4.Text;

                  message.From = new MailAddress(femail);

                  message.Body = textBox3.Text;





                  // set smtp details

                  smtp = new SmtpClient("smtp.gmail.com");

                  smtp.Port = 465;

                  smtp.EnableSsl = true;

                  smtp.Credentials = new NetworkCredential("menondeepika1@gmail.com", "");

                  smtp.SendAsync(message, message.Subject);

                  smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);

              }

              catch (Exception ex)

              {

                  MessageBox.Show(ex.Message);

                  btnCancel.Visible = false;

                  btnSend.Enabled = true;

              }
          }*/
        }
    }
}