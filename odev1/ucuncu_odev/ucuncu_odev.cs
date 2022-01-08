using System;

namespace ucuncu_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba, lütfen pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                string[] dizi = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Lütfen {0}. elemanı giriniz: ", i+1);
                    dizi[i] = Console.ReadLine();
                }

                for (int x = n-1; x >= 0; x--)
                {
                    Console.WriteLine(dizi[x]);
                }
            }
        }
    }
}
