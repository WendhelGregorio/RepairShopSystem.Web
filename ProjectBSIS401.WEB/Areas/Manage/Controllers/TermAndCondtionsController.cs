using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Areas.Manage.ViewModels.termAndcondtions;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

namespace ProjectBSIS401.WEB.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TermAndCondtionsController : Controller
    {
        private readonly DefaultDbContext _context;
      
        public TermAndCondtionsController(DefaultDbContext context)
        {
            _context = context;
         
        }

        [HttpGet, Route("manage/terms-and-conditions")]
        [HttpGet, Route("manage/terms-and-conditions/index")]
        public IActionResult Index(int pageSize = 10, int pageIndex = 1, string keyword = "")
        {
            Page<TermAndCondition> result = new Page<TermAndCondition>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<TermAndCondition> tacQuery = (IQueryable<TermAndCondition>)this._context.TermAndConditions.OrderBy(p => p.UpdatedAt);
            if (string.IsNullOrEmpty(keyword) == false)
            {
                tacQuery = tacQuery.Where(p => p.Title.Contains(keyword)
                                            );
            }


            long queryCount = tacQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            int skip = (int)(pageSize * (pageIndex - 1));
            List<TermAndCondition> termAndConditions = tacQuery.ToList();

            result.Items = termAndConditions.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;
            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }
            return View(new IndexViewModel
            {

                TermAndConditions = result
            });
        }


        [HttpGet,Route("manage/terms-and-conditions/create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, Route("manage/terms-and-conditions/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Title and Description is REQUIRED");
                return View(model);
            }
           
            var termAndDescription = new TermAndCondition()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Description = model.Description.ToString(),
                IsPublished = true,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                
            };
            this._context.TermAndConditions.Add(termAndDescription);
            this._context.SaveChanges();



            return RedirectToAction("Index");
        }

    }
}