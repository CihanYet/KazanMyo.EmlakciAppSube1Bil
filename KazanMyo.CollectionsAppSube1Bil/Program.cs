using System;
using System.Collections;
using System.Collections.Generic;

namespace KazanMyo.CollectionsAppSube1Bil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[2];//Type Safe
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //int result = sayilar[0] + sayilar[1];

            //ArrayList lst = new ArrayList();
            //lst.Add(10);
            //lst.Add(15);
            //lst.Add(20);

            //int sonuc = (int)lst[0] + (int)lst[1];

            //int sayi = 5;//Stack bölgesi
            //object number = sayi;//Stack-->Heap Boxing
            //int _sayi = (int)number;//Heap-->Stack UnBoxing

            ////Generic Collection
            //var ogr = new Ogrenci();
            //ogr.Ad = "Ahmet";
            //var t = new Test<Ogrenci>();
            //t.Yazdir(ogr);


           

            List<Ogrenci> lst = new List<Ogrenci>();
            lst.Add(new Ogrenci { Ad = "Ahmet" });
            lst.Add(new Ogrenci { Ad = "Mehmet" });

            Console.WriteLine(lst[1].Ad);

            //Ogrenci ogr = new Ogrenci();
            //ogr.Ad = "Ahmet";



            // var ogr = new Ogrenci { Ad = "Ahmet" };


        }
    }

    class Test<T>
    {
        public void Yazdir(T veri)
        {
            Console.WriteLine(veri.ToString());
        }
    }

    class Ogrenci:Okul
    {
        public string Ad { get; set; }

        public override string ToString()
        {
            return $"Öğrenci Adı:{this.Ad}";
        }

    }

    class Okul
    {

    }
}
