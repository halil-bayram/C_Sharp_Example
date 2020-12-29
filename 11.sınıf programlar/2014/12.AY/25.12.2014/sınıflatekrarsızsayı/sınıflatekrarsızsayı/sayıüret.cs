using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sınıflatekrarsızsayı
{
    class sayıüret
    {
     public   List<int> sayıuret(int adet,int küçüksayı,int büyüksayı)
        {
            List<int> sayılar = new List<int>();
            Random rnd = new Random();
            int sayı, sayac = 0;
            do
            {
                sayı = rnd.Next(küçüksayı, büyüksayı);
                if (sayılar.IndexOf(sayı)==-1)
                {
                    sayılar.Add(sayı);
                    sayac++;
                }
            } while (sayac!=adet);
            sayılar.Sort();
            return sayılar;
        }
     public   List<int> sayıuret(int adet, int küçüksayı, int büyüksayı,bool tekmi)
        {
            List<int> sayılar = new List<int>();
            Random rnd = new Random();
            int sayı, sayac = 0;
            if (tekmi)
            {
                do
            {
                sayı = rnd.Next(küçüksayı, büyüksayı);
                if (sayılar.IndexOf(sayı) == -1&&sayı%2==1)
                {
                    sayılar.Add(sayı);
                    sayac++;
                }
            } while (sayac != adet);
            }
            else
            {
                do
                {
                    sayı = rnd.Next(küçüksayı, büyüksayı);
                    if (sayılar.IndexOf(sayı) == -1 && sayı % 2 == 0)
                    {
                        sayılar.Add(sayı);
                        sayac++;
                    }
                } while (sayac != adet);
            }
            sayılar.Sort();
            return sayılar;
        }

      public  List<int> sayıuret(int adet, int küçüksayı, int büyüksayı,int katları)
        {
            List<int> sayılar = new List<int>();
            Random rnd = new Random();
            int sayı, sayac = 0;
            do
            {
                sayı = rnd.Next(küçüksayı, büyüksayı);
                if (sayılar.IndexOf(sayı) == -1&&sayı%katları==0)
                {
                    sayılar.Add(sayı);
                    sayac++;
                }
            } while (sayac != adet);
            sayılar.Sort();
            return sayılar;
        }
    }
}
