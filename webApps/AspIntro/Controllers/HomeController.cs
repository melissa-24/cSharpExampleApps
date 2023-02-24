using Microsoft.AspNetCore.Mvc;
namespace AspIntro.Controllers;   
public class HelloController : Controller   
{      
    [HttpGet("")]
    public string Index()        
    {            
        return "Hello World from HelloController!";        
    } 
    [HttpGet("newPage")]
    public string NewPage() {
        return "New page new string";
    }
}

