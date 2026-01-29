using Microsoft.AspNetCore.Mvc;

namespace S2_5_LePetitProjet.Controllers
{
    public class RecetteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["title"] = "recetteeee";
            return View("index");
        }
    }
}
