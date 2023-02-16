using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarketStore.Models;
using OnlineMarketStore.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly dbMarketsContext _context;
        public INotyfService _notyfService { get; }
        public OrderController(dbMarketsContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [HttpPost]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var customerId = HttpContext.Session.GetString("CustomerId");
                if (string.IsNullOrEmpty(customerId)) return RedirectToAction("Login", "Accounts");
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(customerId));
                if (customer == null) return NotFound();
                var order = await _context.Orders
                    .Include(x => x.TransactStatus)
                    .FirstOrDefaultAsync(m => m.OrderId == id && Convert.ToInt32(customerId) == m.CustomerId);
                if (order == null) return NotFound();

                var orderDetail = _context.OrderDetails
                    .Include(x => x.Product)
                    .AsNoTracking()
                    .Where(x => x.OrderId == id)
                    .OrderBy(x => x.OrderDetailId)
                    .ToList();
                OrderDetailVM orderVM = new OrderDetailVM();
                orderVM.Order = order;
                orderVM.OrderDetail = orderDetail;
                return PartialView("Details", orderVM);

            }
            catch
            {
                return NotFound();
            }
        }
    }
}
