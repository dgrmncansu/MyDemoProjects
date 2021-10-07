using InterfaceAbstractDemoo.Entities;
using System;

namespace InterfaceAbstractDemoo.Abstract
{
   public class Customer:IEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DataOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
