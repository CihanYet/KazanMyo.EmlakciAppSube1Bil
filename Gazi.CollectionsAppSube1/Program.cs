using System;
using System.Collections;
using System.Collections.Generic;

namespace Gazi.CollectionsAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] dizi = new int[2];//Type Safe
            //dizi[0] = 5;
            //dizi[1] = 3;
            //Console.WriteLine(dizi[0] + dizi[1]);

            ////Non Generic Collections
            ArrayList al = new ArrayList();
            //al.Add(5);
            //al.Add(3);
            //al.Add(2);
            //al.Add(1);
            //al.Add(2);
            //al.Add(3);
            //al.Add(2);
            //al.Add(1);
            //al.Add(2);
            //al.Add(10);
            //al.Capacity = al.Count;
            //Console.WriteLine($"Eleman sayısı:{al.Count}\nKapasite:{al.Capacity}");
            //Console.WriteLine((int)al[0] + (int)al[1]);


            //int sayi = 10;//Değer Tipidir-Stack
            //object number = sayi;//Referans Tipidir-Heap - Boxing işlemi

            //int _sayi = (int)number;//Unboxing işlemi

            //Generic Collections
            //Test<int, string> t = new Test<int, string>();
            //t.veri1 = 10;
            //t.veri2 = "20";
            //t.Yazdir(t.veri1);

            List<int> lst = new List<int>();
            lst.Add(10);
            lst.Add(20);
            lst.Capacity = lst.Count;
            Console.WriteLine(lst[0] + lst[1]);
        }
    }

    class Test<T, U> where T : struct
                     where U : class
    {
        public T veri1;
        public U veri2;

        public void Yazdir(T value)
        {
            Console.WriteLine(value);
        }
    }
}

//Diziler: Başta eleman sayısı bilinmek zorunda. Tip Güvenliği sağlayan yapılar
//Koleksiyonlar: Başta eleman sayısı bilinmek zorunda değil. Bir koleksiyona eleman ataması yapılırken, koleksiyonun boyutu dinamik olarak arttırılır.
