using System;

namespace OOP2
{
    class Program
        //Cansu Değirmen
    {
        static void Main(string[] args)
        {
            Indıvidual ındıvidual1 = new Indıvidual();
            ındıvidual1.Id = 1;
            ındıvidual1.MusteriNo = "12345";
            ındıvidual1.Adi = "Cansu";
            ındıvidual1.Soyadi = "Değirmen";
            ındıvidual1.TcNo = "12345678910";

            //Kodlama.io
            Coorporate coorporate2 = new Coorporate();
            coorporate2.Id = 2;
            coorporate2.MusteriNo = "54321";
            coorporate2.SirketAdi = "Kodlama.io";
            coorporate2.VergiNo = "1234567890";

            //gerçek müşteri-tüzel müşteri
            //SOLİD
            Customer customer3 = new Indıvidual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            CustomerManager.Add(customer3);
            customerManager.Add(customer4);



        }
    }
}
