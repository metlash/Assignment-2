using BusTravels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTravels.Controllers
{
    public class HomeController : Controller
    {
        BusDbContext context = new BusDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(context.Buses);
        }


        [HttpPost]
        public ViewResult Index(Bus model)
        {
            //Code to save the customer data here
            ViewData["error"] = "Customer Data Update successfully";
            return View();
        }

        public ActionResult Create()
        {
            return View();

        }

        public ActionResult CreateAccount(Bus model)
        {
            context.Buses.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}