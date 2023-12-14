namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authentication;

    using FrostArc.Data.Models;
    using FrostArc.Web.ViewModels.User;

    public class UserController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = new ApplicationUser()
            {
                DisplayName = model.DisplayName
            };

            await this.userManager.SetEmailAsync(user, model.Email);
            await this.userManager.SetUserNameAsync(user, model.Email);

            IdentityResult result = await this.userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await this.signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Login(string? returnUrl)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Fix result
            var result =
                await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                return View(model);
            }

            return Redirect(model.ReturnUrl ?? "/Home/Index");
        }
    }
}
