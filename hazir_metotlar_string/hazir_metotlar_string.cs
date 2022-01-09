using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hazır String Metotları
            string degisken = "Dersimiz CSharp. Hoşgeldiniz!";
            string degisken2 = "CSharp";
            string degisken3 = "dersimiz CSharp. Hoşgeldiniz!";

            // Length;
            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            // Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0, 1, -1 | birinci değişken, ikinci değişkene eşitse 0
                                                              // birinci değişken ikinciden daha küçük karakter sayısına sahipse 1 döndürür
                                                              // ikinci değişken birinciden daha küçük karakter sayısına sahipse -1 döndürür.

            Console.WriteLine(String.Compare(degisken, degisken3, true));  // true dersek büyük küçük harf duyarsız
            Console.WriteLine(String.Compare(degisken, degisken3, false));

            // Contains - EndsWith - StartsWith
            Console.WriteLine(degisken.Contains(degisken2)); // degisken içinde degisken2 var mı kontrolü, varsa true yoksa false
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            // IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            // stringde bu eşleşmeyi bulduğunda, eşleşmenin başladığı yerdeki elemanın indexini döndürür
            Console.WriteLine(degisken.IndexOf("Can"));
            // stringde bir eşleşme bulamadığı zaman -1 döndürür
            Console.WriteLine(degisken.LastIndexOf("i"));
            // birden fazla i harfimiz var ancak en sonraki eşleşmenin indexini döndürdü

            // Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! ")); // 0. indexten başlayarak stringe belirtilen ifadeyi eklettik

            // PadLeft, PadRight;
            Console.WriteLine(degisken + degisken2.PadLeft(30));       // değisken2'nin boşluklar dahil karakter sayısı 30'dan küçükse soluna 30'a tamamlayacak kadar boşluk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));  // boşluk yerine * eklettik
            Console.WriteLine(degisken.PadRight(50) + degisken2);      // degisken'in sağına, elli karaktere tamamlayacak kadar boşluk eklettik
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2); // degisken'in sağına, elli karaktere tamamlayacak kadar - eklettik

            // Remove
            Console.WriteLine(degisken.Remove(10));  // 10. indexten itibaren sonuna kadar sildik
            Console.WriteLine(degisken.Remove(5,3)); // 5. indexten itibaren üç karakter sildirdik
            Console.WriteLine(degisken.Remove(0,1)); // 0. indexten itibaren bir karakter sildik (ilk harfi)

            // Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#")); // stringdeki CSharp yazısını C#'a çevirdik
            Console.WriteLine(degisken.Replace(" ", "*"));       // stringdeki boşlukları yıldız yaptık

            // Split
            Console.WriteLine(degisken.Split(' ')[1]); // stringi boşluklara göre ayırıp her birini bir diziye atadık, birinci indexteki elemanı aldık

            // Substring
            Console.WriteLine(degisken.Substring(4));    // 4. indexten başlayarak sonuna kadar getirdik
            Console.WriteLine(degisken.Substring(4, 6)); // 4. indexten başlayarak 6 karakter getirdik
        }
    }
}
