using System;
using System.Collections.Generic;
using System.Text;

namespace Gazi.EmlakciLibSube2
{
    public class SatilikEv : Ev
    {
        public double Satisfiyat { get; set; }

        // public new string EvBilgileri() => $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";

        public override string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
        }
    }
}
