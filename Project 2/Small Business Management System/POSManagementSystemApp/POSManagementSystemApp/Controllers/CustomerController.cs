using POSManagementSystem.BLL.BLL;
using POSManagementSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POSManagementSystemApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Add()
        {
            CustomerManager _customerManager;
            _customerManager = new CustomerManager();
            Customer customer = new Customer();
            _customerManager.check(customer);
            return View();
        }
    }
}