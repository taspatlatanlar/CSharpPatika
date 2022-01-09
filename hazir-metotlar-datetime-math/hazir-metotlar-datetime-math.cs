using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("**** DateTime ****");
            // DateTime

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());     // 9 Ocak 2022 Pazar
            Console.WriteLine(DateTime.Now.ToShortDateString());    // 9.01.2022
            Console.WriteLine(DateTime.Now.ToLongTimeString());     // 12:53:40
            Console.WriteLine(DateTime.Now.ToShortTimeString());    // 12:53

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(45));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));   // günün değerini getirir, bugün 9.1.22 olduğu için 09 yazacak
            Console.WriteLine(DateTime.Now.ToString("ddd"));  // günün yazılı kısaltma karşılığı
            Console.WriteLine(DateTime.Now.ToString("dddd")); // günün yazılı tam karşılığı

            Console.WriteLine(DateTime.Now.ToString("MM"));   // ayın değerini getirir, bugün 9.1.22 olduğu için 01 yazacak
            Console.WriteLine(DateTime.Now.ToString("MMM"));  // ayın yazılı kısaltma karşılığı
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // ayın yazılı tam karşılığı
            
            Console.WriteLine(DateTime.Now.ToString("yy"));   // 22
            Console.WriteLine(DateTime.Now.ToString("yyy"));  // 2022

            Console.WriteLine("**** Math Kütüphanesi ****");
            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));       // Mutlak değer
            Console.WriteLine(Math.Sin(10));        // Sin(x)
            Console.WriteLine(Math.Cos(10));        // Cos(x)
            Console.WriteLine(Math.Tan(10));        // Tan(x)

            Console.WriteLine(Math.Ceiling(10.3));  // 11
            Console.WriteLine(Math.Round(10.3));    // 10
            Console.WriteLine(Math.Round(10.7));    // 11
            Console.WriteLine(Math.Floor(10.7));    // 10

            Console.WriteLine(Math.Max(2, 6));      // 6
            Console.WriteLine(Math.Min(2, 6));      // 2

            Console.WriteLine(Math.Pow(3, 4));      // 3^4
            Console.WriteLine(Math.Sqrt(9));        // 3
            Console.WriteLine(Math.Log(9));         // 9'un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3));         // e^3
            Console.WriteLine(Math.Log10(100));     // 2 (100'ün log10 tabanındaki karşılığı)

        }
    }
}
