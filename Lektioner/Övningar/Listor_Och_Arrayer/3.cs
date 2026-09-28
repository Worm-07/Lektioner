/*
Bygg en List<int>, fyll den med talen 1–20 med en for-loop och Add,
och ta sedan bort alla jämna tal (n % 2 == 0) — antingen med en
baklänges-for eller med RemoveAll.
*/

List<int> numbers = [];

for (int i = 1; i < 21; i++)
{
    numbers.Add(i);
}

numbers.RemoveAll(n => n % 2 == 0);

foreach (int tal in numbers)
{
    Console.WriteLine(tal + " ");
}