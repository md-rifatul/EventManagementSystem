using Microsoft.AspNetCore.Mvc;
using QuickEventManagementSystem.Data;

namespace QuickEventManagementSystem.Controllers
{
    public class EventController : Controller
    {
        public IActionResult AllEvents()
        {
            var events = SeedData.Events.ToList();
            return View(events);
        }
        public IActionResult UpcomingEvents()
        {
            var events = SeedData.Events.Where(x=>x.Date>DateTime.Today)
                                        .ToList();
            return View(events);
        }
    }
}
