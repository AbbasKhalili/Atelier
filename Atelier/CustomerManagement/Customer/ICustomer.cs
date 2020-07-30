using System;
using System.Collections.Generic;
using Atelier.Customer.Models;

namespace Atelier.Customer.Facade
{
    public interface ICustomer
    {
        int InsertCustomer(CustomerModel obj);
    }
}
