using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetFicheDeJeuLibrary.controleur
{   
    
    public class ManageurDeJeu
    {
        /// <summary>
        /// Liste contenant le nom des fiches
        /// </summary>
        List<string> nomsFiche = new List<string>();

        /// <summary>
        /// liste de fiche de Jeu
        /// </summary>
        List<FicheDeJeu> fiches = null;

        /// <summary>
        /// methode permettant de construire une fiche de jeu
        /// </summary>
        /// <param name="nom">nom du jeu</param>
        /// <param name="regles">règles du jeu</param>
        /// <param name="trancheAge">tranche d'âge du jeu</param>
        /// <param name="dureeJeu">durée du jeu</param>
        /// <param name="categ">catégorie du jeu</param>
        /// <param name="objectif">objectifs du jeu</param>
        /// <returns>une fiche de jeu</returns>
        public FicheDeJeu creerJeu(string nom, string regles, Age trancheAge, float dureeJeu, uint categ, IObjectif objectif)
        {
            nomsFiche.Add(nom);
            return new FicheDeJeu(nom, regles, trancheAge, dureeJeu, categ, objectif);
        }

        /// <summary>
        /// Cette recherche retournera le tableau des fiches de jeu grâce pas forcèment à du SQL
        /// </summary>
        /// <returns></returns>
        public FicheDeJeu[] recherchePlusJoues()
        {
            return null;
        }

        /// <summary>
        /// Retourne le tableau triés en fonction des notes
        /// </summary>
        /// <returns></returns>
        public List<FicheDeJeu> rechercheParNoteCroissante()
        {
            List<FicheDeJeu> SortedList = fiches.OrderBy(o => o.note).ToList();

            return SortedList;
        }

        /// <summary>
        /// Retourne le tableau des fiches grâce a la categorie passée en paramètre
        /// </summary>
        /// <returns></returns>
        public List<FicheDeJeu> rechercheParCateg(uint categorie)
        {
            List<FicheDeJeu> listeParCritere = fiches.Where(o => o.categ == categorie).ToList();
            //return null;
            return listeParCritere;

        }
        /// <summary>
        /// Retourne le tableau des fiches grâce aux critères passés en paramètre
        /// </summary>
        /// <returns></returns>
        public List<FicheDeJeu> rechercheParCritere()
        {
            return null;
        }
        public List<FicheDeJeu> rechercheParDureeCroissante()
        {
            List<FicheDeJeu> SortedList = fiches.OrderBy(o => o.dureeJeu).ToList();

            return SortedList;
        }

        // chargerTouteLesFiches présentes en xml
        public FicheDeJeu[] chargerToutesLesFiches(IStockage stockage)
        {
            FicheDeJeu[] fichesDeJeu = new FicheDeJeu[nomsFiche.Count];


            for (int i = 0; i < nomsFiche.Count; i++)
            {
                fichesDeJeu[i] = stockage.SelectionnerUneFiche(nomsFiche[i]);
            }
            fiches = new List<FicheDeJeu>(fichesDeJeu);
            return fichesDeJeu;
        }


    }
}
