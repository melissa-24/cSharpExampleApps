using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcLinq.Models;

namespace MvcLinq.Controllers;

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
        List<User> Users = new List<User> {
            new User("Jane", "Doe", "janiegirl"),
            new User("Bob", "Ross", "happytrees"),
            new User("John", "Smith", "johnboy"),
            new User("Copper", "Tone", "Nugglet"),
            new User("Mr", "Tucker", "mrT"),
        };
        Random rand = new Random();
        int i = rand.Next(Users.Count);
        string choice = Users[i].FirstName;
        Console.WriteLine(choice);
        User? oneUser = Users.FirstOrDefault(user => user.FirstName == choice);
        if(oneUser != null) {
            Console.WriteLine(oneUser.AUser());
            string theUser = oneUser.AUser();
            ViewBag.theUser = theUser;
            return View("Index", theUser);
        } else {
            Console.WriteLine("User not in list");
            return View();
        }
    }
    [HttpGet("indexTwo")]
    public  IActionResult IndexTwo() {
        List<User> Users = new List<User> {
            new User("Jane", "Doe", "janiegirl"),
            new User("Bob", "Ross", "happytrees"),
            new User("John", "Smith", "johnboy"),
            new User("Copper", "Tone", "Nugglet"),
            new User("Mr", "Tucker", "mrT"),
        };
        List<User> orderUsers = users.OrderByDescending(user => user.Username).ToString();

        Console.WriteLine(orderUsers);
        ViewBag.orderUsers = orderUsers;
        return ErrorViewModel("IndexTwo", orderUsers);
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
