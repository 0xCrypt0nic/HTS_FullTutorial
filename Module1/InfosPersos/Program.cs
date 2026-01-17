Console.WriteLine("Bonjour, saisir votre prénom :");
string? prenom = Console.ReadLine();
Console.WriteLine("Merci, saisir votre âge :");
// int age = int.Parse(Console.ReadLine());
//int age = Convert.ToInt32(Console.ReadLine());
int age = 0;
int.TryParse(Console.ReadLine(), out age);
Console.Clear();
Console.WriteLine($"Bonjour {prenom}, vous avez {age} ans.");

if (age >= 18)
{
    Console.WriteLine("Vous êtes majeur");
}
else
{
    Console.WriteLine("Vous êtes mineur");
}