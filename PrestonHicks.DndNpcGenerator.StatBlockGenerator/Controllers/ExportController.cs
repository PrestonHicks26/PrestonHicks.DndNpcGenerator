using Microsoft.AspNetCore.Mvc;

namespace PH.DndNpcGenerator.StatBlockGenerator.Controllers
{
    public class ExportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
