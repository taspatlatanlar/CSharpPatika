using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki tek ve çift sayıları kendi içlerinde topla, ekrana yazdır

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if(i % 2 == 1)
                    tekToplam += i;     // tekToplam = tekToplam + i;

                else
                    ciftToplam += i;    // ciftToplam = ciftToplam + i;
            }   

            Console.WriteLine("Tek sayıların toplamı = " + tekToplam);
            Console.WriteLine("Çift sayıların toplamı = " + ciftToplam);

            // *** Break & Continue ***
            /*
                Break: Eğer bir döngü içerisinde bir case'e bağlı olarak looktan çıkmak istiyorsak break ifadesini kullanırız.
                Continue: Eğer bir şarta bağlı olarak mevcut döngünün bir alt cycleına atlamak istiyorsak continue ifadesini kullanırız.
            */
            
            Console.WriteLine("\nBreak örneği, burada i = 4 olduğunda döngüyü sonlandıracak.");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break; // dörde gelip durdu!
                Console.WriteLine(i);
            }
            Console.WriteLine("\nContinue örneği, burada i = 4 olduğunda o adımı atlayıp i = 5'ten devam edecek.");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue; // yalnızca dördü atladı, beşten devam etti!
                Console.WriteLine(i);
            }
            // Döngü içerisinde döngü kullanmamız gereken durumlar olacaktır, break yalnızca içinde bulunduğu loopu sonlandırır.
            // Örneğin en içteki loopta olan bir duruma göre break ifadesi kullanırsak yalnızca o loop sonlanır, üst iki loop çalışmaya devam eder!

            

        }
    }
}
