using BookDAL.Entities;
using BookWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Interface
{
    public interface IBookService
    {
        IEnumerable<BookModel> GetAllBooks();
    }
}
