using KazanMyo.EmlakciLibSube1Bil;
using System;

namespace KazanMyo.EmlakciAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SatilikEv se=new SatilikEv();
            se.Katno = 2;
            se.Alan = 100;
            se.Semt = "Gazi";
            se.Odasayisi = 4;
            se.Satisfiyat = 1000000;

                      
        }

        
    } 
}










//Class: Aynı zamanda bir veri tipidir.(Referans tipi) Eğer önceden tanımlanmış veri tipleri bizim ihtiyacımızı karşılamıyorsa, o zaman class yazarak ihtiyacımıza özel veri tipi oluşturabiliriz.
//Private: Sadece tanımlandıkları class içerisinden erişilebilir üyeler
//Public: Tanımlandıkları class dışından da erişelebilir üyeler.
//static: Class içinde tanımlanan static üyelerin nesnelerle bir bağlantısı yoktur. Doğrudan class adı ile erişilebilir.

//Constructor-Yapıcı Metod-Kurucu Metod: Her class içerisinde class adı ile aynı ada sahip olan metodlardır. Bu metodların görevi, class'dan nesne türeltildiğinde class içinde bulunan field/property'lere varsayılan değerini atamakdır.
