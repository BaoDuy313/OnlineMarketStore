using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineMarketStore.Areas.Admin.Models;
using OnlineMarketStore.Extension;
using OnlineMarketStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineMarketStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AccountController : Controller
    {
        private readonly dbMarketsContext _context;
        public INotyfService _notyfService { get; }
        public AccountController(dbMarketsContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        [Route("/admin/login.html", Name = "AdminLogin")]
        public IActionResult AdminLogin(string returnUrl = null)
        {
            var accountId = HttpContext.Session.GetString("AccountId");
            if (accountId != null) return RedirectToAction("Index", "Home", new { Area = "Admin" });
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("/admin/login.html", Name = "AdminLogin")]
        public async Task<IActionResult> AdminLogin(LoginViewModel model, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    Account account = _context.Accounts
                    .Include(p => p.Role)
                    .SingleOrDefault(p => p.Email.ToLower() == model.UserName.ToLower().Trim());

                    if (account == null)
                    {
                        ViewBag.Error = "Thông tin đăng nhập chưa chính xác";
                    }
                    string pass = (model.Password + account.Salt.Trim()).ToMD5();
                    // + kh.Salt.Trim()
                    if (account.Password.Trim() != pass)
                    {
                        ViewBag.Error = "Thông tin đăng nhập chưa chính xác";
                        return View(model);
                    }
                    //đăng nhập thành công

                    //ghi nhận thời gian đăng nhập
                    account.LastLogin = DateTime.Now;
                    _context.Update(account);
                    await _context.SaveChangesAsync();


                    var accountId = HttpContext.Session.GetString("AccountId");
                    //identity
                    //luuw seccion Makh
                    HttpContext.Session.SetString("AccountId", account.AccountId.ToString());

                    //identity
                    var userClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, account.FullName),
                        new Claim(ClaimTypes.Email, account.Email),
                        new Claim("AccountId", account.AccountId.ToString()),
                        new Claim("RoleId", account.RoleId.ToString()),
                        new Claim(ClaimTypes.Role, account.Role.RoleName)
                    };
                    var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                    await HttpContext.SignInAsync(userPrincipal);



                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
            }
            catch
            {
                return RedirectToAction("AdminLogin", "Account", new { Area = "Admin" });
            }
            return RedirectToAction("AdminLogin", "Account", new { Area = "Admin" });
        }
        [Route("/admin/logout.html", Name = "AdminLogout")]
        public IActionResult AdminLogout()
        {
            try
            {
                HttpContext.SignOutAsync();
                HttpContext.Session.Remove("AccountId");
                return RedirectToAction("AdminLogin", "Account", new { Area = "Admin" });
            }
            catch
            {
                return RedirectToAction("AdminLogin", "Account", new { Area = "Admin" });
            }
        }
        public IActionResult ChangePassword()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName");
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var account = _context.Accounts.AsNoTracking().SingleOrDefault(x => x.Email == model.Email);
                if (account == null) return RedirectToAction("Login", "Accounts");
                var pass = (model.PasswordNow.Trim() + account.Salt.Trim()).ToMD5();
                {
                    string passnew = (model.Password.Trim() + account.Salt.Trim()).ToMD5();
                    account.Password = passnew;
                    account.LastLogin = DateTime.Now;
                    _context.Update(account);
                    _context.SaveChanges();
                    _notyfService.Success("Đổi mật khẩu thành công");
                    return RedirectToAction("Login", "Accounts", new { Area = "Admin" });
                }
            }


            return View();
        }

    }
}
