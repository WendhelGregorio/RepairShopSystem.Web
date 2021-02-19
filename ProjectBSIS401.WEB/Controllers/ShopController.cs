using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels.shop;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace ProjectBSIS401.WEB.Controllers
{
    public class ShopController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;

        public ShopController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;
        }


        [HttpGet, Route("shop/index")]
        [HttpGet,Route("shop/index/{userId}")]
        public IActionResult Index(Guid? userId,int pageIndex = 1, string keyword = "", string btypes = "")
        {
            Shop result = new Shop();
            Enum.TryParse(btypes, out BusinessType btypeses);
            IQueryable<Shop> shopQuery = (IQueryable<Shop>)this._context.Shops.Where(s => s.BusinessType == btypeses);

            var shop = this._context.Shops.Include(s => s.Bookings)
                                          .OrderBy(s => s.BusinessName)
                                          .Take(30)
                                          .ToList();

            if (string.IsNullOrEmpty(keyword) == false)
            {
                shopQuery = this._context.Shops.Where(s => s.BusinessName.ToLower().Contains(keyword.ToLower())
                                       || s.BusinessEmailAddress.ToLower().Contains(keyword.ToLower()));

            }
            return View(new IndexViewModel
            {
                UserId = userId,
                Shops = shop,
                Keyword = keyword,
                businessType = btypeses

            });

        }
        [HttpGet, Route("shop/shop-items/{shopId}")]
        [HttpGet,Route("shop/shop-items/{shopId}/{userId}")]
        public IActionResult ShopItems(Guid? shopId,Guid? userId)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == shopId);
            //var user = this._context.Users.FirstOrDefault(u => u.Id == WebUser.UserId);
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            var shopServices = this._context.ShopServices.Where(u => u.ShopId == shop.Id).ToList();
            if (shop == null)
            {

                return View();
            }
            if(shopServices == null)
            {
                return Redirect("~/shop/index");
            }

            return View(new ShopIdViewModel {
                Shop = shop,
                ShopServices = shopServices,
                ShopId = shopId,
                UserId = userId
                
            });
        }

        [HttpGet, Route("shop/shop-items-info/{shopServiceId}/{shopId}")]
        public IActionResult ShopItemInfo(Guid? shopServiceId,Guid? shopId)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == shopId);
            var info = this._context.ShopServices.FirstOrDefault(ss => ss.Id == shopServiceId);
            if(info == null)
            {
                return NotFound();
            }

            return View(new ShopShopServicesDetails
            {   ShopId  = shopId,
                ShopServices = info
            });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("shop/shop-create/{userId}")]
        public IActionResult CreateShop(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return BadRequest();
            }
            return View(new CreateShopViewModel {
                UserId = userId,
                OwnerShop = user.UserName,
            });

        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("shop/shop-create")]
        public IActionResult CreateShop(CreateShopViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId && u.UserName == model.OwnerShop);
            if (user == null)
            {
                    Shop shop = new Shop()
                    {

                        BusinessContact = model.BusinessContact,
                        BusinessEmailAddress = model.BusinessEmailAddress,
                        BusinessLocation = model.BusinessLocation,
                        BusinessName = model.BusinessName,
                        BusinessType = model.BusinessType,
                        OpenAt = model.OpenAt,
                        CloseAt = model.CloseAt,
                        Id = Guid.NewGuid(),
                        UserId = model.UserId,
                        Status = Infrastructures.Domain.Enums.Status.Active,
                        BusinessDescription = model.BusinessDescription,
                        OwnerShop = model.OwnerShop,

                    };
                    this._context.Shops.Add(shop);
                    this._context.SaveChanges();     
            }
            else
            {
                ViewBag.Error = "You already have shop";
                return View("~/shop/shop-create/" + model.UserId);
            }
            return View(model);
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("shop/shop-home/{shopId}")]
        public IActionResult ShopHome(Guid? shopId)
        {
            if (shopId == null)
            {
                return NotFound();
            }
            var shops = this._context.Shops.FirstOrDefault(s => s.Id == shopId);

            var booking = this._context.Bookings.Where(b => b.ShopId == shops.Id)
                                                .OrderByDescending(b => b.UpdatedAt)
                                                .ToList();

            var shopServices = this._context.ShopServices.Where(ss => ss.ShopId == shops.Id)
                                                         .OrderByDescending(ss => ss.UpdatedAt)
                                                         .ToList();


            var shopFeedbacks = this._context.FeedBacks.Where(s => s.ShopId == shopId)
                                                       .OrderByDescending(s => s.UpdatedAt)
                                                       .ToList();

            int count = shopFeedbacks.Count();
            int serviceCount = shopServices.Count();
            int costumerCounts = booking.Count();
            if (shops == null)
            {
                return NotFound();
            }
            if(booking == null)
            {
                return NotFound();
            }
            if(shopServices == null)
            {
                return NotFound();
            }
            return View(new ShopHomeViewModel
            {
                ShopServices = shopServices,
                Shops = shops,
                Bookings = booking,
                Count = count,
                serviceCount = serviceCount,
                costumerCount = costumerCounts
            });
            
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("shop/shop-update-profile/{shopId}")]
        public IActionResult ShopUpdateProfile(Guid? shopId)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == shopId);

            if (shop != null)
            {
                return View(new ShopUpdateProfileViewModel()
                {
                    ShopId = shop.Id.Value,
                    OwnerShop = shop.OwnerShop,
                    BusinessContact = shop.BusinessContact,
                    BusinessEmailAddress = shop.BusinessEmailAddress,
                    BusinessLocation = shop.BusinessLocation,
                    BusinessName = shop.BusinessName,
                    BusinessType = shop.BusinessType,
                    CloseAt = shop.CloseAt,
                    OpenAt = shop.OpenAt,
                    BusinessDescription = shop.BusinessDescription,
                });
            }
            return View(shop);
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("shop/shop-update-profile")]
        public IActionResult ShopUpdateProfile(ShopUpdateProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.ShopId);

            if(shop != null)
            {
                shop.OwnerShop = model.OwnerShop;
                shop.BusinessContact = model.BusinessContact;
                shop.BusinessEmailAddress = model.BusinessEmailAddress;
                shop.BusinessLocation = model.BusinessLocation;
                shop.BusinessName = model.BusinessName;
                shop.BusinessType = model.BusinessType;
                shop.OpenAt = model.OpenAt;
                shop.CloseAt = model.CloseAt;
                shop.BusinessDescription = model.BusinessDescription;


                this._context.Shops.Update(shop);
                this._context.SaveChanges();
            }

          
             
            return RedirectToAction("shop/shop-profile" + shop.Id);
        }
        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("/shop/update-banner/{shopId}")]
        public IActionResult Banner(Guid? shopId)
        {
            return View(new BannerImageViewModel() { ShopId = shopId });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("/shop/update-banner")]
        public async Task<IActionResult> Banner(BannerImageViewModel model)
        {
            var fileSize = model.Banner.Length;
            if ((fileSize / 1048576.0) > 5)
            {
                ModelState.AddModelError("", "The file you uploaded is too large. Filesize limit is 5mb.");
                return View(model);
            }
            if (model.Banner.ContentType != "image/jpeg" && model.Banner.ContentType != "image/png")
            {
                ModelState.AddModelError("", "Please upload a jpeg or png file for the banner.");
                return View(model);
            }
            var dirPath = _env.WebRootPath + "/image/shops/banner/" + model.ShopId.ToString();
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            var filePath = dirPath + "/banner.png";
            if (model.Banner.Length > 0)
            {
                byte[] bytes = await FileBytes(model.Banner.OpenReadStream());
                using (Image<Rgba32> image = Image.Load(bytes))
                {
                    image.Mutate(x => x.Resize(750, 300));
                    image.Save(filePath);
                }
            }
            return RedirectToAction("Banner", new { ShopId = model.ShopId });
        }


        [HttpGet, Route("shop/change-status-booking/{status}/{bookingId}/{shopId}")]
        public IActionResult ChangeStatus(string status, Guid? bookingId,Guid? shopId)
        {

            var rStatus = (ReserveStatus)Enum.Parse(typeof(ReserveStatus), status, true);
            var statusUserBooking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (statusUserBooking != null)
            {
                statusUserBooking.ReserveStatus = rStatus;
                this._context.Bookings.Update(statusUserBooking);
                this._context.SaveChanges();
            }
            return Redirect("~/shop/shop-profile/" + shopId);
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("/shop/shop-update-thumbnail/{shopId}")]
        public IActionResult Thumbnail(Guid? shopId)
        {
            return View(new ThumbnailViewModel() { ShopId = shopId });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("/shop/shop-update-thumbnail")]
        public async Task<IActionResult> Thumbnail(ThumbnailViewModel model)
        {
            var fileSize = model.Thumbnail.Length;
            if ((fileSize / 1048576.0) > 2)
            {
                ModelState.AddModelError("", "The file you uploaded is too large. Filesize limit is 2mb.");
                return View(model);
            }
            if (model.Thumbnail.ContentType != "image/jpeg" && model.Thumbnail.ContentType != "image/png")
            {
                ModelState.AddModelError("", "Please upload a jpeg or png file for the thumbnail.");
                return View(model);
            }
            var dirPath = _env.WebRootPath + "/image/shops/thumbnail/" + model.ShopId.ToString();
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            var filePath = dirPath + "/thumbnail.png";
            if (model.Thumbnail.Length > 0)
            {
                byte[] bytes = await FileBytes(model.Thumbnail.OpenReadStream());
                using (Image<Rgba32> image = Image.Load(bytes))
                {
                    image.Mutate(x => x.Resize(750, 300));
                    image.Save(filePath);
                }
            }
            return RedirectToAction("Thumbnail", new { ShopId = model.ShopId });
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("/shop/update-logo/{shopId}")]
        public IActionResult Logo(Guid? shopId)
        {
            return View(new LogoImageViewModel() { ShopId = shopId });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("/shop/update-logo")]
        public async Task<IActionResult> Logo(LogoImageViewModel model)
        {
            var fileSize = model.Logo.Length;
            if ((fileSize / 1048576.0) > 3)
            {
                ModelState.AddModelError("", "The file you uploaded is too large. Filesize limit is 3mb.");
                return View(model);
            }
            if (model.Logo.ContentType != "image/jpeg" && model.Logo.ContentType != "image/png")
            {
                ModelState.AddModelError("", "Please upload a jpeg or png file for the logo.");
                return View(model);
            }
            var dirPath = _env.WebRootPath + "/image/shops/logo/" + model.ShopId.ToString();
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            var filePath = dirPath + "/logo.png";
            if (model.Logo.Length > 0)
            {
                byte[] bytes = await FileBytes(model.Logo.OpenReadStream());
                using (Image<Rgba32> image = Image.Load(bytes))
                {
                    image.Mutate(x => x.Resize(750, 300));
                    image.Save(filePath);
                }
            }
            return RedirectToAction("Logo", new { ShopId = model.ShopId });
        }


        #region Helpers
        public async Task<byte[]> FileBytes(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        #endregion
    }
}
