using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.feedback;
using ProjectBSIS401.WEB.ViewModels.operation;

namespace ProjectBSIS401.WEB.Controllers
{
    public class FeedBackController : Controller
    {
        private readonly ILogger<FeedBackController> _logger;
        private readonly DefaultDbContext _context;
        public FeedBackController(DefaultDbContext context, ILogger<FeedBackController> logger)
        {
            _context = context;
            _logger = logger;
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

        [HttpPost,Route("feedback/add-comment-with-rating")]
        public IActionResult AddCommentWithRating(CommentWithRatingViewModel model)
        {

            var user = _context.Users.FirstOrDefault(p => p.Id == model.UserId);

            var shop = _context.Shops.FirstOrDefault(p => p.Id == model.ShopId);

            if(shop != null)
            {
                if (shop.RatingsEnabled == true)
                {
                    var userRating = _context.Ratings.FirstOrDefault(s => s.UserId == model.UserId && s.Id == model.ShopId);
                    if (userRating == null)
                    {
                        userRating = new Rating()
                        {
                            Score = model.Score,
                            ShopId = model.ShopId,
                            UserId = model.UserId,
                            IsCounted = true,
                            MaskUser = false,
                        };

                        _context.Ratings.Add(userRating);
                        _context.SaveChanges();
                    }

                    if (shop.CommentsEnabled == true)
                    {
                        var userComment = new Comment()
                        {
                            Content = model.Comment,
                            IsPublished = true,
                            ShopId = model.ShopId,
                            UserId = model.UserId,
                            MaskUser = false,
                            LikesEnabled = false,
                            Likes = 0
                        };

                        _context.Comments.Add(userComment);
                        _context.SaveChanges();
                    }

                    //return RedirectPermanent("~/shop/shop-items/" + model.ShopId);
                    return RedirectPermanent("~/shop/" + model.ShopId);
                }
            }
            return NotFound();

        }

        [HttpPost("feedback/likes")]
        public OperationViewModel AddDeductLike(LikeViewModel model)
        {
            var user = _context.Users.FirstOrDefault(p => p.Id == model.UserId);

            var shop = _context.Shops.FirstOrDefault(p => p.Id == model.ShopId);

            if (shop != null)
            {
                if (shop.LikesEnabled == true)
                {
                    var userLike = _context.Likes.FirstOrDefault(r => r.UserId == model.UserId && r.ShopId == model.ShopId);
                    if (userLike == null && model.IsLiked)
                    {
                        userLike = new Like()
                        {
                            ShopId = model.ShopId,
                            UserId = model.UserId,
                        };

                        _context.Likes.Add(userLike);

                        shop.Likes = shop.Likes + 1;
                        _context.Shops.Update(shop);
                    }
                    else if (userLike != null && model.IsLiked == false)
                    {
                        _context.Likes.Remove(userLike);

                        shop.Likes = shop.Likes - 1;
                        _context.Shops.Update(shop);
                    }
                    else
                    {

                    }
                    _context.SaveChanges();

                    return new OperationViewModel()
                    {
                        Code = "Ok",
                        Data = new { Likes = shop.Likes, IsLiked = model.IsLiked }
                    };
                }
                else
                {
                    return new OperationViewModel()
                    {
                        Code = "Fail",
                        Messages = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("", "Likes are disabled for this item.") },
                        Data = new { Likes = shop.Likes, IsLiked = false }
                    };

                }
            
            }
            else
            {
                return new OperationViewModel()
                {
                    Code = "Fail",
                    Messages = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("", "Target shop is not found.") },
                    Data = new { IsLiked = false }
                };
            }
        }
    }

}