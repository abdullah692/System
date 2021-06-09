using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        double total1 = 0;
        double total2 = 0;
        bool add = false;
        bool sub = false;
        bool mul = false;
        bool div = false;

        private void btn_add_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_screen.Text);
            txt_screen.Clear();
            add = true;
            sub = false;
            mul = false;
            div = false;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_screen.Text);
            txt_screen.Clear();
            add = false;
            sub = true;
            mul = false;
            div = false;
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_screen.Text);
            txt_screen.Clear();
            add = false;
            sub = false;
            mul = true;
            div = false;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txt_screen.Text);
            txt_screen.Clear();
            add = false;
            sub = false;
            mul = false;
            div = true;
        }

        private void btn_eql_Click(object sender, EventArgs e)
        {
            if(add==true)
            {
                total2 = total1 + double.Parse(txt_screen.Text);
                 txt_screen.Text= total2.ToString();
                total1 = 0;
            }
            if(sub==true)
            {
                total2 = total1 - double.Parse(txt_screen.Text);
                txt_screen.Text = total2.ToString();
                total1 = 0;
            }
            if (mul== true)
            {
                total2 = total1 * double.Parse(txt_screen.Text);
                txt_screen.Text = total2.ToString();
                total1 = 0;
            }
            if (div == true)
            {
                total2 = total1 / double.Parse(txt_screen.Text);
                txt_screen.Text = total2.ToString();
                total1 = 0;
            }


        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn_dot.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text+btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text +btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txt_screen.Text = txt_screen.Text + btn9.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_screen.Clear();
        }

        
    }
}
