using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectBSIS401.WEB.Areas.Manage.ViewModels.pricings;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

namespace ProjectBSIS401.WEB.Areas.Manage.Controllers
{
    [Area("manage")]
    public class PricingsController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;


        public PricingsController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;
        }

        [HttpGet, Route("manage/pricings")]
        [HttpGet, Route("manage/pricings/index")]
        public IActionResult Index(int pageSize = 10, int pageIndex = 1, string keyword = "")
        {
            Page<Pricing> result = new Page<Pricing>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Pricing> priQuery = (IQueryable<Pricing>)this._context.Pricings.Include(p => p.PricingContents).OrderBy(p => p.UpdatedAt);
            if (string.IsNullOrEmpty(keyword) == false)
            {
                priQuery = priQuery.Where(p => p.Title.Contains(keyword)
                                            );
            }
           

            long queryCount = priQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Pricing> pricings = priQuery.ToList();

            result.Items = pricings.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;
            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }
            return View(new IndexViewModel {

                Pricings = result
            });
        }

    
        [HttpPost, Route("/manage/pricings/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            Pricing pricing = new Pricing
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Title = model.Title,
                Month = model.Month,
                Price = model.Price
            };

            this._context.Pricings.Add(pricing);
            this._context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpPost,Route("/manage/pricings/create-content-pricing")]
        public IActionResult CreatePricingContent(PricingContentViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return RedirectPermanent("Index");
            }
            int Limit = 4;
            var pricing = this._context.Pricings.Include(p => p.PricingContents).FirstOrDefault(p => p.Id == model.PricingId);
            if(pricing != null)
            {
                if(pricing.PricingContents.Count != Limit)
                {
                    PricingContent pricingContent = new PricingContent
                    {
                        Id = Guid.NewGuid(),
                        UpdatedAt = DateTime.UtcNow,
                        CreatedAt = DateTime.UtcNow,
                        PricingId = model.PricingId,
                        Content = model.Content
                    };

                    this._context.PricingContents.Add(pricingContent);
                    this._context.SaveChanges();

                }
                else
                {
                    return RedirectToAction("Index");
                }

            }

            return RedirectToAction("Index");

        }


        //[Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/pricings/delete/{pricingId}")]
        public IActionResult Delete(Guid? pricingId)
        {
            var pricing = this._context.Pricings.FirstOrDefault(s => s.Id == pricingId);

            if (pricing != null)
            {
                this._context.Pricings.Remove(pricing);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }


        [HttpGet, Route("manage/pricings/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricing = this._context.Pricings.Include(p => p.PricingContents).FirstOrDefault(p => p.Id == id);
            if (pricing == null)
            {
                return NotFound();
            }

            return View(pricing);
        }


        [HttpGet, Route("manage/pricings/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {
            var pricing = this._context.Pricings.FirstOrDefault(s => s.Id == id);
            if (pricing == null)
            {
                return RedirectToAction("Index");
            }
            if (pricing != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = pricing.Id,
                        Title = pricing.Title,
                        Price = pricing.Price,
                        Month = pricing.Month,
                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/pricings/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var pricing = this._context.Pricings.FirstOrDefault(s => s.Id == model.Id);

            if (pricing != null)
            {
                pricing.Title = model.Title;
                pricing.Month = model.Month;
                pricing.Price = model.Price;
                this._context.Pricings.Update(pricing);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }

    }
}