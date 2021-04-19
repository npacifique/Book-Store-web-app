﻿using System;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Book> data { get; set; }
        public HomeController(BookstoreContext ctx) => data = new Repository<Book>(ctx);

        public ViewResult Index()
        {
            // get a book at random - updated for SQLite
            Book random = null;
            while (random == null)
            {
                int bookID = new Random().Next(1, data.Count + 1);
                random = data.Get(bookID);
            }

            return View(random);
        }

        public ContentResult Register()
        {
            return Content("Registration has not been implemented yet. It is implemented in chapter 16.");
        }

    }
}