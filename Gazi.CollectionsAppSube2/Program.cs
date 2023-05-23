using System;
using System.Collections;
using System.Collections.Generic;

namespace Gazi.CollectionsAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Olmayan Koleksiyonlar (Object)

            ArrayList al = new ArrayList();
            al.Add(3);
            //al.Add(5);
            //al.Capacity = al.Count;
            //Console.WriteLine($"Eleman Sayısı:{al.Count}\nKapasite:{al.Capacity}");
            //Console.WriteLine((int)al[0] + (int)al[1]);

            //int[] dizi = new int[2];//Type Safe
            //dizi[0] = 3;
            //dizi[1] = 5;
            //Console.WriteLine(dizi[0] + dizi[1]);

            //int sayi = 10;//STACK-Value Type
            //object number = sayi;//HEAP - Reference Type - Boxing
            //int _number = (int)number;//STACK - Unboxing


            //Generic Collections
            //var t = new Test();
            //t.veri1 = 10;
            //t.veri2 = 20;
            //Console.WriteLine(t.Topla());

            //var t = new Test<string,double>();
            //t.veri1 = "5";
            //t.veri2 = 10;

            List<int> lst = new List<int>();//Type Safe
            lst.Add(3);
            lst.Add(20);
            lst.Capacity = lst.Count;
            Console.WriteLine(lst[0] + lst[1]);
            
        }
    }

    class Test<T, U> where T : class//Heap-string,Ev- Referans tipi
                    where U : struct//Stack-int,byte,double,float....Değer tipi
    {
        public T veri1;
        public U veri2;

        public void Yazdir(U veri)
        {
            Console.WriteLine(veri);
        }
    }


}

//Dizi: Aynı türden çok sayıda elemanı tek bir değişken ile temsil etmek için kullanılır.
//Collections: Çok sayıda elemanı tek bir değişken ile temsil etmek için kullanılır. Eğer koleksiyon yapısı generic değilse, her türden(object) elemanı atayabiliriz. Koleksiyonların, dizilerden farkı, tanımlama yapılırken eleman sayısı belirtme ihtiyacı bulunmamasıdır. Kapasiteleri, içerisine eleman eklendikçe dinamik olarak arttırılır.

// Referans tipleri class
//Değer tipleri struct
