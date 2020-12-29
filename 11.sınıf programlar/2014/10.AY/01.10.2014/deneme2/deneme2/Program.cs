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
            int[,] sayılar=new int[4,5];
            Random rnd = new Random();

            int toplam = 0;
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    sayılar[i, j] = rnd.Next(10, 50);
                    Console.Write(sayılar[i, j] + "\t");
                    toplam = sayılar[i,j] + toplam;
                }

                Console.WriteLine("\t"+(i+1)+". satırın toplamı="+toplam);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                toplam = 0;
            }

            Console.ReadKey();
        }
    }
}
