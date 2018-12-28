using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerClient.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            return View(client.GetCustomers());
        }
    }
}