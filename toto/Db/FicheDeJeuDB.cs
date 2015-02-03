using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ProjetFicheDeJeuLibrary.Db
{   [Table (Name="Fiche")]
    public class FicheDeJeuDB : IFicheDeJeu
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

       
        public Age trancheAge { get; set; }

       
        public IObjectif objectif { get; set; }

        [Column (Name="Regles")]
        public string regles { get; set; }

        
        public string[] variantes;
        
        public byte categ;

        public int nombreDeVue { get; set; }

        public double note { get; set; }

   
    }
}
