using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.ModelView
{
    [Route("modelview")]
    public class ModelViewController : Controller
    {
        [HttpGet] public IActionResult Index() => View();
        [HttpGet("introduction")] public IActionResult Introduction() => View();
        [HttpGet("mv")] public IActionResult MV() => View();
        [HttpGet("mvc")] public IActionResult MVC() => View();
        [HttpGet("mvp")] public IActionResult MVP() => View();
        [HttpGet("mvvm")] public IActionResult MVVM() => View();
    }
}
