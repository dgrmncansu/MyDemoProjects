using InterfaceAbstractDemoo.Abstract;
using InterfaceAbstractDemoo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
