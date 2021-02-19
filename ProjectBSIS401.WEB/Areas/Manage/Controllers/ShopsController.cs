using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Areas.Manage.ViewModels.shops;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace ProjectBSIS401.WEB.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ShopsController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;


        public ShopsController(DefaultDbContext context,IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            _config = config;
        }





        [HttpGet, Route("manage/shops")]
        [HttpGet, Route("manage/shops/index")]
        public IActionResult Index(int pageSize = 10, int pageIndex = 1, string keyword = "", string sTaTus = "Active")
        {
            Enum.TryParse(sTaTus, out Status status ); ;

            Page<Shop> result = new Page<Shop>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Shop> shopQuery = (IQueryable<Shop>)this._context.Shops.Where(s => s.Status == status);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                shopQuery = shopQuery.Where(s => s.BusinessName.Contains(keyword)
                                                || s.OwnerShop.Contains(keyword)
                                                || s.BusinessContact.Contains(keyword));
            }

            long queryCount = shopQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Shop> shops = shopQuery.ToList();

            result.Items = shops.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Shops = result,
               status = status
            });
        }



        //[Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/shop/delete/{shopId}")]
        public IActionResult Delete(Guid? shopId)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == shopId);

            if (shop != null)
            {
                this._context.Shops.Remove(shop);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet, Route("manage/shop/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = this._context.Shops.FirstOrDefault(m => m.Id == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }


        [HttpGet, Route("manage/shop/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == id);

            if (shop == null)
            {
                return RedirectToAction("Index");
            }

            if (shop != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = shop.Id.Value,
                        BusinessName = shop.BusinessName,
                        BusinessContact = shop.BusinessContact,
                        BusinessDescription = shop.BusinessDescription,
                        BusinessEmailAddress = shop.BusinessEmailAddress,
                        BusinessLocation = shop.BusinessLocation,
                        OpenAt = shop.OpenAt,
                        CloseAt = shop.CloseAt,
                        OwnerShop = shop.OwnerShop,
                        BusinessType = shop.BusinessType,
                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/shop/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.Id);

            if (shop != null)
            {
                shop.BusinessName = model.BusinessName;
                shop.BusinessContact = model.BusinessContact;
                shop.BusinessDescription = model.BusinessDescription;
                shop.BusinessEmailAddress = model.BusinessEmailAddress;
                shop.BusinessLocation = model.BusinessLocation;
                shop.OpenAt = model.OpenAt;
                shop.CloseAt = model.CloseAt;
                shop.BusinessType = model.BusinessType;

                this._context.Shops.Update(shop);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }



        [HttpPost, Route("manage/shop/unpublish")]
        public IActionResult Unpublish(ShopIdViewModel model)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.Id);
            if (shop != null)
            {
                shop.IsPublished = false;
                this._context.Shops.Update(shop);
                this._context.SaveChanges();
                return Ok();
            }
            return null;
        }



        [HttpPost, Route("manage/shop/publish")]
        public IActionResult Publish(ShopIdViewModel model)
        {
            var shop = this._context.Shops.FirstOrDefault(s => s.Id == model.Id);

            if (shop != null)
            {
                shop.IsPublished = true;
                this._context.Shops.Update(shop);
                this._context.SaveChanges();
                return Ok();
            }
            return null;
        }



        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("manage/shop/update-banner/{shopId}")]
        public IActionResult Banner(Guid? shopId)
        {
            return View(new BannerViewModel() { ShopId = shopId });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("manage/shop/update-banner")]
        public async Task<IActionResult> Banner(BannerViewModel model)
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


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("manage/shop/update-thumbnail/{shopId}")]
        public IActionResult Thumbnail(Guid? shopId)
        {
            return View(new ThumbnailViewModel() { ShopId = shopId });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("manage/shop/update-thumbnail")]
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
        [HttpGet, Route("manage/shop/update-logo/{shopId}")]
        public IActionResult Logo(Guid? shopId)
        {
            return View(new LogoViewModel() { ShopId = shopId });
        }
        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("manage/shop/update-logo")]
        public async Task<IActionResult> Logo(LogoViewModel model)
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