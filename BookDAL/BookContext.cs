using BookDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDAL
{
    public class BookContext : DbContext
    {
        // DbSet est une collection de toutes les entités du context "BookContext"
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        // Constructeur de l'objet BookContext (Il utilise le constructeur de la classe dont il hérite : "DbContext")
        public BookContext(DbContextOptions options): base(options)
        {
        }

    }
}
