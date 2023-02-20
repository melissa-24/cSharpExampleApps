using Microsoft.AspNetCore.Mvc;

namespace SquishyBrowswerWebAppPartOne.Controllers;

public class SquishyController : Controller {
    [HttpGet]
    [Route("")]
    public string Index() {
        return "Welcome to my Squishy App!";
    }

    [HttpGet("squishy")]
    public string Squishy() {
        return "Check me out I am another page in the app!";
    }

    [HttpGet("squishy/{name}")]
    public string HiSquishy(string name) {
        return $"Please be sure to say hi to {name}";
    }
    [HttpGet("math/{a}/{b}")]
    public string DoMath(int a, int b) {
        int c = a + b;
        return $"You gave me {a} and {b} and I have added them to give you {c}";
    }
}