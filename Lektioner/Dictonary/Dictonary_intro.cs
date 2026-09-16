// With values from the start
Dictionary<string, int> ages = new()
{
    ["Andreas"] = 5,
    ["Emil"] = 19,
    ["Patrick"] = 67
};
Console.WriteLine($"Emil is {ages["Emil"]} years old");
Console.WriteLine($"Andreas is {ages["Andreas"]} years old");
Console.WriteLine($"Patrick is {ages["Patrick"]} years old");




Dictionary<string, string> svToEn = new()
{
    ["hund"] = "dog",
    ["katt"] = "cat",
    ["fågel"] = "bird",
    ["råtta"] = "rat",
    ["Patrik"] = "Patrick(med ck)"
};
Console.WriteLine("Vilket ord vill du översätta till engelska? ");
string? toTranslate = Console.ReadLine();

if (svToEn.ContainsKey(toTranslate!))
{
    Console.WriteLine($"{toTranslate} är {svToEn[toTranslate]} på engelska");
}
else
{
    Console.WriteLine($"{toTranslate} finns inte i vår engelska ordlista");
}

svToEn["råtta"] = "dirty rat";
svToEn["rast"] = "break";


svToEn.TryGetValue(toTranslate, out string possibleValue);
Console.WriteLine($"Using TryGetValue: {possibleValue}");
Console.WriteLine($"is TryGetValue null? {possibleValue == null}");