using Microsoft.AspNetCore.Mvc;
namespace MultipleControllersWithViews.Controllers;
    public class SquishyController : Controller
    {
        [HttpGet("squishy/")]
        public ViewResult Squishy()
        {
            return View();
        }
        [HttpGet("squishy/one/")]
        public ViewResult OneSquishy()
        {
            return View();
        }
    }