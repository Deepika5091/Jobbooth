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
            try
            {

                MailMessage msg = new MailMessage();
                
                msg.From = new MailAddress("jobbooth2019@gmail.com");
                msg.To.Add(textBox4.Text);
                msg.Subject = textBox3.Text;
                msg.Body = textBox2.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "jobbooth2019@gmail.com";
                ntcd.Password = "majorproject";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sent successfully");
                textBox4.Text = " ";
                textBox3.Text = " ";
                textBox2.Text = " ";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void email_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
        
    

