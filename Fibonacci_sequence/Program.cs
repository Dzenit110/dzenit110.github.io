using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_dizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1 = 1, d2 = 1, sayi, d3;
            string cikis = d1.ToString() +" "+ d2.ToString();
            

            Console.WriteLine("Lutfen sayinizi yaziniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            d3 = d1 + d2;

            while (d3<sayi)
            {
                d1 = d2;
                d2 = d3;
                cikis = cikis +" "+ Convert.ToString(d3);
                d3 = d1 + d2;

            }

            Console.WriteLine(cikis);

            Console.ReadKey();
        }
    }
}
