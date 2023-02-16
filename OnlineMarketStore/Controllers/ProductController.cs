using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineMarketStore.Models;
using PagedList.Core;

namespace OnlineMarketStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbMarketsContext _context;
        public ProductController(dbMarketsContext context)
        {
            _context = context;
        }
        [Route("shop.html", Name = ("ShopProduct"))]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
           
            var lsProducts = _context.Products.Include(p => p.Cat).AsNoTracking().OrderByDescending(x => x.DateCreated);
            PagedList<Product> models = new PagedList<Product>(lsProducts.AsQueryable(), pageNumber, pageSize);

            
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        [Route("category/{Alias}.html", Name = ("ListProduct"))]
        public IActionResult List(string Alias, int page = 1)
        {
            try
            {
                var pageSize = 10;
                var cate = _context.Categories.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);

                var lsProducts = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == cate.CatId)
                    .OrderByDescending(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsProducts, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = cate;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }
        public IActionResult Filtter(int CatID = 0)
        {
            var url = $"/Product?CatID={CatID}";
            if (CatID == 0)
            {
                url = $"/Product";
            }
            return Json(new { status = "success", redirectUrl = url });
        }
        [HttpGet]
        [Route("/{Alias}-{id}.html", Name = ("ProductDetails"))]
        public IActionResult Detail(int id)
        {
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products
                        .AsNoTracking()
                        .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true)
                        .Take(4)
                        .OrderByDescending(x => x.DateCreated)
                        .ToList();
                ViewBag.Product = lsProduct;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Product");
            }

        }
    }
}
