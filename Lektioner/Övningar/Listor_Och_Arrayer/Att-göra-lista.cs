/*
Skapa en att-göra-lista med två listor: en för saker som ska göras och en för saker som är klara.

Programmet visar båda listorna numrerade, t.ex.

ATT GÖRA

Handla
Städa
KLART

Diska
Input från användaren:

En text → läggs till sist i “att göra”.
Ett nummer → den saken flyttas från “att göra” till “klart”.
Ordet ångra → det senast avklarade flyttas tillbaka till “att göra” (sist i listan).
Om användaren anger ett nummer som inte finns i listan ska programmet säga till istället för att krascha.
*/

List<string> Todo = [];
List<string> Done = [];

while (true)
{
    Console.Clear();
    Console.WriteLine("\n===Att göra lista===");
    for (int i = 0; i < Todo.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Todo[i]}");
    }
    Console.WriteLine("===Färdiga uppgifter===");
    for (int i = 0; i < Done.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Done[i]}");
    }

    Console.WriteLine("\n(Ordet \"ångra\" flyttar tillbaka senaste uppgiften till listan)");
    Console.WriteLine("(Nummret på uppgiften flyttar den till färdig listan)");
    Console.WriteLine("\nVad har du att göra? ");
    string input = Console.ReadLine()!;

    if (int.TryParse(input, out int todoindex))
    {
        todoindex = todoindex - 1;
        Done.Add(Todo[todoindex]);
        Todo.RemoveAt(todoindex);
    }
    else
    {
        if (input == "ångra")
        {
            Done.RemoveAt(Todo.Count);
            Todo.Add(input);
        }
        Todo.Add(input);
    }
}