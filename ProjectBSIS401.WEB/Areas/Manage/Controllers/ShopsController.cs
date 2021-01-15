using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Areas.Manage.ViewModels.shops;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

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
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string sTaTus = "Active")
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

            var service = this._context.Services.FirstOrDefault(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
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
    }
}