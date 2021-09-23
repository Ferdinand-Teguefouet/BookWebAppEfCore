using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDAL.Entities
{
    public class Author
    {
        //Définition des propriétés (différentes colonnes de la table Author de la base de données) de l'entité "Author" 
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string WebUrl { get; set; }
    }
}
