/*
Skapa en int[] med fem tal. Skriv ut summan och medelvärdet med en
foreach. (Medelvärde = summa / .Length — tänk på int-divisionsfällan
från lektion 2!)
*/

double summa = 0;
double medelvärde = 0;
double[] numbers = [7, 20, 13, 9, 3];


foreach (int tal in numbers)
{
    summa += tal;
}
medelvärde = summa / numbers.Length;
Console.WriteLine($"Summan är: {summa}\nMedelvärdet är: {medelvärde:F2}");