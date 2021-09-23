using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishOn { get; set; }
        public int AuthorId { get; set; }
    }
}
