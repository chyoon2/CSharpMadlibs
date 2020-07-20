using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Madpage() { 
      MadlibsWords myWord = new MadlibsWords();
      myWord.Noun = "Garage Door";
      return View(myWord);
    }
  }
}