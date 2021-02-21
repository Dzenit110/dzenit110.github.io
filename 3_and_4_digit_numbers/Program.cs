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

            if (girilenSayi != 0)
            {
                while (girilenSayi > 0)
                {
                    girilenSayi = girilenSayi / 10;
                    eldekiBasamak = eldekiBasamak + 1;
                }

            }


            if (eldekiBasamak == 3)
            {
                while (girilenSayideger > 0)
                {
                    eldekiBasamak = girilenSayideger % 10;
                    girilenSayideger = girilenSayideger / 10;
                    toplam = (eldekiBasamak * eldekiBasamak);

                    sonuc = sonuc + toplam;
                }

            }

            else if (eldekiBasamak == 4)
            {
                if (girilenSayideger % 4 == 0)
                {
                    Console.WriteLine(girilenSayideger + "sayısı 4 ile tam bölünür.");

                }
                else
                {
                    Console.WriteLine(girilenSayideger + "sayısı 4 ile tam bölünmez.");
                }
            }




            else if (eldekiBasamak != 3 && eldekiBasamak != 4)

            {
                Console.WriteLine("Geçersiz sayı girdiniz.");
            }


            Console.ReadKey();
        }
    }


 

        }
    

