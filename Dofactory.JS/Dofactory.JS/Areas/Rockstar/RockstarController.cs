using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.Rockstar
{
    [Route("rockstar")]
    public class RockstarController : Controller
    {
        public IActionResult Index() => View();
    }
}
