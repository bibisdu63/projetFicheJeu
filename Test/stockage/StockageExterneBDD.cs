using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Threading.Tasks;

namespace Test.stockage
{
    public class StockageExterneBDD : IStockage
    {
        /// <summary>
        /// variable qui stock une connection a une base de donnée
        /// </summary>
        SqlConnection ConnectionBase;

        /// <summary>
        /// constructeur de la classe qui permet de se connecter à la base de donnée
        /// </summary>
        public StockageExterneBDD()
        {
            using (ConnectionBase = new SqlConnection())
            {
                try
                {
                    ConnectionBase.ConnectionString = @"Data Source=(localdb)\v11.0;Integrated Security =SSPI; Initial Catalog=bisson";
                    ConnectionBase.Open();
                    Console.WriteLine("connexion OK");
                } 
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public FicheDeJeu SelectionnerUneFiche(String nom)
        {   
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
