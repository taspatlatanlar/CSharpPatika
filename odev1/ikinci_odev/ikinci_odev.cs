using System;

namespace ikinci_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba, lütfen pozitif bir sayı giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if(m > 0)
            {
                Console.Write("Merhaba, lütfen dizinin boyunu giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if(n > 0)
                {
                    int[] dizi = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                        dizi[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine(m + " ile tam bölünebilen veya " + m + " sayısına eşit olan dizi elamanları:");

                    for (int x = 0; x < n; x++)
                    {
                        if((dizi[x] % m == 0) || (dizi[x] == m))
                        {
                            Console.WriteLine("> " + dizi[x]);
                        }
                    }
                }
            }
        }
    }
}
