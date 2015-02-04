using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFicheDeJeuLibrary.Db
{
    /// <summary>
    /// classe permettant la gestion de la table objectifs en base de donnée
    /// </summary>
    [Table]
    class Objectifs
    {
        [Column (Name="Id")]
        public int id;

        [Column(Name="Objectifs")]
        public string objectif;

    }
}
