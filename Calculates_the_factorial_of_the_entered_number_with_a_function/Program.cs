using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_3
{
    class Program
    {    /* Girilen sayının faktöriyelini faktHayır isimli bir fonksiyon ile hesaplayan 
            ve hesapladığı değeri ana programa geri döndüren ve 
            yazdıran algoritma . (Örn:5 için; 5*4*3*2*1= 120)*/


        static int fakt(int sayi)
        {
            
            int degerSayi = sayi;
            int toplam = 1;

            for (int i = 1; i <= degerSayi; i++)
            {
                Console.Write(i + "*" + toplam);
                toplam = toplam * i;
            }


            sayi = toplam;
            return sayi;
        }



        static void Main(string[] args)
        {
            int girilenSayi;

            Console.WriteLine("Lütfen bir sayınızı giriniz:");

            girilenSayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=" + fakt(girilenSayi));
           // Console.WriteLine("Sayının faktöriyeli:" + fakt(girilenSayi));   bu kismi iki kez yazmak bak !!!





            Console.ReadKey();





        }
    }
}
