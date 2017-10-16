using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RESTaurant.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RESTaurant.Controllers
{
    public class HomeController : Controller
    {
        private RESTaurantContext _context;
        public HomeController(RESTaurantContext context)
        {
            _context=context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("process")]
        public IActionResult process(Review review)
        {
            System.Console.WriteLine(review);
            System.Console.WriteLine(review.Reviewer_name);
            System.Console.WriteLine(ModelState.IsValid);
            System.Console.WriteLine(review.create_at);
            if(ModelState.IsValid)
            {
                _context.Add(review);
                _context.SaveChanges();
                return RedirectToAction("reviews");
            }

            return View("Index");
            
        }
        [HttpGet]
        [Route("reviews")]
        public IActionResult reviews()
        {
            List<Review> Reviews=_context.review.OrderByDescending(r=>r.create_at).ToList();
            ViewBag.Reviews=Reviews;
            return View();
        }
    }
}
