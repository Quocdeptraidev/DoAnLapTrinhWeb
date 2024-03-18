using Microsoft.AspNetCore.Mvc;

namespace Library___BookStore.Controllers
{
    public class PopularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
