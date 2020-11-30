using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MathCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入要運算的Max值:");
            //判斷奇偶數
            double result = 0;
            double n = 0;
            n = Double.Parse(Console.ReadLine());

            if(n%2==0)
            {
                result = (-1) * ((n - 1) / 2) + 1;
            }
            else
            {
                result = (-1) * (n / 2);
            }
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
