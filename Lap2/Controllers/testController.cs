using Microsoft.AspNetCore.Mvc;

namespace Lap2.Controllers
{
    public class testController : Controller
    {
        //greetings có thể thêm 
        public string Index()
        {
            return "biubiu";
        }
        public string welcome(int id , string name)
        {
            return $"Hello,{id} _ {name}!";
        }
        public IActionResult welcome1(int id , string name )
        {
            ViewBag.id = id ;
            ViewData["name"] = name ;

            return View();
        }
    }
}

