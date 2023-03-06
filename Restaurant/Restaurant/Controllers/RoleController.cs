using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.ViewModels.Role;

namespace Restaurant.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        // DI
        public RoleController(RoleManager<IdentityRole> RoleManager)
        {
            roleManager = RoleManager;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoleViewModel roleVM)
        {
            if(ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole();
                role.Name = roleVM.RoleName;
                IdentityResult result = await roleManager.CreateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Products");
                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
      
            return View(roleVM);
        }
    }
}
