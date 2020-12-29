using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] oyuncular = { "halil", "hüseyin", "veli", "yunus", "fatih", "burak" };
            int[] numaralar = new int[oyuncular.Length];
            int sayi, sayac = 0;
            Random rnd = new Random();
            do
            {
                sayi = rnd.Next(1, 7);
                if (Array.IndexOf(numaralar, sayi) == -1)
                {
                    numaralar[sayac] = sayi;
                    sayac++;
                }

            } while (sayac != 6);

            Console.WriteLine("  Eşleşmeler");
            Console.WriteLine();
            for (int i = 0; i < 6; i += 2)
            {

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine((oyuncular[numaralar[i] - 1] + " -- " + oyuncular[numaralar[i + 1] - 1]));
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadKey();
        }
    }
}
