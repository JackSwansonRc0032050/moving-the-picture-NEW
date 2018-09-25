using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moving_the_picture_NEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X , pictureBox2.Location.Y + 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            int d;
            try
            { d = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Only numbers fella");
                d = 10;
            }
            for (int i = 0; i < 10; i++)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
                await Task.Delay(d);
            }
        }
    }
    
    
}
