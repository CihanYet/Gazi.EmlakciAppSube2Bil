using System;
using System.Runtime.InteropServices;

namespace Gazi.EmlakciAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var evim = new Ev(-3, 2, "Gazi", 120);
            Console.WriteLine(evim.EvBilgileri());

            var evim2 = new Ev();
            Console.WriteLine(evim2.EvBilgileri());

            var evim3 = new Ev();
           
            Console.WriteLine(Ev.Sayac);
        }
    }

    class Ev
    {
        private static int sayac = 0;
        public static int Sayac { get => sayac;}
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
//Class: Nesnelerin sahip olması gereken özelliklerin ve eylemlerin tanımlandığı kod bloklarıdır. Classlar aynı zamanda bir veri tipidir. Referans tipi veri tiplerindendir.
//private: Gizli anlamına gelir. Private üyelere sadece içinde bulunduğu class tarafından erişilebilir.
//public: Public üyelere, içinde bulunduğu class dışından da erişilebilir.
//static olarak tanımlanan üyelere nesne referansı ile erişilemez. Bu üyeler nesnelerin değil, class'ın bir parçası olarak tanımlanırlar.

//Constructor-Yapıcı Metod-Kurucu Metod: Class içinde tanımlanmış olan field/property'lere varsayılan değerlerini atayarak onları kullanıma hazır hale getirirler.
// Her classta parametre almayan varsayılan bir constructor bulunur.


