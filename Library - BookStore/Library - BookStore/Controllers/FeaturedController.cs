using Microsoft.AspNetCore.Mvc;

namespace Library___BookStore.Controllers
{
    public class FeaturedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
