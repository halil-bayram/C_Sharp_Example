using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ikiboyutludiziler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sayılar = new int[9, 5];
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sayılar[i, j] = rnd.Next(10,50);
                    Console.Write(sayılar[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
