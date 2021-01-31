using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307095DzenitHafta12Odev10
{
    class Program
    {
        
        static void Main(string[] args)
        {

            
            bool kontrol = true;
            
            int girissayi;
            do
            {
                Console.WriteLine("Lutfen sayinizi giriniz:");


                if ((kontrol = int.TryParse(Console.ReadLine(), out girissayi)) == false)
                {
                    Console.WriteLine("Yanlış giriş ");
                }


            } while (kontrol==false);
            

            int sayi = 0;

            
            for (int i = 1; i < girissayi; i++)
            {
                if (girissayi % i == 0)
                {
                    sayi += i;

                    Console.WriteLine("Sayının Bölenlerini:" + i);

                    Console.WriteLine();
                    
                }
            }

            

            

            Console.WriteLine();

            if (sayi == girissayi)
            {
                Console.WriteLine(girissayi + " sayı mükemmel sayıdır");
            }


            else
            {
                Console.WriteLine(girissayi + " sayı mükemmel sayı değildir");
            }

            Console.ReadKey();




        }
    }
}
