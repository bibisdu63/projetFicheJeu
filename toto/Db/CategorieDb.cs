using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFicheDeJeuLibrary.Db
{
    [Table]
    public class CategorieDb
    {
        [Column(Name="Id")]
        public int id;

        [Column(Name="categorie")]
        public string categorie;

    }
}
