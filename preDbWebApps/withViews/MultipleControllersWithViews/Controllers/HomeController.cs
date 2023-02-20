using Microsoft.AspNetCore.Mvc;
namespace MultipleControllersWithViews.Controllers;
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

    }