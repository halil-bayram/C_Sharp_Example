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
            string isim;
            int index1, index2;
            Random rnd = new Random();
            //ismi al
            Console.WriteLine("Anne  kızlık soyadınızı giriniz");
            isim = Console.ReadLine();
            //soyadın uzunlugu kadar 2 tane rastgele sayı üret
            //sayıların birbirinden farklı olmasını sagla 
                index1 = rnd.Next(1,isim.Length);
            do
            {
                index2 = rnd.Next(1, isim.Length);
                
            } while (index1==index2);
            Console.WriteLine(index1+" "+index2);
            //soyadının üretilen sAyılardaki harfleri yazdır digerlerini "*" koy
        for (int i = 1; i <= isim.Length; i++)
            {
if (i==index1||i==index2)
                {
                    Console.Write(isim[i-1]);
                }
                else
                {
                    Console.Write("*");
                }
    }
            Console.ReadKey();
        }
    }
}
