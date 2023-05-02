using System;

namespace KazanMyo.EmlakciLibSube1Bil
{
    //public private protected internal sealed
    public class Ev : Object
    {

        protected int sayi;

        private static int sayac = 0;
        public Ev()
        {
            sayac++;
        }
        public Ev(int odasayisi, int katno, string semt, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            sayac++;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Gazi";
            this.Alan = alan;
            sayac++;
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
        public static int Sayac { get => sayac; }      

       
        public override string ToString()
        {
            return $"Odasayısı:{this.odasayisi}\nAlan:{this.Alan}\nSemt:{this.Semt}\nKat No:{this.Katno}";
        }
    }
}
