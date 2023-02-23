using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Petstagram.Models;

namespace Petstagram.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost("/addPet")]
    // public RedirectToActionResult AddPet(string PetName, int Age, string HairColor) {
    //     return RedirectToAction("Index"); // redirecting to the function name that we want it to redirect too
    // }
    // [HttpPost("/addPet")]
    // public RedirectResult AddPet(string PetName, int Age, string HairColor) {
    //     return Redirect("/"); // redirecting to the url we want
    // }
    public IActionResult AddPet(string PetName, int Age, string HairColor){
        Console.WriteLine($"{PetName} is {Age} and has {HairColor} ");
        return Redirect("/");
    }

//IActionResult might be the best option but the others can be used to be more specific

    [HttpPost("/addNewPet")]
    public IActionResult AddNewPet(string PetName, string PetType, int Age, string HairColor) {
        if(PetType == "dolphin") {
            ViewBag.SecretMessage = "You have picked the secret pet type!";
            return View("Index");
        }
        Console.WriteLine($"{PetName} is {Age} and has {HairColor} ");
        return Redirect("/");
    }
    [HttpGet("{**path}")]
    public RedirectToActionResult Unknown()
    {
        Console.WriteLine("Page not found");
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
