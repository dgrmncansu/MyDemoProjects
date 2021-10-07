using InterfaceAbstractDemoo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        //ezebilirim demek
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db  : "  + customer.FirstName  + customer.LastName + customer.Id + customer.DataOfBirth);
        }

       
    }
}
