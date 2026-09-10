//Rubrik till inköpslistan

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


Console.WriteLine("Inköpslista");
List<string> produkt = [];
List<int> pris = [];

static string Ask(string question)
{
    Console.WriteLine(question + "");
    return Console.ReadLine()!;
}

while (true)
{
    Console.Clear();
    string[] menu = [
        "Vad vill du göra?",
        "1. Lägga till en produkt",
        "2. Ta bort en produkt",
        "3 Klar med listan"
    ];
    string choice = Ask(string.Join("\n", menu) + "\n");
    Console.Clear();
    if (choice == "1")
    {
        //Lägger till en vara/produkt
        produkt.Add(Ask("Vilken vara vill du lägga till: "));
        pris.Add(int.Parse(Ask("Vad är priset på varan (heltal): ")));
    }
    else if (choice == "2")
    {
        //Tar bort en produkt
        int index = int.Parse(Ask("Vilken produkt vill du ta bort (agne nummer)? ")) - 1;
    }
    else if (choice == "3")
    {
        //Ska visa alla produkter och totalsumman, avslutar programmet med 1

    }
}