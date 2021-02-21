using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    
    class Program
    {
        static int j = 100;
       static double i = 1;

        static double Topla(double i)
        {
            i = 2;

            return i ;


        }

        static void Main(string[] args)
        {

            double i = 3;

            Console.WriteLine("i değeri:" + i);
            Console.WriteLine("i değeri:" + (Program.i));
            Console.WriteLine("i değeri:" + Topla(i));
            Console.WriteLine("j değeri:" + Program.j);

            Console.ReadKey();
        }
        
       
    }
}
