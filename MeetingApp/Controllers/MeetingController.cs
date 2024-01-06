using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            //database
            //list
            //boş veri ya da hatalı veri gönderilmeye çalışıldığında sayfa refresh ediliyor
            if(ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
          
        }

        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }


        //meeting/details/2 
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
