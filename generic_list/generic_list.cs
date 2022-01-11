using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collection.Generic
            // T -> generic olduğunu belirtir, object türündedir, liste içindeki nesnelerin tipini belirtir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine("*** Count ***");
            // Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve List.Foreach ile elemanlara erişim
            Console.WriteLine("*** Sayı Listesi Elemanları ***");
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("*** Renk Listesi Elemanları ***");
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            sayiListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma

            //sayiListesi.Remove(4);
            //renkListesi.Remove("Yeşil");

            //Console.WriteLine("*** Remove ***");
            //sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            //renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("*** RemoveAt ***");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama
            Console.WriteLine("\n*** Liste içerisinde arama ***");
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde mevcut");
            }

            // Eleman ile indexe erişme -> BinarySearch
            Console.WriteLine("\n*** Eleman ile indexe erişme ***");
            Console.WriteLine(renkListesi.BinarySearch("Yeşil"));

            // Diziyi listeye çevirme
            Console.WriteLine("\n*** Diziyi listeye çevirme ***");
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi temizleme
            hayvanListesi.Clear();

            // List içerisinde nesne tutma
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Özge";
            kullanici1.Soyisim = "Bulut";
            kullanici1.Yas = 23;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Can";
            kullanici2.Soyisim = "Taşpatlatanlar";
            kullanici2.Yas = 24;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
            }
            yeniListe.Clear();
        }
    }
    public class Kullanıcılar{
        
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
