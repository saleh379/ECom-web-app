using ECom_wep_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECom_wep_app.Controllers
{
    public class CustomerController : Controller
    {
  
       // Customer/List
        public IActionResult List()
        {
            CustomerBL customerBL = new CustomerBL();
            List<Customer> customers = customerBL.GetAllCustomers();
            return View("List",customers);
        }
    }
}
