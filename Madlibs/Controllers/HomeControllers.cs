using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Form() { return View(); }

    [HttpGet("/")]
    public ActionResult Madpage() { 
      MadlibsWords myWord = new MadlibsWords();
      // myWord.Noun = "Garage Door";
      return View(myWord);
    }
    [HttpPost("/madform")]
    public ActionResult Madform(string noun)
    {
      MadlibsWords myWord = new MadlibsWords();
      myWord.Noun = noun;
      return View("Madpage", myWord);
    }

  }
}