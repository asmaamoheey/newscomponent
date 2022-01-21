using compents.Models;
using compents.Resporities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace compents.Controllers
{
    public class NewsController : Controller
    {
        //[Route("api/")]
        private readonly INews _newsrepositry;
        
        public NewsController(INews newsrepo)
        {
            _newsrepositry = newsrepo;
        }
        
        public ActionResult Index()
        {
            var comnews =_newsrepositry.Getallnews();
            return View(comnews);
        }

        public ActionResult Details(int id)
        {
            var comnews = _newsrepositry.GetnewsId(id);
            return View(comnews);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(News comnews)
        {
            if (ModelState.IsValid)
            {
                _newsrepositry.createnews(comnews);
                _newsrepositry.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var comnews = _newsrepositry.GetnewsId(id);
            return View(comnews);
        }

        [HttpPost]
        public ActionResult Edit(News comnews)
        {
            if (ModelState.IsValid)
            {
                _newsrepositry.Updatecomponentnews(comnews);
                _newsrepositry.Save();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(comnews);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var comnews = _newsrepositry.GetnewsId(id);
            return View(comnews);
        }

        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            _newsrepositry.Deletecomponentnews(id);
            _newsrepositry.Save();
            return RedirectToAction("Index", "Home");
        }

    }
}
