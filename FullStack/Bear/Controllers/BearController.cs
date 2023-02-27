using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bear.Models;

namespace Bear.Controllers;

public class BearController : Controller {

    private MyContext _context;

    [HttpGet("/bear")]
    public IActionResult Bear() {
        // ViewBag.AllBear = _context.Bears.ToList();
        List<Bear> AllBear = _context.Bears.ToList();
        return View(AllBear);
    }

}