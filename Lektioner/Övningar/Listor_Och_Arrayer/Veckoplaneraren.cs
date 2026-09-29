string[] dagar = ["Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag"];
string[] aktiviteter = new string[7];

for (int i = 0; i < 7; i++)
{
    aktiviteter[i] = "Ledig";
}

while (true)
{
    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine($"{i + 1}. {dagar[i]} - {aktiviteter[i]}");
    }
    Console.WriteLine("\nVilken dag vill du ändra? ");
    int edit = int.Parse(Console.ReadLine()!);

    if (edit > 7 || edit < 1)
    {
        Console.WriteLine("===Välj en dag mellan 1-7!===");
        continue;
    }

    Console.WriteLine("Vad vill du ändra? ");
    string aktivity = Console.ReadLine();

    aktiviteter[edit - 1] = aktivity;

}