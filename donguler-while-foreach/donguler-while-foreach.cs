using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // Birden başlayarak, konsoldan alınan sayıya kadar olan sayıların ortalamalarını hesaplayıp konsola yazdıran program
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1, toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama = " + (toplam/sayi));

            // a'dan z'ye kadar tüm harfleri konsola yazdıran program

            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character + " ");
                character++;
            }

            Console.WriteLine("*** Foreach ***");
            string[] arabalar = {"Ford", "Mercedes", "Toyota", "Nissan", "BMW"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
