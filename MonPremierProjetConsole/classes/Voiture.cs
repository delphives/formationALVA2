using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjetConsole.classes
{
    public class Voiture
    {
        private string _marque;
        private string _couleur;

        public void SetMarque(string marque)
        {
            this._marque = marque;
        }

        public void SetCouleur(string couleur)
        {
            this._couleur = couleur;
        }

        public string GetCouleur()
        {
            return this._couleur;
        }

        //propfull
        private int _cylindree;

        public int Cylindree
        {
            get { return _cylindree; }
            set { _cylindree = value; }
        }

        //prop
        public string Modele { get; set; }

    }
}
