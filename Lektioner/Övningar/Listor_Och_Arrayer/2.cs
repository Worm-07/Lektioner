/*
Skapa en List<string> med några namn. Lägg till ett i slutet och ett i
början, ta bort ett i mitten med RemoveAt, och skriv ut listan med en
foreach.
*/

List<string> names = ["Emil", "Andreas", "Patrick"];
names.Insert(0, "Noah");
names.Add("Joel");
names.RemoveAt(2);

foreach (string namn in names)
{
    Console.WriteLine(namn + " ");
}