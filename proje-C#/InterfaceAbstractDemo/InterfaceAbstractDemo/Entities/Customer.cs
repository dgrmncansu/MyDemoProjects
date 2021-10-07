﻿using System;

namespace InterfaceAbstractDemo.Entities
{
    class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }


    }

    internal interface IEntity 
    { 
    }
}
