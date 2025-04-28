using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            List<CustomersModel> oCustomersModel = new List<CustomersModel>();
            //
            oCustomersModel.Add(new CustomersModel()
            {
                CustomerId = 1,
                CustomerName = "Farid",
            });
            oCustomersModel.Add(new CustomersModel()
            {
                CustomerId = 2,
                CustomerName = "Ahmed",
            });
            oCustomersModel.Add(new CustomersModel()
            {
                CustomerId = 3,
                CustomerName = "Salaha",
            });
            oCustomersModel.Add(new CustomersModel()
            {
                CustomerId = 4,
                CustomerName = "Abdo",
            });

            ViewBag.Customers = oCustomersModel;

            var invoice = new InvoiceModel();
            //
            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                ItemId = 1,
                Price = 500,
                Quantity = 4
            });
            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                ItemId = 2,
                Price = 1000,
                Quantity = 10
            });
            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                ItemId = 3,
                Price = 700,
                Quantity = 1
            });
            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                ItemId = 4,
                Price = 100,
                Quantity = 30
            });
            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                ItemId = 5,
                Price = 10,
                Quantity = 0
            });


            return View(invoice);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(InvoiceModel model)
        {
            if (!ModelState.IsValid)
                return View("Index", model);


            return View("Index", model);
        }
    }
}
