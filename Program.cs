double[] eingabe = new double[7];
int i;
double max = 0;
double min = 0;
int tagmax = 0;
int tagmin = 0;

Console.WriteLine("Bitte geben Sie Ihren Umsatz ein: ");

for (i = 0; i < 7; i++)
{
    eingabe[i] = Convert.ToDouble(Console.ReadLine());

    if (i == 0)
    {
        max = eingabe[i];
        min = eingabe[i];
    }

    if (eingabe[i] > max)
    {
        max = eingabe[i];
        tagmax = i + 1;
    }

    if (eingabe[i] < min)
    {
        min = eingabe[i];
        tagmin = i + 1;
    }
}

Console.WriteLine($"Das Mínimum liegt bei: {min} und wurde am {tagmin}. Tag erzielt.");
Console.WriteLine($"Das Maximum liegt bei: {max} und wurde am {tagmax}. Tag erzielt.");
