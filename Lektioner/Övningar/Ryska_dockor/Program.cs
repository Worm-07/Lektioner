var big = new RussianDoll(8);
var medium = new RussianDoll(5);
var small = new RussianDoll(2);

medium.AddInsideMe(small);
big.AddInsideMe(medium);
big.TellMeAboutDollsInsideYou();

// Storlek utanför 1-10 justeras
Console.WriteLine($"Storlek 0 blir {new RussianDoll(0).Size}");
Console.WriteLine($"Storlek 99 blir {new RussianDoll(99).Size}");

// Större docka i mindre ska ge fel
try
{
    small.AddInsideMe(big);
}
catch (ArgumentException e)
{
    Console.WriteLine($"Fel: {e.Message}");
}
