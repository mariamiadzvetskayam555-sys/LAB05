using LAB05;


try
{
    AProgression pr1 = new AProgression(2, 3);
    pr1.PrintInfo();
    Console.WriteLine($"Сумма: {pr1.GetSum(4)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine();

try
{
    AProgression pr2 = new AProgression(4, 0);
    pr2.PrintInfo();
    Console.WriteLine($"Сумма: {pr2.GetSum(4)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine();

try
{
    AProgression pr3 = new AProgression(-10, 3);
    pr3.PrintInfo();
    Console.WriteLine($"Сумма: {pr3.GetSum(4)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine();

try
{

    AProgression pr4 = new AProgression(7, 4);
    pr4.PrintInfo();
    Console.WriteLine($"Сумма: {pr4.GetSum(-2)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

