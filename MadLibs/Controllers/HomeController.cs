using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Splash() {return View();}

    [Route("/moon")]
    public ActionResult Form() {return View();}

    [Route("/madlibs")]
    public ActionResult MadLibs(string noun, string adjective, string adverb, string name, string bird, string liquid)
    {
      MadLibsVariable newMadLibs = new MadLibsVariable();
      newMadLibs.Noun = noun;
      newMadLibs.Adjective = adjective;
      newMadLibs.Adverb = adverb;
      newMadLibs.Name = name;
      newMadLibs.Bird = bird;
      newMadLibs.Liquid = liquid;
      return View(newMadLibs);
    }

    [Route("/mars")]
    public ActionResult FormMars() {return View();}  

    [Route("/madlibsmars")]
    public ActionResult MadLibsMars(string noun, string adjective, string adverb, string name, string bird, string liquid)
    {
      MadLibsMarsVariable newMadLibsMars = new MadLibsMarsVariable();
      newMadLibsMars.Noun = noun;
      newMadLibsMars.Adjective = adjective;
      newMadLibsMars.Adverb = adverb;
      newMadLibsMars.Name = name;
      newMadLibsMars.Bird = bird;
      newMadLibsMars.Liquid = liquid;
      return View(newMadLibsMars);
    }

  }
}