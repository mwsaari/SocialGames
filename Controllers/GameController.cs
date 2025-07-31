using Microsoft.AspNetCore.Mvc;

namespace SocialGames.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
