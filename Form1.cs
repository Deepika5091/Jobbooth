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
    public partial class Form1 : Form
    {
        // public static string SetValueForText1 { get; internal set; }
        // public static string SetValueForText2 { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }
        /* private int imageNumber = 1;

         private void LoadNextImage()
         {
             if(imageNumber == 10)
             {
                 imageNumber = 1;


             }
             pictureBox1.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
             imageNumber++;

         }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //label1.BackColor = System.Drawing.Color.Transparent;
            //label2.BackColor = System.Drawing.Color.Transparent;
            //label3.BackColor = System.Drawing.Color.Transparent;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();

        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jobseekerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();


        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void sIGNUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // LoadNextImage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //this.Hide();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AboutUs f12 = new AboutUs();
             f12.Show();
             this.Hide();
        }
    }

    
}
