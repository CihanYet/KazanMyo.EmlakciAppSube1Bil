using System;

namespace KazanMyo.EmlakciAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;//Değer tipi(STACK)
            Ev evim = new Ev();//Ev classından yeni bir nesne türettik.
            evim.Alan = 120;//Set
            evim.Odasayisi = 3;
            evim.Katno = 2;
            evim.Semt = "Gazi";

            Ev evim2 = new Ev();
            evim2.Katno = 1;
            evim2.Alan = 100;
            evim2.Odasayisi = 2;
            evim2.Semt = "Gazi";

            Console.WriteLine(evim2.EvBilgileri());

        }


    }

    class Ev
    {
        private int odasayisi;

        public int Odasayisi
        {
            get { return odasayisi; }
            set { odasayisi = value; }
        }

        public string Semt { get => semt; set => semt = value; }
        public int Katno { get => katno; set => katno = value; }

        private string semt;
        private int katno;
        public double Alan { get; set; }

        public string EvBilgileri()
        {
            return $"Odasayısı:{this.odasayisi}\nAlan:{this.Alan}\nSemt:{this.Semt}\nKat No:{this.Katno}";
        }

    }
}

//Class: Aynı zamanda bir veri tipidir.(Referans tipi) Eğer önceden tanımlanmış veri tipleri bizim ihtiyacımızı karşılamıyorsa, o zaman class yazarak ihtiyacımıza özel veri tipi oluşturabiliriz.
//Private: Sadece tanımlandıkları class içerisinden erişilebilir üyeler
//Public: Tanımlandıkları class dışından da erişelebilir üyeler.
//static: Class içinde tanımlanan static üyelerin nesnelerle bir bağlantısı yoktur. Doğrudan class adı ile erişilebilir.
