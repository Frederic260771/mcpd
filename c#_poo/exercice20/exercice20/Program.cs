

using System.Linq;

SortedSet<string> participants = new SortedSet<string>() { "frederic", "marco", "bob","frederic" };

Console.WriteLine("participants :");


participants.Add("frederic");
participants.Add("marco");
participants.Add("bob");
participants.Add("frederic");


foreach (string str in participants)
    Console.WriteLine(str);


string participant = "bob";

if (participants.Contains(participant))
{
    Console.WriteLine("bob est bien inscrit.");
}
else
{
    Console.WriteLine("participant n'est pas inscrit.");
}
Queue<string> fileClients = new Queue<string>();


fileClients.Enqueue("frederic");
fileClients.Enqueue("marco");
fileClients.Enqueue("bob");

Console.WriteLine("Appuyez sur Entrée ...");


while (fileClients.Count > 0)
{
    Console.ReadLine(); 

    string clientEnCours = fileClients.Dequeue();
    Console.WriteLine("Client en cours de traitement : {frederic}");
    Console.WriteLine("Clients restants : {frederic}");
}


Console.WriteLine("C'est l'heure de la pause.");
 
