using Microsoft.AspNetCore.Mvc;
namespace MultipleControllersWithViews.Controllers;
    public class GardenController : Controller
    {
        [HttpGet("garden/")]
        public ViewResult Garden()
        {
            return View();
        }
        [HttpGet("garden/plant/")]
        public ViewResult Plant()
        {
            return View();
        }

    }