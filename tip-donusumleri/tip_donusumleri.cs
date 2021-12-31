using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion - Bilinçsiz Dönüşüm
            // Düşü kkapasiteli bir değişkenin, kendinden daha yüksek kapasiteli bir değişkene dönüştürülmesi

            Console.WriteLine("*** Implicit Conversion ***");

            byte a = 5;
            short b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Can";
            char f = 'k';
            object g = e + f + d;

            Console.WriteLine("g: " + g);

            // Explicit Conversion - Bilinçli Dönüşüm
            // Kendiliğinden gerçekleşemeyen dönüşümleri gerçekleştiririz.

            Console.WriteLine("*** Explicit Conversion ***");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y = " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t = " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v = " + v);
            // w doğal sayı olmadığı için byte'a dönüştürüldüğü zaman noktadan sonrası kaynolacaktır
            // Tip dönüşümleri veri kaybına sebep olabilmektedir!

            // *** ToString Metotu ***

            Console.WriteLine("*** ToString Metotu ***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy = " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            // System.Convert

            Console.WriteLine("*** System.Convert Sınıfı ***");
            string s1 = "10", s2 = "20"; // tek satırda aynı tipte birden fazla değişken tanımlama
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1); // Değeri "10", tipi string olan s1 değişkenini int32 tipinde sayi1 değişkenine atadık
            sayi2 = Convert.ToInt32(s2); // Değeri "20", tipi string olan s2 değişkenini int32 tipinde sayi2 değişkenine atadık
            toplam = sayi1 + sayi2;      // Tip dönüşümlerinden sonra s1 ve s2 değerlerinin atanmış olduğu sayi1 ve sayi2 değişkenlerinin
                                         // toplamlarını, int tipindeki toplam değişkenine atadık

            Console.WriteLine("toplam = " + toplam);

            // Parse

            Console.WriteLine("*** Parse Methodu ***");
            ParseMethod();

        }

        public static void ParseMethod(){

            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);               // Değeri 10, tipi string olan metin1 değişkenini int32 tipinde sayi1 değişkenine atadık
            Console.WriteLine("rakam1 = " + rakam1);

            double1 = Double.Parse(metin2);             // değeri 10.25, tipi string olan metin2 değişkenini double tipinde double1 değişkenine atadık.
            Console.WriteLine("double1 = " + double1);

        }
    }
}
