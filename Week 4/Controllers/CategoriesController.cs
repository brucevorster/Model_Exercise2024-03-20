using Microsoft.AspNetCore.Mvc;

namespace Week_4.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
