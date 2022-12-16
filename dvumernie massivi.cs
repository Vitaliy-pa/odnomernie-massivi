// Павлов 4.1 Базовый
int i, n, m, t;
int[,] mas = new int[5, 4];
Random random= new Random();
for (n = 0; n < 5; n++)
{
    for (m = 0; m < 4; m++)
    {
        mas[n, m] = random.Next(1, 99);
        Console.Write("{0}\t", mas[n, m]);
    }
    Console.WriteLine();
}
m = 4;
n = 5;
for (i = 0; i < n - 1; i++)
{
    if (mas[i, m - 1] < mas[i + 1, m - 1])
    {
        t = mas[i, m - 1];
        mas[i, m - 1] = mas[i + 1, m - 1];
        mas[i + 1, m - 1] = t;
    }
}
Console.WriteLine();
for (n = 0; n < 5; n++)
{
    for (m = 0; m < 4; m++)
    {
        Console.Write("{0}\t", mas[n, m]);
    }
}
