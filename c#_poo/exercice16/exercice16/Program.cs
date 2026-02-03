// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> mots = new List<string>();
string saisie;
Console.WriteLine("taper des mots ( stop)pour finir  :");

do
{
    saisie = Console.ReadLine();

    if (saisie != "stop")
    {
        mots.Add(saisie);

    }

}while (saisie != "stop");




Console.WriteLine("Nombre de mots saisis : " + mots.Count);
Console.WriteLine("Liste des mots :");

foreach (string mot in mots)
{
    Console.WriteLine(mot);
}

