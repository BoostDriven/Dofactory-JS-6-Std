using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.Modern
{
    [Route("modern")]
    public class ModernController : Controller
    {
        [HttpGet] public IActionResult Index() => View();
        [HttpGet("chaining")] public IActionResult Chaining() => View();
        [HttpGet("constructor")] public IActionResult Constructor() => View();
        [HttpGet("introduction")] public IActionResult Introduction() => View();
        [HttpGet("invocation")] public IActionResult Invocation() => View();
        [HttpGet("lazyload")] public IActionResult LazyLoad() => View();
        [HttpGet("mixin")] public IActionResult Mixin() => View();
        [HttpGet("module")] public IActionResult Module() => View();
        [HttpGet("monkeypatch")] public IActionResult Monkeypatch() => View();
        [HttpGet("multiton")] public IActionResult Multiton() => View();
        [HttpGet("namespace")] public IActionResult Namespace() => View();
        [HttpGet("partial")] public IActionResult Partial() => View();
    }
}
