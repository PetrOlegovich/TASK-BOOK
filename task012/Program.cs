Console .Write("ВВедите координату X \n: ");
int x = Convert.ToInt32(Console.ReadLine());
Console .Write("ВВедите координату Y \n: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console .WriteLine("Точка находится в первой четверти: ");
}
else if (x < 0 && y > 0)
{
    Console .WriteLine("Точка находится во второй  четверти: ");
}
else if (x < 0 && y < 0)
{
    Console .WriteLine("Точка находится в третьей четверти: ");
}
else
{
    Console .WriteLine("Точка находится в четвертой четверти: ");
}