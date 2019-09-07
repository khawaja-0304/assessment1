using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASSESS.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASSESS.Controllers
{
    public class FIRSTController : Controller
    {
        private ASSESSMENT1Context A = null;
        public FIRSTController(ASSESSMENT1Context _ORM)
        {
            A = _ORM;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Addcategories()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Addcategories(Categories C)
        {
            A.Categories.Add(C);
            A.SaveChanges();
            return View();

        }
        public IActionResult Allcategories()
        {
            var allcategories = A.Categories.ToList();
            return View(allcategories);
        }

    }
}