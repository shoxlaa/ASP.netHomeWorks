using Microsoft.AspNetCore.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class NotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
