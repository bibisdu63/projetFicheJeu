using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ProjetFicheDeJeuLibrary
{
    [DataContract] class FicheDeJeuXML : IFicheDeJeu
    {
       [DataMember]
       public uint nombreDeNoteurs=0;

         [Flags]
       public enum categorie : byte
        {
            petitJeu = 1,
            grandJeu = 2,
            veillé = 3,
            manuel = 4
        }
        /// <summary>
        /// Nom du jeu
        /// </summary>
        [DataMember]
        public string nom { get; set; }

        /// <summary>
        /// durée du jeu
        /// </summary>
        [DataMember]
        public float dureeJeu { get; set; }

        /// <summary>
        /// tranche d'âge du jeu
        /// </summary>
        [DataMember]
        public Age trancheAge { get; set; }

        /// <summary>
        /// objectifs du jeu
        /// </summary>
        [DataMember]
        public IObjectif objectif { get; set; }

        /// <summary>
        /// règles du Jeu
        /// </summary>
        [DataMember]
        public string regles { get; set; }

        /// <summary>
        /// Tableau des variantes du jeu 
        /// </summary>
        [DataMember]
        public string[] variantes;

        [DataMember] public byte categ;

        [DataMember] public int nombreDeVue { get; set; }

        [DataMember] public double note { get; set; }

        public FicheDeJeuXML(string nom, string regles, Age trancheAge, float dureeJeu)
        {
            this.nom = nom;
            this.regles = regles;
            this.trancheAge = trancheAge;
            this.dureeJeu = dureeJeu;
            this.nombreDeVue = 0;
            this.note = 2.5;
        }
        public FicheDeJeuXML()
        {
            this.nom = "nom";
            this.regles = "regles";
            this.trancheAge = null;
            this.dureeJeu = 30;
            this.nombreDeVue = 0;
            this.note = 2.5;
        }

    }
    
}
