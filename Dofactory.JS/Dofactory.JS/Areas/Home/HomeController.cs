using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
