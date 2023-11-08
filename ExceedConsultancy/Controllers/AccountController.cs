using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ExceedConsultancy.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUser> _userManager { get; }
        private SignInManager<ApplicationUser> _signInManager { get; }
        public RoleManager<Role> _roleManager { get; }

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("[controller]/[action]/{returnUrl?}")]
        [Route("Admin/Login/{returnUrl?}")]
        public IActionResult Login(string returnUrl)
        {
            LoginViewModel loginViewModel = new LoginViewModel() { RetuenUrl = returnUrl };
            return View(loginViewModel);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("[controller]/[action]")]
        [Route("Admin/Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (string.IsNullOrEmpty(model.UserName))
            {
                TempData["fail"] = "UserName Is Required.";
                return View();
            }
            else if (string.IsNullOrEmpty(model.Password))
            {
                TempData["fail"] = "Password Is Required.";
                return View();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.RetuenUrl))
                    {
                        return LocalRedirect(model.RetuenUrl);
                    }
                    else
                    {
                        return RedirectToAction("Home", "CPanel");
                    }
                }
                TempData["fail"] = "Invalid UserName Or Password.";
                return View();
            }
        }

        [HttpGet]
        [Authorize]
        [Route("Admin/Register")]
        [Route("[controller]/[action]")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [Route("Admin/Register")]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (string.IsNullOrEmpty(model.UserName))
            {
                TempData["fail"] = "UserName Is Required.";
                return View();
            }
            else if (string.IsNullOrEmpty(model.Password))
            {
                TempData["fail"] = "Password Is Required.";
                return View();
            }
            else if (model.ConfirmPassword != model.Password)
            {
                TempData["fail"] = "Password Mismatch.";
                return View();
            }
            else
            {
                var existing = await _userManager.FindByEmailAsync(model.Email);
                if (existing != null)
                {
                    TempData["fail"] = "Email Already Exists.";
                    return View();
                }

                var user = new ApplicationUser(model.Email)
                {
                    UserName = model.UserName,
                    Email = model.Email,
                };
                var results = await _userManager.CreateAsync(user, model.Password);
                if (!results.Succeeded)
                {
                    TempData["fail"] = "Something Went Wrong. Please Try Again.";
                    return View();
                }

                await _userManager.AddToRoleAsync(user, "Admin");
                await _userManager.AddClaimAsync(user, new System.Security.Claims.Claim("CanEdit", "CanEdit"));
                await _signInManager.SignInAsync(user, isPersistent: true);

                return RedirectToAction("index", "Home");
            }
        }

        [Authorize]
        public IActionResult ChangePassword()
        {
            ChangePasswordViewModel model = new ChangePasswordViewModel();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (string.IsNullOrEmpty(model.OldPassword))
            {
                TempData["fail"] = "Old Password Is Required.";
                return View(model);
            }
            if (string.IsNullOrEmpty(model.NewPassword))
            {
                TempData["fail"] = "New Password Is Required.";
                return View(model);
            }
            if (model.NewPassword != model.CondirmNewPassword)
            {
                TempData["fail"] = "New Password and Confirm Password should be the same.";
                return View(model);
            }

            var user = await _userManager.GetUserAsync(HttpContext.User);
            var response = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (!response.Succeeded)
            {
                TempData["fail"] = "Old Password is Incorrect";
            }
            else
            {
                TempData["success"] = "Password has been changed.";
            }
            return RedirectToAction("Home", "CPanel");
        }






        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }





        [HttpGet]
        [Route("[action]")]
        [AllowAnonymous]
        public IActionResult Denied()
        {
            return View();
        }


    }
}
