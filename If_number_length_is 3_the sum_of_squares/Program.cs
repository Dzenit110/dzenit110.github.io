using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int girilenSayi = Convert.ToInt32(Console.ReadLine());
            int girilenSayideger = girilenSayi;
            int eldekiBasamak = 0;
            int toplam = 0;
            int sonuc = 0;


            while (girilenSayi > 0)
            {
                girilenSayi = girilenSayi / 10;
                eldekiBasamak = eldekiBasamak + 1;
            }




            if (eldekiBasamak == 3)
            {
                int ucbasamakliSayi = girilenSayideger;
                while (girilenSayideger > 0)
                {
                    eldekiBasamak = girilenSayideger % 10;
                    girilenSayideger = girilenSayideger / 10;
                    toplam = (eldekiBasamak * eldekiBasamak);

                    sonuc = sonuc + toplam;


                }
                Console.WriteLine(ucbasamakliSayi + " sayısının basamak kareleri toplamı:" + sonuc);

            }


            else if (eldekiBasamak == 4)
            {
                if (girilenSayideger % 4 == 0)
                {
                    Console.WriteLine(girilenSayideger + " sayısı 4 ile tam bölünür.");

                }
                else
                {
                    Console.WriteLine(girilenSayideger + " sayısı 4 ile tam bölünmez.");
                }


            }


            else
            {
                Console.WriteLine("Geçersiz sayı girdiniz.");
            }




            Console.ReadKey();

        }
    }
}
