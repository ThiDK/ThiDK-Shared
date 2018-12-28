using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            return View(service.GetCustomers());
        }
    }
}