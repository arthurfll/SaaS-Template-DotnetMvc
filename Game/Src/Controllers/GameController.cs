using Microsoft.AspNetCore.Mvc;

namespace Game.Controllers
{
  public class GameController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    public IActionResult Match()
    {
      return View();
    }
  }
}

