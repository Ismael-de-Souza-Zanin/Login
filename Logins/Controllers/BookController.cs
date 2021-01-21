using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logins.Models;

namespace GoldenBooks.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            List<Book> list = new List<Book>();
            list.Add(new Book
            {
                Code = 001,
                Name = "The Little Prince",
                Author = "Antoine de Saint-Exupéry",
                Description = "The nice and criative book for any people",
                NumberOfPages = 96,
                PublishingCompany = "Edit. Aster",
                Price = 11.90
            });


            return View(list);
        }
    }
}
