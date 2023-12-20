namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Game;

    [Authorize]
    public class GameController : Controller
    {
        private IGameService gameService;

        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All(string? genreId)
        {
            IEnumerable<GameListViewModel> games = await this.gameService.GetAllAsync(genreId);

            return View(games);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                GameDetailsViewModel game = await this.gameService.GetDetailsAsync(id);

                return View(game);
            }
            catch (ArgumentException ae)
            {
                return Json(ae.Message);
            }
        }
    }
}
