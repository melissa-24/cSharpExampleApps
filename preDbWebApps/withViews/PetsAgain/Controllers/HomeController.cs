using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetsAgain.Models;

namespace PetsAgain.Controllers;

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

    [HttpPost("/addPet")]
    public IActionResult AddPet(string PetName, int Age, string HairColor){
        Console.WriteLine($"{PetName} is {Age} and has {HairColor} ");
        return Redirect("/");
    }
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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
