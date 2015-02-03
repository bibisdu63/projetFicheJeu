using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetFicheDeJeuLibrary.modele
{
    interface IFicheDeJeu
    {
        
        //uint nombreDeNoteurs = 0;

        /* public enum categorie : byte
        {
            petitJeu = 1,
            grandJeu = 2,
            veillé = 3,
            manuel = 4
        }*/
        /// <summary>
        /// Nom du jeu
        /// </summary>
         string nom { get; set; }

        /// <summary>
        /// durée du jeu
        /// </summary>
         float dureeJeu { get; set; }

        /// <summary>
        /// tranche d'âge du jeu
        /// </summary>
         Age trancheAge { get; set; }

        /// <summary>
        /// objectifs du jeu
        /// </summary>
         IObjectif objectif { get; set; }

        /// <summary>
        /// règles du Jeu
        /// </summary>
         string regles { get; set; }

        /// <summary>
        /// Tableau des variantes du jeu 
        /// </summary>
         //string[] variantes;

        // uint categ;

         int nombreDeVue { get; set; }

         double note { get; set; }

    }
}
