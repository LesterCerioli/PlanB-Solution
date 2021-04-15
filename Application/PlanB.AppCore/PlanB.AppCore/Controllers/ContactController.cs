using Microsoft.AspNetCore.Mvc;

namespace PlanB.AppCore.Controllers
{
    public class ContactController : Controller

    {
        public IActionResult Index()
        {
            return View();
        }
    }
}