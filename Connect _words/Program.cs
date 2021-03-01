using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yazdığımız cümle, içindeki bulunan boşluklar silip bu programda birleştirmek olarak bir cümle yazdık.

            string girilenCumle = "  Teknoloji Fakültesi / Kocaeli Üniversitesi   .";
           
            //string girilenCumle = Console.ReadLine(); //  Kullanıcı giriş yapbilir

            Console.WriteLine(girilenCumle);


            string[] kelimler = girilenCumle.Split(' ');

            foreach (string kelime in kelimler)
            {
                Console.Write(kelime);
            }
         

            Console.ReadKey();
        }
    }
}
