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

        public IActionResult Index()
        {
            return View();
        }
    }
}
