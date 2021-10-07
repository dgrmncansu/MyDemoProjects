using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç temel kurs", "Java" };


            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {


            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
