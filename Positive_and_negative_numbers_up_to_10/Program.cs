using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_2
{         //Girilen 10 adet sayı içerisinden pozitiflerin ve negatiflerin sayısını bulan ve yazdıran akış şeması.
    class Program
    {
        static void Main(string[] args)
        {
            int[] d1 = new int[10];

            Console.WriteLine("Lütfen 10 adet sayınızı yazınız:");


            for (int i = 0; i < d1.Length; i++)
            {

                d1[i] = Convert.ToInt32(Console.ReadLine());   //  Burada yazarken "1 2 3.." olmasi gerekiyor
                                                               // Ayrıca n sayıları girerse 10 adet değil !!
                
            }


            Console.Write("Pozitif sayıları:");
            for (int i = 0; i < d1.Length; i++)
            {
                if (d1[i] > 0)
                {

                    Console.Write(" " + d1[i]);
                }

            }

            Console.WriteLine();
            Console.Write("Negatif sayıları:");

                for (int n = 0; n < d1.Length; n++)
                {
                    if (d1[n]<0)
                    {
                        
                        Console.Write(" "+d1[n]);
                    }
                }
            

            Console.ReadKey();

        }
    }
}
