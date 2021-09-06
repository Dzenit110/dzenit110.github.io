using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaIIHafta5SiniflarGiris
{
    class HesapKarti
    {
        #region degiken ve tanımlar
        //Kart sınıfı oluşturulalım

        //değişkenler 
        //müsteri adı soyadı
        //kart no-müsteri no
        //skt
        //bakiye
        //limiti

        //metotlar
        //ParaCek()
        //ParaYatir()
        //LimitArttir()
        //HesapAc()
        //HesapKapat()
        //hesapYazdir()
        //değişkenler
        string musAdSoyad;
        int musNo;
        int skt;
        double bakiye;
        double limit;
        string sifre;
        #endregion

        #region kurucular/yapıcılar ve yıkıcı
        //yapıcı metot: sınıf ile aynı isme sahip..
        //parametreli ve parametresiz
        public HesapKarti()
        {
            Console.WriteLine("parametresiz kurucu");
            bakiye = 100;
        }
        public HesapKarti(double b, double l)
        {
            Console.WriteLine("parametreli kurucu çalıştı");
            bakiye = b;
            limit = l;
        }
        //public HesapKarti(double bb):this(bb,0)  //aşağıdaki kurucunun muadili
        //{

        //}
        public HesapKarti(double bb)
        {
            Console.WriteLine("parametreli kurucu çalıştı");
            bakiye = bb;
        }

        //kopya kurucu
        public HesapKarti(HesapKarti hk)
        {
            Console.WriteLine("kopya kurucu çalıştı");
            this.musAdSoyad = hk.musAdSoyad;
            this.bakiye = hk.bakiye;
            this.limit = hk.limit;
            this.skt = hk.skt;
            this.sifre = hk.sifre;
            this.musNo = hk.musNo;
        }
        //yıkıcı
        ~HesapKarti()
        {
            Console.WriteLine("yıkıcı çalıştı..");
        }
        #endregion
        #region metotlar
        //metotlar
        //hesapAc(girdiler)
        //paraYatir(yatirlan miktar)
        //paraCek(cekilen miktar)
        //Yazdir()
        //limitArttir(yeni limit değeri)
        //hesapKapat()


        //metotlar
        //hesapAC()
        public void HesapAc(string musAdSoyad, int musNo, int skt, double limit)
        {
            this.musAdSoyad = musAdSoyad;
            this.musNo = musNo;
            this.skt = skt;
            this.limit = limit;
        }

        //paraYatir(yatirilanMiktar)
        public void paraYatir(double yatirilanMiktar)
        {
            bakiye += yatirilanMiktar;
        }

        //paraCek(cekilenMiktar)
        public void paraCek(double cekilenMiktar)
        {
            //l=l-(cek-b) b=0
            //1. şart.. cekilenMiktar bakiyeden<= ise direk bakiyeden düş
            //2. şart cekilenMiktar bakiyeden fazla ise kalanı limitten düşerek çek
            //3. şart çekilenMiktar b+l fazla ise işlem yapma
            if (cekilenMiktar <= bakiye)
                bakiye = bakiye - cekilenMiktar;
            else if (cekilenMiktar < bakiye+limit)
            {
                limit = limit - (cekilenMiktar - bakiye);
                bakiye = 0;
            }
            else 
                Console.WriteLine(cekilenMiktar+ " tl yetersiz hesap (bakiye+limit) yüzünden çekilemedi");

        }

        public void limitArttir(double yeniLimit)
        {
            if (yeniLimit < limit)
                Console.WriteLine("yeni limit daha büyük olmalı");
            else
            limit = yeniLimit;
        }

        //Yazdir()
        public void Yazdir()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Mus adsoyad:" + musAdSoyad);
            Console.WriteLine("Musno:" + musNo);
            Console.WriteLine("Skt:" + skt);
            Console.WriteLine("Bakiye:" + bakiye);
            Console.WriteLine("Limit:" + limit);
            Console.WriteLine("Sifre:" + sifre);
        }
        #endregion
      
        static void Main(string[] args)
        {
            HesapKarti hk1 = new HesapKarti();
            HesapKarti hk2 = new HesapKarti(1400);


       } //program sonu ve yıkıcılar çalışıyor
    }

    
}
