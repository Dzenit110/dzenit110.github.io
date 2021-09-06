using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaIIHafta4AsiriYuklenmisMetotlarParams
{
    class Program
    {
        //fonk metod tanımlayıp, aşırı yükleyelim
       static void fonk()
        {
            Console.WriteLine("Aşırı yüklenmiş ilk metot");
          
         
        }

        //aşırı yükleyelim
        static void fonk(int a)
        {
            Console.WriteLine("Sonuc:(int)"+a * a);
        }

        static void fonk(double a)
        {
            Console.WriteLine("Sonuc:(double)"+a * a);
        }

        static int fonk(int a,int b)
        {
            return a + b;
        }
     
        static void fonk(string a)
        {
            Console.WriteLine("Sonuc:(str)" + a);
        }

        static void fonkp(params object[] a) //n tane parametre alacak..PARAMS anahtarı 
        {
            if (a.Length == 0)
                Console.WriteLine("parametre gelmedi");
            foreach (object t in a)
            {
                
                Console.WriteLine(t);
            }

        }
        static void Main(string[] args)
        {
            
            fonk();
            fonk(34);
            Console.WriteLine("Sonuc:" + fonk(3, 4));
            fonk(4.5);
            //params kullanımı
            fonkp();
            fonkp(44);
            fonkp(545,666,55,77);
            
           
            
        }
    }
}
