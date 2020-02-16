using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimpleOnlineStoreRepositoryCore.Data.Entities;
using SimpleOnlineStoreRepositoryCore.Data.Models;

namespace OnlineStore.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserManager { get; }
        private SignInManager<AppUser> SignInManager { get; }
        private IMapper AutoMapper { get; }
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            AutoMapper = mapper;
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
            
            return Ok();
        }
    }
}