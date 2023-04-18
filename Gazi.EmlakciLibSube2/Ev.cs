using System;

namespace Gazi.EmlakciLibSube2
{
    public class Ev
    {
        private static int sayac = 0;
        public static int Sayac { get => sayac; }
        public Ev()
        {
            sayac++;
            
        }
        public Ev(int odasayisi, int katno, string semt, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.Semt = semt;
            sayac++;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.Semt = "Gazi";
            sayac++;
        }

        private int odasayisi;

        public int Odasayisi
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }

        public int Katno { get => katno; set => katno = value; }

        private int katno;
        private string semt;
        public double Alan { get; set; }
        public string Semt { get => semt; set => semt = value; }       

        public string EvBilgileri() => $"Alan:{this.Alan}\nOda Sayısı:{this.odasayisi}\nKat no:{this.Katno}\nSemt:{this.Semt}";
    }
}
