using System;
using System.Collections.Generic;

namespace Atelier.CustomerManagement.Contract
{
    public class CustomerContract
    {
        public int ID { get; set; }
        public string ContractNO { get; set; }
        public string ContractTitle { get; set; }
        public string ContractDate { get; set; }
        public int FKIDCustomer { get; set; }
        public string ContractDescs { get; set; }
        public string CeremonyType { get; set; }
        public string UserSave { get; set; }
        public string DateSave { get; set; }
        public string TimeSave { get; set; }
    }
}