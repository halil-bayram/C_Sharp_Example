using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otobüsKoltukSayısı
{
    class Program
    {//bir otobüste kullanıcıdan koltuk numarası alınarak o koltuğun boş yada dolu old bulan program.
        static void Main(string[] args)
        {
            int[] koltuklar = new int[40];
            int[] doluKoltuklar = new int[20];
            Random rnd = new Random();
            int sayi, sayac = 0,üstbos=0,altbos=0;
            do
            {
                sayi = rnd.Next(1, 41);
                if (Array.IndexOf(doluKoltuklar,sayi)==-1)
                {
                    doluKoltuklar[sayac] = sayi;
                    koltuklar[sayi - 1] = 1;
                    sayac++;
                }
            } while (sayac!=20);
            sayac = 0;
            foreach (var item in koltuklar)
            {
                if (item==0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.Write(sayac + 1 + "\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                sayac++;
                if (sayac%4==0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("istediğiniz koltuk No");
            int istenenKoltukİndeks=Convert.ToInt16(Console.ReadLine())-1;
            if (koltuklar[istenenKoltukİndeks]==0)
            {
                Console.WriteLine("rezervasyon gerçeklerştirildi");
                koltuklar[istenenKoltukİndeks] = 1;
            }
            else
            {
                Console.WriteLine("istediğiniz koltuk doludur");
                for (int i = istenenKoltukİndeks; i < 40; i++)
                {
                    if (koltuklar[i]==0)
                    {
                        üstbos = i;
                        break;
                    }
                }
                for (int i = istenenKoltukİndeks; i >=0; i--)
                {
                    if (koltuklar[i]==0)
                    {
                        altbos = i;
                        break;
                    }
                }
                int farkust = üstbos - istenenKoltukİndeks;
                int farkalt = istenenKoltukİndeks - altbos;
                if (farkust<farkalt)
                {
                    Console.WriteLine("en yakın boş koltuk:"+(üstbos+1)); 
                }
                else if (farkalt==farkust)
                {
                    Console.WriteLine("en yakın boş koltuk:"+ (üstbos+1)+ " veya "+ + (altbos+1));
                }
                else if (farkalt<farkust)
                {
                    Console.WriteLine("en yakın boş koltuk:"+ (altbos+1));
                }
            }
            Console.ReadKey();
        }
    }
}
