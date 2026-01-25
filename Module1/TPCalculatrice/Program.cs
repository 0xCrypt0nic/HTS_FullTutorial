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

    // switch (operateur)
    // {
    //     case "+":
    //         operation = new Addition(a, b);
    //         break;
    //     case "-":
    //         operation = new Soustraction(a, b);
    //         break;
    //     case "*":
    //         operation = new Multiplication(a, b);
    //         break;
    //     case "/":
    //         operation = new Division(a, b);
    //         break;
    //     case "%":
    //         operation = new Modulo(a, b);
    //         break;
    //     default:
    //         operation = null;
    //         Console.WriteLine("Opérateur non reconnu");
    //         break;
    // }

    try
    {
        operation = operateur switch
        {
            "+" => new Addition(a, b),
            "-" => new Soustraction(a, b),
            "*" => new Multiplication(a, b),
            "/" => new Division(a, b),
            "%" => new Modulo(a, b),
            _ => throw new OperateurNonReconnuException($"{operateur} est un opérateur non reconnu")
        };

        Calculatrice calc = new(operation);
        calc.Executer();

        Console.WriteLine($"Le résultat de votre opération est : {calc.Resultat}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

foreach (Operation uneOp in Historique.Operations)
{
    Console.WriteLine(uneOp.ToString());
}