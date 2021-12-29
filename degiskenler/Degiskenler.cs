using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // String Ifadeler

            string str1 = string.Empty; // boş değer vermek için
            str1 = "Can Taspatlatanlar"; // boş stringe atama yaptık

            string ad = "Can";
            string soyad = "Taspatlatanlar";
            string tamIsim = ad + " " + soyad;
            Console.WriteLine(tamIsim);

            // Integer Tanımlama Şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // Boolean

            bool bool1 = 10 < 2; // bool1 ifadesine false atayacak
            bool bool2 = 10 > 2; // bool2 ifadesine true atayacak
            Console.WriteLine(bool1);
            Console.WriteLine(bool2);

            // Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // Çıktısı 40

            // DateTime

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy"); // DateTime.Now ama yalnızca tarih bilgisi (noktalı)
            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); // DateTime.Now, yalnızca tarih bilgisi (slashlı)
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm"); // DateTime.Now ama yalnızca saat ve dakika bilgisi geliyor
            Console.WriteLine(datetime3);
            
        }
    }
}
