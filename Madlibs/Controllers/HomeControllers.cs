using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/zooform")]
    public ActionResult ZooForm() { return View(); }

    [HttpGet("/")]
    public ActionResult Madpage() { 
      MadlibsWords myWord = new MadlibsWords();
      // myWord.Noun = "Garage Door";
      return View(myWord);
    }
    [HttpPost("/madzoo")]
    public ActionResult MadZoo(string noun, string noun2, string noun3, string verb, string adverb, string adjective, string adjective2)
    {
      MadlibsWords myWord = new MadlibsWords();
      myWord.Noun = noun;
      myWord.Noun2 = noun2;
      myWord.Noun3 = noun3;
      myWord.Verb = verb;
      myWord.Adverb = adverb;
      myWord.Adjective = adjective;
      myWord.Adjective2 = adjective2;
      return View(myWord);
    }
  }
}