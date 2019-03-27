using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobBooth
{
    public partial class Form5 : Form
    {
        //MySqlConnection connection;

        private MySqlCommand cc;
        private string server;
        private string database;
        private string uid;
        private string password;
        string connectionString;
        //private MySqlConnection conn;

        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
          database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SslMode=none;";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                server = "localhost";
                database = "jobbooth";
                uid = "root";
                password = "";

                int flag = 0;
                Regex expr = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                Regex exp = new Regex(@"(?<!\d)\d{10}(?!\d)");
                Regex urlRegex = new Regex(@"(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ;,./?%&=]*)?");

                String Error_Message = "";

                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                MySqlConnection conn1 = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM cdetails", conn1);
                conn1.Open();

                cmd.ExecuteNonQuery();
                int n = Convert.ToInt32(cmd.ExecuteNonQuery());
                int mysqlint = int.Parse(cmd.ExecuteScalar().ToString());
                int i = mysqlint + 1;
                string cid = string.Concat("CD", i);

                string cname = textBox1.Text;
                string pass = textBox5.Text;
                string cpass = textBox6.Text;
                string phone = textBox15.Text;
                string url = textBox4.Text;
                string refmail = textBox7.Text;
                string cadd = textBox14.Text;
                string cdet = textBox2.Text;


                String insert = "insert into cdetails(cid,cname,password,cdetails,phone,url,refmail,cadd)values('" + cid + "','" + cname + "' ,'" + cpass + "','" + cdet + "','" + phone + "','" + url + "','" + refmail + "','" + cadd + "')";

                cc = new MySqlCommand(insert, conn1);
                cc.ExecuteNonQuery();

                

                string vpost = textBox8.Text;
                string jdesp = textBox9.Text;
                string minexp = textBox10.Text;
                string qual = textBox11.Text;
                string skill = textBox12.Text;
                string sal = textBox13.Text;

                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM vdetails", conn1);



                
                cmd1.ExecuteNonQuery();
                int n1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
                int mysqlint1 = int.Parse(cmd1.ExecuteScalar().ToString());
                int i1 = mysqlint + 1;
                string vid = string.Concat("VAD", i);

                String insert1 = "insert into vdetails(cid,vid,vpost,jdesp,minexp,qual,skill,sal)values('" + cid + "','" + vid + "' ,'" + vpost + "','" + jdesp + "','" + minexp + "','" + qual + "','" + skill + "','" + sal +  "')";

                cc = new MySqlCommand(insert1, conn1);
                cc.ExecuteNonQuery();

                MessageBox.Show("REGISTERED");

                if (!exp.IsMatch(phone))
                {
                    Error_Message += "\n INVALID CONTACT NUMBER ";
                    textBox15.Text = "";
                    errorProvider2.SetError(textBox6, "contact number required");
                    if (flag == 0)
                    {
                        textBox15.Focus();
                        flag = 1;
                    }
                }

                if (!urlRegex.IsMatch(url))
                {
                    Error_Message += "\n INVALID URL ";
                    textBox4.Text = "";
                    errorProvider3.SetError(textBox7, "url required");
                    if (flag == 0)
                    {
                        textBox4.Focus();
                        flag = 1;
                    }
                }


                if (!expr.IsMatch(refmail))
                {
                    Error_Message += "\n INVALID EMAIL ";
                    textBox7.Text = "";
                    errorProvider1.SetError(textBox7, "email id required");
                    if (flag == 0)
                    {
                        textBox7.Focus();
                        flag = 1;
                    }
                }

            }
            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }
        }
    }

}