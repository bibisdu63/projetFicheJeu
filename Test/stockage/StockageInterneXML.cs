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

            FicheDeJeuXML myObject = new FicheDeJeuXML(fiche);
            var ds = new DataContractSerializer(typeof(FicheDeJeuXML),new Type[]{typeof(ObjectifTableau)});
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = false };
            using (XmlWriter w = XmlWriter.Create(fiche.nom +".xml", settings))
                ds.WriteObject(w, myObject);
           // System.Diagnostics.Process.Start(fiche.nom+".xml"); 
           // Console.ReadLine();
        }

        FicheDeJeu IStockage.SelectionnerUneFiche(string nom)
        {
            FicheDeJeuXML maFiche;// = new FicheDeJeuXML();
            var ds = new DataContractSerializer(typeof(FicheDeJeuXML), new Type[] { typeof(ObjectifTableau) });
            using (Stream s = File.OpenRead(nom+".xml"))
                maFiche = ds.ReadObject(s) as FicheDeJeuXML;                    
            return maFiche.ficheDeJeu;
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
