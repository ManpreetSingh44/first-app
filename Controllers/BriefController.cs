using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp
{
    public class BriefController : Controller
    {
        public IActionResult Brief()
        {
            return View();
        }
    }
}