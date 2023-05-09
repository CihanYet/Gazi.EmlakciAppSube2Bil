using System;
using System.Collections.Generic;
using System.Text;

namespace Gazi.EmlakciLibSube2
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {
            
        }

        public SatilikEv(int odasayisi,int katno,string semt,double alan,double satisfiyat):base(odasayisi,katno,semt,alan)
        {
            this.Satisfiyat = satisfiyat;
        }
        public double Satisfiyat { get; set; }

        // public new string EvBilgileri() => $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
               

        public override string ToString()
        {
            return $"{base.ToString()}\nSatış Fiyatı:{this.Satisfiyat}";
        }
    }
}
