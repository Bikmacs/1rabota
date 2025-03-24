using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace _1rabota.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View(); // Возвращает представление Index.cshtml
        }

        public IActionResult Page2()
        {
            return View();
        }

        public string Welcome(string name, int numTimes = 1)
        {
            string message = "Hello " + name + ", NumTimes is: " + numTimes;
            return message;
        }
    }
}
