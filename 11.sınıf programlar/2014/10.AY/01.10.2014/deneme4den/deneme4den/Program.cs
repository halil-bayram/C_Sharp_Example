using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme4den
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bilgiler = new string[5, 4];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i+1)+".  ögrencinin ismini giriniz: ");
                bilgiler[i, 0] = Console.ReadLine();
                bilgiler[i, 1]=rnd.Next(30,101).ToString();
                bilgiler[i, 2]=rnd.Next(30,101).ToString();
                bilgiler[i, 3] = ((int.Parse(bilgiler[i, 1]) + int.Parse(bilgiler[i, 2])) / 2).ToString();
            }
            
            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 4; j++)
                {

                    Console.Write(bilgiler[i,j]+"\t");
                  
                }
                Console.WriteLine();
            }
            int tercih;
            Console.WriteLine("1--------75 üzeri\n2--------50-75 arası\n3---------50`nin altı");
            tercih = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tercih==1&&int.Parse(bilgiler[i,3])>75)
                    {
                        Console.Write(bilgiler[i,j]);
                    }
                    else if (tercih == 2 && int.Parse(bilgiler[i, 3]) > 50 && int.Parse(bilgiler[i, 3]) < 75)
                    {
                        Console.Write(bilgiler[i,j]);
                    }
                    else if (tercih==3&&int.Parse(bilgiler[i,3])<50)
                    {
                        Console.Write(bilgiler[i,j]);
                    }

                    Console.WriteLine();
                    
                }
       
            }
            Console.ReadKey();
        }
    }
}
