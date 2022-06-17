using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Oiseau
    {

        public static void Voler(int x)
        {
            Console.WriteLine("battre des ailes!");
        }

        public void Chanter(string chant)
        {
            Console.WriteLine(chant);
        }

        public string Nom { get; set; }


        public void QuelEstTonNom()
        {
            Console.WriteLine(Nom);
        }

    }
}
