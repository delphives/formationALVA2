using MonNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MesMethodes
    {
        public int GetSomme(int nb1, int nb2)
        {
            Maths m = new Maths();
            return m.CalculerSommeDeDeuxNombres(nb1, nb2);
        }
    }
}
