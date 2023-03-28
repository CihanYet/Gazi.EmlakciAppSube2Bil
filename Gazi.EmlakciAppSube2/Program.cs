using System;
using System.Runtime.InteropServices;

namespace Gazi.EmlakciAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var evim = new Ev();

            Console.WriteLine("Oda sayısı giriniz:");
            evim.Odasayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Kat no giriniz:");
            evim.katno = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan giriniz:");
            evim.alan=int.Parse(Console.ReadLine());
            Console.WriteLine("Semt giriniz:");
            evim.semt=Console.ReadLine();
            Console.WriteLine(evim.EvBilgileri());

        }
    }

    class Ev
    {
        private int odasayisi;

        public int Odasayisi
        {
            get { return odasayisi; }
            set { odasayisi = value; }
        }

        public int katno;
        public string semt;
        public double alan;
        public string EvBilgileri()=> $"Alan:{this.alan}\nOda Sayısı:{this.odasayisi}\nKat no:{this.katno}\nSemt:{this.semt}";       
    }
}
//Class: Nesnelerin sahip olması gereken özelliklerin ve eylemlerin tanımlandığı kod bloklarıdır. Classlar aynı zamanda bir veri tipidir. Referans tipi veri tiplerindendir.
//private: Gizli anlamına gelir. Private üyelere sadece içinde bulunduğu class tarafından erişilebilir.
//public: Public üyelere, içinde bulunduğu class dışından da erişilebilir.
//static olarak tanımlanan üyelere nesne referansı ile erişilemez. Bu üyeler nesnelerin değil, class'ın bir parçası olarak tanımlanırlar.


