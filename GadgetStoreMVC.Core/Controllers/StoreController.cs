using Microsoft.AspNetCore.Mvc;

namespace GadgetStoreMVC.Controllers
{
    public class StoreController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}