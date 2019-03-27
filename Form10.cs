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
    public partial class Form10 : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;
        private MySqlCommand cc;

        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
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

                string cid = textBox2.Text;
                string vpost = textBox8.Text;
                string jdesp = textBox9.Text;
                string minexp = textBox10.Text;
                string qual = textBox11.Text;
                string skill = textBox12.Text;
                string sal = textBox13.Text;

                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                MySqlConnection conn1 = new MySqlConnection(connectionString);
                conn1.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM vdetails", conn1);




                cmd1.ExecuteNonQuery();
                int n1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
                int mysqlint1 = int.Parse(cmd1.ExecuteScalar().ToString());
                int i1 = mysqlint1 + 1;
                string vid = string.Concat("VAD", i1);

                String insert1 = "insert into vdetails(cid,vid,vpost,jdesp,minexp,qual,skill,sal)values('" + cid + "','" + vid + "' ,'" + vpost + "','" + jdesp + "','" + minexp + "','" + qual + "','" + skill + "','" + sal + "')";

                cc = new MySqlCommand(insert1, conn1);
                cc.ExecuteNonQuery();

                MessageBox.Show("Vacancy Added");
            
            }
            catch (Exception cc)
            {
                MessageBox.Show(cc.ToString());
            }
        }
    }
}
