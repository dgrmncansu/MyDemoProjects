

using System;

namespace KampIntro
{
    class Program

    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // Değer tutucu-allas
            //int:sınırlı sayıdadır
            string kategoriEtiketi = "Kategori";
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }

            else if (dolarDun < dolarBugun) ;
            {
                Console.WriteLine("Artış butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("kullacı ayarları butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            {
                Console.WriteLine("Giriş yap butonu");

            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
