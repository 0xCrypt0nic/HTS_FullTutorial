using TPCalculatrice;
using TPCalculatrice.Operations;

//Calculatrice uneCalculatrice = new Calculatrice();
//Console.WriteLine($"Résultat de 5 + 5 : {uneCalculatrice.Addition(5, 5)}");

Console.WriteLine("Bienvenue sur une calculatrice");

while (true)
{
    Console.WriteLine("Saisissez l'opérateur ou 'q' pour quitter");
    string? operateur = Console.ReadLine();

    if (operateur is null || operateur.Equals("q"))
        break;


    int a, b = 0;
    Console.WriteLine("Saisissez le premier nombre :");
    int.TryParse(Console.ReadLine(), out a);

    Console.WriteLine("Saisissez le deuxième nombre :");
    int.TryParse(Console.ReadLine(), out b);

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