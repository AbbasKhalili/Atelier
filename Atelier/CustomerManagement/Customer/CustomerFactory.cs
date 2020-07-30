using System;
using System.Collections.Generic;

namespace Atelier.Customer.Facade
{
    public class CustomerFactory
    {
        public ICustomer GetCustomerInstance()
        {
            return new BLL.Customer();
        }
    }
}