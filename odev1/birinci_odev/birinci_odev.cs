using System;

namespace birinci_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba, lütfen dizinin eleman sayısını giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > 0)
            {
                int[] dizi = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                    dizi[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int x = 0; x < n; x++)
                {
                    if(dizi[x] % 2 == 0)
                    {
                        Console.WriteLine(dizi[x]);
                    }
                }
            }

        }
    }
}
