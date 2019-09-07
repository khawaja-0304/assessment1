using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASSESS.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASSESS.Controllers
{
    public class SECONDController : Controller
    {
        private ASSESSMENT1Context A1 = null;
        public  SECONDController(ASSESSMENT1Context _AS  )
        {
            A1 = _AS;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddPost()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddPost(Post P)
        {
            A1.Post.Add(P);
            A1.SaveChanges();
            return View();
        }
        public IActionResult AllPost()
        {
            var allpost = A1.Post.ToList();
            return View(allpost);
        }
    }
}