﻿using ProjetFicheDeJeuLibrary.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ProjetFicheDeJeuLibrary
{
    [DataContract] 
    public class FicheDeJeuXML : IFicheDeJeu
    {
        /// <summary>
        /// instance de la fiche de jeu référencé
        /// </summary>
        [IgnoreDataMember]
        public FicheDeJeu ficheDeJeu;

        /// <summary>
        /// nombre de noteurs, variable necessaire pour le calcul de la moyenne des notes
        /// </summary>
        [DataMember]
        public uint nombreDeNoteurs
        {
            get { return ficheDeJeu.nombreDeNoteurs; }
            set { ficheDeJeu.nombreDeNoteurs = value; }
        }

        /// <summary>
        /// enum de la catégorie d'un jeu
        /// </summary>
        [Flags]
        public enum categorie : uint
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
        public string nom
        {
            get { return ficheDeJeu.nom; }
            set { ficheDeJeu.nom = nom; }
        }

        /// <summary>
        /// durée du jeu
        /// </summary>
        [DataMember]
        public float dureeJeu
        {
            get { return ficheDeJeu.dureeJeu; }
            set { ficheDeJeu.dureeJeu = dureeJeu; }
        }

        /// <summary>
        /// tranche d'âge du jeu
        /// </summary>
        [DataMember]
        public Age trancheAge
        {
            get { return ficheDeJeu.trancheAge; }
            set { ficheDeJeu.trancheAge = trancheAge; }
        }

        /// <summary>
        /// objectifs du jeu
        /// </summary>
        [DataMember]
        public IObjectif objectif
        {
            get { return ficheDeJeu.objectif; }
            set { ficheDeJeu.objectif = objectif; }
        }

        /// <summary>
        /// règles du Jeu
        /// </summary>
        [DataMember]
        public string regles
        {
            get { return ficheDeJeu.regles; }
            set { ficheDeJeu.regles = regles; }
        }

        /// <summary>
        /// Tableau des variantes du jeu 
        /// </summary>
        [DataMember]
        public string[] variantes
        {
            get { return ficheDeJeu.variantes; }
            set { ficheDeJeu.variantes = variantes; }
        }

        /// <summary>
        /// categorie d'un jeu
        /// </summary>
        [DataMember]
        public uint categ;

        /// <summary>
        /// nombre de vue de la fiche de jeu
        /// </summary>
        [DataMember]
        public int nombreDeVue
        {
            get { return ficheDeJeu.nombreDeVue; }
            set { ficheDeJeu.nombreDeVue = nombreDeVue; }
        }

        /// <summary>
        /// note de la fiche de jeu
        /// </summary>
        [DataMember]
        public double note
        {
            get { return ficheDeJeu.note; }
            set { ficheDeJeu.note = note; }
        }

        /// <summary>
        /// Constructeur de Fiche de jeu XML (pour la sérialisastion)
        /// </summary>
        /// <param name="ficheDeJeu"> une fiche de jeu qui sert de référencement</param>
        public FicheDeJeuXML(FicheDeJeu ficheDeJeu)
        {
            this.ficheDeJeu = ficheDeJeu;
            this.nom = ficheDeJeu.nom;
        }

    }
    
}
