using TPCalculatrice;
using TPCalculatrice.Operations;

//Calculatrice uneCalculatrice = new Calculatrice();
//Console.WriteLine($"Résultat de 5 + 5 : {uneCalculatrice.Addition(5, 5)}");

Console.WriteLine("Bienvenue sur une calculatrice");

Console.WriteLine("Saisissez le premier nombre :");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Saisissez le deuxième nombre :");
int b = int.Parse(Console.ReadLine());

Operation operation;

Console.WriteLine("Saisissez votre opérateur :");
string operateur = Console.ReadLine();

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