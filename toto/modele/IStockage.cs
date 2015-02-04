using System;

namespace ProjetFicheDeJeuLibrary.modele
{
    /// <summary>
    /// interface pour gérer différente manière de stockage
    /// </summary>
public interface IStockage
    {
        /// <summary>
        /// permet de selectionner une fiche de jeu en fonction du nom dans le stockage
        /// </summary>
        /// <param name="nom">nom du jeu rechercher</param>
        /// <returns>une fiche de jeu</returns>
         FicheDeJeu SelectionnerUneFiche(String nom);

        /// <summary>
        /// permet de stocker une fiche de jeu dans stockage
        /// </summary>
        /// <param name="fiche">la fiche de jeu a stocker</param>
         void StockerUneFiche(FicheDeJeu fiche);

        /// <summary>
        /// permet de supprimer une fiche dans stokage
        /// </summary>
        /// <param name="nom">fiche à supprimer</param>
        /// <returns>entier de tester</returns>
         int SupprimerUneFiche(FicheDeJeu nom);

         /// <summary>
         /// permet de modifier une fiche dans stokage
         /// </summary>
         /// <param name="nom">fiche à supprimer</param>
         /// <returns>entier de tester</returns>
         int ModifierUneFiche(FicheDeJeu nom);

    }
}
