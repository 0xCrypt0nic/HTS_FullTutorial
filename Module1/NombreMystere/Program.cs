// Jeu NombreMystere
const int nbMystere = 7;

Console.WriteLine("Bonjour et bienvenu dans le jeu du Nombre Mystere, comment vous appelez vous ?");
string? name = Console.ReadLine();

Console.WriteLine($"Parfait {name}, vous pouvez essayer de deviner le nombre mystere !, allez-y c'est à vous : ");

int res = 0;

while (res != nbMystere)
{
    int.TryParse(Console.ReadLine(), out res);
    if (res != nbMystere)
        Console.WriteLine("Mauvaise réponse, essayez encore :");
}

Console.WriteLine("Bravo !");