using ProjetFicheDeJeuLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Threading.Tasks;
using ProjetFicheDeJeuLibrary.Db;
using ProjetFicheDeJeuLibrary.modele;

namespace Test.stockage
{
    public class StockageExterneBDD : IStockage
    {
        /// <summary>
        /// variable qui stock une connection a une base de donnée
        /// </summary>
        DataContext contextDonnee;
        /// <summary>
        /// constructeur de la classe qui permet de se connecter à la base de donnée
        /// </summary>
        public StockageExterneBDD()
        {
            contextDonnee = new DataContext("Data Source=(localdb)\v11.0;Initial Catalog=bisson;Integrated Security=True;Pooling=False");
        }

        public FicheDeJeu SelectionnerUneFiche(String nom)
        {
            var query = //from Fiche in contextDonnee.GetTable<FicheDeJeuDB>() select Fiche;
                contextDonnee.GetTable<FicheDeJeuDB>();
            foreach(var fiche in query)
            { Console.WriteLine(fiche.nom); }


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
