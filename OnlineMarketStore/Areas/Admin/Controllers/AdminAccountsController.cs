using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineMarketStore.Areas.Admin.Models;
using OnlineMarketStore.Extension;
using OnlineMarketStore.Helpper;
using OnlineMarketStore.Models;
using PagedList.Core;

namespace OnlineMarketStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminAccountsController : Controller
    {
        private readonly dbMarketsContext _context;

        public INotyfService _notyfService { get; }

        public AdminAccountsController(dbMarketsContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        //ChangePassword
       
        // GET: Admin/AdminAccounts
        public IActionResult Index(int RoleID = 0)
        {


            List<Account> lsAccounts = new List<Account>();
            if (RoleID != 0)
            {
                lsAccounts = _context.Accounts.Include(p => p.Role).AsNoTracking().Where(x => x.RoleId == RoleID).OrderBy(x => x.AccountId).ToList();
            }
            else
            {
                lsAccounts = _context.Accounts.Include(p => p.Role).AsNoTracking().OrderByDescending(x => x.AccountId).ToList();
            }


            ViewBag.CurrentRoleID = RoleID;

            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName", RoleID);


            return View(lsAccounts);
        }
        public IActionResult Filtter(int RoleID = 0)
        {
            var url = $"/Admin/AdminAccounts?RoleID={RoleID}";
            if (RoleID == 0)
            {
                url = $"/Admin/AdminAccounts";
            }
            return Json(new { status = "success", redirectUrl = url });
        }
        // GET: Admin/AdminAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/AdminAccounts/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName");
            return View();
        }

        // POST: Admin/AdminAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountId,Phone,Email,Password,Salt,Active,FullName,RoleId,LastLogin,CreateDate")] Account account)
        {
            if (ModelState.IsValid)
            {

                account.Salt = Utilities.GetRandomKey();
                account.Password = (account.Password + account.Salt.Trim()).ToMD5();
                account.CreateDate = DateTime.Now;
                account.LastLogin = DateTime.Now;


                _context.Add(account);
                await _context.SaveChangesAsync();
                _notyfService.Success("Successful New Creation");
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName", account.RoleId);
            return View(account);
        }

        // GET: Admin/AdminAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName", account.RoleId);
            return View(account);
        }

        // POST: Admin/AdminAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountId,Phone,Email,Password,Salt,Active,FullName,RoleId,LastLogin,CreateDate")] Account account)
        {
            if (id != account.AccountId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    account.Password = account.Password;

                    account.LastLogin = DateTime.Now;

                    _context.Update(account);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Update Successful");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.AccountId))
                    {
                        _notyfService.Success("Update error");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName", account.RoleId);
            return View(account);
        }

        // GET: Admin/AdminAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Admin/AdminAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            _notyfService.Success("Delete Successful");
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.AccountId == id);
        }
    }
}
