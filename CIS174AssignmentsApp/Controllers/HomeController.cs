using Microsoft.AspNetCore.Mvc;

namespace CIS174AssignmentsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
