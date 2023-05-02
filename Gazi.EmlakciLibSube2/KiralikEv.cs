using System;
using System.Collections.Generic;
using System.Text;

namespace Gazi.EmlakciLibSube2
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {
            
        }

        public KiralikEv(int odasayisi, int katno, string semt, double alan, double kira, double depozito) : base(odasayisi, katno, semt, alan)
        {
            this.Kira = kira;
            this.Depozito = depozito;
        }
        public double Kira { get; set; }
        public double Depozito { get; set; }

        //public new string EvBilgileri() => $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";

        public override string ToString()
        {
            return $"{base.ToString()}\nKira:{this.Kira}\nDepozito{this.Depozito}";
        }
    }
}
