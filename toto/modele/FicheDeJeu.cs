using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace ProjetFicheDeJeuLibrary.modele

{
    /// <summary>
    /// classe Fiche de Jeu
    /// </summary>
   public class FicheDeJeu : IFicheDeJeu
    {

        /// <summary>
        /// Enum pour la gestion des catégorie
        /// </summary>
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

       /// <summary>
       /// categorie
       /// </summary>
        public uint categ = 1;       

       /// <summary>
       /// nombre de Vue 
       /// </summary>
        public int nombreDeVue { get; set; }

       /// <summary>
       /// note attribué à la fiche de jeu
       /// </summary>
        public double note { get; set; }

       /// <summary>
       /// nombre de vue necessaire pour calculer la note 
       /// </summary>
        public uint nombreDeNoteurs { get; set; }

       /// <summary>
       /// constructeur d'une fiche de jeu
       /// </summary>
       /// <param name="nom"></param>
       /// <param name="regles"></param>
       /// <param name="trancheAge"></param>
       /// <param name="dureeJeu"></param>
       /// <param name="categ"></param>
       /// <param name="objectif"></param>
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

       /// <summary>
       /// constrcteur d'unee fiche de jeu sans paramètre
       /// </summary>
        public FicheDeJeu()
        {
            this.nom = "nom";
            this.regles = "regles";
            this.trancheAge = null;
            this.dureeJeu = 30;
            this.nombreDeVue = 0;

        }

        
        public void ToString()
        {
            Console.WriteLine("------Fiche de Jeu-----------");
            Console.WriteLine(" nom : " + this.nom);
            Console.WriteLine("regle : " + this.regles);
            Console.WriteLine("Age : " + this.trancheAge.ToString());
            Console.WriteLine("Duree : " + this.dureeJeu);
            Console.WriteLine("Categorie : " + this.categ);
            Console.WriteLine("Objectifs : " + this.objectif.ToString());
        }
    }
}
