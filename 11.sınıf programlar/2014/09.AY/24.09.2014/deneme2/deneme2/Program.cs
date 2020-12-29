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
            bool bölenivarmı = false;
            for (int j = 1; j < 100; j++)
            {
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        bölenivarmı = true;
                        break;
                    }
                }
                if (bölenivarmı == false)
                {
                    Console.WriteLine(j);
                }
                bölenivarmı = false;
            }
            
            Console.ReadKey();
        }
    }
}
