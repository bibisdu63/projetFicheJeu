using ProjetFicheDeJeuLibrary.Db;
using ProjetFicheDeJeuLibrary.modele;
using System;

namespace Test.stockage
{
    public class StockageExterneBDD : IStockage
    {
        /// <summary>
        /// variable qui stock une connection a une base de donnée
        /// </summary>
        FicheCatalogue catalog;

        /// <summary>
        /// constructeur de la classe qui permet de se connecter à la base de donnée
        /// </summary>
        public StockageExterneBDD()
        {
            catalog = new FicheCatalogue();
        }

        public FicheDeJeu SelectionnerUneFiche(String nom)
        {

            foreach (FicheDeJeuDB fiche in catalog.Fiche)
            {
                Console.WriteLine(fiche.nom);
            }
            /*
            var query = //from Fiche in contextDonnee.GetTable<FicheDeJeuDB>() select Fiche;
                contextDonnee.GetTable<FicheDeJeuDB>();
            foreach(var fiche in query)
            { Console.WriteLine(fiche.nom); }
            */

            return null;
        }
        public void StockerUneFiche(FicheDeJeu fiche)
        {
        
        }
        public int SupprimerUneFiche(FicheDeJeu nom)
        {
            return 0;
        }
        public int ModifierUneFiche(FicheDeJeu nom)
        {
            return 0;
        }

    }
}
