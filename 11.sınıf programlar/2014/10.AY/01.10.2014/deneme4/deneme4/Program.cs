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
            string[,] notlar = new string[5, 4];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("isim girinz:");
                notlar[i, 0] = Console.ReadLine();
                for (int j = 1; j < 4; j++)
                {
                    if (j == 2 || j == 1)
                    {

                        notlar[i, j] = rnd.Next(30, 101).ToString();
                    }

                    if (j == 3)
                    {
                        notlar[i, j] = ((Convert.ToInt32(notlar[i, j - 1]) + Convert.ToInt32(notlar[i, j - 2])) / 2).ToString();
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(notlar[i, j] + "\t ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
