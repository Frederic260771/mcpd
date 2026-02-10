using exerciceado.classes;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceado.classes
{
    internal class Commandes
    {
        private object client;

        public int? Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public float Total { get; set; }

        public Commandes() { }
        public Commandes(int? id, int clientId, DateTime date, float total)
        {
            Id = id;
            ClientId = clientId;
            Date = date;
            Total = total;


        }
        public void AjouterCommande(int clientId, Commandes commande)
        {
            

            if (client != null)
            {
                commande.ClientId = clientId;
                Commandes.Add(commande);
                
                Console.WriteLine("Commande ajoutée");
            }
            else
            {
                Console.WriteLine("Client introuvable.");
            }
        }

        public static void Add(Commandes commande)
        {
            throw new NotImplementedException();
        }
    }

}
}

