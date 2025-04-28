using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {

            return View("/CustomView/CustomView.cshtml", name);
        }

        public IActionResult Default()
        {
            return RedirectToAction("Index");
        }

        public int Login()
        {
            return 10;
        }
    }
}
