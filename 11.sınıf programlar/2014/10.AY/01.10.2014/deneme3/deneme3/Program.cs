using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sayılar = new int[4, 5];
            Random rnd = new Random();

            int toplam = 0,sayac=0;
            for (int i = 0; i < 4; i++)
            {
            
                for (int j = 0; j < 5; j++)
                {
                    sayılar[i, j] = rnd.Next(1, 10);
                    Console.Write(sayılar[i, j] + "\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                   
                    toplam = sayılar[j, i] + toplam;
                }

                System.Threading.Thread.Sleep(1000);
                Console.Write(toplam+"\t");
                toplam = 0;
            }

            Console.ReadKey();
        }
    }
}
