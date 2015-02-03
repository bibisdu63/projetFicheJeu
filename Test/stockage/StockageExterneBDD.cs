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

        SqlConnection ConnectionBase;
        SqlCommand myCommandSelect;

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
            try
            {
                String titreJeu;
                String requete = "SELECT * from Fiche WHERE Titre = 'PRV'";
               
                /*string strRequete = "Select f.Titre,f.Regles,f.duree,f.note,f.nbVue,f.NbJoueur,c.categorie,a.AgeMin,a.AgeMax,  o.objectifs" +
                                    "from Fiche f, Age a, Categorie c, Objectifs o,FicheAge fa, FicheObjectifs fo " +
                                    "Where c.id=f.Categorie" +
                                    "AND fa.Fiche=f.Id" +
                                    "AND a.Id=fa.Age" +
                                    "AND fo.fiche=f.Id" +
                                    "AND o.Id=fo.objectif" +
                                    "AND f.Titre='PRV'";*/
               // ConnectionBase.Open();
                myCommandSelect = new SqlCommand(requete, ConnectionBase);


                SqlDataReader lectureFiche = myCommandSelect.ExecuteReader();
                while (lectureFiche.Read())
                {
                    //On teste que le résultat n’est pas NULL afin d’éviter un plantage on moment du cast
                    if (lectureFiche["Titre"] != System.DBNull.Value)
                    {
                        //récuppère le nom à l’aide d’un cast
                        titreJeu = (string)lectureFiche["Titre"];
                    }
                    else
                    {                                                                                                                                         
                        titreJeu = "erreur";
                    }
                    //On affiche le champ dans la console
                    Console.WriteLine(titreJeu);

                    ConnectionBase.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception :" + e.Message);
            }
           

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
