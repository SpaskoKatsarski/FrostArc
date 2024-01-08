namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Platform;

    [Authorize]
    public class PlatformController : Controller
    {
        private IPlatformService platformService;

        public PlatformController(IPlatformService platformService)
        {
            this.platformService = platformService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<PlatformAllViewModel> platforms = await this.platformService.GetAllAsync();

            return View(platforms);
        }

        public async Task<IActionResult> Details(int id)
        {
            PlatformDetailsViewModel platform = await this.platformService.GetDetailsAsync(id);

            return View(platform);
        }
    }
}
