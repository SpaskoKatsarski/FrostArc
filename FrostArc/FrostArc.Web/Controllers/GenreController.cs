namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Genre;

    public class GenreController : Controller
    {
        private IGenreService genreService;

        public GenreController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<GenreAllViewModel> genres = await this.genreService.GetAllAsync();

            return View(genres);
        }
    }
}
