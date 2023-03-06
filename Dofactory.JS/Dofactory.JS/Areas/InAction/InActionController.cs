using Microsoft.AspNetCore.Mvc;

namespace Dofactory.JS.Areas.InAction
{
    [Route("inaction")] 
    public class InActionController : Controller
    {
        [HttpGet] public IActionResult Index() => View();
        [HttpGet("dashboard")] public IActionResult Dashboard() => View();
        [HttpGet("dashboardapp")] public IActionResult DashboardApp() => View();
        [HttpGet("dataentry")] public IActionResult DataEntry() => View();
        [HttpGet("dataentryapp")] public IActionResult DataEntryApp() => View();
        [HttpGet("introduction")] public IActionResult Introduction() => View();
        [HttpGet("mapping")] public IActionResult Mapping() => View();
        [HttpGet("mappingapp")] public IActionResult MappingApp() => View();
        [HttpGet("pagination")] public IActionResult Pagination() => View();
        [HttpGet("paginationapp")] public IActionResult PaginationApp() => View();
        [HttpGet("search")] public IActionResult Search() => View();
        [HttpGet("searchapp")] public IActionResult SearchApp() => View();
        [HttpGet("spa")] public IActionResult Spa() => View();
        [HttpGet("spaapp")] public IActionResult SpaApp() => View();
        [HttpGet("spaappload")] public IActionResult SpaAppLoad() => View();
    }
}
