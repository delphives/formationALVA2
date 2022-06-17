using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjetConsole.utilitaires
{
    public class GestionErreurs
    {
        public int GetDivision(int nb1, int nb2)
        {
            int resultat = 0;
            try
            {
                Console.WriteLine("étape n° 1");
   
                resultat = nb1 / nb2;
                Console.WriteLine("étape n° 2");
            }
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine("zut");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Attention Erreur : {ex.Message}");
                resultat = -1;
                throw;
            } finally
            {
                Console.WriteLine("étape n° 3");
            }
            return resultat;
        }
    }
}
