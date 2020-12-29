using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar=new int[10];
            Random rnd = new Random();
            int sayac=0,sıra=0,sayi;
            do
            {
                sayi = rnd.Next(1, 100);
                if (sıra==0&&sayi%2==0)
                {
                    sayılar[sayac] = sayi;
                    Console.WriteLine(sayılar[sayac]);
                    sayac++;
                  if (sayac%2==0)
                {
                    sıra = 1;
                }
                }
                if (sıra == 1 && sayi % 2 == 1)
                {
                    sayılar[sayac] = sayi;
                    Console.WriteLine(sayılar[sayac]);
                    sayac++;
                    if (sayac%2==0)
                    {
                        sıra = 0;
                    }
                }
            } while (sayac!=10);
            Console.ReadKey();
        }
    }
}
