using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetFicheDeJeuLibrary.modele
{
    public class ObjectifTableau : IObjectif
    {
        /// <summary>
        /// tableau contenant les objectifs de jeu
        /// </summary>
        private String[] m_tabObjectif{get;set;}

        public ObjectifTableau(params String[] tabObjectif)
        {
         m_tabObjectif= new String[9];
            for (int i = 0; i < tabObjectif.Length; i++)
            {
                this.m_tabObjectif[i] = tabObjectif[i];
            }

        }


        public String toString()
        {
            String objectifs = "";
            foreach (string s in this.m_tabObjectif)
                objectifs += s + "\n";
            return objectifs;
        }
    }
}
