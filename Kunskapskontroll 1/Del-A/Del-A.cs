//En lista där användaren ska ange namnet på varje vara

//En lista där användaren ska ange priset för varje vara (i heltal)

/*

Krav för godkänt:
* Programmet kör en loop och visar hela tiden listan som en numrerad lista med totalsumma.
* Man kan lägga till en vara (namn+pris) sist i listan
* De två listorna hålls i synk -tar man bort en vara så försvinner både namn och pris
* Man kan ta bort en var genom att ange dess nummer
* Ett pris som inte är ett heltal, eller ett nummer som inte finns, hanteras utan att programmet krachar

*/

//OBS! När kvittot skrivs ut längst ner i koden, eller när listan med produkter printas ut så kan de gamla produkterna vara kvar. Jag har försökt med Console.Clear(); men fungerade inte. Ai rekomenderade mig att testa i powershell, och där funkar koden. 

//Rubrik och skapade listorna
Console.WriteLine("Inköpslista");
List<string> produkt = [];
List<int> pris = [];

static string Ask(string question)
{
    Console.WriteLine(question + "");
    return Console.ReadLine()!;
}


// En loop som alltid skriver ut vad som finns på inköpslistan
while (true)
{
    Console.Clear();
    int total = 0;
    for (int i = 0; i < produkt.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {produkt[i]} {pris[i]} kr");
        total += pris[i];
    }
    Console.WriteLine($"Total: {total}");
    Console.WriteLine("");

    //Printar ut menyn
    string[] menu = [
        "Vad vill du göra?",
        "1. Lägga till en produkt",
        "2. Ta bort en produkt",
        "3 Klar med listan"
    ];
    string choice = Ask(string.Join("\n", menu) + "\n");
    Console.Clear();


    // Lite radbrytning för att göra det snyggare (Choice 1)
    if (choice == "1")
    {
        //Lägger till en vara/produkt, med namn och pris
        string namn = Ask("Vilken vara vill du lägga till: ");
        if (int.TryParse(Ask("Vad är priset på varan (heltal): "), out int värde))
        {
            produkt.Add(namn);
            pris.Add(värde);
        }
        else
        {
            Console.WriteLine("Ange ett HELTAL!");
        }

    }


    // Lite radbrytning för att göra det snyggare (Choice 2)
    else if (choice == "2")
    {
        //Tar bort en produkt genom att välja produktens nummer
        int index;
        while (!int.TryParse(Ask("Vilken produkt vill du ta bort (ange produktnummret): "), out index))
        {
            Console.WriteLine("Produktnummret finns inte, försök igen: ");
        }
        index = index - 1;
        if (index >= 0 && index < produkt.Count)
        {
            produkt.RemoveAt(index);
            pris.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Produktnummret finns inte!");
        }
    }


    // Lite radbrytning för att göra det snyggare (Choice 3)
    else if (choice == "3")
    {
        //Ska visa alla produkter och totalsumman, typ som ett kvitt
        //Asvlar också programmet
        Console.Clear();
        Console.WriteLine("----- KVITTO -----");

        int summa = 0;
        for (int i = 0; i < produkt.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {produkt[i]} {pris[i]} kr");
            summa += pris[i];
        }

        Console.WriteLine("------------------");
        Console.WriteLine($"TOTALT: {summa} kr");
        break;
    }
}
