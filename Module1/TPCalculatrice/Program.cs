using TPCalculatrice;
using TPCalculatrice.Operations;

//Calculatrice uneCalculatrice = new Calculatrice();
//Console.WriteLine($"Résultat de 5 + 5 : {uneCalculatrice.Addition(5, 5)}");

Console.WriteLine("Bienvenue sur une calculatrice");


int GetIntValue(string valeur)
{
    int? resultat = null;
    while (resultat is null)
    {
        Console.WriteLine($"Saisissez la valeur {valeur} entière :");
        string? saisie = Console.ReadLine();
        if (saisie is not null)
        {
            try
            {
                resultat = int.Parse(saisie);
            }
            catch
            {
                resultat = null;
            }
        }
    }

    return resultat.Value;
}


while (true)
{
    Console.WriteLine("Saisissez l'opérateur ou 'q' pour quitter");
    string? operateur = Console.ReadLine();

    if (operateur is null || operateur.Equals("q"))
        break;


    int a = GetIntValue("première");
    int b = GetIntValue("deuxième");

    Operation operation;

    if (operateur == "+")
    {
        operation = new Addition(a, b);
    }
    else if (operateur == "-")
    {
        operation = new Soustraction(a, b);
    }
    else if (operateur == "/")
    {
        operation = new Division(a, b);
    }
    else if (operateur == "*")
    {
        operation = new Multiplication(a, b);
    }
    else if (operateur == "%")
    {
        operation = new Modulo(a, b);
    }
    else
    {
        Console.WriteLine("Opérateur non reconnu");
        return;
    }

    Calculatrice calc = new(operation);
    calc.Executer();

    Console.WriteLine($"Le résultat de votre opération est : {calc.Resultat}");
}

foreach (Operation uneOp in Historique.Operations)
{
    Console.WriteLine(uneOp.ToString());
}