using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercice3.classes
{
    internal class Recette
    {

        public int? Id { get; set; }
        
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int RecetteId { get; internal set; }
        public object Ingredients { get; internal set; }

        public Recette(int? id,  string nom, string description, string instructions)
        {
            Id = id;
            
            Nom = nom;
            Description = description; 
            Instructions = instructions;
           
        }

        public Recette()
        {
        }

        public override string ToString()
        {
            return $"ID: {Id} Nom {Nom} Descrition: {Description} Instructions {Instructions}";
        }








    }
}
