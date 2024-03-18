using Microsoft.AspNetCore.Mvc;

namespace Library___BookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
