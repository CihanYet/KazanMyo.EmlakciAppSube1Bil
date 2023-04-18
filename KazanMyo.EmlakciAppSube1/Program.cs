using KazanMyo.EmlakciLibSube1Bil;
using System;

namespace KazanMyo.EmlakciAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var se = new SatilikEv();
            se.Katno = 2;
            se.Alan = 100;
            se.Semt = "Satilik Ev";
            se.Odasayisi = 4;
            se.Satisfiyat = 1000000;
           
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
            for (int i = 0; i < evler.Length; i++)
            {
                Console.WriteLine(evler[i].EvBilgileri());
                Console.WriteLine("---------------------");
            }

            //Döngü her döndüğünde gelen evin tipine bakılarak ilgili class içindeki EvBilgileri metodunu çağırmaya çalışalım
        }


    }
}
//Name Hiding(İsim Gizleme): Türeyen classta, base class ile aynı isimde tanımlanmış üyelere, türeyen class referansları ile ulaşıldığında artık base classtaki üyelere ulaşılamaz.









//Class: Aynı zamanda bir veri tipidir.(Referans tipi) Eğer önceden tanımlanmış veri tipleri bizim ihtiyacımızı karşılamıyorsa, o zaman class yazarak ihtiyacımıza özel veri tipi oluşturabiliriz.
//Private: Sadece tanımlandıkları class içerisinden erişilebilir üyeler
//Public: Tanımlandıkları class dışından da erişelebilir üyeler.
//static: Class içinde tanımlanan static üyelerin nesnelerle bir bağlantısı yoktur. Doğrudan class adı ile erişilebilir.

//Constructor-Yapıcı Metod-Kurucu Metod: Her class içerisinde class adı ile aynı ada sahip olan metodlardır. Bu metodların görevi, class'dan nesne türeltildiğinde class içinde bulunan field/property'lere varsayılan değerini atamakdır.
