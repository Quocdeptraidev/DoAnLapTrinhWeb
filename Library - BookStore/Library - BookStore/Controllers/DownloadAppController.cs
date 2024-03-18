using Microsoft.AspNetCore.Mvc;

namespace Library___BookStore.Controllers
{
    public class DownloadAppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
