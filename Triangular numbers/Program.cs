using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307095DzenitHafta13Odev11
{
    class Program
    {
        static void Main(string[] args)
        {

            bool kontrol = true;

            int girilenSayi;
                Yanlis:
            do
            {
                Console.WriteLine("Lütfen  sayınızı giriniz:");

            
                if ((kontrol = int.TryParse(Console.ReadLine(), out girilenSayi)) == false)
                {
                    

                    Console.WriteLine("Yanlış giriş!");
                }


            } while (kontrol == false);


            int girilenSayideger = girilenSayi;
            int eldekiBasamak = 0;
            int toplam = 0;
            int sayi = 1;


            while (girilenSayi > 0)
            {
                girilenSayi = girilenSayi / 10;
                eldekiBasamak = eldekiBasamak + 1;
            }

            if (eldekiBasamak <= 4 && girilenSayideger > 0)
            {



                while (toplam < girilenSayideger)
                {
                    toplam= toplam + sayi;

                    sayi = sayi + 1;

                }
                     

                if (toplam == girilenSayideger)
                {
                    Console.WriteLine(girilenSayideger+" üçgen sayıdır");
                }

                else
                {
                    Console.WriteLine(girilenSayideger + " üçgen sayı değildir");
                }
                        
                
            }

            else
            {
                Console.WriteLine("Yanlış giriş, lütfen en fazla 4 basamaklı ve pozitif bir sayı olması gerekiyor.");
                goto Yanlis;
                
            }


                Console.ReadKey();

        }
    }
}
