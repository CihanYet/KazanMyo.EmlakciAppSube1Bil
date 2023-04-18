using System;
using System.Collections.Generic;
using System.Text;

namespace KazanMyo.EmlakciLibSube1Bil
{
    public class SatilikEv:Ev
    {
        public double Satisfiyat { get; set; }

        public new string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
        }
    }
}

//internal erişim belirleyicisi: Sadece tanımlı olduğu namespace içerisinde kullanılabilir.