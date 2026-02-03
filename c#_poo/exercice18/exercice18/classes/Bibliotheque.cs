using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace exercice18.classes
{
    internal class Bibliotheque
    {
         List<Livre> livre = new List<Livre>();



        public void Ajouter(Livre livre)
        {
            this.livre.Add(livre);
            Console.WriteLine("Livre ajoute !");
        }
        public void SupprimerLivre(int numero)
        {
            livre.Remove(livre );
            Console.WriteLine("Livre supprimer !");

        }




       




    }         