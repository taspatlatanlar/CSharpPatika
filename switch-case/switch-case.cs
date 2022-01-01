using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            Console.WriteLine(month + ". Ay");

            // Expression, kontrol etmek istediğimiz koşul
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;

                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;

                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                
                default: // Hiçbir koşul sağlanmadığı zaman çalışacak olan blok
                    Console.WriteLine("Yanlış veri girişi yaptınız.");
                break;
            }
                    // Birden fazla koşul için;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz.");
                break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlk bahar mevsimindesiniz.");
                break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz.");
                break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Son bahar mevsimindesiniz.");
                break;
                
                default:
                break;
            }
        }
    }
}
