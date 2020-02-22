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
    public partial class Form7 : Form
    {
        private string connectionString;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
            MySqlConnection conn1 = new MySqlConnection(connectionString);
            conn1.Open();
            string Query = "select * from cdetails;";
            //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn1);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                MySqlConnection conn1 = new MySqlConnection(connectionString); conn1.Open();
                string Query = "select * from jpersonaldetails d,jeducational e,expdet f where d.jid=e.jid and d.jid=f.jid ;";


                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn1);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }
        }
           /* public void jobseeker()
            {

                try
                {
                
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                    MySqlConnection conn1 = new MySqlConnection(connectionString); conn1.Open();
                    string Query = "select * from jpersonaldetails d,jeducational e,expdet f where d.jid=e.jid and d.jid=f.jid ;";


                    //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, conn1);
                    //  MyConn2.Open();  
                    //For offline connection we weill use  MySqlDataAdapter class.  
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand2;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    dataGridView1.DataSource = dTable;
                }
                catch (Exception cc)
                {
                    MessageBox.Show(cc.ToString());
                }
          
        }*/

        private void Form7_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SslMode=none;";

            try
            {

                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                MySqlConnection conn2 = new MySqlConnection(connectionString);
                conn2.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM jpersonaldetails", conn2);
                

                cmd.ExecuteNonQuery();
                int n = Convert.ToInt32(cmd.ExecuteNonQuery());
                int mysqlint = int.Parse(cmd.ExecuteScalar().ToString());
                string myString = mysqlint.ToString();
                label9.Text = myString;


                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM cdetails", conn2);
                

                cmd1.ExecuteNonQuery();
                int n1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
                int mysqlint1 = int.Parse(cmd1.ExecuteScalar().ToString());
                string myString1 = mysqlint1.ToString();
                label8.Text = myString1;


                MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM vdetails", conn2);
                

                cmd2.ExecuteNonQuery();
                int n2 = Convert.ToInt32(cmd2.ExecuteNonQuery());
                int mysqlint2 = int.Parse(cmd2.ExecuteScalar().ToString());
                string myString2 = mysqlint2.ToString();
                label7.Text = myString2;


            }

            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                MySqlConnection conn1 = new MySqlConnection(connectionString); conn1.Open();
                string Query = "select * from vdetails;";
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn1);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;

            }
            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SUCCESSFULLY LOGGED OUT");
            this.Close();
            this.Close();

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
