int y;
int wurzel;
double ergebnis;

Console.Write("\n\tGeben sie eine Zahl ein: ");
y = Convert.ToInt32(Console.ReadLine());

Console.Write("\n\tGeben sie ein die wievielte Wurzel gezogen werden soll: ");
wurzel = Convert.ToInt32(Console.ReadLine());

ergebnis = Math.Pow(y, 1.0 / wurzel);

Console.Clear();

if (wurzel % 2 != 0)
{
    Console.Write("\n\tDie " + wurzel + ". Wurzel aus " + y + " ist = " + ergebnis);

    if (ergebnis % 2 != 0)
    {
        Console.WriteLine("\n\n\t\t        Gerundet = " + Math.Round(ergebnis, 3));
    }
}

if (wurzel % 2 == 0)
{
    Console.WriteLine("\n\tDie " + wurzel + ". Wurzel aus " + y + " ist = " + ergebnis +
                      " / " + ergebnis * -1 + "\n\n\t\t        Gerundet = " + Math.Round(ergebnis, 3) +
                      " / " + Math.Round(ergebnis, 3) * -1);
}
