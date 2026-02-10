using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceado.classes
{
    internal class Client
    {
        internal object Codepostal;
        private int? v;
        private object email;

        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public List<Commandes> Commandes { get; set; } = new List<Commandes>();

        public Client() { }
        public Client(int? id, string nom, string prenom, string adresse, string codepostal, string ville, string telephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codepostal;
            Ville = ville;
            Telephone = telephone;


        }

        public Client(int? v, string nom, string prenom, string adresse, object email)
        {
            this.v = v;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            this.email = email;
        }

        internal static Client FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}