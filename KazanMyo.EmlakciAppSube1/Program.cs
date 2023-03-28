using System;

namespace KazanMyo.EmlakciAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ev evim3 = new Ev();
            Ev evim = new Ev(3, 2, "Gazi", 100);
            Ev evim2 = new Ev(2, 5, 100);

            Console.WriteLine(evim2.EvBilgileri());
        }
    }

    class Ev
    {
        public Ev()
        {

        }
        public Ev(int odasayisi, int katno, string semt, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Gazi";
            this.Alan = alan;
        }

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

//Constructor-Yapıcı Metod-Kurucu Metod: Her class içerisinde class adı ile aynı ada sahip olan metodlardır. Bu metodların görevi, class'dan nesne türeltildiğinde class içinde bulunan field/property'lere varsayılan değerini atamakdır.
