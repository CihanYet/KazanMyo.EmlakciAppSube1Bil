using System;
using System.Collections.Generic;
using System.Text;

namespace KazanMyo.EmlakciLibSube1Bil
{
    public class KiralikEv:Ev
    {
        public double Kira { get; set; }
        public double Depozito { get; set; }

        public new string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        }
    }
}
