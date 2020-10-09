using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_projet
{
    class Program
    {
        static int valeur;
        static void Main(string[] args)
        {
            Console.WriteLine("salut");
            Console.WriteLine();
            Console.WriteLine("Veuillez entrer une valeur");
            valeur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La valeur saisie est {valeur}");
        }
    }
}
