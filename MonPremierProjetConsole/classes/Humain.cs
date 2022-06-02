using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjetConsole.classes
{
    public class Humain
    {
        private string _prenom;
        public string Prenom { get { return $"je m'appelle{_prenom}"; } set { _prenom = value; } }
        public int Age { get; set; }
        public bool IsHomme { get; }
    }
}
