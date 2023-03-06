using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.Classic
{
    [Route("classic")]
    public class ClassicController : Controller
    {
        [HttpGet] public IActionResult Index() => View();
        [HttpGet("abstractfactory")] public IActionResult AbstractFactory() => View();
        [HttpGet("adapter")] public IActionResult Adapter() => View();
        [HttpGet("bridge")] public IActionResult Bridge() => View();
        [HttpGet("builder")] public IActionResult Builder() => View();
        [HttpGet("chain")] public IActionResult Chain() => View();
        [HttpGet("command")] public IActionResult Command() => View();
        [HttpGet("composite")] public IActionResult Composite() => View();
        [HttpGet("decorator")] public IActionResult Decorator() => View();
        [HttpGet("facade")] public IActionResult Facade() => View();
        [HttpGet("factorymethod")] public IActionResult FactoryMethod() => View();
        [HttpGet("flyweight")] public IActionResult Flyweight() => View();
        [HttpGet("interpreter")] public IActionResult Interpreter() => View();
        [HttpGet("introduction")] public IActionResult Introduction() => View();
        [HttpGet("iterator")] public IActionResult Iterator() => View();
        [HttpGet("mediator")] public IActionResult Mediator() => View();
        [HttpGet("memento")] public IActionResult Memento() => View();
        [HttpGet("observer")] public IActionResult Observer() => View();
        [HttpGet("prototype")] public IActionResult Prototype() => View();
        [HttpGet("proxy")] public IActionResult Proxy() => View();
        [HttpGet("singleton")] public IActionResult Singleton() => View();
        [HttpGet("state")] public IActionResult State() => View();
        [HttpGet("strategy")] public IActionResult Strategy() => View();
        [HttpGet("template")] public IActionResult Template() => View();
        [HttpGet("visitor")] public IActionResult Visitor() => View();
    }
}
