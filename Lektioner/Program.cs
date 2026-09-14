Console.WriteLine("Välkommen till banken!");

User user = new("Emil", "Chau");

Console.WriteLine("\n===Kontoinformation===");
Console.WriteLine($"{user.firstname} {user.lastname}");
Console.WriteLine(user.kontonummer);
Console.WriteLine("======================");

Console.WriteLine($"Saldo: {user.saldo}");