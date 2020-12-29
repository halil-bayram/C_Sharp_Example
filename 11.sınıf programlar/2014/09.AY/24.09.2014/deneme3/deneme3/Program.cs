using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] yüzler = {"YÜZ","İKİ YÜZ","ÜÇ YÜZ","DÖRT YÜZ","BEŞ YÜZ","ALTI YÜZ","YEDİ YÜZ","SEKİZ YÜZ","DOKUZ YÜZ" };
            string[] onlaar = {"ON","YİRMİ","OTUZ","KITK","ELLİ","ALTMIŞ","YETMİŞ","SEKSEN","DOKSAN" };
            string[] birler = {"BİR","İKİ","ÜÇ","DÖRT","BEŞ","ALTI","YEDİ","SEKİZ","DOKUZ" };
            Console.WriteLine("3 BASAMAKLI BİR SAYI GİRİNİZ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            int yuzlerbas, onlarbas, birlerbas;

            yuzlerbas = sayi / 100;
            birlerbas = sayi % 10;
            onlarbas = (sayi % 100) / 10;
            if (birlerbas==0&&onlarbas==0)
            {
                Console.Write(yüzler[yuzlerbas - 1]+"  ");
            }
            else if (birlerbas==0)
            {
                Console.Write(yüzler[yuzlerbas - 1]+"   ");
                Console.Write(onlaar[onlarbas - 1] + "   ");
            }
            else if(onlarbas==0)
            {
                
                Console.Write(yüzler[yuzlerbas-1]+"   ");
                 Console.Write(birler[birlerbas - 1]);
            }
            else
            {
            Console.Write(yüzler[yuzlerbas - 1]+"  ");
           Console.Write(onlaar[onlarbas - 1]+"   ");
            Console.Write(birler[birlerbas - 1]);
            }
           
           
            Console.ReadKey();

        }
    }
}
