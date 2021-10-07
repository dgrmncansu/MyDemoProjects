using System;

namespace DictionaryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Engin");


            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Lenght);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);

            }
        }
    }
}
