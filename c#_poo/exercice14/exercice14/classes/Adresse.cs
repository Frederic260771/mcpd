using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice14.classes
{
    internal class Adresse
    {

        
        
            private int NumeroRue { get; set; }
            private string NomRue { get; set; }
            private string Ville { get; set; }
            private string CodePostal { get; set; }
        
            public Adresse(int NumeroRue, string NomRue, string Ville, string CodePostal)
            {
                NumeroRue = NumeroRue;
                NomRue = NomRue;
                Ville = Ville;
                CodePostal = CodePostal;
            }

            public override string ToString()
            {
                return $"{NumeroRue} {NomRue}, {CodePostal} {Ville}";
            }
        }


    }
}
