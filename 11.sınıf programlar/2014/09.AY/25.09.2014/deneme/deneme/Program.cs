using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] girilen = new int[6];
            int[] çekilen = new int[6];
            int sayac = 0, sayi, adet = 0;
            Random rnd = new Random();

            do
            {
                Console.Write((sayac + 1) + ".  tahmininizi giriniz :");
                sayi = Convert.ToInt16(Console.ReadLine());
                if (Array.IndexOf(girilen, sayi) == -1 && sayi >= 1 && sayi <= 49)
                {
                    girilen[sayac] = sayi;
                    sayac++;
                }
                else
                {
                    Console.WriteLine("yanlış deger girdiniz");
                }
            } while (sayac < 6);

            Console.WriteLine();
            Console.WriteLine("girilen sayılar");
            Console.WriteLine();

            foreach (var x in girilen)
            {
                Console.Write(x + "    ");
            }

            Console.WriteLine();
            Console.WriteLine("çekiliş için ENTER tuşuna basınız");
            Console.WriteLine();
            Console.ReadLine();
            sayac = 0;

            do
            {
                sayi = rnd.Next(1, 50);
                if (Array.IndexOf(çekilen, sayi) == -1)
                {
                    çekilen[sayac] = sayi;
                    sayac++;
                }
            } while (sayac < 6);

            Console.WriteLine();

            foreach (var x in çekilen)
            {
                Console.Write(x + "    ");
                System.Threading.Thread.Sleep(100);
            }

            for (int i = 0; i < 6; i++)
            {
                if (Array.IndexOf(çekilen, girilen[i]) != -1)
                {
                    adet++;
                }
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(adet + " tane tutturdunuz.");
            Console.ReadKey();




















        }
    }
}
