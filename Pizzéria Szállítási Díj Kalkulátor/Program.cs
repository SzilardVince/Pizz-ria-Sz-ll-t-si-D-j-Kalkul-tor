using System.Drawing;

string vn = "Tóth Bence";
double rendelésö = 8500;
bool törzse = true;
double szálitás = 0;
if (törzse == false)
{
  
    if (rendelésö >= 5000)
    {
        szálitás = 500;
    }
    else
    {
        szálitás = 1200;
    }
}
double végössz = (rendelésö + szálitás);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"========================================");
Console.WriteLine($"Vásárló neve:   {vn}");
Console.WriteLine($"Rendelés összege:   {rendelésö} Ft");
Console.WriteLine($"Szállítási díj:   {szálitás} Ft (Törzsvásárlói / 10k feletti ingyenes szállítás)");
Console.WriteLine($"Fizetendő végösszeg:   {végössz} Ft");
Console.WriteLine($"========================================");