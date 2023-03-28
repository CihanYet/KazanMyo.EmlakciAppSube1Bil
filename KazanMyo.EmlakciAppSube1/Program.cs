using System;

namespace KazanMyo.EmlakciAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;//Değer tipi(STACK)
            Ev evim = new Ev();//Ev classından yeni bir nesne türettik.
            evim.alan = 120;//Set
            evim.odasayisi = 3;
            evim.katno = 2;
            evim.semt = "Gazi";

            Ev evim2 = new Ev();
            evim2.katno = 1;
            evim2.alan = 100;
            evim2.odasayisi = 2;
            evim2.semt = "Gazi";

            Console.WriteLine(evim2.EvBilgileri());
        }


    }

    class Ev
    {
        public int odasayisi;//field
        public string semt;
        public int katno;
        public double alan;

        public string EvBilgileri()
        {
            return $"Odasayısı:{this.odasayisi}\nAlan:{this.alan}\nSemt:{this.semt}\nKat No:{this.katno}";
        }

    }
}

//Class: Aynı zamanda bir veri tipidir.(Referans tipi) Eğer önceden tanımlanmış veri tipleri bizim ihtiyacımızı karşılamıyorsa, o zaman class yazarak ihtiyacımıza özel veri tipi oluşturabiliriz.
//Private: Sadece tanımlandıkları class içerisinden erişilebilir üyeler
//Public: Tanımlandıkları class dışından da erişelebilir üyeler.
//static: Class içinde tanımlanan static üyelerin nesnelerle bir bağlantısı yoktur. Doğrudan class adı ile erişilebilir.
