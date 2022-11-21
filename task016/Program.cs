// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Ваше число \n:");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    int count = 1;
    while (count <= n)
    {
    int res = count*count*count; // ну или :  res = Math.Pow(count, 3);
    count++;
    Console.Write($"{res}, ");
    }
} 
else if (n < 0)
{
    int count = (-1);
    while (count >= n)
    {
    int res = count*count*count; // ну или :  res = Math.Pow(count, 3);
    count = count+(-1);
    Console.Write($"{res}, ");
    }
} 
else 
{
    Console.WriteLine("что то не так");
}