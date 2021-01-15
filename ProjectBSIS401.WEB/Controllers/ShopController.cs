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

        [HttpGet,Route("shop/index")]
        public IActionResult Index(int pageIndex = 1,string keyword = null)
        {
            var shop = this._context.Shops.Include(s => s.ShopServices).Include(s => s.Bookings)
                                          .OrderBy(s => s.CreatedAt)
                                          .Take(30)
                                          .ToList();

            if (string.IsNullOrEmpty(keyword) == false)
            {
                 var shopQuery = this._context.Shops.Where(s => s.BusinessName.ToLower().Contains(keyword.ToLower())
                                       || s.BusinessEmailAddress.ToLower().Contains(keyword.ToLower()));
            }

            return View(new IndexViewModel
            {
                Shops = shop,
                Keyword = keyword
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


               
            return View();

        }

        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("shop/shop-create")]
        public IActionResult CreateShop(CreateShopViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

         
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebUser.UserId);
      
            if (user != null)
            {
                var userRole = this._context.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);
                if (user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.Active && userRole.Role == Infrastructures.Domain.Enums.Role.User)
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
                        Id = user.Id.Value,
                        UserId = user.Id.Value,
                        Status = Infrastructures.Domain.Enums.Status.Active,
                        BusinessDescription = model.BusinessDescription,
                        OwnerShop = user.UserName,

                    };
                    this._context.Shops.Add(shop);
                    this._context.SaveChanges();

                 
                }
              
            }
            return View(model);
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("shop/shop-profile/{shopId}")]
        public IActionResult ShopProfile(Guid? shopId)
        {
            if (shopId == null)
            {
                return NotFound();
            }
            var shop = _context.Shops.Include(s => s.Bookings).FirstOrDefault(s => s.Id == shopId);

            if (shop == null)
            {
                return NotFound();
            }

            //var shop = this._context.Shops.Include(s => s.Bookings);
            return View(shop);
        }

      



        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("shop/shop-profile-feed")]
        public List<Booking> FeedBookings(int pageIndex)
        {
            int skip = (int)(3 * (pageIndex - 1));
            return this._context.Bookings
                                .Where(c => c.Id != null)
                                .OrderBy(c => c.TimeStamps)
                                .Skip(skip)
                                .Take(30)
                                .ToList();
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




        [HttpGet, Route("shop/delete")]
        public IActionResult Delete(Guid? costumerId)
        {
            var costumer = this._context.Bookings.FirstOrDefault(c => c.Id == costumerId);

            if (costumer != null)
            {
                costumer.Description = null;
                costumer.UserName = null;

                this._context.Bookings.Remove(costumer);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("/shop/shop-update-thumbnail/{shopId}")]
        public IActionResult Thumbnail(Guid? shopId)
        {
            return View(new LogoImageViewModel() { ShopId = shopId });
        }


        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("/shop/shop-update-thumbnail")]
        public async Task<IActionResult> Thumbnail(LogoImageViewModel model)
        {
            //Check file size of the uploaded thumbnail
            //reject if the file is greater than 2mb
            var fileSize = model.Logo.Length;
            if ((fileSize / 1048576.0) > 2)
            {
                ModelState.AddModelError("", "The file you uploaded is too large. Filesize limit is 2mb.");
                return View(model);
            }
            //Check file type of the uploaded thumbnail
            //reject if the file is not a jpeg or png
            if (model.Logo.ContentType != "image/jpeg" && model.Logo.ContentType != "image/png")
            {
                ModelState.AddModelError("", "Please upload a jpeg or png file for the thumbnail.");
                return View(model);
            }
            //Formulate the directory where the file will be saved
            //create the directory if it does not exist
            var dirPath = _env.WebRootPath + "/image/shops/thumbnail/" + model.ShopId.ToString();
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            //always name the file thumbnail.png
            var filePath = dirPath + "/thumbnail.png";
            if (model.Logo.Length > 0)

            {
                //Open a file stream to read all the file data into a byte array
                byte[] bytes = await FileBytes(model.Logo.OpenReadStream());
                //load the file into the third party (ImageSharp) Nuget Plugin                
                using (Image<Rgba32> image = Image.Load(bytes))
                {
                    //use the Mutate method to resize the image 150px wide by 150px long
                    image.Mutate(x => x.Resize(150, 150));
                    //save the image into the path formulated earlier
                    image.Save(filePath);
                }
            }
            return RedirectToAction("Thumbnail", new { ShopId = model.ShopId });
        }


        //[HttpGet, Route("/shop/shop-reservation/{userId}")]
        //public IActionResult Reservation(Guid? userId)
        //{
        //    var user = this._context.Users.FirstOrDefault(u => u.Id == userId);


        //    if (user == null)
        //    {
        //        ModelState.AddModelError("", "Please login your account");
        //        return RedirectToAction("~/home");
        //    }



        //    return View();
        //}

        //[HttpPost, Route("/shop/shop-reservation")]
        //public IActionResult Reservation(ReserveViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "Information is required");
        //        return View();
        //    }

        //    var user = this._context.Users.FirstOrDefault(u => u.Id == WebUser.UserId);
        //    if (user != null)
        //    {

        //    }



        //    return View();
        //}

        [HttpGet,Route("/shop/shop-rating-star")]
        public IActionResult ShopRatingStar()
        {
            return View();
        }

        //[HttpPost, Route("/shop/shop-rating-star")]
        //public IActionResult ShopRatingStar()
        //{
        //    return View();
        //}



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
