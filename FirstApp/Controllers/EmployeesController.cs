using FirstApp.Bl;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class EmployeesController : Controller
    {
        LinkedList<EmployeesModel> ListEmployees;
        private void CreateEmployeesList()
        {
            ClsEmployee oClsEmployee = new ClsEmployee();
            ListEmployees = oClsEmployee.GetData();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Departemnt = "Salse";
            ViewData["Salary"] = 5000;
            //  ViewBag.SalesMan = model;

            CreateEmployeesList();

            //  ViewBag.EmployeesTable = ListEmployees;
            return View(ListEmployees);
        }

        public IActionResult Details(int id)
        {
            CreateEmployeesList();
            var myModel = ListEmployees.Where(a => a.Id == id).FirstOrDefault();

            return View();
        }

    }
}
