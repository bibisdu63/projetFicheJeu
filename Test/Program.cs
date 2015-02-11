using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFicheDeJeuLibrary.modele;
using ProjetFicheDeJeuLibrary.controleur;
using Test.stockage;

namespace Test
{
    class Program
    {
        /// <summary>
        /// methode main de la classe pour test fonctionnel
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IStockage i = new StockageInterneXML();
            ManageurDeJeu manager = new ManageurDeJeu();
            
            string lu = null;
            int luconvert = 0;
            Console.WriteLine("---------------Menu------------");
            Console.WriteLine("1. Créer une fiche de Jeu");
            Console.WriteLine("2. Charger les fiches local et les afficher");
            Console.WriteLine("3. Charger les fiches local et les afficher trié par categorie");
            Console.WriteLine("0. Quitter le programme");
            Console.WriteLine();
            Console.WriteLine("Choix : ");
            lu = Console.ReadLine();
            try
            {
                luconvert = Convert.ToInt32(lu);
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur de parsing");
            }
            while (luconvert != 0)
            {
                switch (luconvert)
                {
                    case 1 :
                        FicheDeJeu fiche = null;
                        fiche = creerFiche(manager);
                        Console.WriteLine();
                        Console.WriteLine("------Sous-Menu------");
                        Console.WriteLine("1. Afficher fiche");
                        Console.WriteLine("2. Sauvegarder Fiche en local");
                        Console.WriteLine("0. Revenir au menu principal");
                        Console.WriteLine();
                        Console.WriteLine("Choix : ");
                        lu = Console.ReadLine();
                        try
                        {
                            luconvert = Convert.ToInt32(lu);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Erreur de parsing");
                        }
                        while (luconvert != 0)
                        {
                            switch(luconvert){
                                case 1 : 
                                    fiche.ToString();
                                    break;
                                case 2 : 
                                     i.StockerUneFiche(fiche);
                                    break;
                                default : 
                                    Console.WriteLine("erreur saisi");
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("------Sous-Menu------");
                            Console.WriteLine("1. Afficher fiche");
                            Console.WriteLine("2. Sauvegarder Fiche en local");
                            Console.WriteLine();
                            Console.WriteLine("Choix : ");
                            lu = Console.ReadLine();
                            try
                            {
                                luconvert = Convert.ToInt32(lu);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Erreur de parsing");
                            }
                        }
                        break;
                    case 2 :
                        FicheDeJeu[] mesFiches = manager.chargerToutesLesFiches(i);
                        for (int cpt = 0; cpt < mesFiches.Length; cpt++)
                        {
                            Console.WriteLine("fiche n°" + cpt + " : " + mesFiches[cpt].nom);
                        }
                        if (mesFiches.Length == 0)
                        {
                            Console.WriteLine("aucune fiche enregistré - Attention les fiches ne peuvent être chargé que dans la même session dans laquelle elle a été enregistré.");
                        }
                        break;
                    case 3 :
                        List<FicheDeJeu> listeTrieParCateg = manager.rechercheParCateg(1);
                        for (int x = 0; x < listeTrieParCateg.Count; x++)
                        {
                            Console.WriteLine("fiche n°" + x + " : " + listeTrieParCateg[x].nom + "categ : " + listeTrieParCateg[x].categ);
                        }
                        if (listeTrieParCateg.Capacity == 0)
                        {
                            Console.WriteLine("aucune fiche enregistré - Attention les fiches ne peuvent être chargé que dans la même session dans laquelle elle a été enregistré.");
                        }
                        break;
                    
                    default :
                        Console.WriteLine("Erreur dans la commande. Merci de retaper");
                        break;
                }
                Console.WriteLine("---------------Menu------------");
                Console.WriteLine("1. Créer une fiche de Jeu");
                Console.WriteLine("2. Charger les fiches local et les afficher");
                Console.WriteLine("3. Charger les fiches local et les afficher trié par categorie");
                Console.WriteLine("0. Quitter le programme");
                Console.WriteLine();
                Console.WriteLine("Choix : ");
                lu = Console.ReadLine();
                try
                {
                    luconvert = Convert.ToInt32(lu);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erreur de parsing");
                }
            }
        }


        public static FicheDeJeu creerFiche(ManageurDeJeu manager)
        {
            FicheDeJeu fiche = null;
            Age age = null;
            ObjectifTableau objectifs = null;
            Console.Write("Entrez le nom du jeu : ");
            String titre = Console.ReadLine();
            Console.Write("Entrez les rêgles du jeu : ");
            String regle = Console.ReadLine();
            Console.Write("Entrez l'âge Minimun pour jouer au jeu : ");
            String tmpAgeMin = Console.ReadLine();
            Console.Write("Entrez l'age maximum pour jouer au jeu : ");
            String tmpAgeMax = Console.ReadLine();
            Console.Write("Entrez la durée du jeu(en minutes) : ");
            String tmpduree = Console.ReadLine();
            Console.WriteLine("1. Petit jeu ");
            Console.WriteLine("2. Grand jeu ");
            Console.WriteLine("3. Veillée");
            Console.WriteLine("4. Activité Manuel");
            Console.Write("Saisissez la catégorie du jeu : ");
            String tmpcateg = Console.ReadLine();
            Console.Write("Saisissez l'objectif 1 : ");
            String obj1 = Console.ReadLine();
            Console.Write("Saisissez l'objectif 2 : ");
            String obj2 = Console.ReadLine();
            try
            {
                int ageMin = Convert.ToInt32(tmpAgeMin);
                int ageMax = Convert.ToInt32(tmpAgeMax);
                int duree = Convert.ToInt32(tmpduree);
                uint categ = Convert.ToUInt32(tmpcateg);
                objectifs = new ObjectifTableau(obj1, obj2);
                age = new Age(ageMin, ageMax);
                fiche = manager.creerJeu(titre, regle, age, duree, categ, objectifs);
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur de parsing");
            }
            return fiche;
        }
    }
}
