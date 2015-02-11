using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ProjetFicheDeJeuLibrary.Db
{  
    /// <summary>
    /// classe permettant la gestion de la table fiche en base de donnée
    /// </summary>
    [Table (Name="Fiche")]
    public class FicheDeJeuDB
    {
        public enum categorie : byte
        {
            petitJeu = 1,
            grandJeu = 2,
            veillé = 3,
            manuel = 4
        }
       
        [Column (Name="Titre")]
        public string nom { get; set; }

        [Column (Name="Duree")]
        public float dureeJeu { get; set; }

        private EntitySet<FicheAge> _FicheAge = new EntitySet<FicheAge>();
        [Association(Name = "FK_FicheAge_Fiche", Storage = "_FicheAge", IsForeignKey = true,OtherKey="id_Fiche" ,ThisKey = "id")]
        private ICollection <FicheAge> trancheAge 
        {
            get { return _FicheAge; }
            set { _FicheAge.Assign(value); }
        }

        private EntitySet<FicheObjectifs> _FicheObjectifs = new EntitySet<FicheObjectifs>();
        [Association(Name = "FK_FicheObjectifs_Fiche", Storage = "_FicheObjectifs",IsForeignKey=true,OtherKey="id_Fiche", ThisKey = "id")]
        public ICollection<FicheObjectifs> objectif 
        {
            get { return _FicheObjectifs; }
            set { _FicheObjectifs.Assign(value);  }
        }



        [Column (Name="Regles", IsPrimaryKey=true)]
        public string regles { get; set; }

        [Column (Name="Id",IsPrimaryKey=true)]
        public int id;

        private EntityRef<CategorieDb> _categorie = new EntityRef<CategorieDb>();
        [Association(Name = "FK_Fiche_Categorie", IsForeignKey = true, Storage = "_categorie", ThisKey = "id")]
        public CategorieDb categoriedb
        {
            get { return _categorie.Entity; }
            set { _categorie.Entity = value; }
        }
        [Column (Name = "Categorie")] public uint? categ;

        public uint nombreDeNoteurs { get; set; }

        public int nombreDeVue { get; set; }

        public double note { get; set; }

        public string[] variantes;

   
    }
}
