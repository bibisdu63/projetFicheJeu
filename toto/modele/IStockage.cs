using System;

namespace ProjetFicheDeJeuLibrary.modele
{
public interface IStockage
    {
         FicheDeJeu SelectionnerUneFiche(String nom);
         void StockerUneFiche(FicheDeJeu fiche);
         int SupprimerUneFiche(FicheDeJeu nom);
         int ModifierUneFiche(FicheDeJeu nom);

    }
}
