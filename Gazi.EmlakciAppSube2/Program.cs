using Gazi.EmlakciLibSube2;
using System;
using System.IO;
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


            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                //----
                FileMode mod;
                if (File.Exists(@"D:\Evler.txt"))
                {
                    mod = FileMode.Append;
                }
                else
                {
                    mod = FileMode.CreateNew;
                }


                using (fs = new FileStream(@"D:\Evler.txt", mod))
                {
                    using (sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(ke.ToString());
                        fs.Flush();
                        sw.Close();
                        fs.Close();
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Dosya işleminde hata oluştu!");
            }
            catch (Exception)
            {
                Console.WriteLine("Hata oluştu!!");
            }
            finally
            {
                //if (sw != null && fs != null)//Null Check
                //{
                //    sw.Dispose();
                //    fs.Dispose();
                //}
            }






            //var ke2 = new KiralikEv(3, 2, "Kiralik Ev", 150, 800, 900);

            //Ev[] evler = new Ev[2];
            //evler[0] = se;
            //evler[1] = ke;


            //for (int i = 0; i < evler.Length; i++)
            //{
            //    if (evler[i] is SatilikEv)
            //    {
            //        SatilikEv sev = (SatilikEv)evler[i];
            //        Console.WriteLine(sev.EvBilgileri());
            //    }
            //    else
            //    {
            //        KiralikEv kev = (KiralikEv)evler[i];
            //        Console.WriteLine(kev.EvBilgileri());
            //    }                
            //    Console.WriteLine("------------------------");
            //}

            //for (int i = 0; i < evler.Length; i++)
            //{
            //    Console.WriteLine(evler[i].EvBilgileri());
            //    Console.WriteLine("------------------------");
            //}



            //Animal animal;

            //animal = new Cat();
            //Console.WriteLine(animal.Sound());

            //animal = new Dog();
            //Console.WriteLine(animal.Sound());          

        }


    }


    class Animal
    {
        public virtual string Sound()
        {
            return "Animal classındaki ses işlemleri yapıldı.";
        }
    }

    class Cat : Animal
    {
        public override string Sound()
        {
            return $"{base.Sound()} Miyav sesi oluştu";
            //Kedi ile ilgili ses işlemleri
        }
    }

    class Dog : Animal
    {
        public override string Sound()
        {
            return $"{base.Sound()} Hav Hav sesi oluştu";
            //Köpek ile ilgili ses işlemleri
        }
    }

}

//Name Hiding(İsim Gizleme): Türeyen classlarlarda base classtaki bir üye ile aynı isimde üye tanımlaması yapılırsa, türeyen class referansı ile base classtaki üyeye artık erişilemez. Kısaca, türeyen classtaki üye, base classtaki üyeyi gizler.

//Polymorphisim (Çok biçimlilik): Türeyen classlarda tanımlanan üyelerin, base classtaki virtual olan üyeleri ezerek devre dışı bırakmasıdır. Base classta tanımlanan bir üyenin, türeyen classlarda farklı biçimde çalışmasıdır.














//Class: Nesnelerin sahip olması gereken özelliklerin ve eylemlerin tanımlandığı kod bloklarıdır. Classlar aynı zamanda bir veri tipidir. Referans tipi veri tiplerindendir.
//private: Gizli anlamına gelir. Private üyelere sadece içinde bulunduğu class tarafından erişilebilir.
//public: Public üyelere, içinde bulunduğu class dışından da erişilebilir.
//static olarak tanımlanan üyelere nesne referansı ile erişilemez. Bu üyeler nesnelerin değil, class'ın bir parçası olarak tanımlanırlar.

//Constructor-Yapıcı Metod-Kurucu Metod: Class içinde tanımlanmış olan field/property'lere varsayılan değerlerini atayarak onları kullanıma hazır hale getirirler.
// Her classta parametre almayan varsayılan bir constructor bulunur.


