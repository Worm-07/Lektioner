/*
Skapa ett program där användaren matar in poäng (heltal), ett i taget. Varje poäng sparas i en lista.

Efter varje inmatning ska programmet visa:

Alla poäng hittills, t.ex. 12 + 7 + 20 = 39
Antal inmatade poäng
Det högsta poänget
Om användaren skriver något som inte är ett heltal ska programmet säga till och inte spara något.

Om användaren skriver 0 ska det senast inmatade poänget tas bort (man råkade skriva fel).
*/

List<int> points = [];

while (true)
{

    Console.WriteLine("\nAnge ditt poäng i heltal: ");
    int point = int.Parse(Console.ReadLine()!);
    points.Add(point);

    // Visa alla pong hittills
    foreach (int i in points)
    {
        Console.Write(i + " + ");
    }
}