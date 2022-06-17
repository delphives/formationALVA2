using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjetConsole.utilitaires
{
    public class MethodeParamEntree
    {
        public void DisCoucou()
        {
            Console.WriteLine("coucou");
        }

        public void DisQuelqueChose(string quelqueChose)
        {
            Console.WriteLine(quelqueChose);
        }

        public void DisQuelqueChose(int tutu)
        {
            Console.WriteLine(tutu);
        }

        public void DisQuelqueChoseXFois(string quelqueChose, int x = 5, int y = 9)
        {
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine(quelqueChose);
            }
        }
    }
}
