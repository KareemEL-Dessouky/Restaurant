using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.ViewModels.Login;
using Restaurant.ViewModels.Register;

namespace Restaurant.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        //Register for customers 
        public IActionResult CustomerRegister()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CustomerRegister(UserRegister userVM) // UserRegister it's viewModel have data of registration
        {
            if(ModelState.IsValid) { 
               
                // create function don't take viewModel, it's only take model so:
                ApplicationUser userModel = new ApplicationUser();
                
                userModel.UserName = userVM.UserName;
                userModel.Email = userVM.Email;
                userModel.PasswordHash = userVM.Password;
                userModel.Address = userVM.Address;

                // save datat in database, by using Store if result true will save data
                // don't forget hash input password
                IdentityResult result = await userManager.CreateAsync(userModel, userVM.Password);

                if (result.Succeeded)
                {
                    //create cookie authantication to make user do login,
                    //cookie can be session/persistent if false/true
                    await signInManager.SignInAsync(userModel, false);
                    return RedirectToAction("Index", "Products");
                }
                else
                {
                    // remeber there are errors, but this errors it's IEnumerable 
                    // and ModelError take a string, so use foreach 
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            
            return View(userVM);
        }

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLogin userVM)
        {
            if (ModelState.IsValid)
            {
                //check if user is exist
                ApplicationUser userModel = await userManager.FindByNameAsync(userVM.UserName);

                if (userModel != null)
                {
                    await signInManager.PasswordSignInAsync(userModel, userVM.Password, userVM.RememberMe, false);
                    return RedirectToAction("Index", "Products");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or Password is invalid;");
                }
            }
            return View(userVM);
        }
    }
}
