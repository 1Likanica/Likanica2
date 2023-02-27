using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Likanica2
{
    public partial class Form1 : Form
    {
        int Comp_num, hp;
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

            private void button1_Click(object sender, EventArgs e)
        {
            int Hum_num = Convert.ToInt32(textBox1.Text);
            if (Comp_num == Hum_num)
            { 
                MessageBox.Show("Вы угадали!!!");
                button2.Visible = true;
                button1.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;
                button3.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
            }
            if (Comp_num > Hum_num)
            { 
                MessageBox.Show("Мое число больше");
                hp -= 1;
            }
            if (Comp_num < Hum_num)
            { 
                MessageBox.Show("Мое число меньше");
                hp -= 1;
            }
            label4.Text = hp.ToString();
            if (hp == 0)
            {
                MessageBox.Show("Вы проиграли!!!");
                button2.Visible = true;
                button1.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;
                button3.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
            button3.Visible = false;
            Random r = new Random();
            Comp_num = r.Next(0, 101);
            textBox1.Text = "";
            hp = 7;
            label4.Text = hp.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
