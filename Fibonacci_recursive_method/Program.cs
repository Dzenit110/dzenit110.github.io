using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzenit_Vildic_191307095__Odev4
{
    class Program
    {
        static void Fibonacci()
        {
            int d1 = 1, d2 = 1, sayi, d3;


            Console.WriteLine("ilk olarak hangi sıradaki değeri görmek istiyorsunuz ?");
            sayi = Convert.ToInt32(Console.ReadLine());

            d3 = d1 + d2;


            int[] dizi = new int[sayi];

            dizi[0] = d1;
            dizi[1] = d2;

            for (int i = 2; i < dizi.Length; i++)
            {
                d1 = d2;
                d2 = d3;
                dizi[i] = dizi[i] + d3;
                d3 = d1 + d2;

                if (i == (sayi - 1))
                {
                    Console.WriteLine((i + 1) + ".sıradaki fibonacci değeri:" + dizi[i] + "(iteratif)");
                }

            }
        }

        static int Fibonacci1(int i)
        {

            //Sıfıra eşitse
            if (i == 0)
                return 1;
            //bire eşitse
            else if (i == 1)
                return 1;
            else
                return Fibonacci1(i - 1) + Fibonacci1(i - 2);
        }

        static int UsAlma(int taban, int us)
        {
            int sonuc;
            if (us == 0)
                sonuc = 1;
            else
                sonuc = taban * UsAlma(taban, us - 1);
            return sonuc;
        }


        static void Main(string[] args)
        {
            bool kontrol = true;
            bool durum = false;
            int girilenSayi;

            string yildiz = new string('*', 93);
            Console.WriteLine(yildiz);

            Console.WriteLine("Dzenit Vildic 191307095 Odev4 Ozyinelemeli Fonksiyonlar");
            Console.WriteLine();

            Console.WriteLine("1 - Fibonacci Hesaplama (iteratif)");
            Console.WriteLine("2 - Fibonacci Hesaplama (özyinelemeli)");
            Console.WriteLine("3 - Us alma(özyinelemeli)");
            Console.WriteLine("4 - Çıkış");

            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz :");
                Console.WriteLine(yildiz);



                if ((kontrol = int.TryParse(Console.ReadLine(), out girilenSayi)) == false)
                {
                    if (kontrol == false)
                    {
                        Console.WriteLine("Geçersiz giriş yaptınız!");
                        goto cikis;
                    }
                }



                if (girilenSayi == 1)

                {
                    Fibonacci();

                    Console.WriteLine("Devam etmek istiyor musunuz? (e/h)");
                }


                else if (girilenSayi == 2)
                {
                    Console.WriteLine("ilk olarak hangi sıradaki değeri görmek istiyorsunuz ?");
                    girilenSayi = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < girilenSayi; i++)
                    {
                        Fibonacci1(i);

                        if (i == (girilenSayi - 1))
                        {
                            Console.WriteLine((i + 1) + ".sıradaki fibonacci değeri:" + Fibonacci1(i) + "(özyinelemeli)");
                        }
                    }
                    Console.WriteLine("Devam etmek istiyor musunuz? (e/h)");
                }


                else if (girilenSayi == 3)
                {
                    int us, sonuc;
                    Console.Write("Lütfen taban degerini giriniz:");
                    girilenSayi = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Sayısının kacıncı kuvvetini alacaksiniz:", girilenSayi);

                    us = Convert.ToInt32(Console.ReadLine());
                    sonuc = UsAlma(girilenSayi, us);

                    Console.WriteLine(girilenSayi + " üzeri " + us + " : " + sonuc);

                    Console.WriteLine("Devam etmek istiyor musunuz? (e/h)");
                }

                else
                {
                    goto cikis;
                }



                string cevap = Console.ReadLine();


                if (cevap == "e")
                {
                    durum = true;
                }

                else
                {
                    durum = false;
                    Console.WriteLine("Geçersiz giriş yaptınız!");
                }
            } while (durum == true);

        cikis: Console.ReadKey();


        }
    }
}
