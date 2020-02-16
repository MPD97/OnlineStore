using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleOnlineStoreRepositoryCore.Data.Entities;
using SimpleOnlineStoreRepositoryCore.Data.Models;

namespace OnlineStore.Controllers
{
    public class AccountController : LoggableControllerBase
    {
        private UserManager<AppUser> UserManager { get; }
        private SignInManager<AppUser> SignInManager { get; }
        private IMapper Mapper { get; }
        private ILogger Logger { get; }
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper, ILogger logger)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            Mapper = mapper;
            Logger = logger;
        }
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            var user = Mapper.Map<AppUser>(model);
            user.UserName = model.Email;

            var result = await UserManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await SignInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to register new user");
        }
    }
}