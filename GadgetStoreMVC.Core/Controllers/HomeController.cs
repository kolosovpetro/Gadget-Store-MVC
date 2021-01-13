using Microsoft.AspNetCore.Mvc;

namespace GadgetStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}