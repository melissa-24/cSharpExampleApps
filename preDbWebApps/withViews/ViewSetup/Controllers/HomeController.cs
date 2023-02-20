using Microsoft.AspNetCore.Mvc;
namespace ViewSetup.Controllers;
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("test/")]
        public ViewResult Test()
        {
            return View();
        }

    }