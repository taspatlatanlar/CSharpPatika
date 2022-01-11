using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayListler, System.Collections namescape'i altındadır.
            // Arraylist bir koleksiyon tipidir, tek bir veri tipini değil birden çok veri tipini içinde barındırabilir.
            // Dinamik olarak büyüyp küçülebilirler

            ArrayList liste = new ArrayList();
            //liste.Add("Can");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            // İçerisindeki verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}
            // AddRange -> Birden fazla elemanı aynı anda ekleme
            Console.WriteLine("\n*** Add Range ***");
            //string[] renkler = {"kırmızı", "sarı", "mavi"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};

            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            // Sort -> Sıralama
            Console.WriteLine("\n*** Sort ***");
            //liste.Sort();-> compile time'da değil ancak runtime'da hata verir, çünkü listenin elemanlarının tamamı Int32 tipinde değil
            // o yüzden listeye eklediğimiz int dışındaki her şeyi yorum satırına aldık
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Binary Search
            Console.WriteLine("\n*** Binary Search ***");
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse
            Console.WriteLine("\n*** Reverse ***");
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Clear
            Console.WriteLine("\n*** Clear ***");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
