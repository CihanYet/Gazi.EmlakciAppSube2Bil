using Gazi.EmlakciLibSube2;
using System;
using System.Runtime.InteropServices;

namespace Gazi.EmlakciAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var se = new SatilikEv();
            se.Alan = 120;
            se.Satisfiyat = 10000;
            se.Odasayisi = 3;
            se.Katno = 1;
            se.Semt = "Satilik Ev";
           
            var ke = new KiralikEv();
            ke.Alan = 100;
            ke.Semt = "Kiralik Ev";
            ke.Kira = 500;
            ke.Depozito = 500;
            ke.Odasayisi = 3;
            ke.Katno = 2;


            Ev[] evler = new Ev[2];
            evler[0] = se;
            evler[1] = ke;

            for (int i = 0; i < evler.Length; i++)
            {
                Console.WriteLine(evler[i].EvBilgileri());
                Console.WriteLine("------------------------");
            }
            //Döngü her döndüğünde gelen evin tipini tespit ederek, kiralik yada satılık ev classındaki ev bilgileri metodunu çağırmaya çalışalım.




           

        }
    }
    
}

//Name Hiding(İsim Gizleme): Türeyen classlarlarda base classtaki bir üye ile aynı isimde üye tanımlaması yapılırsa, türeyen class referansı ile base classtaki üyeye artık erişilemez. Kısaca, türeyen classtaki üye, base classtaki üyeyi gizler.













//Class: Nesnelerin sahip olması gereken özelliklerin ve eylemlerin tanımlandığı kod bloklarıdır. Classlar aynı zamanda bir veri tipidir. Referans tipi veri tiplerindendir.
//private: Gizli anlamına gelir. Private üyelere sadece içinde bulunduğu class tarafından erişilebilir.
//public: Public üyelere, içinde bulunduğu class dışından da erişilebilir.
//static olarak tanımlanan üyelere nesne referansı ile erişilemez. Bu üyeler nesnelerin değil, class'ın bir parçası olarak tanımlanırlar.

//Constructor-Yapıcı Metod-Kurucu Metod: Class içinde tanımlanmış olan field/property'lere varsayılan değerlerini atayarak onları kullanıma hazır hale getirirler.
// Her classta parametre almayan varsayılan bir constructor bulunur.


