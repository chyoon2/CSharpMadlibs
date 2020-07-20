using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet(/form)]
    public ActionResult Form() {} return View(); }

    [Route("/")]
    public ActionResult Madpage() { 
      MadlibsWords myWord = new MadlibsWords();
      myWord.Noun = "Garage Door";
      return View(myWord);
    }
    [Route("/madform")]
    public ActionResult Madform(string noun)
    {
      MadlibsWords myWord = new MadlibsWords();
      myWord.Noun = noun;
      return View(myWord);
    }

  }
}