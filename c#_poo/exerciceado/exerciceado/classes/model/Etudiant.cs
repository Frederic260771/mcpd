using exerciceado.classes.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceado.classes.model
{


    
   

    internal class Etudiant
    {
        private int v1;
        private string v2;
        private string v3;
        private DateTime dateTime;
        private string v4;
        private object value;
        private string v;

        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DatedeNaissance { get; set; }
        public string Email { get; set; }

        public Etudiant(int? id, string nom, string prenom, string v, DateTime date_de_naissance, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DatedeNaissance = date_de_naissance;
            Email = email;
        }

        public Etudiant(int v1, string v2, string v3, DateTime dateTime, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.dateTime = dateTime;
            this.v4 = v4;
        }

        public Etudiant(object value, string v, string v2, string v3, string v4)
        {
            this.value = value;
            this.v = v;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Nom : {Nom}, Prenom {Prenom}, Date_de_Naissance : {DatedeNaissance}, Email : {Email}.";
        }

        internal static void add(Etudiant etudiant)
        {
            throw new NotImplementedException();
        }

    }
}





    