﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimpleOnlineStoreRepositoryCore.Data.Entities;
using SimpleOnlineStoreRepositoryCore.Data.Models;

namespace OnlineStore.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserManager { get; }
        private SignInManager<AppUser> SignInManager { get; }
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody]RegisterModel model)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest("Model is not valid");
            }
            return Ok();
        }
    }
}