﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample_Razor.Models;

namespace Sample_Razor.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductId = 1,
            Name = "Kayak",
            Description = "A boat  for one person",
            Category = "Watersports",
            Price= 275M
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }
    }
}