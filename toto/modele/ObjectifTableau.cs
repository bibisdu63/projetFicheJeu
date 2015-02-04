using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace ProjetFicheDeJeuLibrary.modele
{
    [DataContract]
    public class ObjectifTableau : IObjectif
    {
        /// <summary>
        /// tableau contenant les objectifs de jeu
        /// </summary>
        ///
        [DataMember] String[] m_tabObjectif { get; set; }

        /// <summary>
        /// constructeur du tableau dd'objectifs
        /// </summary>
        /// <param name="tabObjectif">tableau d'objectifs</param>
        public ObjectifTableau(params String[] tabObjectif)
        {
            m_tabObjectif = new String[9];
            for (int i = 0; i < tabObjectif.Length; i++)
            {
                this.m_tabObjectif[i] = tabObjectif[i];
            }
        }

        /// <summary>
        /// methode permettant l'affichage de tous les objectifs du tableau
        /// </summary>
        /// <returns></returns>
        override public String ToString()
        {
            String objectifs = "";
            foreach (string s in this.m_tabObjectif)
                objectifs += s + "\n";
            return objectifs;
        }
    }
}
