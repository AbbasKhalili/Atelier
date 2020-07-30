using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Atelier.Customer.Facade;
using Atelier.Customer.Models;
using Atelier.Tools;

namespace Atelier.Controllers
{
    public class CustomerContractController : Controller
    {
        public ActionResult CreateCustomerContract()
        {
            return View();
        }
       /* [HttpPost]
        public ActionResult CreateCustomerContract(CustomerContract CC_obj)
        {
            CustomerFactory x = new CustomerFactory();
            x.GetCustomerInstance().InsertCustomer(CC_obj);
            return View();
        }*/
	}
}