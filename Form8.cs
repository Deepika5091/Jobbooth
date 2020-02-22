using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobBooth
{
    public partial class Form8 : Form
    {
        private string connectionString;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
            MySqlConnection conn1 = new MySqlConnection(connectionString);
            conn1.Open();
            try
            {
                server = "localhost";
                database = "jobbooth";
                uid = "root";
                password = "";
                label7.Text = Form3.SetValueForText1;
                string a = Form3.SetValueForText1;
                //MessageBox.Show(a);
                String Query = "select cname from cdetails where cname='" + a + "';";
                String Query1 = "select cadd from cdetails where cname='" + a + "';";
                String Query2 = "select cid from cdetails where cname='" + a + "';";
                String Query3 = "select cname from cdetails where cname='" + a + "';";
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand1 = new MySqlCommand(Query, conn1);
                MySqlCommand MyCommand2 = new MySqlCommand(Query1, conn1);
                MySqlCommand MyCommand3 = new MySqlCommand(Query2, conn1);
                MySqlCommand MyCommand4 = new MySqlCommand(Query3, conn1);
                //string q = MyCommand2.ExecuteNonQuery();
                label2.Text = Convert.ToString(MyCommand1.ExecuteScalar());
                label4.Text = Convert.ToString(MyCommand2.ExecuteScalar());
                label8.Text = Convert.ToString(MyCommand3.ExecuteScalar());
                label9.Text = Convert.ToString(MyCommand4.ExecuteScalar());

            }
            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                MySqlConnection conn2 = new MySqlConnection(connectionString);
                conn2.Open();
                string a = Form3.SetValueForText1;
                String Query2 = "select cid from cdetails where cname='" + a + "';";
                MySqlCommand cmd1 = new MySqlCommand(Query2, conn2);
                string s = Convert.ToString(cmd1.ExecuteScalar());
                string Query = "select * from vdetails where cid='" + s + "';";
                MySqlCommand cmd2 = new MySqlCommand(Query, conn2);
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                // MyConn2.Open();  
                //For offline connection we will use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd2;
                // MyAdapter.SelectCommand = cmd2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;





            }
            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            email e1 = new email();
            e1.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
            MySqlConnection conn1 = new MySqlConnection(connectionString);
            conn1.Open();
            try
            {
                
                string a = Form3.SetValueForText1;
                string vid = textBox1.Text;               
               // String Query4 = "select cid from cdetails where cname='" + a + "';";
                //MySqlCommand cmd1 = new MySqlCommand(Query4, conn1);
              //  string s = Convert.ToString(cmd1.ExecuteScalar());
                string Query5 = "select qual from vdetails where vid='" + vid + "';";
                MySqlCommand cmd2 = new MySqlCommand(Query5, conn1);
                string l = Convert.ToString(cmd2.ExecuteScalar());
                //MessageBox.Show(l);


                string Query6 = "select firstname,middlename,lastname,address,dob,gender,phone,email,hobbies,exp,Xschool,Xpassout,Xpercent,XIIschool,XIIpassout,XIIpercent,ugcollege,ugpassout,ugpercent,ugmajor,pgcollege,pgpassout,pgpercent,pgmajor,jtitle,ocname,expyear,ryear,psdec from jpersonaldetails d,jeducational e,expdet f where d.jid=e.jid and d.jid=f.jid and ugmajor like '%" + l + '%' + "';";
                //string Query6 = "select firstname,middlename,lastname,address,dob,gender,phone,email,hobbies,exp,Xschool,Xpassout,Xpercent,XIIschool,XIIpassout,XIIpercent,ugcollege,ugpassout,ugpercent,ugmajor,pgcollege,pgpassout,pgpercent,pgmajor,jtitle,ocname,expyear,ryear,psdec from jpersonaldetails d,jeducational e,expdet f where d.jid=e.jid and d.jid=f.jid or ugmajor like '%" + l + '%' + "' or pgmajor like '%" + l + '%' + "';";
                MySqlCommand cmd3 = new MySqlCommand(Query6, conn1);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd3;
                // MyAdapter.SelectCommand = cmd2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;

            }
            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("SUCCESSFULLY LOGGED OUT");
            this.Close();
            this.Close();

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}


