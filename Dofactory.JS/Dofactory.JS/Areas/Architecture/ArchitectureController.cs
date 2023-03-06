using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.Architecture;

[Route("architecture")]
public class ArchitectureController : Controller
{
    [HttpGet] public IActionResult Index() => View();
    [HttpGet("amdrequire")] public IActionResult AmdRequire() => View();
    [HttpGet("errorhandling")] public IActionResult ErrorHandling() => View();
    [HttpGet("introduction")] public IActionResult Introduction() => View();
    [HttpGet("modularity")] public IActionResult Modularity() => View();
    [HttpGet("scriptloading")] public IActionResult ScriptLoading() => View();
    [HttpGet("testing")] public IActionResult Testing() => View();
    [HttpGet("transpilers")] public IActionResult Transpilers() => View();
}
