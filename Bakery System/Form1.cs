using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //We can select the color of the radio button
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            //Used to clear the combobox
            comboBox1.Items.Clear();

            //Items add to selected radio button1
            comboBox1.Items.Add("QULAB JAMUN");
            comboBox1.Items.Add("CHUMCHUM");
            comboBox1.Items.Add("PATEESA");

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //We can select the color of the radio button
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            //Used to clear the combobox
            comboBox1.Items.Clear();

            //Items add to selected radio button1
            comboBox1.Items.Add("DAAL MOUT");
            comboBox1.Items.Add("MIX NIMKO");
            comboBox1.Items.Add("DAAL MOONG");

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        //We select the item and it will show us the price of the selected item
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if(comboBox1.SelectedItem.ToString()== "QULAB JAMUN")
            {
                txt_price.Text = "350";
            }
            else if(comboBox1.SelectedItem.ToString()== "CHUMCHUM")
            {
                txt_price.Text = "350";
            }
            else if(comboBox1.SelectedItem.ToString()== "PATEESA")
            {
                txt_price.Text = "400";

            }
            else if (comboBox1.SelectedItem.ToString() == "DAAL MOUT")
            {
                txt_price.Text = "100";

            }
            else if (comboBox1.SelectedItem.ToString() == "MIX NIMKO")
            {
                txt_price.Text = "80";

            }
            else if (comboBox1.SelectedItem.ToString() == "DAAL MOONG")
            {
                txt_price.Text = "120";

            }
            else
            {
                txt_price.Text = "0";
            }
            //It will clear the total and qty text area when U select the next item
            txt_total.Text = "";
            txt_qty.Text = "";
        }
        //In this we multiply the price and qty and show in the total box.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(txt_qty.Text.Length>0)
            {
                txt_total.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString();
        
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we create an array for the listview box having 4 inputs in it
            string[] arr = new string[4];
            arr[0] = comboBox1.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            //call the ListViewItem and create the new listviewttem and pass the array
            ListViewItem lie = new ListViewItem(arr);
            listView1.Items.Add(lie); //add the value sof array in the list

        //add the total amount with subtotal
           txt_subtot.Text = (Convert.ToInt32(txt_subtot.Text) + Convert.ToInt32(txt_total.Text)).ToString();
           
        }

        private void txt_dsc_TextChanged(object sender, EventArgs e)
        {
            //give the discount
            if(txt_dsc.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt32(txt_subtot.Text) - Convert.ToInt32(txt_dsc.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            //enter the paid amount and show the balance
            if(txt_paid.Text.Length>0)
            {
                txt_bal.Text = (Convert.ToInt32(txt_net.Text) - Convert.ToInt32(txt_paid.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Working on remove button
            if(listView1.SelectedItems.Count>0)
            {
                for(int i=0; i<listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                        txt_subtot.Text = (Convert.ToInt32(txt_subtot.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }

                }
            }
        }
    }
}
