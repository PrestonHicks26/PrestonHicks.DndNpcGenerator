using Microsoft.AspNetCore.Mvc;

namespace PH.DndNpcGenerator.StatBlockGenerator.Controllers
{
    public class GeneratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
