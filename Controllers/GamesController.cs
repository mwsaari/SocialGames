using Microsoft.AspNetCore.Mvc;
using SocialGames.Models;
using SocialGames.Models.Games;

namespace SocialGames.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Games"] = new List<IGame>()
            {
                new SecretSocieties(),
                new OneNight(),
            };
            return View();
        }
    }
}
