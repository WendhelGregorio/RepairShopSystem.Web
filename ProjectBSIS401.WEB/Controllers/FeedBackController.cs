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
        [HttpGet, Route("~/feedback/list-feedbacks/{shopId}")]
        public IActionResult ListFeedback(Guid? shopId)
        {
            var shopFeedbacks = this._context.FeedBacks.Where(s => s.ShopId == shopId)
                                                       .OrderByDescending(s => s.UpdatedAt)
                                                       .ToList();

            int count = shopFeedbacks.Count();
          
           
            return View(new IndexViewModel()
            {
                ShopFeedBacks = shopFeedbacks,
                Count = count,
               
            });
        }


        [HttpPost,Route("~/feedback/shop-feedbacks")]
        public IActionResult ShopFeedBack(FeedBackViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid Input");
                return Redirect("~/shop/shop-items/" + model.ShopId + "/" + model.UserId);
            }

            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.ShopId);


            if(user != null && shop != null)
            {
                FeedBack feedBack = new FeedBack()
                {
                    Id = Guid.NewGuid(),
                    UserId = model.UserId,
                    ShopId = model.ShopId,
                    FullName = model.FullName,
                    Comment = model.Comment,
                    Email = model.Email,
                    Rating = model.Rating,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                this._context.FeedBacks.Add(feedBack);
                this._context.SaveChanges();

            }
            ViewBag.Success = "Message send successfully";
            return Redirect("~/shop/shop-items/" + model.ShopId + "/" + model.UserId);
        }

    }

}