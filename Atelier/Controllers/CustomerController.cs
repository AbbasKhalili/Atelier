using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Atelier.Facade;
using Atelier.Customer;
using Atelier.Tools;
using Atelier.Customer.Models;

namespace Atelier.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            GetPersianDate todaydate = new GetPersianDate();
            todaydate.SetTodayDate();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerModel Customer_obj)
        {
            CustomerFactory x = new CustomerFactory(); 
            x.GetCustomerInstance().InsertCustomer(Customer_obj);
            return View();
        }

        
	}
}