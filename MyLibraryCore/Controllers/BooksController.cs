﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibraryCore.Models;
using MyLibraryCore.Repository;

namespace MyLibraryCore.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookRepos = null;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var books = _bookRepos.GetBookById(id);
            return View(books);
        }

        [HttpGet]

        public IActionResult Create()
        {
            //ViewBag.Genre = new SelectList(GetGenre(), "Text","Value");
            ViewBag.Genre = new List<SelectListItem>()
           {
               new SelectListItem(){Text="Horror",Value="Horror"},
               new SelectListItem(){Text="Comdey",Value="Comdey"},
               new SelectListItem(){Text="Thriller",Value="Thriller"},
               new SelectListItem(){Text="Drama",Value="Drama"}
           };

            return View();
        }

        [HttpPost]

        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
           // ViewBag.Genre = new SelectList(GetGenre(), "Text","Value");
            _bookRepos.CreateBook(book);

            return RedirectToAction("Index", "Books");
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var book = _bookRepos.GetBookById(id);
            ViewBag.Genre = new List<SelectListItem>()
           {
               new SelectListItem(){Text="Horror",Value="Horror"},
               new SelectListItem(){Text="Comdey",Value="Comdey"},
               new SelectListItem(){Text="Thriller",Value="Thriller"},
               new SelectListItem(){Text="Drama",Value="Drama"}
           };

            return View("Edit",book);
        }

        [HttpPost]
        public IActionResult Edit(int? id,Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookRepos.UpdateBook(id,book);

            return RedirectToAction("Index", "Books");
        }

        public IActionResult Delete(int? id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookRepos.DeleteBook(id);

            return RedirectToAction("Index", "Books");
        }

        public IActionResult NewIndex()
        {
            return View();
        }



        //[NonAction]
        //public IEnumerable<SelectListItem> GetGenre()
        //{
        //    return new List<SelectListItem>
        //    {
        //        new SelectListItem{Text="Select your genre"},
        //        new SelectListItem{Text="Horror",Value="Horror"},
        //        new SelectListItem{Text="Comic",Value="Comic"},
        //        new SelectListItem{Text="Thriller",Value="Thriller"}
        //    };
        //}
    }
}
