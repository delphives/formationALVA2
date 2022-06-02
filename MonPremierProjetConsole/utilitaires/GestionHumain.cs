using MonPremierProjetConsole.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjetConsole.utilitaires
{
    public class GestionHumain
    {
        public void CreerHumain()
        {
            Humain h = new Humain();
            h.Age = 32;
            h.Prenom = "toto";
        }
    }
}
