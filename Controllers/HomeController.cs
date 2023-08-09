using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            int userCount = Repository.Users.Where(i => i.WillAttend == true).Count();

            ViewData["IndexText"] = saat > 12 ? "İyi Günler" : "Günaydın";

            var meetingInfo = new MeetInfo()
            {
                Id = 1,
                Location = "İstanbul",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = userCount,
            };
            return View(meetingInfo);
        }
    }
}