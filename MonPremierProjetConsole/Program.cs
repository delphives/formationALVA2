//public static void Main(string[] args)
//{

// See https://aka.ms/new-console-template for more information
//commentaire une ligne
//ici on se trouve à l'intérieur de la méthode Maint


/*sdfsdf
 * 
 * 
 * commentaires sur plusieurs lignes
 * 
 * 
 */


using MonNamespace;
/** 
* commentaire pour les méthodes, ....
*/
Console.WriteLine("Hello, World!");
string? toto = "";
toto = null;
toto = "asdf";
int? tutu;
tutu = null;
int? age = null;
//string? x = Console.ReadLine();
Object y = null;
tutu = 2147483647;
age = 175765;
tutu += 2147483647 + age;

//if
if ((false) || (true && false) || true)
{

}

if (age > 2)
{
    Console.WriteLine("+");
    Console.WriteLine("toot");
}

if (age > 2)
    Console.WriteLine("toot");
Console.WriteLine("+");


//if simplifié
string z = "";
if (age > 2)
    z = "+";
else
    z = "-";
z = age > 2 ? "+" : "-";

Maths m = new Maths();
Console.WriteLine(m.CalculerSommeDeDeuxNombres(4, 6));
Console.ReadLine();
//}
