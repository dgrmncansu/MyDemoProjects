﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi1 = 10;
            int sayi2=30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1??30

            //int,decimal,float,double,bool= Değer tip (sayısal)
            // array,class,interface= Referans tip (metinsel)
            //değer tipleri (stack)=sayi1=10(sayı 1'in değeri),sayi2=30 burda tanımlanır
            //referans tipleri (heap)=Array'dir.Yeni bir yer,adres yada alan oluştur demektir
            //c gibi dillerde pointer araştır
            //yazılım da sürdürebilirlilik önemlidir.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999


        }
    }
}
