using System.ComponentModel.Design;

int A = 10;
int B = 20;
int C;

C = A;
A = B;
B = C;

Console.WriteLine(A);
Console.WriteLine(B);

Console.Write("premier nombre :");
int nombre1 = int.Parse(Console.ReadLine());
Console.Write("deuxieme nombre :");
int nombre2 = int.Parse(Console.ReadLine());
int somme = nombre1 + nombre2;
Console.WriteLine(somme);


Console.Write(" quelle est la temperature en degres celsius :");
string? saisie = (Console.ReadLine());
float fahrenheit;
if (float.TryParse(saisie, out float celsius)) ;
else
    Console.WriteLine("erreur de saisie");
fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine("temperature en fahrenheit : " + fahrenheit);


Console.Write("longueur d'un rectangle : ");
float longueur = float.Parse(Console.ReadLine());
Console.Write(" largeur d'un rectangle");
float largeur = float.Parse(Console.ReadLine());
float Périmètre = 2 * (longueur + largeur);
Console.WriteLine(" perimetre du rectangle est :" + Périmètre);
float Aire = longueur * largeur;
Console.WriteLine(" l'aire du rectangle est : " + Aire);


Console.Write("Entrez un entier:");
string saisie1 = Console.ReadLine();
int n;
if (!int.TryParse(saisie1, out n))
{
    Console.WriteLine("entier invalide");
}
else
{
    if (n < 0)
    {
        Console.WriteLine("le nombre est negatif.");
    }
    else if (n == 0)
    {
        Console.WriteLine("le nombre est null.");
    }
    else
    {
        Console.WriteLine("le nombre est positif .");
    }

    if (n % 2 == 0)
    {
        Console.WriteLine("le nombre est pair .");
    }
    else
    {
        Console.WriteLine("le nombre est impair .");
    }
}


Console.Write("saisir un entier.");
int nb = int.Parse(Console.ReadLine());
Console.WriteLine($"table de multiplication de {nb} :");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{nb} * {i}= {nb * i}");
}


