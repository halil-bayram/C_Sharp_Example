using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sınıflasifreoluşturma
{
    class sıfreolustur
    {
        Random rnd = new Random();
        List<int> rakamlar = new List<int>();
        List<string> karışıüretilenharf = new List<string>();
        List<string> harf = new List<string>();
        List<string> alfabe = new List<string>() { "q", "w", "e", "r", "t", "y", "u", "ı", "o", "p", "ğ", "ü", "a", "s", "d", "f", "g", "h", "j", "k", "l", "ş", "i", "z", "x", "c", "v", "b", "n", "m", "ö", "ç" };
        List<string> rastgelekarakter = new List<string>() { "!", "£", "#", "$", "½", "&", "?" };
     public List< string> olusturma(int şifreuzunlugu, string netür, bool özelkarakter)
        {
            List<string> geridönen = new List<string>();
            if (netür == "Rakam")
            {
                List<int> sayılar = new List<int>();
                int sayı;
                do
                {
                    sayı = rnd.Next(1, 10);
                    sayılar.Add(sayı);
                } while (sayılar.Count != şifreuzunlugu);
                for (int i = 0; i < sayılar.Count; i++)
                {
                    geridönen.Add(sayılar[i].ToString());
                }
            }
            if (netür == "Harf")
            {
                int sayı;
                do
                {
                    sayı = rnd.Next(1, 32);
                    rakamlar.Add(sayı);
                    harf.Add(alfabe[sayı]);

                } while (şifreuzunlugu != rakamlar.Count);
                for (int i = 0; i < rakamlar.Count; i++)
                {
                    geridönen.Add(harf[i]);
                }
                
            }
            if (netür == "Karışık")
            {
                int öncehangisi, sayı, kaçtanerakam, kaçtaneharf;
                List<int> sayılar = new List<int>();
                öncehangisi = rnd.Next(1, 3);
                if (özelkarakter)
                {
                    if (öncehangisi == 1)
                    {
                        kaçtanerakam = rnd.Next(1, 10);
                        kaçtaneharf = şifreuzunlugu - kaçtanerakam;
                        do
                        {
                            sayı = rnd.Next(1, 10);
                            sayılar.Add(sayı);
                        } while (sayılar.Count != kaçtanerakam - 1);
                        do
                        {
                            sayı = rnd.Next(1, 33);
                            rakamlar.Add(sayı);
                            karışıüretilenharf.Add(alfabe[sayı]);
                        } while (kaçtaneharf - 1 != rakamlar.Count);
                        for (int i = 0; i < şifreuzunlugu; i++)
                        {
                            geridönen.Add(sayılar[i].ToString());
                            geridönen.Add(karışıüretilenharf[i].ToString());
                            if (kaçtaneharf + kaçtanerakam == şifreuzunlugu - 1)
                            {
                                geridönen.Add(rastgelekarakter[rnd.Next(0, 8)]);
                            }
                        }
                    }
                    if (öncehangisi == 2)
                    {
                        kaçtanerakam = rnd.Next(1, 8);
                        kaçtaneharf = şifreuzunlugu - kaçtanerakam;
                        do
                        {
                            sayı = rnd.Next(1, 10);
                            sayılar.Add(sayı);
                        } while (sayılar.Count != kaçtanerakam - 1);
                        do
                        {
                            sayı = rnd.Next(1, 33);
                            rakamlar.Add(sayı);
                            karışıüretilenharf.Add(alfabe[sayı]);

                        } while (kaçtaneharf - 1 != rakamlar.Count);
                        for (int i = 0; i < şifreuzunlugu; i++)
                        {
                            geridönen.Add(karışıüretilenharf[i].ToString());
                            geridönen.Add(sayılar[i].ToString());
                            if (kaçtaneharf + kaçtanerakam == şifreuzunlugu - 1)
                            {
                                geridönen.Add(rastgelekarakter[rnd.Next(0, 8)]);
                            }
                        }
                    }
                }
                else
                {
                    if (öncehangisi == 1)
                    {
                        kaçtanerakam = rnd.Next(1, 8);
                        kaçtaneharf = şifreuzunlugu - kaçtanerakam;
                        do
                        {
                            sayı = rnd.Next(1, 10);
                            sayılar.Add(sayı);
                        } while (sayılar.Count != kaçtanerakam);
                        do
                        {
                            sayı = rnd.Next(1, 33);
                            rakamlar.Add(sayı);
                            karışıüretilenharf.Add(alfabe[sayı]);
                        } while (kaçtaneharf != rakamlar.Count);
                        for (int i = 0; i < şifreuzunlugu; i++)
                        {
                            geridönen.Add(sayılar[i].ToString());
                            geridönen.Add(karışıüretilenharf[i].ToString());
                        }
                    }
                    if (öncehangisi == 2)
                    {
                        kaçtanerakam = rnd.Next(1, 8);
                        kaçtaneharf = şifreuzunlugu - kaçtanerakam;
                        do
                        {
                            sayı = rnd.Next(1, 10);
                            sayılar.Add(sayı);
                        } while (sayılar.Count != kaçtanerakam);
                        do
                        {
                            sayı = rnd.Next(1, 33);
                            rakamlar.Add(sayı);
                            karışıüretilenharf.Add(alfabe[sayı]);
                        } while (kaçtaneharf != rakamlar.Count);
                        for (int i = 0; i < şifreuzunlugu; i++)
                        {
                            geridönen.Add(karışıüretilenharf[i].ToString());
                            geridönen.Add(sayılar[i].ToString());
                        }
                    }
                }
            }
            return geridönen;
        }
    }
}
