using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetFicheDeJeuLibrary.modele
{
    interface IFicheDeJeu
    {

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

        /// <summary>
        /// nombre de personne ayant voté
        /// </summary>
         uint nombreDeNoteurs { get; set; }

        /// <summary>
        /// nombre de vue sur cette fiche
        /// </summary>
         int nombreDeVue { get; set; }

        /// <summary>
        /// note du jeu
        /// </summary>
         double note { get; set; }

    }
}
