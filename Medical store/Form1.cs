using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count >0)
            {
                for(int i=0; i<listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt32(txt_sub.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();

                    }
                    if(txt_sub.Text.ToString()=="0")
                    {
                        txt_dsc.Text = "";
                        txt_net.Text = "";
                        txt_paid.Text = "";
                        txt_bal.Text = "";
                    }

                }
            }
                 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Panadol");
            comboBox1.Items.Add("Postan");
            comboBox1.Items.Add("Ciprine 250mg");
            comboBox1.Items.Add("Busy 10mg");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Brufin syrup");
            comboBox1.Items.Add("Rigix syrup");
            comboBox1.Items.Add("Syrup 3");
            comboBox1.Items.Add("Syrup 4");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()== "Panadol")
            {
                txt_price.Text = "50";
            }
            else if(comboBox1.SelectedItem.ToString()== "Postan")
            {
                txt_price.Text = "60";
            }
            else if(comboBox1.SelectedItem.ToString()== "Ciprine 250mg")
            {
                txt_price.Text = "300";
            }
            else if (comboBox1.SelectedItem.ToString() == "Busy 10mg")
            {
                txt_price.Text = "250";
            }
            else if (comboBox1.SelectedItem.ToString() == "Brufin syrup")
            {
                txt_price.Text = "120";
            }
            else if (comboBox1.SelectedItem.ToString() == "Rigix syrup")
            {
                txt_price.Text = "150";
            }
            else if (comboBox1.SelectedItem.ToString() == "Syrup 3")
            {
                txt_price.Text = "110";
            }
            else if (comboBox1.SelectedItem.ToString() == "Syrup 4")
            {
                txt_price.Text = "150";
            }
            else
            {
                txt_price.Text ="0";
            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(txt_qty.Text.Length>0)
            {
                txt_total.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString();
            }

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string [4];
            arr[0] = comboBox1.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lie = new ListViewItem(arr);
            listView1.Items.Add(lie);

            txt_sub.Text = (Convert.ToInt32(txt_sub.Text) + Convert.ToInt32(txt_total.Text)).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(txt_dsc.Text.Length>0)
            {
                txt_net.Text = (Convert.ToInt32(txt_sub.Text) - Convert.ToInt32(txt_dsc.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if(txt_paid.Text.Length>0)
            {
                txt_bal.Text = (Convert.ToInt32(txt_net.Text) - Convert.ToInt32(txt_paid.Text)).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txt_price.Text = "";
            txt_qty.Text = "";
            txt_total.Text = "";
            txt_sub.Text = "";
            txt_dsc.Text = "";
            txt_net.Text = "";
            txt_paid.Text = "";
            txt_bal.Text = "";

        }
    }
}
