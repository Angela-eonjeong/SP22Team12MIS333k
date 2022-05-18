using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SetupProject.DAL;
using SetupProject.Models;

//Upddate this namespace to match your project name
namespace SetupProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
        
            var query = from r in _context.Promotions
                                          .Where(c => c.Status == true)

                        select r;

            List<Promotion> promotions = query.ToList();
            

            return View(promotions);
        }
    }
}
