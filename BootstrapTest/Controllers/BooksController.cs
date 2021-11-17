using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;

namespace BootstrapTest.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksCatalog _booksCatalog;

        public BooksController()
        {
            _booksCatalog = new BooksCatalog();

            _booksCatalog.AddBook(new Book
            {
                Title = "Цветы для Элджернона",
                Author = "Дэниел Киз",
                Genre = "фантастика, драма, психология",
                InventoryNumber = Guid.NewGuid().ToString(), 
                ISBN = "9780606340182",
                YearOfEdition = "1959"
            });

            _booksCatalog.AddBook(new Book
            {
                Title = "Пркосновение",
                Author = "Дэниел Киз",
                Genre = "фантастика, драма, психология",
                InventoryNumber = Guid.NewGuid().ToString(),
                ISBN = "9780709121435",
                YearOfEdition = "1968"
            });
        }

        public IActionResult Index()
        {
            var books = _booksCatalog.GetAll();
            ViewBag.Title = "Catalog Book";

            return View(books);
        }
    }
}
