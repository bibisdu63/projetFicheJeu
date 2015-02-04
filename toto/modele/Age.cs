using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ProjetFicheDeJeuLibrary.modele
{
    /// <summary>
    /// classe Age (sérialisable)
    /// </summary>
    [DataContract]
    public class Age
    {
        /// <summary>
        /// age min pour le jeu
        /// </summary>
        [DataMember]
        private int ageMin { get; set; }

        /// <summary>
        /// age maximum pour le jeu
        /// </summary>
        [DataMember]
        private int ageMax { get; set; }

        /// <summary>
        /// constrcteur d'une tranche d'age
        /// </summary>
        /// <param name="min">age minimum</param>
        /// <param name="max">age maximum</param>
        public Age(int min, int max)
        {
            this.ageMin = min;
            this.ageMax = max;
        }

        /// <summary>
        /// affichage de la tranche d'âge pour un jeu
        /// </summary>
        /// <returns></returns>
        override public String ToString()
        {
            return ageMin + " - " + ageMax;
        }
    }
}
