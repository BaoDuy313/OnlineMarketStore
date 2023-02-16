using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineMarketStore.Extension;
using OnlineMarketStore.Helpper;
using OnlineMarketStore.Models;
using OnlineMarketStore.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly dbMarketsContext _context;
        public INotyfService _notyfService { get; }
        public CheckoutController(dbMarketsContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> Cart
        {
            get
            {
                var cart = HttpContext.Session.Get<List<CartItem>>("Cart");
                if (cart == default(List<CartItem>))
                {
                    cart = new List<CartItem>();
                }
                return cart;
            }
        }
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            //Lay gio hang ra de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart");
            var customerId = HttpContext.Session.GetString("CustomerId");
            OrderVM model = new OrderVM();
            if (customerId != null)
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(customerId));
                model.CustomerId = customer.CustomerId;
                model.FullName = customer.FullName;
                model.Email = customer.Email;
                model.Phone = customer.Phone;
                model.Address = customer.Address;
            }
            //ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
            ViewBag.Cart = cart;
            return View(model);
        }

        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(OrderVM orderVM)
        {
            //Lay ra gio hang de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart");
            var customerId = HttpContext.Session.GetString("CustomerId");
            OrderVM model = new OrderVM();
            if (customerId != null)
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(customerId));
                model.CustomerId = customer.CustomerId;
                model.FullName = customer.FullName;
                model.Email = customer.Email;
                model.Phone = customer.Phone;
                model.Address = customer.Address;
                customer.Address = orderVM.Address;

                _context.Update(customer);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    //Khoi tao don hang
                    Order order = new Order();
                    order.CustomerId = model.CustomerId;
                    order.Adress = model.Address;
                    order.OrderDate = DateTime.Now;
                    order.TransactStatusId = 1;//Don hang moi
                    order.Deleted = false;
                    order.Note = Utilities.StripHTML(model.Note);
                    order.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));

                    _context.Add(order);
                    _context.SaveChanges();
                    //tao danh sach don hang

                    foreach (var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = order.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Quantity = item.amount;
                        orderDetail.Quantity = item.amount;
                        orderDetail.Total = order.TotalMoney;
                        orderDetail.Price = (int?)item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;

                        _context.Add(orderDetail);
                    }
                    _context.SaveChanges();
                    //clear gio hang
                    HttpContext.Session.Remove("Cart");
                    //Xuat thong bao
                    _notyfService.Success("Order Success");
                    //cap nhat thong tin khach hang
                    return RedirectToAction("Success");


                }
            }
            catch(Exception ex)
            {
                //ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
                ViewBag.Cart = cart;
                return View(model);
            }
            //ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "Location", "Name");
            ViewBag.Cart = cart;
            return View(model);
        }
        [Route("order-success.html", Name = "Success")]
        public IActionResult Success()
        {
            try
            {
                var customerId = HttpContext.Session.GetString("CustomerId");
                if (string.IsNullOrEmpty(customerId))
                {
                    return RedirectToAction("Login", "Accounts", new { returnUrl = "/order-success.html" });
                }
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(customerId));
                var order = _context.Orders
                    .Where(x => x.CustomerId == Convert.ToInt32(customerId))
                    .OrderByDescending(x => x.OrderDate)
                    .FirstOrDefault();
                OrderSuccessVM successVM = new OrderSuccessVM();
                successVM.FullName = customer.FullName;
                successVM.OrderID = order.OrderId;
                successVM.Phone = customer.Phone;
                successVM.Address = customer.Address;
                //successVM.PhuongXa = GetNameLocation(order.Ward.Value);
                //successVM.TinhThanh = GetNameLocation(order.District.Value);
                return View(successVM);
            }
            catch
            {
                return View();
            }
        }
        //public string GetNameLocation(int idlocation)
        //{
        //    try
        //    {
        //        var location = _context.Locations.AsNoTracking().SingleOrDefault(x => x.LocationId == idlocation);
        //        if (location != null)
        //        {
        //            return location.NameWithType;
        //        }
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }
        //    return string.Empty;
        //}
    }
}
