using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFicheDeJeuLibrary.Db
{
    /// <summary>
    /// classe permettant la gestion de la table liant Age et Fiche de jeu en base de donnée
    /// </summary>
    [Table]
    class FicheAge
    {
        [Column(Name = "Fiche")]
        public string id_Fiche;

        [Column(Name = "Age")]
        public string id_age;

        private EntityRef<AgeDb> _ages = new EntityRef<AgeDb>();
        [Association(Name = "FK_FicheAge_Age", IsForeignKey = true, Storage = "_ages", ThisKey = "id_age")]
        public AgeDb ages
        {
            get { return _ages.Entity; }
            set { _ages.Entity = value; }
        } 
    }
}
