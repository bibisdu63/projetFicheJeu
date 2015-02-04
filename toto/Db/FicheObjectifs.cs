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
    /// classe permettant la gestion de la table liant Fiche et objectifs en base de donnée
    /// </summary>
    [Table]
    class FicheObjectifs
    {
        [Column(Name = "fiche")]
        public string id_Fiche;

        [Column(Name = "objectif")]
        public string id_Objectifs;

        private EntityRef<Objectifs> _objectifs = new EntityRef<Objectifs>();
        [Association(Name = "FK_FicheObjectifs_Objectifs", IsForeignKey = true, Storage = "_objectifs", ThisKey = "id_Objectifs")]
        public Objectifs objectifs
        {
            get { return _objectifs.Entity; }
            set { _objectifs.Entity = value; }
        } 
    }
}
