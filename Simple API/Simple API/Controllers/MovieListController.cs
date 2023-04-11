using Microsoft.AspNetCore.Mvc;

namespace Simple_API.Controllers
{
    public class MovieListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
