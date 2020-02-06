using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            IEnumerable<Article> articles = db.Articles;
            return View(articles);
        }
        [HttpGet]
        public ActionResult AddArticle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddArticle(Article article)
        {
            db.Articles.Add(article);
            db.SaveChanges();
            ViewBag.AddStatus = true;
            return View();
        }
        public ActionResult ViewReiviws()
        {
            IEnumerable<Review> reviews = db.Reviews;
            return View(reviews);
        }
        [HttpGet]
        public ActionResult Reviws()
        {
            Review review = new Review();
            return View(review);
        }
        [HttpPost]
        public ActionResult Reviws(Review review)
        {
            if (ModelState.IsValid) {
                review.Time = DateTime.Now;
                db.Reviews.Add(review);
                db.SaveChanges();
                ViewBag.AddStatus = true;
            }
            
            return View();
        }
        [HttpGet]
        public  ActionResult Ancet()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult Ancet(string q1,string q2,string[] q3,string name,string color)
        {
            if(q1=="4" && q2=="Donald Trump"  && q3[0]=="true" && q3[2] == "true" && color.ToLower()=="yellow")
            {
                ViewBag.Res = true;
            }
            ViewBag.Name = name;
                return View("Result");
        }
    }
}