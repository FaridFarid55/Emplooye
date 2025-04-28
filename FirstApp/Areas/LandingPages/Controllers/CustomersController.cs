using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Areas.LandingPages.Controllers
{
    [Area("LandingPages")]
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            List<CustomersModel> ListCustomer = new List<CustomersModel>();
            ListCustomer.Add(new CustomersModel()
            {
                CustomerId = 1,
                CustomerName = "Farid",
                Phone = " 01009266353",
                Email = "Farid@gmail.com",
                City = "alx"
            });
            ListCustomer.Add(new CustomersModel()
            {
                CustomerId = 2,
                CustomerName = "Ahmed",
                Phone = " 01020656887",
                Email = "Ahmed@gmail.com",
                City = "cairo"
            });
            ListCustomer.Add(new CustomersModel()
            {
                CustomerId = 3,
                CustomerName = "Salaha",
                Phone = "01059266353",
                Email = "Salaha@gmail.com",
                City = "giza"
            });

            ViewBag.Customer = ListCustomer;
            return View(ListCustomer);
        }

        public IActionResult Add()
        {
            return View(new CustomersModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CustomersModel model)
        {
            if (!ModelState.IsValid)
                return View("Add", model);


            return View("Add", model);
        }
    }
}
