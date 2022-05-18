using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SetupProject.DAL;
using SetupProject.Models;
using Microsoft.AspNetCore.Authorization;
using SetupProject.Utilities;
using System.Net.Mail;
using System.Net;

namespace SetupProject.Controllers
{

    public class ShippingCostsController : Controller
    {
        private readonly AppDbContext _context;

        public ShippingCostsController(AppDbContext context)
        {
            _context = context;
        }

        //add method for manager changing shipping costs
        [Authorize(Roles = "Admin")]
        public ActionResult ChangeShippingCosts()
        {
            ShippingCosts currentShipCosts = _context.ShippingCosts.FirstOrDefault();

            //return View();
            return View(currentShipCosts);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult ChangeShippingCosts(int ShipCostId, string FirstBookShipCost, string AddBookShipCost)
        {
            if (FirstBookShipCost == null || AddBookShipCost == null)//if the admin doesn't enter a value for both
            {
                ViewBag.InvalidCost = "You must enter values for both shipping costs";
                return View();
            }
            else //check if text entered is a decimal
            {
                Decimal decFirstBookShipCost;
                Decimal decAddBookShipCost;

                ShippingCosts currentShipCosts = _context.ShippingCosts.FirstOrDefault(c => c.ShippingCostsID == ShipCostId);

                try
                {
                    decFirstBookShipCost = Convert.ToDecimal(FirstBookShipCost);
                    currentShipCosts.FirstBookShipCost = decFirstBookShipCost;
                }
                catch
                {
                    ViewBag.InvalidFirstBook = "You must enter a valid decimal for the first cost";
                    return View();
                }
                try
                {
                    decAddBookShipCost = Convert.ToDecimal(AddBookShipCost);
                    currentShipCosts.AddBookShipCost = decAddBookShipCost;
                }
                catch
                {
                    ViewBag.InvalidAddBook = "You must enter a valid decimal for the additional cost";
                    return View();
                }

                _context.Update(currentShipCosts);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
        }
    }
}
