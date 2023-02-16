using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarketStore.Extension;
using OnlineMarketStore.Helpper;
using OnlineMarketStore.Models;
using OnlineMarketStore.ModelViews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineMarketStore.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly dbMarketsContext _context;
        public INotyfService _notyfService { get; }
        public AccountsController(dbMarketsContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if (customer != null)
                    return Json(data: "Phone number : " + Phone + " already in use");

                return Json(data: true);

            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (customer != null)
                    return Json(data: "Email : " + Email + " already in use");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [Route("my-account.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var customerId = HttpContext.Session.GetString("CustomerId");
            if (customerId != null)
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(customerId));
                if (customer != null)
                {
                    var lsorder = _context.Orders
                        .Include(x => x.TransactStatus)
                        .AsNoTracking()
                        .Where(x => x.CustomerId == customer.CustomerId)
                        .OrderByDescending(x => x.OrderDate)
                        .ToList();
                    ViewBag.Order = lsorder;
                    return View(customer);
                }

            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("register.html", Name = "Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register.html", Name = "Register")]
        public async Task<IActionResult> Register(RegisterVM account)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Customer customer = new Customer
                    {
                        FullName = account.FullName,
                        Phone = account.Phone.Trim().ToLower(),
                        Email = account.Email.Trim().ToLower(),
                        Password = (account.Password + salt.Trim()).ToMD5(),
                        Active = true,
                        Salt = salt,
                        CreateDate = DateTime.Now,
                        Birthday = DateTime.Now,
                        LastLogin = DateTime.Now
                    };
                    try
                    {
                        _context.Add(customer);
                        await _context.SaveChangesAsync();
                        //Lưu Session MaKh
                        HttpContext.Session.SetString("CustomerId", customer.CustomerId.ToString());
                        var customerId = HttpContext.Session.GetString("CustomerId");

                        //Identity
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,customer.FullName),
                            new Claim("CustomerId", customer.CustomerId.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        _notyfService.Success("Sign Up Success");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    catch
                    {
                        return RedirectToAction("Register", "Accounts");
                    }
                }
                else
                {
                    return View(account);
                }
            }
            catch
            {
                return View(account);
            }
        }
        [AllowAnonymous]
        [Route("login.html", Name = "Login")]
        public IActionResult Login(string returnUrl = null)
        {
            var customerId = HttpContext.Session.GetString("CustomerId");
            if (customerId != null)
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("login.html", Name = "Login")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(customer.UserName);
                    if (!isEmail) return View(customer);

                    var customerIn = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == customer.UserName);

                    if (customerIn == null) return RedirectToAction("Register");
                    string pass = (customer.Password + customerIn.Salt.Trim()).ToMD5();
                    if (customerIn.Password != pass)
                    {
                        _notyfService.Warning("Incorrect login information");
                        return View(customer);
                    }
                    //kiem tra xem account co bi disable hay khong

                    if (customerIn.Active == false)
                    {
                        return RedirectToAction("Notification", "Accounts");
                    }

                    //Luu Session MaKh
                    HttpContext.Session.SetString("CustomerId", customerIn.CustomerId.ToString());
                    var customerId = HttpContext.Session.GetString("CustomerId");

                    //Identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, customerIn.FullName),
                        new Claim("CustomerId", customerIn.CustomerId.ToString())
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    _notyfService.Success("Logged in successfully");
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
            }
            catch
            {
                return RedirectToAction("Register", "Accounts");
            }
            return View(customer);
        }
        [HttpGet]
        [Route("logout.html", Name = "Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerId");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM model)
        {
            try
            {
                var customerID = HttpContext.Session.GetString("CustomerId");
                if (customerID == null)
                {
                    return RedirectToAction("Login", "Accounts");
                }
                if (ModelState.IsValid)
                {
                    var customer = _context.Customers.Find(Convert.ToInt32(customerID));
                    if (customer == null) return RedirectToAction("Login", "Accounts");
                    var pass = (model.PasswordNow.Trim() + customer.Salt.Trim()).ToMD5();
                    {
                        string passnew = (model.Password.Trim() + customer.Salt.Trim()).ToMD5();
                        customer.Password = passnew;
                        _context.Update(customer);
                        _context.SaveChanges();
                        _notyfService.Success("Change password successfully");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                }
            }
            catch
            {
                _notyfService.Success("Password change failed");
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notyfService.Success("Password change failed");
            return RedirectToAction("Dashboard", "Accounts");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCustomer(int id, [Bind("CustomerId,FullName,Birthday,Avatar,Address,Email,Phone,CreateDate,Password,Salt,LastLogin,Active")] Customer customer, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    customer.FullName = Utilities.ToTitleCase(customer.FullName);
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string image = Utilities.SEOUrl(customer.FullName+"-"+customer.CustomerId) + extension;
                        customer.Avatar = await Utilities.UploadFile(fThumb, @"customers", image.ToLower());
                    }
                    if (string.IsNullOrEmpty(customer.Avatar))
                    {
                        customer.Avatar = "default.jpg";
                    }
                    customer.LastLogin = DateTime.Now;

                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Update Successful");
                }
                catch (DbUpdateConcurrencyException)
                {
                        return NotFound();
                }
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View(customer);
        }
    }
}
