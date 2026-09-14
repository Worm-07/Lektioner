Console.WriteLine("Välkommen till banken!");

User user = new("Emil", "Chau");

Console.WriteLine("\n===Kontoinformation===");
Console.WriteLine($"{user.firstname} {user.lastname}");
Console.WriteLine(user.kontonummer);
Console.WriteLine("======================");

Console.WriteLine($"Saldo: {user.saldo}");

double Saldo = user.saldo - user.kontoavgift;
Console.WriteLine($"Din saldo efter kontoavgiften är: {Saldo}");

if (user.kontostatus = false)
{
    Console.WriteLine("Ditt konto är spärrat");
}
else
{
    Console.WriteLine("Ditt konto är aktivt");
}