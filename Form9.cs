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
    public partial class Form9 : Form
    {
        private string connectionString;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
            MySqlConnection conn1 = new MySqlConnection(connectionString);
            conn1.Open();
            try
            {

                server = "localhost";
                database = "jobbooth";
                uid = "root";
                password = "";
                
                label3.Text = Form2.SetValueForText1;
                string a =Form2.SetValueForText1;
                //MessageBox.Show(a);
                String Query = "select firstname from jpersonaldetails where email='" + a + "';";
                String Query1 = "select lastname from jpersonaldetails where email='" + a + "';";
                String Query2 = "select JID from jpersonaldetails where email='" + a + "';";
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand1 = new MySqlCommand(Query, conn1);
                MySqlCommand MyCommand2 = new MySqlCommand(Query1, conn1);
                MySqlCommand MyCommand3 = new MySqlCommand(Query2, conn1);
                //string q = MyCommand2.ExecuteNonQuery();
                label7.Text = Convert.ToString(MyCommand1.ExecuteScalar());
                label8.Text = Convert.ToString(MyCommand2.ExecuteScalar());
                label9.Text = Convert.ToString(MyCommand3.ExecuteScalar());

                //String Query4 = "select jid from jpersonaldetails where email='" + a + "';";
                MySqlCommand cmd1 = new MySqlCommand(Query2, conn1);
                string s = Convert.ToString(cmd1.ExecuteScalar());
                string Query5 = "select ugmajor from jeducational where jid='" + s + "';";
                MySqlCommand cmd2 = new MySqlCommand(Query5, conn1);
                string l = Convert.ToString(cmd2.ExecuteScalar());
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                // MyConn2.Open();  
                //For offline connection we will use  MySqlDataAdapter class.
                string Query6 = "select cname,cdetails,cadd,vpost,jdesp,minexp,qual,skill,sal,phone,url,refmail from cdetails c, vdetails v where c.cid=v.cid and qual like '%" + l + '%'+"';";
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
