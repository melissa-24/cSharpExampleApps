using Microsoft.AspNetCore.Mvc;
namespace MvcWithControllersSetup.Controllers;
    public class FirstController : Controller
    {
        [HttpGet]
        [Route("")] 
        public string Index()
        {
            return "Check Me Out I have a Controller folder and file!";
        }
    }