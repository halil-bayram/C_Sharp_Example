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
            int kullanıcı;
            bool bölenivarmı = false;
            Console.WriteLine("bir sayı giriniz");
            kullanıcı = Convert.ToInt16(Console.ReadLine());
            for (int i = 2; i < kullanıcı; i++)
            {
                if (kullanıcı%i==0)
                {
                    bölenivarmı = true;
                    break;
                }
            }
            if (bölenivarmı==true)
            {
                Console.WriteLine("asal degildir");
            }
            else
            {
                Console.WriteLine("asaldır");
            }
            Console.ReadKey();
        }
    }
}
