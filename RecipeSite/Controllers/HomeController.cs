using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace RecipeSite.Controllers
{
    public class HomeController : Controller
    {
        //default action method
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("Home");
        }
        [HttpGet]
        public ViewResult RecipeList()
        {
            return View();
        }
        [HttpGet]
        public ViewResult ViewRecipe()
        {
            return View();
        }
        [HttpGet]
        public ViewResult ReviewRecipe()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }
    }
}
