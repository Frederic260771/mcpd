
using exercice2.classe.repository;
using exerciceado.classes;

{


    Client RecupererUnClientParId()
    {

        object value = AfficherClient();

        Console.WriteLine();
        Console.Write("Veuillez saisir un ID : ");

        int.TryParse(Console.ReadLine(), out int id);
        Client client = ClientRepository.RecupereUnClientParSonId(id);
        if (client == null)
            throw new ArgumentException("Id invalide !");

        return client;
    }

  
    static void Afficherclient(object client, List<Client> Client = null)
    {
        
        if (client == null)
            client = ClientRepository.RecupererToutLesClient();

        Console.WriteLine("=== LISTE DES CLIENTS ===");

       
        if (client == null || Client.Count == 0)
        {
            Console.WriteLine("Aucun client");
            return;
        }
        else
        {
            foreach (Client e in Client)
            {
                Console.WriteLine(e);
            }

            void AfficherClient()
            {
                throw new NotImplementedException();
            }
        }
    }
}

object AfficherClient()
{
    throw new NotImplementedException();
}

void AjouterClient()
{
    
    Client clientAInserer = SaisieClient();
    
    ClientRepository.AjouterUnClient(clientAInserer);
}

Client SaisieClient()
{
    throw new NotImplementedException();
}


Client Saisieclient(Client clientAModifier = null)
{
    
    bool updateMode = clientAModifier != null;

    
    string nomUpdate = updateMode ? $"({clientAModifier.Nom})" : "";
    string prenomUpdate = updateMode ? $"({clientAModifier.Prenom})" : "";
    string adresseUpdate = updateMode ? $"({clientAModifier.Adresse})" : "";
    string codepostalUpdate = updateMode ? $"({clientAModifier.Codepostal})" : "";
    string villeUpdate = updateMode ? $"({clientAModifier.Ville})" : "";
    string telephoneUpdate = updateMode ? $"({clientAModifier.Telephone})" : "";




    Console.WriteLine(updateMode ?
        "=== MODIFICATION CLIENT ===\n"
        :
        "=== AJOUT CLIENT ===\n");

    Console.Write($"Veuillez saisir un nom {nomUpdate} : ");
    string nom = Console.ReadLine();

    Console.Write($"\nVeuillez saisir un prenom {prenomUpdate}: ");
    string  prenom = Console.ReadLine();


    Console.Write($"\nVeuillez saisir une adresse {adresseUpdate}: ");
    string adresse = Console.ReadLine();

    Console.Write($"\nVeuillez saisir un codepostal {codepostalUpdate}: ");
    string codepostal = Console.ReadLine();

    Console.Write($"\nVeuillez saisir une ville {villeUpdate}: ");
    string ville = Console.ReadLine();

    Console.Write($"\nVeuillez saisir un telephone {telephoneUpdate}: ");
    string telephone = Console.ReadLine();

    
    if (nom.Trim() == "" && updateMode)
        nom = clientAModifier.Nom;

    if (prenom.Trim() == "" && updateMode)
        prenom = clientAModifier.Prenom;


    if (adresse.Trim() == "" && updateMode)
        adresse = clientAModifier.Adresse;


    if (codepostal.Trim() == "" && updateMode)
        codepostal = clientAModifier.CodePostal;


    if (ville.Trim() == "" && updateMode)
        ville = clientAModifier.Ville;


    if (telephone.Trim() == "" && updateMode)
        telephone = clientAModifier.Telephone;

    return new Client(updateMode ? clientAModifier.Id : null, nom, prenom, adresse, codepostal,ville,telephone);
}
