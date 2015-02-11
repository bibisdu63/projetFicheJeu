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
    public class FicheAge
    {



        [Column(Name = "Fiche", IsPrimaryKey=true)] public string id_Fiche;
        private EntityRef<FicheDeJeuDB> _fiche = new EntityRef<FicheDeJeuDB>();
        [Association(Name = "FK_FicheAge_Fiche", IsForeignKey = true, Storage = "_fiche",OtherKey="id", ThisKey = "id_Fiche")]
        public FicheDeJeuDB fiche
        {
            get { return _fiche.Entity; }
            set { _fiche.Entity = value;}
        }


        [Column(Name = "Age",IsPrimaryKey=true)] public string id_age;
        private EntityRef<AgeDb> _ages = new EntityRef<AgeDb>();
        [Association(Name = "FK_FicheAge_Age", IsForeignKey = true, Storage = "_ages",OtherKey="id", ThisKey = "id_age")]
        public AgeDb ages
        {
            get { return _ages.Entity; }
            set { _ages.Entity = value; }
        } 
    }
}
