namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Community;

    public class CommunityController : Controller
    {
        private ICommunityService communityService;

        public CommunityController(ICommunityService communityService)
        {
            this.communityService = communityService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<CommunityAllViewModel> communities = await this.communityService.GetAllAsync();

            return View(communities);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                CommunityAllViewModel community = await this.communityService.FindAsync(id);

                return View(community);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }
    }
}
