using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFicheDeJeuLibrary.Db
{
    [Table]
    class AgeDb
    {
        [Column (Name="Id")]
        public int id;

        [Column (Name="AgeMin")]
        public int ageMin;

        [Column (Name="AgeMax")]
        public int ageMax;
    }
}
