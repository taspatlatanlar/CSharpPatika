using System;

namespace dorduncu_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            string[] bolunmusCumle = cumle.Split(" ");
            char[] harfler = cumle.ToCharArray();
            int kelimeSayisi = 0;
            int harfSayisi = 0;

            foreach (var kelime in bolunmusCumle)
            {
                kelimeSayisi++;
            }

            foreach (var harf in harfler)
            {
                if(harf == ' ' || harf == ',' || harf == '.')
                {
                    continue;
                }
                harfSayisi++;
            }
            Console.WriteLine("Girdiğiniz cümledeki kelime sayısı: " + kelimeSayisi);
            Console.WriteLine("Girdiğiniz cümledeki harf sayısı: " + harfSayisi);
        }
    }
}
