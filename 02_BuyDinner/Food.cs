using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BuyDinner
{
    public class Food
    {
        public decimal perprice { get; set; }
        public string foodname { get; set; }
        public int amount { get; set; }

        public decimal moneyperitem { get; set; }

        //public void BuyFood(string foodname, int amount)
        //{
        //    moneyperitem = amount * perprice;
        //}


    }
}
