using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FavoriteImages.Models;
using Microsoft.AspNetCore.Identity;

namespace FavoriteImages.Controllers;

public class ImageController : Controller 
{

    private MyContext db;
    
    public ImageController(MyContext context)
    {
        db = context;
    }

    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }

    [HttpGet("/dashboard")]
    public IActionResult Dashboard() {

        if(HttpContext.Session.GetInt32("uid") == null) {
            return RedirectToAction("Index", "User");
        }

        List<Image> theImages = db.Images.ToList();

        return View("Dashboard", theImages);
    }    
    
    // [HttpGet("/image/{imageId}/view")]
    // public IActionResult ViewImage() {
        
        
    // }

    // [HttpGet("/image/{userId}/view")]
    // public IActionResult UserImages() {

    // }

    [HttpGet("/image/nasa")]
    public IActionResult Nasa() {
        if(HttpContext.Session.GetInt32("uid") == null) {
            return RedirectToAction("Index", "User");
        }
        return View("Nasa");
    }

    [HttpGet("/image/addImage")]
    public IActionResult AddImage() {
        if(HttpContext.Session.GetInt32("uid") == null) {
            return RedirectToAction("Index", "User");
        }
        return View("addImage");
    }
        
    [HttpPost("/image/createImage")]
    public IActionResult CreateImage(Image i) {
        i.UserId = (int)HttpContext.Session.GetInt32("uid");
        if(ModelState.IsValid) {
            db.Images.Add(i);
            db.SaveChanges();
            return Redirect("/dashboard");
        } else {
            return View("AddImage");
        }

    }

    // [HttpGet("/image/{imageId}/edit")]
    // public IActionResult EditImage() {
        
    // }

    // [HttpPost("//image/{imageId}/update")]
    // public IActionResult UpdateImage() {
        
    // }

    // [HttpGet("/image/{imageId}/delete")]
    // public IActionResult DeleteImage() {
        
    // }


}
