namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Community;

    [Authorize]
    public class CommunityController : Controller
    {
        private ICommunityService communityService;

        public CommunityController(ICommunityService communityService)
        {
            this.communityService = communityService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<CommunityAllViewModel> communities = await this.communityService.GetAllAsync();

            return View(communities);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                CommunityDetailsViewModel community = await this.communityService.GetForDetailsAsync(id);

                return View(community);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }
    }
}
