using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemoo.Abstract;
using InterfaceAbstractDemoo.Entities;
using MernisService;


namespace InterfaceAbstractDemoo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            var NationalyId = Convert.ToInt64(customer.NationalityId);


           //KPSPublicSoapClient client = new KPSPublicSoapClient();
           // return client.TCKimlikNoDogrula (Convert.ToInt64(customer.NationalityId,
           //customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DataOfBirth.Year);
           
           

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrula(NationalyId,
           customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DataOfBirth.Year);

        }

    
    }
}
