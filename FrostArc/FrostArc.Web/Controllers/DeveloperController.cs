namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Developer;

    [Authorize]
    public class DeveloperController : Controller
    {
        private IDeveloperService developerService;

        public DeveloperController(IDeveloperService developerService)
        {
            this.developerService = developerService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<DeveloperAllViewModel> devs = await this.developerService.GetAllAsync();

            return View(devs);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            DeveloperDetailsViewModel dev = await this.developerService.GetDetailsAsync(id);

            return View(dev);
        }
    }
}
