// Павлов 22-ИСП-2\1 средний уровень 5 вариант
try
{
    Console.Write("Введите l: ");
    double l = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите k:");
    double k = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите m:");
    double m = double.Parse(Console.ReadLine());
    if (n > 2 && n > 1 ) ;
    else Console.WriteLine(m < l);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}