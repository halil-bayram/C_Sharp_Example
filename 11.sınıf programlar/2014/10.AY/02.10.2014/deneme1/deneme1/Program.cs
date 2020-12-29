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

            int kolon, sayı, sayac = 0;                                                                                                       
            Console.Write("kaç çekiliş yapmak istersiniz:");
            kolon = Convert.ToInt32(Console.ReadLine());
            bool varmı = false;
            int[,] sayılar = new int[kolon, 6];
            int[] girilen = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < kolon; i++)
            {
                do
                {
                    sayı = rnd.Next(1, 50);
                    for (int j = 0; j < 6; j++)
                    {
                        if (sayılar[i, j] == sayı)
                        {
                            varmı = true;
                            break;
                        }
                    }
                    if (varmı == false)
                    {
                        sayılar[i, sayac] = sayı;
                        Console.Write(sayılar[i, sayac] + "\t");
                        sayac++;
                    }
                    varmı = false;
                } while (sayac < 6);
                sayac = 0;
                Console.WriteLine();
            }
            Console.WriteLine();
            sayac = 0;
            
            do
            {
                sayı = rnd.Next(0, 50);
                if (Array.IndexOf(girilen, sayı) == -1)
                {
                    girilen[sayac] = sayı;
                    Console.Write(girilen[sayac] + "\t");
                    sayac++;
                }
            } while (sayac < 6);
            sayac = 0;
            for (int i = 0; i < kolon; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (sayılar[i, j] == girilen[k])
                        {
                            sayac++;
                        }
                    }
                }
                Console.WriteLine();
                Console.Write((i+1)+".kolondan== "+"\t"+sayac + "sayı  tutdurdunuz");
                sayac = 0;
            }
            Console.ReadKey();
        }
    }
}
