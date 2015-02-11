using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFicheDeJeuLibrary.Db
{
    /// <summary>
    /// classe permettant la gestion de la table Age en base de donnée
    /// </summary>
    [Table]
    public class AgeDb
    {
        [Column (Name="Id",IsPrimaryKey=true)]
        public int id;

        [Column (Name="AgeMin")]
        public int ageMin;

        [Column (Name="AgeMax")]
        public int ageMax;
    }
}
