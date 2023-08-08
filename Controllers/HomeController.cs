using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            // ViewBag.IndexText = saat > 12 ? "İyi Günler" : "Günaydın";

            ViewData["IndexText"] = saat > 12 ? "İyi Günler" : "Günaydın";
            return View();
        }
    }
}