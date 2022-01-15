using Meta.Models;
using Meta.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Controllers
{
    public class DashboardController : Controller
    {
        private readonly MetaDBContext _context;

        public DashboardController(MetaDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           var vm= _context.Contents.Include(x=>x.Type).Include(x=>x.ContentLanguages).ToList();
            return View(vm);
        }
        public IActionResult Add()
        {
            AddVM vm = new()
            {
                Categories = _context.Categories.Include(x=>x.CategoryLanguages).ToList(),
                Directors=_context.Directors.ToList(),
                Actors=_context.Actors.ToList(),
                Languages=_context.Languages.ToList()
            };
            return View(vm);
        }
    }
}
