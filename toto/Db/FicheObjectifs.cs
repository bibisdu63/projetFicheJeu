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
    public class FicheObjectifs
    {
        [Column(Name = "fiche",IsPrimaryKey=true)] public string id_Fiche;
        private EntityRef<FicheDeJeuDB> _fiche = new EntityRef<FicheDeJeuDB>();
        [Association(Name = "FK_FicheAge_Fiche", IsForeignKey = true, Storage = "_fiche", OtherKey="id", ThisKey = "id_Fiche")]
        public FicheDeJeuDB fiche
        {
            get { return _fiche.Entity; }
            set { _fiche.Entity = value; }
        }

        [Column(Name = "objectif")] public string id_Objectifs;

        private EntityRef<Objectifs> _objectifs = new EntityRef<Objectifs>();
        [Association(Name = "FK_FicheObjectifs_Objectifs", IsForeignKey = true, Storage = "_objectifs",OtherKey="id", ThisKey = "id_Objectifs")]
        public Objectifs objectifs
        {
            get { return _objectifs.Entity; }
            set { _objectifs.Entity = value; }
        } 
    }
}
