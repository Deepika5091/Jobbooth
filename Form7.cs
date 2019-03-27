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

        private void Form7_Load(object sender, EventArgs e)
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
         database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SslMode=none;";

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
    }
}
