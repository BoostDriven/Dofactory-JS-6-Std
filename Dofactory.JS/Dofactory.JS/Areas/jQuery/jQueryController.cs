using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.jQuery
{
    [Route("jquery")]
    public class jQueryController : Controller
    {
        [HttpGet] public IActionResult Index() => View();
        [HttpGet("adapter")] public IActionResult Adapter() => View();
        [HttpGet("chaining")] public IActionResult Chaining() => View();
        [HttpGet("doubleexclamation")] public IActionResult DoubleExclamation() => View();
        [HttpGet("facade")] public IActionResult Facade() => View();
        [HttpGet("introduction")] public IActionResult Introduction() => View();
        [HttpGet("iterator")] public IActionResult Iterator() => View();
        [HttpGet("lazyload")] public IActionResult LazyLoad() => View();
        [HttpGet("module")] public IActionResult Module() => View();
        [HttpGet("namespace")] public IActionResult Namespace() => View();
        [HttpGet("observer")] public IActionResult Observer() => View();
        [HttpGet("optionshash")] public IActionResult OptionsHash() => View();
        [HttpGet("overload")] public IActionResult Overload() => View();
        [HttpGet("placeholder")] public IActionResult Placeholder() => View();
        [HttpGet("plugin")] public IActionResult Plugin() => View();
        [HttpGet("proxy")] public IActionResult Proxy() => View();
        [HttpGet("shortwalk")] public IActionResult ShortWalk() => View();
        [HttpGet("singleton")] public IActionResult Singleton() => View();
        [HttpGet("singlevar")] public IActionResult SingleVar() => View();
        [HttpGet("zerotimeout")] public IActionResult ZeroTimeout() => View();
    }
}
