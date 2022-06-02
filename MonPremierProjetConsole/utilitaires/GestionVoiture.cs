using MonPremierProjetConsole.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjetConsole.utilitaires
{
    public class GestionVoiture
    {
        public void CreerVoitures()
        {
            Voiture v = new Voiture();
            v.SetCouleur("rouge");
            v.SetMarque("Fiat");
            v.GetCouleur();

            v.Cylindree = 3000;
            Console.WriteLine(v.Cylindree);
        }
    }
}
