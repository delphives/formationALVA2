using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonNamespace
{
    /*visibilités :
     * public --> tout le monde peut voir
     * private --> seule la classe contenant l'élément privé peut le voir
     * protected --> la classe en cours + les classes enfants ou qui héritent
     * internal --> seulement les classes du même namespace*/
    /// <summary>
    /// classe Maths pour des opérations mathématiques complexes
    /// </summary>
    public class Maths
    {
 
        /// <summary>
        /// méthode qui cacule la somme de 2 nombres
        /// </summary>
        /// <param name="nb1">le nombre numéro 1</param>
        /// <param name="nb2">le nombre 2</param>
        /// <returns>la somme</returns>
        public int CalculerSommeDeDeuxNombres(int nb1, int nb2)
        {
            return nb1 + nb2;
        }
    }
}
