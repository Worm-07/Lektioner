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
    int summa = 0;
    Console.WriteLine("Ange 0 för att ta bort senaste poänget");
    Console.WriteLine("\nAnge ditt poäng i heltal: ");
    string input = Console.ReadLine()!;

    if (int.TryParse(input, out int point))
    {
        if (point == 0)
        {
            if (points.Count == 0)
            {
                Console.WriteLine("Det finns inget poäng att ta bort");
            }
            else
            {
                points.RemoveAt(points.Count - 1);
            }
        }
        else
        {
            points.Add(point);
        }
    }
    else
    {
        Console.WriteLine("\nDet är inget heltal!\n");
    }

    if (points.Count > 0)
    {
        foreach (int poäng in points)
        {
            summa += poäng;
        }

        for (int i = 0; i < points.Count; i++)
        {
            Console.Write($"{points[i]}");

            if (i < points.Count - 1)
            {
                Console.Write(" + ");
            }
        }

        Console.WriteLine($" = {summa}");

        Console.WriteLine($"Antal poäng : {points.Count}");

        int störst = points.Max();
        Console.WriteLine($"\nHögsta poäng är: {störst}");
    }
}