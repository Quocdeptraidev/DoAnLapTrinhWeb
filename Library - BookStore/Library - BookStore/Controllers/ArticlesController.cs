using Microsoft.AspNetCore.Mvc;

namespace Library___BookStore.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
