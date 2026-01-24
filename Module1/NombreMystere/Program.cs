// Jeu NombreMystere
const int nbMystere = 7;

List<int> listOfNumbers = new List<int>();

bool gagne = false;
int nombre = 0;

Console.Clear();

while (!gagne)
{
    if (listOfNumbers.Any())
    {
        Console.WriteLine("Nombres déjà saisis : ");
        foreach (int nb in listOfNumbers)
        {
            Console.Write($" {nb}");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("Saisir un nombre entre 1 et 10");

    while (nombre < 1 || nombre > 10)
    {
        try
        {
            string? saisie = Console.ReadLine();
            nombre = saisie is not null ? int.Parse(saisie) : 0;
        }
        catch
        {
            nombre = 0;
        }
    }

    listOfNumbers.Add(nombre);

    if (nombre == nbMystere)
    {
        Console.WriteLine("Félicitations ! Vous avez gagné et trouvé le nombre mystère");
        gagne = true;
    }
    else
    {
        Console.Clear();

        if (nombre > nbMystere)
        {
            Console.WriteLine("Raté ! Trop grand !!");
        }
        else
        {
            Console.WriteLine("Raté ! Trop petit !!");
        }
    }
}

