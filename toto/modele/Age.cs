using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ProjetFicheDeJeuLibrary.modele
{
  [DataContract] public class Age
    {
        /// <summary>
        /// age min pour le jeu
        /// </summary>
       [DataMember] private int ageMin { get; set; }

        /// <summary>
        /// age maximum pour le jeu
        /// </summary>
       [DataMember] private int ageMax { get; set; }

        public Age(int min, int max)
        {
            this.ageMin = min;
            this.ageMax = max;
        }



        /// <summary>
        /// affichage de la tranche d'âge pour un jeu
        /// </summary>
        /// <returns></returns>
        public String toString()
        {
            return ageMin+" - "+ageMax;
        }
    }
}
