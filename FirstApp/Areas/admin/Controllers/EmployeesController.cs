// Ignore Spelling: admin App

using FirstApp.Bl;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class EmployeesController : Controller
    {
        public IActionResult List()
        {
            ClsEmployee oClsEmployee = new ClsEmployee();
            return View(oClsEmployee.GetData());
        }

        public IActionResult Edit()
        {
            return View(new EmployeesModel());
        }


        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyEmail(string email)
        {
            if (false)
            {
                return Json($"Email {email} is already in use.");
            }

            return Json(true);
        }

        public IActionResult Create()
        {

            return View(new CustomersModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CustomersModel model)
        {
            if (!ModelState.IsValid)
                return View("Create", model);


            return View("Create", model);
        }
    }
}
