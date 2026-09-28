List<string> que = [];
string serving = "";

while (true)
{
    Console.WriteLine("===Kö===");
    for (int i = 0; i < que.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {que[i]}");
    }
    Console.WriteLine("\n\"klar\" avslutar programmet");
    Console.WriteLine("\"nästa\" flyttar fram kön");
    Console.WriteLine("\nAnge ditt namn: ");
    string name = Console.ReadLine()!;



    if (name == "klar")
    {
        break;
    }
    else if (name == "nästa")
    {
        if (0 >= que.Count)
        {
            Console.WriteLine("Det står ingen i kö");
        }
        else
        {
            serving = que[0];
            que.Remove(que[0]);
            Console.WriteLine($"Nu är det {serving}s tur!");
        }
    }
    else
    {
        bool innehållerSifrra = false;

        foreach (char c in name)
        {
            if (char.IsDigit(c))
            {
                innehållerSifrra = true;
                break;
            }
        }

        if (innehållerSifrra == true)
        {
            Console.WriteLine("Namnet kan bara bestå av bokstäver");
        }
        else
        {
            que.Add(name);
        }
    }
}