using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.Essentials
{
    [Route("essentials")]
    public class EssentialsController : Controller
    {
        [HttpGet] public IActionResult Index() => View();
        [HttpGet("codingstandards")] public IActionResult CodingStandards() => View();
        [HttpGet("crackingidioms")] public IActionResult CrackingIdioms() => View();
        [HttpGet("designpatterns")] public IActionResult DesignPatterns() => View();
        [HttpGet("eventloop")] public IActionResult EventLoop() => View();
        [HttpGet("introduction")] public IActionResult Introduction() => View();
        [HttpGet("javascriptpatterns")] public IActionResult JavaScriptPatterns() => View();
        [HttpGet("oodesign")] public IActionResult OODesign() => View();
        [HttpGet("prototypes")] public IActionResult Prototypes() => View();
        [HttpGet("unobtrusive")] public IActionResult Unobtrusive() => View();
    }
}
