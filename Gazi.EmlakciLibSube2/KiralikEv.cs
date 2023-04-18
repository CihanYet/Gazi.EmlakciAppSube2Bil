using System;
using System.Collections.Generic;
using System.Text;

namespace Gazi.EmlakciLibSube2
{
    public class KiralikEv : Ev
    {
        public double Kira { get; set; }
        public double Depozito { get; set; }

        public new string EvBilgileri() => $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
    }
}
