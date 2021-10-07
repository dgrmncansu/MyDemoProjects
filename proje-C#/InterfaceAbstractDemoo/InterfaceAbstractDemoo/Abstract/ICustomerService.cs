using InterfaceAbstractDemoo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoo.Abstract
{
  public  interface ICustomerService
    {
        //interface implementasyonunu yapan herkes bu operasyonu kullanmak(implemente) zorundadır
        void Save(Customer customer);
    }
}
