using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarketStore.Models;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.Controllers
{
    public class NewsController : Controller
    {
        private readonly dbMarketsContext _context;
      
        public NewsController(dbMarketsContext context)
        {
            _context = context;
        }
        [Route("news.html", Name = ("News"))]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var lsNews = _context.News.AsNoTracking().OrderByDescending(x => x.PostId);

            PagedList<News> models = new PagedList<News>(lsNews, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;

            return View(models);
        }
        [Route("/news/{Alias}-{id}.html", Name = "NewsDetail")]
        public IActionResult Details(int id)
        {
            var news = _context.News.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (news == null)
            {
                return RedirectToAction("Index");
            }
            var lsnews = _context.News
            .AsNoTracking()
            .Where(x => x.Published == true && x.PostId != id)
            .Take(3)
            .OrderByDescending(x => x.CreateDate).ToList();
            ViewBag.lsnews = lsnews;
            return View(news);
        }
    }
}
