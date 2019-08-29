using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mutuales2020.Web.Data.Entities;
using Mutuales2020.Web.Helpers;
using Mutuales2020.Web.Models;
using System.Threading.Tasks;

namespace Mutuales2020.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;

        public AccountController(IUserHelper userHelper)
        {
            _userHelper = userHelper;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var busqueda = await _userHelper.GetUserByEmailAsync(model.Username);

                var result = await _userHelper.LoginAsync(model);

                if (result.Succeeded)
                {
                    //if (Request.Query.Keys.Contains("ReturnUrl"))
                    //{
                    //    return Redirect(Request.Query["ReturnUrl"].First());
                    //}
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "User or password not valid.");
                model.Password = string.Empty;
            }
            return View(model);
        }

        public async Task<User> Create(AddUserViewModel model)
        {
            var user = new User
            {
                Address = model.Address,
                Document = model.Document,
                Email = model.Username,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UserName = model.Username
            };

            var result = await _userHelper.AddUserAsync(user, model.Password);
            if (result != IdentityResult.Success)
            {
                return null;
            }

            ModelState.AddModelError(string.Empty, "User with this mail already exists.");

            var newUser = await _userHelper.GetUserByEmailAsync(model.Username);
            //await _userHelper.AddUserToRoleAsync(newUser, "Owner");
            return newUser;
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
