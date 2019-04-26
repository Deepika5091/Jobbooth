using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JobBooth
{
    public partial class Form12 : Form



    {
        private string connectionString;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

       
                server = "localhost";
                database = "jobbooth";
                uid = "root";
                password = "";

                string Pass = textBox1.Text;
                string pass1 = textBox2.Text;
                string pass2 = textBox3.Text;

                string a = Form2.SetValueForText2;
                string b = Form2.SetValueForText1;

                if (a == Pass)
                {
                    if (pass1 == pass2)
                    {
                        string query = "update jpersonaldetails set password='" + pass1 + "' where password ='" + Pass + "'";
                    }
                    else
                    {
                        MessageBox.Show("ConfirmPassword doesnt match");
                    }
                }
                else
                {
                    MessageBox.Show(" Old Password doesnt match");
                }
            }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
            MySqlConnection conn1 = new MySqlConnection(connectionString);
            conn1.Open();

        }
    }
    }

