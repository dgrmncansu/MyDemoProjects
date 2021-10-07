using InterfaceAbstractDemoo.Abstract;
using InterfaceAbstractDemoo.Adapters;
using InterfaceAbstractDemoo.Concrete;
using InterfaceAbstractDemoo.Entities;
using System;

namespace InterfaceAbstractDemoo
{
    class Program
    {
        static void Main(string[] args)
        {


            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DataOfBirth = new DateTime(1991, 1, 6),
                FirstName = "Cansu",
                LastName = "Değirmen",
               NationalityId= "1234567890"
            });
            Console.ReadLine();
            
        }
    }
}
