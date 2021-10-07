﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int yas = 36;


            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.İzlenmeOrani = 64;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.İzlenmeOrani = 80;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" " +kurs.Egitmeni    );
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
