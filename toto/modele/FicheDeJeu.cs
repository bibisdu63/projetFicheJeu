using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace ProjetFicheDeJeuLibrary.modele

{
   public class FicheDeJeu : IFicheDeJeu
    {
      
        
       public enum categorie : byte
        {
            petitJeu = 1,
            grandJeu = 2,
            veillé = 3,
            manuel = 4
        }
        /// <summary>
        /// Nom du jeu
        /// </summary>
        public string nom { get; set; }

        /// <summary>
        /// durée du jeu
        /// </summary>
        public float dureeJeu { get; set; }

        /// <summary>
        /// tranche d'âge du jeu
        /// </summary>
        public Age trancheAge { get; set; }

        /// <summary>
        /// objectifs du jeu
        /// </summary>
        public IObjectif objectif { get; set; }

        /// <summary>
        /// règles du Jeu
        /// </summary>
        public string regles { get; set; }

        /// <summary>
        /// Tableau des variantes du jeu 
        /// </summary>
        public string[] variantes;

        public uint categ = 1;

        public int nombreDeVue { get; set; }

        public double note { get; set; }
        
        public uint nombreDeNoteurs = 0;

        public FicheDeJeu(string nom, string regles,
             Age trancheAge, float dureeJeu, uint categ, IObjectif objectif = null)
        {
            this.nom = nom;
            this.regles = regles;
            this.trancheAge = trancheAge;
            this.dureeJeu = dureeJeu;
            this.objectif = objectif;
            this.nombreDeVue = 0;
            this.categ = categ;
            //this.note = 2.5;
        }
        public FicheDeJeu()
        {
            this.nom = "nom";
            this.regles = "regles";
            this.trancheAge = null;
            this.dureeJeu = 30;
            this.nombreDeVue = 0;

        }

    }
}
