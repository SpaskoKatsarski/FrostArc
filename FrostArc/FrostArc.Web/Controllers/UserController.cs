namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Data.Models;

    public class UserController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private IUserStore<ApplicationUser> userStore;

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
