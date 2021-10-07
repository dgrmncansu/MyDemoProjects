using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat amevzuat = new AMevzuat();
            amevzuat.Kaydet();
            amevzuat.Degerlendirme();

            Console.ReadLine();

        }
    }

    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {

        }
        //Bir bankanın kredi değerlendirme işlemi


        public abstract void Degerlendirme();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
    class AMevzuat : MevzuatBase
    {
        public override void Degerlendirme()
        {
            Console.WriteLine("A mevzuatına göre değerlendirildi");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendirme()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi");
        }
    }

    class CustomerManager
    {

      public  void Add()
        {
            Console.WriteLine("Added");
        }  
        public void Delete()
        {
            Console.WriteLine("deleted");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
