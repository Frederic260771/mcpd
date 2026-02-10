using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice14.classes
{
    internal class User
    { private string Nom { get; set; }
        private string Prenom { get; set; }
        private Adresse Adresse { get; set; }

        
public User(string nom, string prenom, Adresse adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom}Adresse : {Adresse}";
        }
    }
}
