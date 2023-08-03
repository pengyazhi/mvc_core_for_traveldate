using Microsoft.AspNetCore.Mvc;

namespace prjTravelDate_core.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult ForumList()
        {
            return View();
        }
        public IActionResult Create() 
        {
            return View();
        }
        public IActionResult ArticleView() 
        {
            return View();
        }
    }
}
