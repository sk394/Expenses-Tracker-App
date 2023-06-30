using Microsoft.AspNetCore.Mvc;

namespace ManageMyGhanta.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
