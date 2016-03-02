using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS.Web.Models;
using FMS.Web.Services;
using FMS.Web.ViewModels.Administrator;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace FMS.Web.Controllers
{
    public class AdministratorController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AdministratorController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
             RoleManager<IdentityRole> roleManager,
            IEmailSender emailSender,
            ISmsSender smsSender,
            ILoggerFactory loggerFactory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
        }


        //
        // GET: /Account/Register
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Users()
        {     


            return View(_userManager.Users);
        }

        // GET: /Account/Register
        [HttpGet]
        [AllowAnonymous]
        public IActionResult EditUser()
        {


            return View(new UserViewModel());
        }

        //
        // GET: /Account/Register
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AddUser()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(UserViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            await _userManager.CreateAsync(new ApplicationUser()
            {
                UserName = model.Email,
                Email = model.Email
            });
            await Task.Delay(1);
            // If we got this far, something failed, redisplay form
            return View(model);
        }

    }
}
