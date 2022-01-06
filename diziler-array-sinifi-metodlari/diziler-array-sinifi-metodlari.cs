using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort (Sıralama)
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};

            Console.WriteLine("*** Sırasız Dizi ***");

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            
            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayiDizisi); // Array.Sort(), içerisine verdiğimiz diziyi sıralayıp bize geri veren fonksiyondur.
            
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear - Dizi içerisinde, verdiğimiz elemandan itibaren belirtilen sayı kadar bütün elemanları sıfırlıyor.

            Console.WriteLine("*** Array Clear ***");

            Array.Clear(sayiDizisi,2,2); // Array.Clear(dizi, index, kaç değerin sıfırlanacağı);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse - Tersine çevirme (Verdiğimiz diziyi x = 0'dan itibaren aynalıyor gibi düşünebiliriz)
            Console.WriteLine("*** Array Reverse ***");

            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // IndexOf - verdiğimiz dizinin, eğer içerisinde varsa, belirli elemanının indexini döner.
            Console.WriteLine("*** Array IndexOf ***");

            Console.WriteLine(Array.IndexOf(sayiDizisi, 17));

            // Resize - Yeniden boyutlandırma - Normalde boyutu x olan dizimizi y boyutuna çıkar
            Console.WriteLine("*** Array Rezise ***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 90;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
