using TPCalculatrice;

//Calculatrice uneCalculatrice = new Calculatrice();
//Console.WriteLine($"Résultat de 5 + 5 : {uneCalculatrice.Addition(5, 5)}");

Console.WriteLine("Bienvenue sur une calculatrice");

Console.WriteLine("Saisissez le premier nombre :");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Saisissez le deuxième nombre :");
int b = int.Parse(Console.ReadLine());

Calculatrice calc = new(a, b);

Console.WriteLine("Saisissez votre opérateur :");
string operateur = Console.ReadLine();

if (operateur == "+")
{
    calc.Addition(calc.OperG, calc.OperD);
}
else if (operateur == "-")
{
    calc.Soustraction(calc.OperG, calc.OperD);
}
else if (operateur == "/")
{
    calc.Division(calc.OperG, calc.OperD);
}
else if (operateur == "*")
{
    calc.Multiplication(calc.OperG, calc.OperD);
}
else if (operateur == "%")
{
    calc.Modulo(calc.OperG, calc.OperD);
}
else
{
    Console.WriteLine("Opérateur non reconnu");
    return;
}

Console.WriteLine($"Le résultat de votre opération est : {calc.Resultat}");