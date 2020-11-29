using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fei_sCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("共要輸出到第幾個數列?");
            int n = Int32.Parse(Console.ReadLine());
            
            List<int> Fib = new List<int>(n);
            Console.WriteLine("請輸入第一位數字");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("請輸入第二位數字");
            int b = Int32.Parse(Console.ReadLine());
            Fib.Add(a);
            Fib.Add(b);
            for (int i = 2; i < n; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fib[i].ToString());
            }
            Console.ReadLine();

        }
    }
}
