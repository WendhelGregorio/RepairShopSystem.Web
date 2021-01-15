using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.feedback;

namespace ProjectBSIS401.WEB.Controllers
{
    public class FeedBackController : Controller
    {
        private readonly DefaultDbContext _context;
        public FeedBackController(DefaultDbContext context)
        {
            _context = context;
        }
        [HttpGet, Route("/feedback/index")]
        public IActionResult Index()
        {
            List <FeedBack> feedBacks = this._context.FeedBacks.ToList();

            return View(new IndexViewModel()
            {
                FeedBacks = feedBacks
            });
        }

        [HttpGet,Route("/feedback/feedbacks-infos")]
        public ActionResult FeedBackInfo()
        {
            return View();
        }

        [HttpPost, Route("/feedback/feedbacks-infos")]
        public ActionResult FeedBackInfo(FeedBackViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid Input");
                return View();
            }

            var feedback = new FeedBack()
            {
                Comment = model.Comment,
                Email = model.Email,
                FullName = model.FullName,
                Id = Guid.NewGuid(),
            };

            this._context.FeedBacks.Add(feedback);
            this._context.SaveChanges();

            return View();
        }

    }

}