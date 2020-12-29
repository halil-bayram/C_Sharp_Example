using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            int[] kullanıcısayısı=new int[6];
            int [] otomatiksayılar=new int[6];
            int sayi,girilensayılar,sayac=0,ortaksayısay=0;
            for (int i = 1; i < 7; i++)
			{
                Console.Write(i + "sayıyı giriniz=");
                kullanıcısayısı[sayac] = Convert.ToInt16(Console.ReadLine());
                sayac++;
			}
            sayac = 0;
            do
	{

         sayi=rnd.Next(1,50);
             
             if (Array.IndexOf(otomatiksayılar,sayi)==-1)
             {
                 otomatiksayılar[sayac] = sayi;
Console.Write(otomatiksayılar[sayac]+"  ");
                 sayac++;
             }
	} while (sayac!=6);

            sayac = 0;
            for (int i = 0; i < kullanıcısayısı.Length; i++)
            {
                for (int j = 0; j < otomatiksayılar.Length; j++)
                {
                  if ( kullanıcısayısı[i] == otomatiksayılar[j])
                    {
                        ortaksayısay++;
                    }
                  
                }
            }
            if (ortaksayısay<=6)
            {
                Console.Write("tutdurdugunuz sayılar=="+ortaksayısay);
                
            }

            else if (ortaksayısay==0)
            {
                Console.Write("hiç tutduramadınız");
            }
            else if (ortaksayısay == 6)
            {
                Console.Write("tutdurdugunuz sayılar=="+ortaksayısay );
                Console.Write("tebrikler kazandınız!!");
            }
//            do
//            {
//if (kullanıcısayısı[sayac]==otomatiksayılar[sayac])
//            {
//                ortaksayısay++;
//                Console.WriteLine("ortak sayılar "+ortaksayısay); 
               
//            }
//    sayac++;   
//            } while (sayac!=6);
           

//            if (ortaksayısay==0)
//    {
//         Console.WriteLine("hiç tutturamadınız");
//    }               
            
            Console.ReadLine();
        }
    }
}
