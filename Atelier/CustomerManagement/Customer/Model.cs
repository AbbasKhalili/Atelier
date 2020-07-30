using System;
using System.Collections.Generic;

namespace Atelier.Customer.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public enumeration.Gender Gender { get; set; }
        public string NationalCode{ get; set;}
        public string Birthdate{ get; set;}
        public string Tel { get; set;}
        public string Mobile { get; set;}
        public string Email { get; set; }
        public string Address { get; set; }
        public string Descs { get; set; }
        public string UserSave { get; set; }
        public string DateSave { get; set; }
        public string TimeSave { get; set; }

    }
}