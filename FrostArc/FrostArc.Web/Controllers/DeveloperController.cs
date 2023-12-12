namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Developer;

    //TODO Implement
    public class DeveloperController : Controller
    {
        private IDeveloperService developerService;

        public DeveloperController(IDeveloperService developerService)
        {
            this.developerService = developerService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<DeveloperAllViewModel> devs = await this.developerService.GetAllAsync();

            return View(devs);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            DeveloperDetailsViewModel dev = await this.developerService.GetDetailsAsync(id);

            return View(dev);
        }
    }
}
