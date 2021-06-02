using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanHesaplama
{

    class Sekil
    {

        internal Sekil()
        {
            Console.WriteLine("#####");
            Console.WriteLine("Şekil seçimi yapılıyor.");
        }

        public virtual void SonucuGoster()
        {
            Console.WriteLine("Şekil alanı gösterilir.");
        }


    }

    class Daire : Sekil
    {
        private double _r = 0;

        public Daire(double r)
        {
            _r = r;
        }

        public Daire()
        {
            Console.WriteLine("Dairenin yarıçapını giriniz:");
            if (!double.TryParse(Console.ReadLine(), out _r)) ;
            Console.WriteLine("Girilen değer yanlış!");

        }

        public double AlaniniBul()
        {
            return Math.PI * _r;

        }

        public override void SonucuGoster()
        {
            if (_r == 0)
                Console.WriteLine("Alan hesaplanamadı...");
            else
                Console.WriteLine("Dairenin Alanı: {0}", AlaniniBul());

            Console.WriteLine("########################################");


        }


    }


    class Kare : Sekil
    {
        private double _en = 0;

        public Kare(double en)
        {
            _en = en;

        }

        public Kare()
        {
            Console.WriteLine("Karenin uzunluğunu giriniz.");
            if (!double.TryParse(Console.ReadLine(), out _en))
                Console.WriteLine("Girilen değer yanlış.");

        }

        public double AlaniBul()
        {
            return _en * _en;
        }

        public override void SonucuGoster()
        {
            if (_en == 0)
                Console.WriteLine("Alan hesaplanmadı!");
            else
                Console.WriteLine("KArenin alanı: {0}", AlaniBul());

            Console.WriteLine("############################################");


        }


    }


    class Ucgen : Sekil
    {
        private double _taban = 0, _yukseklik = 0;

        public Ucgen(double taban, double yukseklik)
        {

            _taban = taban;
            _yukseklik = yukseklik;
        }

        public Ucgen()
        {
            Console.WriteLine("Üçgenin taban uzunluğunu giriniz");
            if (!double.TryParse(Console.ReadLine(), out _taban)) ;
            Console.WriteLine("Lütfen taban yüksekliğini giriniz");
            double.TryParse(Console.ReadLine(), out _yukseklik);

        }

        public double AlaniniBul()
        {
            return (_taban * _yukseklik) / 2;
        }


        public override void SonucuGoster()
        {
            if (_taban == 0 || _yukseklik == 0)
                Console.WriteLine("Alan hesaplanamadı...");
            else
                Console.WriteLine("Üçgenin Alanı: {0}", AlaniniBul());

            Console.WriteLine("#######################################");

        }

    }


    static class Program
    {

        static void Main(string[] args)
        {
            int secim = 0;
            while (true)
            {
                Console.WriteLine("###Seçim Yapınız###");
                Console.WriteLine("1.Kare");
                Console.WriteLine("2.Üçge");
                Console.WriteLine("3.Daire");
                Console.WriteLine("Lütfen seçtiğiniz şekil için sayı giriniz: ");

                if (int.TryParse(Console.ReadLine(), out secim))
                {

                    switch (secim)
                    {

                        case 1:
                            Sekil kare = new Kare();
                            kare.SonucuGoster();
                            break;
                        case 2:
                            Sekil ucgen = new Ucgen();
                            ucgen.SonucuGoster();
                            break;
                        case 3:
                            Sekil daire = new Daire();
                            daire.SonucuGoster();
                            break;

                        default:
                            Console.WriteLine("Lütfen listedeki değerlerden birini seçiniz");
                            break;
                    }
                }

                Console.WriteLine("Yeni hesaplamanın başlatılması için bir tuşa basın.(çıkış için q'ya basınız");
                if (Console.ReadKey().KeyChar == 'q')
                {
                    Console.Clear();
                    Console.Write("Programdan çıkılıyor...");
                    break;
                }
                else
                    Console.Clear();

            }



        }
    }
}
