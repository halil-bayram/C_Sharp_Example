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
            string[,] ismler=new string[2,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("isim giriniz:");
                        ismler[j, i] = Console.ReadLine().ToUpper();
                    }
                    else if (j == 1)
                    {
                        Console.Write("cinsiyeti giriniz:");
                        ismler[j, i] = Console.ReadLine().ToUpper();
                    }

                }
            }
            
            string tercih; 
            do
            {
                Console.Write("hangilerini görmek istersiniz E/K/H=");
                tercih = Console.ReadLine().ToUpper();
            } while (tercih!="E"&&tercih!="K"&&tercih!="H");
            if (tercih == "H")
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(ismler[0, i] + "\t" + "\t");
                }
                Console.WriteLine();

            }

            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (ismler[1, i] == tercih)
                    {
                        Console.Write(ismler[0, i] + "\t"+"\t");
                    }
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
