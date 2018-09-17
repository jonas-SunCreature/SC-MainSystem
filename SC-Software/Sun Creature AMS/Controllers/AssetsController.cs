using Sun_Creature_AMS.Models;
using Sun_Creature_AMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sun_Creature_AMS.Controllers
{
    public class AssetsController : Controller
    {
        private ApplicationDbContext _context;

        public AssetsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Assets
        public ActionResult Index()
        {
            var assets = new AssetsViewModel
            {
                Assets = _context.Assets.ToList(),
                NewAssetViewModel = new NewAssetViewModel {
                    AssetDetails = _context.AssetsDetails.ToList()
                }
        };
            return View(assets);
        }

        public ActionResult Details(int id)
        {
            var asset = _context.Assets.SingleOrDefault(a => a.Id == id);

            if (asset == null)
            {
                return HttpNotFound();
            }
            return View(asset);
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}