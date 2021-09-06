using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static int Faktoriyel(int n)
        {
            if (n == 0) 
                return 1;
            else
                return n*Faktoriyel(n - 1);
           
        }

        static void Main(string[] args)
        {
           Console.WriteLine("Sonuc:"+Faktoriyel(8));

        }
    }
}
