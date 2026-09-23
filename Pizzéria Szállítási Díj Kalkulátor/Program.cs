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
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"========================================");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Vásárló neve:   {vn}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Rendelés összege:   {rendelésö} Ft");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Szállítási díj:   {szálitás} Ft (Törzsvásárlói / 10k feletti ingyenes szállítás)");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Fizetendő végösszeg:   {végössz} Ft");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"========================================");
Console.ForegroundColor = ConsoleColor.Black;