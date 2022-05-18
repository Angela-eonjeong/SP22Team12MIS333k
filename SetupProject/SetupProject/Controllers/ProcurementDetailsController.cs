using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SetupProject.DAL;
using SetupProject.Models;

namespace SetupProject.Controllers
{
    public class ProcurementDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public ProcurementDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            return View(await _context.ProcurementDetails
                .Include(p => p.Book).ToListAsync());
        }




     
    }
}
