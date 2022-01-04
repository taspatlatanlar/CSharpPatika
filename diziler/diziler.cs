using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];                        // renkler adında bir dizi tanımlayıp boyutunu belirledik
            string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"}; // hayvanlar adında bir dizi tanımlayıp elemanlarını belirledik

            int[] dizi;         // boyut da eleman da vermedik, daha sonra boyutunu şöyle verebiliriz;
            dizi = new int[5];  // dizi adındaki dizinin boyutunu 5 yaptık

            // Dizide değer atama ve erişim

            renkler[0] = "Mavi";                // renkler dizisinin sıfırıncı indexindeki, yani birinci elemanına "Mavi" değerini atadık
            Console.WriteLine(hayvanlar[0]);    // hayvanlar dizisinin sıfırıncı indexindeki elemanın değerini ekrana yazdırdık

            dizi[3] = 10;                       // Dizinin üçüncü indexine 10 değerini atadık.

            Console.WriteLine("hayvanlar dizisinin ikinci elemanı: " + hayvanlar[1]);
            Console.WriteLine("dizi dizisinin dördüncü elemanı: " + dizi[3]);
            Console.WriteLine("renkler dizisinin birinci elemanı: " + renkler[0]);

            // Döngülerle dizi kullanımı

            Console.WriteLine("*** Döngülerle Dizi Kullanımı ***");

            // klavyeden girilen n tane sayının ortalamasını alan program

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1); // Lütfen 1. sayıyı giriniz diye başlayacak
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());    // sayiDizisi[0] = (girilen sayı) şeklinde atama yapacak
            }
            
            int toplam = 0;
            foreach (var sayi in sayiDizisi)    // "sayiDizisi" elemanları içerisinde döneceğiz
            {
                toplam += sayi;                 // her bir elemanı toplam değişkenine ekleyerek elemanlar bitene kadar bu işlemi tekrarlayacağız
            }
            Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
        }
    }
}
