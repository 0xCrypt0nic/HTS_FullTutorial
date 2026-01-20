using TPCalculatrice;

//Calculatrice uneCalculatrice = new Calculatrice();
//Console.WriteLine($"Résultat de 5 + 5 : {uneCalculatrice.Addition(5, 5)}");

Console.WriteLine("Bienvenue sur une calculatrice");

Console.WriteLine("Saisissez le premier nombre :");
int nb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Saisissez le deuxième nombre :");
int nb2 = int.Parse(Console.ReadLine());

Console.WriteLine("Saisissez votre opérateur :");
string operateur = Console.ReadLine();

Calculatrice calc = new();
int resultat = 0;

if (operateur == "+")
{
    resultat = calc.Addition(nb1, nb2);
}
else if (operateur == "-")
{
    resultat = calc.Soustraction(nb1, nb2);
}
else if (operateur == "/")
{
    resultat = calc.Division(nb1, nb2);
}
else if (operateur == "*")
{
    resultat = calc.Multiplication(nb1, nb2);
}
else if (operateur == "%")
{
    resultat = calc.Modulo(nb1, nb2);
}
else
{
    Console.WriteLine("Opérateur non reconnu");
    return;
}

Console.WriteLine($"Le résultat de votre opération est : {resultat}");