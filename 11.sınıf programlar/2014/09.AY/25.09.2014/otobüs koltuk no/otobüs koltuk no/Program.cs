using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otobüs_koltuk_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] koltuklar = new int[40];
            int[] dolukoltuklar = new int[20];
            Random rnd = new Random();
            int sayi, sayac = 0,koltuk1=0,koltuk2=0;
            do
            {
                sayi = rnd.Next(1, 41);
                if (Array.IndexOf(dolukoltuklar,sayi)==-1)
                {
                    dolukoltuklar[sayac] = sayi;
                    koltuklar[sayi - 1] = 1;
                    sayac++;
                }
            } while (sayac<20);
            Array.Sort(dolukoltuklar);
            foreach ( var item in dolukoltuklar)
            {
              Console.Write(item+" ");  
            }
            Console.WriteLine();
            foreach (var item in koltuklar)
            {
                Console.Write(item+" ");
            }
            Console.Write("İstenen koltuk numarasına giriniz=");
            int istenenkoltuk = Convert.ToInt16(Console.ReadLine());
            if (koltuklar[istenenkoltuk-1]==0)
            {
                Console.Write("Rezervasyonunuz yapıldı");
            }
            else
            {
                Console.WriteLine("İstediğiniz koltuk doludur");
            }
            if (koltuklar[istenenkoltuk-1]==1)
            {
                for (int i =istenenkoltuk; i >0 ; i--)
                {
                    if (koltuklar[i-1]==0)
                    {
                        koltuk1 = i;
                        break;
                    }
                }

                for (int i = istenenkoltuk; i < 40; i++)
                {
                    if (koltuklar[i - 1] == 0)
                    {
                        koltuk2 = i;
                        break;
                    }
                }
            }
            int fark, fark1;
            fark = istenenkoltuk - koltuk1;
            fark1 = koltuk2 - istenenkoltuk;
            if (fark<fark1)
            {
                Console.WriteLine("En yakın koltuk"+koltuk1);
            }
            else if (fark == fark1)
            {
                Console.WriteLine("en yakın koltuklar" + koltuk1 + " veya " + koltuk2);
            }
            else
            {
                Console.WriteLine( "en yakın koltuk"+koltuk2);
            }
           
            
            Console.ReadKey();
        }
    }
}
