using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobBooth
{
    public partial class Form2 : Form
    {
        //*******************************************
        public static string SetValueForText1 = "";
        // public static string SetValueForText2 = "";
        //*******************************************
        private string connectionString;
        private string password;
        private string server;
        private string uid;
        private string database;
        private MySqlCommand cc;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SslMode=none;";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "jobbooth";
            uid = "root";
            password = "";
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
            MySqlConnection conn1 = new MySqlConnection(connectionString);
            conn1.Open();
       
            string email = textBox1.Text;
            string pass = textBox2.Text;


            /**************************************************/
            //SetValueForText1 = textBox1.Text;
            // SetValueForText2 = textBox2.Text;

            //Form9 frm9 = new Form9();
            //frm9.Show();
            /*************************************************/
            


            MySqlCommand cmd = new MySqlCommand("select email,password from jpersonaldetails where email='" + textBox1.Text + "'and password='" + textBox2.Text + "'", conn1);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               
                SetValueForText1 = textBox1.Text;
                // SetValueForText2 = textBox2.Text;

                textBox1.Text = "";
                textBox2.Text = "";
                Form9 frm9 = new Form9();
                frm9.Show();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Invalid UserName or Password");
                //MessageBox.Show("Invalid UserName or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Access Denied!!");

                // MessageBox.Show("Invalid Login please check username and password");
                //Form9 f9 = new Form9();
                //f9.Show();
                //this.Hide();
            }
            conn1.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
