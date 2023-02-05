using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Views.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
