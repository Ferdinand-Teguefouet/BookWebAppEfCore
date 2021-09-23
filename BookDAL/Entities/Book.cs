using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDAL.Entities
{
    public class Book
    {
        //Définition des propriétés (différentes colonnes de la table Book de la base de données) de l'entité "Book" 
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishOn { get; set; }
        public int AuthorId { get; set; }
    }
}
