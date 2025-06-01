using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
