using Microsoft.AspNetCore.Mvc;

namespace PlanB.AppCore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}