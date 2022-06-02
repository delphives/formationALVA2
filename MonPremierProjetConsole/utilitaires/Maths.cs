using MonPremierProjetConsole.classes;
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
            int x = nb1 + nb2;
            return x;
        }

        public void Test()
        {
            int? a = null;
            string b = "";
            char c = 'a';
            bool d = false;
            decimal e = 2.12m;
            double f = 2.12;
            float g = 2.23f;
            DateTime h = DateTime.Now;
            h = h.AddDays(-2);
        }

        public void TestFor()
        {
            for(int i = 1; i <= 1; i++)
            {
                Console.WriteLine("coucou " + i);
                Console.WriteLine("1"  + "2");
                Console.WriteLine("1" + 2);
                Console.WriteLine(1 + "2");
                Console.WriteLine(1 + 2);
                //1
                Console.WriteLine("coucou " + i + "!");
                //2
                Console.WriteLine("coucou {2}{0}!{1}", i, "salut", 4);
                //3
                Console.WriteLine($"coucou {i} {true} toto");


            }

            for (int i = 0; i < 10; )
            {
                Console.WriteLine(i--);
                Console.WriteLine(++i);
            }
            //1. déclaration tableau
            int[] tab = new int[10]; 
            for(int i = 0; i < tab.Length;i++)
            {
                tab[i] = i + 10;
                int x = tab[i];
            }
            //2. déclaration tableau
            int[] tab2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            
        }

        public void TestWhile()
        {
            int i = 10;
            while (i < 10)
            {
                Console.WriteLine(i++);
            }
        }

        public void TestDoWhile()
        {
            int i = 10;
            //s'exécute au moins 1x
            do
            {
                Console.WriteLine(i++);
            } while(i < 10);
        }
        public void TestSwitch()
        {
            int i = 2;
            switch (i)
            {
                case 0: Console.WriteLine("");
                    break;
                case 1: Console.WriteLine("");
                    break;
                default: Console.WriteLine("");
                    break;
            }
        }

        public void TestBreak()
        {
            int i = 0;
            while(true)
            {
                i++;
                if (i == 100)
                    break;
            }
        }

        public void TestContinue()
        {
            int i = 0;
            while (true)
            {
                if (i == 10)
                {
                    i++;
                    continue;
                }
                    
                Console.WriteLine(i++);
                if (i == 13)
                    break;
            }
        }

        public void TestGoTo()
        {
            int i = 0;
            if (i == 0)
                i = 3;
            if (i == 3)
            {
                i = 5;
            } else
            {
                goto monlabel2;
            }
            i = 9;
        monlabel:
            i = 10;

        monlabel2:
            i = i - 1;
            Console.WriteLine(i);
        }

        public void TestGoTo2()
        {
            for(; ; )
            {
                for(; ; )
                {
                    //je veux sortir des 2 boucles for
                    goto monLabelDeSortie;
                }
            }
            monLabelDeSortie:
            Console.WriteLine("fini");
        }

        public void TestForeach()
        {
            int[] i = new int[] { 1, 2, 3, 3, 3, 3, 3, 3 };
            int j = 0;
            foreach(int i2 in i)
            {
                Console.WriteLine($"{j++} : {i2}");
                
            }
        }

        public void TestList()
        {
            List<string> maListe = new List<string>();
            maListe.Add("oucou");
            maListe.Add("asdf");
            maListe.Remove("oucou");
        }

        public void TestList2()
        {
            //je veux mettre 3 utilisateurs dans une liste
            List<Utilisateur> maListe = new List<Utilisateur>();

            int nbUtilisateurs = 3;
            for (int i = 0; i < nbUtilisateurs; i++)
            {
                Utilisateur uti = new Utilisateur();
                uti.SetPrenom($"uti{i}");
                maListe.Add(uti);
            }

            foreach(Utilisateur uti in maListe)
            {
                Console.WriteLine($"je m'appelle {uti.GetPrenom}");
            }
           
            maListe[2].GetPrenom();

            Console.WriteLine(maListe[0].GetPrenom());
        }

        public void TestStatic()
        {
            //appel méthode static par la classe
            Utilisateur.DisCoucou();
            Utilisateur u = new Utilisateur();
            
        }

        public void EcrisDuTexteDansLaConsole(string texte)
        {
            Console.WriteLine(texte);
        }

        public void HelloWorld()
        {
            Console.WriteLine("hello world");
        }

    }
}
