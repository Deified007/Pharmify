using Microsoft.AspNetCore.Mvc;

namespace Pharmify.Controllers
{
    public class DetailMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
