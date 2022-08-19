using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebboardMVC.Models;
using WebboardMVC.Models.db;
using WebboardMVC.ViewModels;

namespace WebboardMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly thaivbWebboardContext _db;

        public HomeController(thaivbWebboardContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var viewmodel = new MainIndexViewModel()
            {
                CategoriesLists = _db.Categories,
                KraoosLists = _db.Kratoos
                .OrderByDescending(r => r.RecordDate)
                .Take(10)
                .Include(c =>c.Category)
                .Where(i => i.IsShow == true)
            };

            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
