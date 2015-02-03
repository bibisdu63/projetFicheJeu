using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetFicheDeJeuLibrary.modele
{
    /// <summary>
    /// interface permettant de facilité le changement de gestion des objectifs 
    /// </summary>
    public interface IObjectif
    {
        /// <summary>
        /// fonction qui permet d'afficher les objectifs contenus dans le tableau
        /// </summary>
        /// <returns></returns>
        String toString();
    }
}
