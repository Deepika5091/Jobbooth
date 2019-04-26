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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;

            if((name=="Deepika"&&pass=="deepu")||(name == "Sandra" && pass == "sandra"))
            {
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
