using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice18.classes
{
    internal class Livre
    {

        private int Numero { get; set; }
        private string Titre { get; set; }
        private string Auteur { get; set; }
        private int ExemplairesDisponibles { get; set; }

        public Livre(int numero, string titre, string auteur, int exemplaires)
        {
            Numero = numero;
            Titre = titre;
            Auteur = auteur;
            ExemplairesDisponibles = exemplaires;
        }

        public override string ToString()
        {
            return $"numéro: {Numero}, titre: {Titre}, auteur: {Auteur}" +
                $", exemplaires: {ExemplairesDisponibles}";
        }





    }
}
