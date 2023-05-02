using System;
using System.Collections.Generic;
using System.Text;

namespace KazanMyo.EmlakciLibSube1Bil
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {           
            
        }

        public SatilikEv(int odasayisi, int katno, double alan, string semt, double satisfiyat) : base(odasayisi, katno, semt, alan)
        {
            this.Satisfiyat = satisfiyat;
        }
        public double Satisfiyat { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
        //}



        public override string ToString()
        {
            return $"{base.ToString()}\nSatış Fiyatı:{this.Satisfiyat}";
        }
    }
}

//internal erişim belirleyicisi: Sadece tanımlı olduğu namespace içerisinde kullanılabilir.

//Ev base class
//SatilikEv Derived class