
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> mots = new List<string>();
        string saisie;

        
        do
        {
            Console.Write("Entrez un mot (\"stop\" pour terminer) : ");
            saisie = Console.ReadLine();

            if (saisie != "stop")
            {
                mots.Add(saisie);
            }

        } while (saisie != "stop");

        
        Console.WriteLine("\nNombre total de mots saisis : " + mots.Count);
        Console.WriteLine("Liste des mots :");

        foreach (string mot in mots)
        {
            Console.WriteLine(mot);
        }
    }
}