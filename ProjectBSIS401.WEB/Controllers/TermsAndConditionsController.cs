using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.ViewModels.tac;

namespace ProjectBSIS401.WEB.Controllers
{
    public class TermsAndConditionsController : Controller
    {
        private readonly DefaultDbContext _context;
        public TermsAndConditionsController(DefaultDbContext context)
        {
            _context = context;
         
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet,Route("~/tac/terms-and-conditions")]
        public IActionResult TAC()
        {
            var tacId = Guid.Parse("0919fe8a-f05b-4f1f-a0ee-db37664fad38");
            var tac = this._context.TermAndConditions.FirstOrDefault(t => t.Id == tacId);
            if (tac == null)
            {
                return BadRequest();
            }

            return View(new TacViewModel
            {
                TermAndCondition = tac
            });
        }
    }
}