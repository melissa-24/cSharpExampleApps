using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetsApp.Models;

namespace PetsApp.Controllers;

public class BearController : Controller {

    // private MyContext _context;
    private MyContext db;
    // Can change this to db for example as it is helping the controllers talk to the database
    // by doing this we will now call db not _context

    public BearController(MyContext context) {
        db = context;
    }

    [HttpGet("/newBear")]
    public IActionResult NewBear() {

        return View();
    }

    // The form should have the function name
    [HttpPost("createBear")]
    public IActionResult CreateBear(Bear b) {
        if(ModelState.IsValid){
            db.Bears.Add(b);
            // save changes actually updates the database
            db.SaveChanges();
            // once we do we can actually pull back the id to make sure it did save
            Console.WriteLine(b.BearId);

            return Redirect("/bear");
        } else {
            return View();
        }
    }

    [HttpGet("/bear")]
    public IActionResult Bear() {
        List<Bear> allBear = db.Bears.ToList();
        return View("Bear", allBear);
    }

}