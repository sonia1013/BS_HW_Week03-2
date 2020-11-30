using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_BuyDinner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal total = 0;
        private void GetPrice()
        {
            Dictionary<string, decimal> PriceTag = new Dictionary<string, decimal>()
            {
                {checkBox1.Text, decimal.Parse(label1.Text)},{checkBox2.Text, decimal.Parse(label2.Text)},
                    {checkBox3.Text, decimal.Parse(label3.Text)},{checkBox4.Text, decimal.Parse(label4.Text)}
            };

            //moneyperitem = amount * perprice;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown4.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GetMoneyExchange(decimal money)
        {

        }


    }
}
