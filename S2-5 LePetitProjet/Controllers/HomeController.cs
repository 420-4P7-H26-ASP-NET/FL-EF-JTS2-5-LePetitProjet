using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S2_5_LePetitProjet.Models;

namespace S2_5_LePetitProjet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
