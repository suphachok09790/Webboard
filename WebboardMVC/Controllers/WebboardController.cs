﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebboardMVC.Models.db;
using WebboardMVC.ViewModels;

namespace WebboardMVC.Controllers
{
    public class WebboardController : Controller
    {
        private thaivbWebboardContext _db;

        public WebboardController(thaivbWebboardContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var ks = _db.Kratoos.OrderByDescending(k => k.RecordDate).Include(c => c.Category).Where(u => u.IsShow == true);
            if (ks == null)
            {
                return NotFound();
            }
            return View(await ks.ToListAsync());
        }
        public IActionResult Create()
        {
            ViewData["CategoriesLists"] = new SelectList(_db.Categories, "CategoryId","CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Kratoo data)
        {
            if (ModelState.IsValid)
            {
                data.RecordDate = DateTime.Now;
                data.ViewCount = 1;
                data.ReplyCount = 0;
                data.UserIp = HttpContext.Connection.RemoteIpAddress.ToString();
                data.IsShow = true;

                _db.Kratoos.Add(data);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriesLists"] = new SelectList(_db.Categories, "CategoryId", "CategoryName",data.CategoryId);
            return View(data);

        }

        public async Task<IActionResult> KratoosByCategoryId(int id)
        {
            var ks = _db.Kratoos.OrderByDescending(k => k.RecordDate)
                .Include(c => c.Category)
                .Where(u => u.IsShow == true)
                .Where(i => i.CategoryId == id);
            if (ks == null)
            {
                return NotFound();
            }
            return View("Index", await ks.ToListAsync());
        }
        public async Task<IActionResult> Search(string q)
        {
            var ks = _db.Kratoos
                .OrderByDescending(k => k.RecordDate)
                .Include(c => c.Category)
                .Where(u => u.IsShow == true)
                .Where(i => i.KratooTopic.Contains(q));
            if (ks == null)
            {
                return NotFound();
            }
            return View("Index",await ks.ToListAsync());
        }
        public async Task<IActionResult> KratooComments(int id)
        {
            var kc = await _db.Kratoos
                .Include(c => c.Category)
                .Where(i => i.IsShow == true)
                .FirstOrDefaultAsync(k => k.Kid == id);

            if (kc ==null)
            {
                return NotFound();
            }
            if (id != kc.Kid)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var viewcount = kc.ViewCount;
                    viewcount++;
                    kc.ViewCount = viewcount;

                    _db.Update(kc);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var result = _db.Kratoos.Any(k => k.Kid == id);
                    if (result ==false)
                    {
                        return NotFound();
                    }
                }

            }

            IQueryable<Comment> cs = _db.Comments
                .OrderBy(c => c.CommentNo)
                .Where(i => i.IsShow == true)
                .Where(j => j.Kid == id);

            var viewmodel = new KratooCommentsViewModel()
            {
                Kratoo = kc,
                CommentsLists = cs
            };

            ViewData["KratooCommentsViewModel"] = viewmodel;

            return View();


        }

    }
}
