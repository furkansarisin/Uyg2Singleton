using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Sinif s1 = new Sinif();
            s1.a = 10;
            Sinif s2 = new Sinif();
            s2.a = 10;

            if (s1 == s2)
                Console.WriteLine("Nesneler eşit");
            else
                Console.WriteLine("Nesneler eşit değil");
            //Yukarıdaki karşılaştırmada s1 ve s2 nesnelerinin bellek adresleri eşit mi diye kontrol ediyoruz.

            if (s1.a == s2.a)
                Console.WriteLine("a değeri eşittir.");
            else
                Console.WriteLine("a değeri eşit değildir.");
            //s1 ve s2 nesnelerinin a değerleri eşit mi diye kontrol ediyoruz.

            Sinif s3 = new Sinif();
            s3.a = 10;
            Sinif s4 = s3;
            s4.a = 5;

            if (s3 == s4)
            {

                Console.WriteLine("Nesnelerin bellek adresleri aynı");
            }
            else
                Console.WriteLine("Nesnelerin bellek adresleri farklı");
            //iki nesne aynı bellek adresini gösteriyorsa,aynı nesnelerdir.

            /* Baglantı b1 = new Baglantı();
             Baglantı b2 = new Baglantı();
             Baglantı b3 = new Baglantı();*/

            Baglantı b1 = Baglantı.BaglantıDönder();
            Baglantı b2 = Baglantı.BaglantıDönder();
            Baglantı b3 = Baglantı.BaglantıDönder();
            //Hepsi aynı nesne

            if (b1 == b2)
                Console.WriteLine("Nesneler aynı adresi gösteriyor");
            else
                Console.WriteLine("Farklı nesneler");

            //Singleton Design Pattern

        }

    }
    class Sinif
    {
        public int a;
    }
}