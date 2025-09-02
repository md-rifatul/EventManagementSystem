using Microsoft.AspNetCore.Mvc;
using QuickEventManagementSystem.Data;

namespace QuickEventManagementSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AllUsers()
        {
            var users = SeedData.Users.ToList();
            return View(users);
        }
    }
}
