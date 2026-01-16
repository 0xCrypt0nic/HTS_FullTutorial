Console.WriteLine("Bonjour, saisir votre prénom :");
string? prenom = Console.ReadLine();
Console.WriteLine("Merci, saisir votre âge :");
int age = 0;
int.TryParse(Console.ReadLine(), out age);
Console.Clear();
Console.WriteLine($"Bonjour {prenom}, vous avez {age} ans.");