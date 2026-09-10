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

//Rubrik och skapade listorna
Console.WriteLine("Inköpslista");
List<string> produkt = [];
List<int> pris = [];

