using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme5
{
    class Program
    {
        static void Main(string[] args)
        {
            
             string isim;
            Console.WriteLine("bir isim giriniz:");
            isim=Console.ReadLine();
string[] metin = new string[isim.Length];
            for (int i = 0; i < isim.Length; i++)
			{
			 metin[i]=isim[i].ToString();
            
			}

            Array.Sort(metin);
            foreach (var item in metin)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
