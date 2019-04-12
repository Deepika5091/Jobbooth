
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
using MySql.Data.MySqlClient;
namespace JobBooth
{
   
    public partial class Form4 : Form
    {
        MySqlConnection connection;
        
        private MySqlCommand cc;
        private string server;
        private string database;
        private string uid;
        private string password;
        string connectionString;
        private MySqlConnection conn;

        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox7.Visible = false;
            groupBox5.Visible = false;
            
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
       database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SslMode=none;";

            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            // groupBox6.Visible(false);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = true;

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                server = "localhost";
            database = "jobbooth";
            uid = "root";
            password = "";
            //connectionString = "SERVER=" + server + ";" + "DATABASE=" +
       // database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SslMode=none;";
           
            int flag = 0;
            Regex expr = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            Regex exp = new Regex(@"(?<!\d)\d{10}(?!\d)");
            String Error_Message = "";


                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=jobbooth;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                MySqlConnection conn1 = new MySqlConnection(connectionString);

                
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM jpersonaldetails", conn1);
                conn1.Open();
                // string count = "SELECT COUNT(*) FROM jpersonaldetails";


                // cc = new MySqlCommand(count, connection);
                //Convert.ToInt32(cc.ExecuteNonQuery());

                cmd.ExecuteNonQuery();
                int n = Convert.ToInt32(cmd.ExecuteNonQuery());
                int mysqlint = int.Parse(cmd.ExecuteScalar().ToString());
                int i = mysqlint + 1;

                string fname = textBox1.Text;
                string mname = textBox2.Text;
                string lname = textBox3.Text;
                string password1 = textBox24.Text;
                //string cpass = textBox26.Text;
                string add = textBox4.Text;
                string dob = textBox5.Text;
                string phone = textBox6.Text;
                string email = textBox7.Text;
                string lang = textBox14.Text;
                string hob = textBox15.Text;
                string gender = radioButton1.Checked ? "M" : "F";
                string exper = radioButton3.Checked ? "YES" : "NO";


                string xschool = textBox11.Text;
                string Xpassout = textBox9.Text;
                string Xpercent = textBox10.Text;
                string XIIschool = textBox8.Text;
                string XIIpassout = textBox12.Text;
              
                string XIIpercent = textBox13.Text;
                string ugcollege = textBox29.Text;
                string ugpassout = textBox28.Text;
                string ugpercent = textBox27.Text;
                string ugmajor = textBox30.Text;
                string pgcollege = textBox16.Text;
                string pgpassout = textBox17.Text;
                string pgpercent = textBox18.Text;
                string pgmajor = textBox31.Text;

                string jtitle = textBox19.Text;
                string ocname = textBox20.Text;
                string expyear = textBox21.Text;
                string ryear = textBox22.Text;
                string pcadd = textBox23.Text;
                string psdec = textBox25.Text;

               
                    
                string jid = string.Concat("JD", i);
                String insert = "insert into jpersonaldetails(jid,firstname,middlename,lastname,password,address,dob,gender,phone,email,lang,hobbies,exp)values('" + jid + "','" + fname + "' ,'" + mname + "','" + lname + "','" + password1 + "','" + add + "','" + dob + "','" + gender +"','"+ phone + "','" + email + "','" + lang + "','" + hob + "','" + exper + "')";

                MySqlCommand cc1 = new MySqlCommand(insert,conn1);
                cc1.ExecuteNonQuery();

                

                String insert1 = "insert into jeducational(Xschool,Xpassout,Xpercent,XIIschool,XIIpassout,XIIpercent,ugcollege,ugpassout,ugpercent,ugmajor,pgcollege,pgpassout,pgpercent,pgmajor,jid)values('" + xschool + "','" + Xpassout + "' ,'" + Xpercent + "','" + XIIschool + "','" + XIIpassout + "','" + XIIpercent + "','" + ugcollege + "','" + ugpassout + "','" + ugpercent + "','" + ugmajor + "','" + pgcollege + "','" + pgpassout + "','" + pgpercent + "','" + pgmajor + "','" + jid+ "')";
                MySqlCommand cc2 = new MySqlCommand(insert1, conn1);
                cc2.ExecuteNonQuery();

                String insert2 = "insert into expdet(jid,jtitle,ocname,expyear,ryear,pcadd,psdec)values('" + jid + "','" + jtitle + "' ,'" + ocname + "','" + expyear + "','" + ryear + "','" + pcadd + "','" + psdec + "')";
                MySqlCommand cc3 = new MySqlCommand(insert2, conn1);
                cc3.ExecuteNonQuery();

                MessageBox.Show("REGISTERED \n ");

                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox24.Text="";
                //string cpass = textBox26.Text;
                textBox4.Text="";
                textBox5.Text="";
                textBox6.Text="";
                textBox7.Text="";
                textBox14.Text="";
                textBox15.Text="";



                if (!exp.IsMatch(phone))
                {
                    Error_Message += "\n INVALID CONTACT NUMBER ";
                    textBox6.Text = "";
                    errorProvider2.SetError(textBox6, "contact number required");
                    if (flag == 0)
                    {
                        textBox6.Focus();
                        flag = 1;
                    }
                }

                if (!expr.IsMatch(email))
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


        private void button2_Click(object sender, EventArgs e)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();


            }

            private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

            private void groupBox5_Enter(object sender, EventArgs e)
            {

            }

            private void groupBox7_Enter(object sender, EventArgs e)
            {

            }

            private void radioButton5_CheckedChanged(object sender, EventArgs e)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
            }

            private void radioButton8_CheckedChanged(object sender, EventArgs e)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
            }

            private void radioButton7_CheckedChanged(object sender, EventArgs e)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox7.Visible = true;
                groupBox5.Visible = false;
            }


            private void radioButton6_CheckedChanged(object sender, EventArgs e)
            {
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox7.Visible = true;
                groupBox5.Visible = true;
            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }


