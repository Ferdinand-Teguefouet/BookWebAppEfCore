using BookWebApp.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bService;

        public BookController(IBookService bService)
        {
            _bService = bService;
        }

        public IActionResult Index()
        {
            return View(_bService.GetAllBooks());
        }
    }
}
