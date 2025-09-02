using Microsoft.AspNetCore.Mvc;
using QuickEventManagementSystem.Data;

namespace QuickEventManagementSystem.Controllers
{
    public class EventController : Controller
    {
        public IActionResult AllEvents()
        {
            var events = SeedData.Events;
            return View(events);
        }
    }
}
