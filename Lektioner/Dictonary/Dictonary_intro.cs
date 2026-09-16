// With values from the start
Dictionary<string, int> ages = new()
{
    ["Andreas"] = 49,
    ["Emil"] = 19,
};

Console.WriteLine($"Emil is {ages["Emil"]} years old");



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