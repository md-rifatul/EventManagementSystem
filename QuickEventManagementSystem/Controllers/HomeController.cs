using Microsoft.AspNetCore.Mvc;

namespace QuickEventManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
