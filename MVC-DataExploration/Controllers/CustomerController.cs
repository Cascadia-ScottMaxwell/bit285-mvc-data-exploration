﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer myCustomer)
        {
            db.Customers.Add(myCustomer);
            db.SaveChanges();

            return View("Index", db.Customers);
        }
    }
}