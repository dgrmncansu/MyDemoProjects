using InterfaceAbstractDemoo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoo.Abstract
{
    public interface ICustomerCheckService
    {
        Boolean CheckIfRealPerson(Customer customer);
        

        }
    }

