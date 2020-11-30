using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_CountPrise
{
    public partial class Form1 : Form
    {
        List<string> GetStops = new List<string>();
        public Form1()
        {
            InitializeComponent();
            GetStops.Add("台北");
            GetStops.Add("新竹");
            GetStops.Add("台中");
            GetStops.Add("嘉義");
            GetStops.Add("台南");
            GetStops.Add("高雄");
        }

        private void GetDiscount()
        {
            if (ReturnTicket.Checked == true)
            {

            }

            //private void GetDirection()
            //{
            //    if(ToSouth.Checked=true)
            //    {

            //    }
        }
        private void CountTotal_Click(object sender, EventArgs e)
        {

        }
    }

    
}
