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
        static void Main(string[] args)
        {
            Age a1 = new Age(8, 12);

            ObjectifTableau tab = new ObjectifTableau("aa", "bb");

            IStockage i = new StockageInterneXML();

            ManageurDeJeu manageur = new ManageurDeJeu();
            ObjectifTableau objectifs = new ObjectifTableau("courir", "apprendre");
            FicheDeJeu f = new FicheDeJeu("nom", "regles", a1, 30, 0x1, objectifs);
            FicheDeJeu f2 = new FicheDeJeu("nom2", "regles2", a1, 35, 1, objectifs);
            FicheDeJeu f3 = new FicheDeJeu("nom3", "regles2", a1, 32, 2, objectifs);
            i.StockerUneFiche(f);
            i.StockerUneFiche(f2);
            i.StockerUneFiche(f3);
            manageur.creerJeu("nom", "ne pas courir", a1, 30, 1, objectifs);

            manageur.creerJeu("nom2", "courir", a1, 35, 1, objectifs);
            manageur.creerJeu("nom3", "courir", a1, 32, 2, objectifs);

            FicheDeJeu[] mesFiches = manageur.chargerToutesLesFiches(i);
            for (int cpt = 0; cpt < mesFiches.Length; cpt++)
            {
                Console.WriteLine("fiche " + cpt + " : " + mesFiches[cpt].nom + " categ " + mesFiches[cpt].categ);
            }

            List<FicheDeJeu> listeTrieParCateg = manageur.rechercheParCateg(1);
            for (int x = 0; x < listeTrieParCateg.Count; x++)
            {
                Console.WriteLine("fiche " + x + " : " + listeTrieParCateg[x].nom + "categ : " + listeTrieParCateg[x].categ);
            }



            // System.Console.WriteLine(a1.ToString());
            // System.Console.WriteLine(tab.ToString());
            //FicheDeJeu f = new FicheDeJeu("nom","regles",a1,30);
            //FicheDeJeu f2 = new FicheDeJeu("nom2", "regles2", a1, 35);
            //FicheDeJeu f3 = new FicheDeJeu("nom3", "regles2", a1, 32);
            //i.StockerUneFiche(f);
            //i.StockerUneFiche(f2);
            //i.StockerUneFiche(f3);
            //FicheDeJeu fff=  i.SelectionnerUneFiche("nom");
            //Console.WriteLine(fff.nombreDeVue);
            //ObjectifTableau tabac = new ObjectifTableau("a", "b", "c", "d");
            //Console.WriteLine(tabac.ToString() + a1.ToString());
            //FicheDeJeu f = new FicheDeJeu("nom", "regles", a1, 30);
            //Utilisateur user = new Utilisateur();
            //user.noterJeu(12, f);
            //Console.WriteLine("note moyenne : " + f.note + "nb noteur " + f.nombreDeNoteurs);
            //user.noterJeu(14, f);
            //Console.WriteLine("note moyenne : " + f.note + "nb noteur " + f.nombreDeNoteurs);

            //user.noterJeu(16, f);
            //Console.WriteLine("note moyenne : " + f.note +"nb noteur " + f.nombreDeNoteurs);


            System.Console.ReadLine();


        }
    }
}
