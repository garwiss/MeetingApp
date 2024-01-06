
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {

        //erişmek için ---> localhost/home
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            //ViewBag.Selamlama =  saat > 15 ? "İyi akşamlar" : "İyi günler";                                   ------> ViewBag kullanımı 
            // ViewBag.Username = "Kullanıcı"; 

            ViewData["Selamlama"] = saat > 15 ? "İyi akşamlar" : "İyi günler";                                            //----< key value şeklinde bilgi veriyoruz ViewData da
           int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

            //ViewData["Username"] = "Enes";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Ankara,Barolar Birliği",
                Date= new DateTime(2024,1,20,20,0,0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}