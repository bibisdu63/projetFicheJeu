using ProjetFicheDeJeuLibrary;
using ProjetFicheDeJeuLibrary.modele;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
namespace Test
{
    class StockageInterneXML : IStockage
    {


           /// <summary>
        /// Fonction : stocker une fiche dans un fichier XML 
        /// Le fichier créé porte le nom du jeu 
        /// </summary>
        /// <param name="fiche">La fiche de jeu a stocker</param>
        
        public void StockerUneFiche(FicheDeJeu fiche)
        {

            FicheDeJeu myObject = new FicheDeJeu();
            var ds = new DataContractSerializer(typeof(FicheDeJeu));
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = false };
            using (XmlWriter w = XmlWriter.Create(fiche.nom +".xml", settings))
            ds.WriteObject(w, fiche);
           // System.Diagnostics.Process.Start(fiche.nom+".xml"); 
           // Console.ReadLine();
        }

        FicheDeJeu IStockage.SelectionnerUneFiche(string nom)
        {

            FicheDeJeu maFiche;
            var ds = new DataContractSerializer(typeof(FicheDeJeu));
            using (Stream s = File.OpenRead(nom+".xml"))
            maFiche= (FicheDeJeu)ds.ReadObject(s);                    
            return maFiche;
        }

        int IStockage.SupprimerUneFiche(FicheDeJeu nom)
        {

            throw new NotImplementedException();
        }

        int IStockage.ModifierUneFiche(FicheDeJeu nom)
        {

            throw new NotImplementedException();
        }
    }
}
