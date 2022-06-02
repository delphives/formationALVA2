using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjetConsole.classes
{
    public class Utilisateur
    {
        public static void DisCoucou()
        {
            Console.WriteLine("Coucou");
        }

        private string _prenom;

        public void SetPrenom(string prenom)
        {
            this._prenom = prenom;
        }

        public string GetPrenom()
        {
            return this._prenom;
        }
    }
}
