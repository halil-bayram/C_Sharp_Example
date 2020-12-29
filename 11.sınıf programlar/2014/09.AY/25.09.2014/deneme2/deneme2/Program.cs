using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] koltuklar = new int[40];
            int[] dolukoltuklar = new int[20];
            Random rnd = new Random();
            int sayi, sayac = 0, ustbos = 0, altbos = 0;
            do
            {
                sayi = rnd.Next(1, 41);
                if (Array.IndexOf(dolukoltuklar, sayi) == -1)
                {
                    dolukoltuklar[sayac] = sayi;
                    koltuklar[sayi - 1] = 1;
                    sayac++;
                }
            } while (sayac < 20);
            Array.Sort(dolukoltuklar);
            Console.WriteLine();
            foreach (var item in dolukoltuklar)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in koltuklar)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("istediginiz koltuk numarasını giriniz:");
            int istenenkoltuk = Convert.ToInt16(Console.ReadLine())-1;
            if (koltuklar[istenenkoltuk] == 0)
            {
                Console.WriteLine("rezervazyon işlemi tamamlanmıştır");
                koltuklar[istenenkoltuk - 1] = 1;
            }
            else
            {

                for (int i = istenenkoltuk; i < 40; i++)
                {
                    if (koltuklar[i] == 0)
                    {
                        ustbos = i;
                        break;
                    }
                }
                for (int i = istenenkoltuk; i >= 0; i--)
                {
                    if (koltuklar[i] == 0)
                    {
                        altbos = i;
                        break;
                    }
                }
                int fark1, fark2;
                fark1 = ustbos - istenenkoltuk;
                fark2 = istenenkoltuk - altbos;
                if (fark1 > fark2)
                {
                    Console.WriteLine("en yakın boş koltuklar  " + (altbos + 1));
                }
                else if (fark1 == fark2)
                {
                    Console.WriteLine((ustbos + 1) + "  veya  " + (altbos + 1) + " en yakın boş koltuklar");
                }
                else
                {
                    Console.WriteLine("en yakın boş koltuk   " + (ustbos + 1));
                }
            }
            Console.ReadKey();
        }
    }
}
