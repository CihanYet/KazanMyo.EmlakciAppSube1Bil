using KazanMyo.EmlakciLibSube1Bil;
using System;

namespace KazanMyo.EmlakciAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var se = new SatilikEv(4, 2, 100, "Satilik Semt", 100000);
           
            Console.WriteLine(se.ToString());


            var ke = new KiralikEv();
            ke.Katno = 3;
            ke.Kira = 500;
            ke.Alan = 100;
            ke.Depozito = 600;
            ke.Odasayisi = 2;
            ke.Semt = "Kiralik Ev";



            Ev[] evler = new Ev[2];
            evler[0] = se;
            evler[1] = ke;
            //for (int i = 0; i < evler.Length; i++)
            //{
            //    if (evler[i] is SatilikEv)
            //    {
            //        SatilikEv sev = (SatilikEv)evler[i];
            //        Console.WriteLine(sev.EvBilgileri());
            //    }
            //    else
            //    {
            //        KiralikEv kev = (KiralikEv)evler[i];
            //        Console.WriteLine(kev.EvBilgileri());
            //    }
            //    Console.WriteLine("---------------------");
            //}

            //for (int i = 0; i < evler.Length; i++)
            //{
            //    Console.WriteLine(evler[i].EvBilgileri());
            //    Console.WriteLine("----------------------");
            //}

            //Animal animal;

            //animal = new Cat();
            //Console.WriteLine(animal.Sound());

            //animal = new Dog();
            //Console.WriteLine(animal.Sound());


            //Ev evim;
            //evim = new SatilikEv();
            //Console.WriteLine(evim.EvBilgileri());

            //evim=new KiralikEv();
            //Console.WriteLine(evim.EvBilgileri());

            //Cat cat=new Cat();
            //Console.WriteLine(cat.Sound());

            //Dog dog = new Dog();
            //Console.WriteLine(dog.Sound());

            //Animal animal = new Cat();
            //Console.WriteLine(animal.Sound());

            //animal = new Dog();
            //Console.WriteLine(animal.Sound());


        }
    }


    class Animal
    {
        public virtual string Sound()
        {
            return "Ses tellerinin titreşimi sağlandı.";
        }

    }

    class Cat:Animal
    {
        public override string Sound()
        {
            return base.Sound()+"Titreşim sonucunda miyav sesi çıkar.";
        }
    }

    class Dog:Animal
    {
        public override string Sound()
        {
            return base.Sound()+"Titreşim sonucunda hav hav sesi çıkar";
        }
    }
}
//Name Hiding(İsim Gizleme): Türeyen classta, base class ile aynı isimde tanımlanmış üyelere, türeyen class referansları ile ulaşıldığında artık base classtaki üyelere ulaşılamaz.

//Polymorphisim (Çok biçimlilik): Base class'da virtual olarak tanımlanan bir üyenin, türeyen classta ezilerek devreden çıkarılması ve farklı biçimde çalıştırılmasıdır.









//Class: Aynı zamanda bir veri tipidir.(Referans tipi) Eğer önceden tanımlanmış veri tipleri bizim ihtiyacımızı karşılamıyorsa, o zaman class yazarak ihtiyacımıza özel veri tipi oluşturabiliriz.
//Private: Sadece tanımlandıkları class içerisinden erişilebilir üyeler
//Public: Tanımlandıkları class dışından da erişelebilir üyeler.
//static: Class içinde tanımlanan static üyelerin nesnelerle bir bağlantısı yoktur. Doğrudan class adı ile erişilebilir.

//Constructor-Yapıcı Metod-Kurucu Metod: Her class içerisinde class adı ile aynı ada sahip olan metodlardır. Bu metodların görevi, class'dan nesne türeltildiğinde class içinde bulunan field/property'lere varsayılan değerini atamakdır.
