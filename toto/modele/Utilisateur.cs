using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFicheDeJeuLibrary.modele
{
    class Utilisateur
    {
         //ajout en bdd
        public void ajouterFicheDeJeuEnBDD(){

        }
        //ajout en xml
        public void ajouterFicheDeJeuEnXML()
        {

        }

        /// <summary>
        /// methode permettant au joueur de noter une fiche
        /// </summary>
        /// <param name="note">note attribuer</param>
        /// <param name="fiche">fiche de jeu pour laquelle une note est émise</param>
        public void noterJeu(uint note,FicheDeJeu fiche)
        {
            fiche.note = ((fiche.note * fiche.nombreDeNoteurs) + note) / (fiche.nombreDeNoteurs+1);
            fiche.nombreDeNoteurs++;
        }
    }
}
