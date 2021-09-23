using BookDAL;
using BookWebApp.Interface;
using BookWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bcontext;

        public BookService(BookContext bcontext)
        {
            _bcontext = bcontext;
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            return _bcontext.Books.Select(b => new BookModel
            {
                BookId = b.BookId,
                Title = b.Title,
                Description = b.Description,
                PublishOn = b.PublishOn,
                AuthorId = b.AuthorId
            });
        }
    }
}
