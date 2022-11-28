// Написать программу которая принимает на вход число N и выдает произведение чисел от 1 до N 
// Пример :
// 4 => 24
// 5 => 120

int Method(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}
Console.WriteLine("ВВедите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = Method(a);
Console.WriteLine($"факториал числа {a} равен {sum}");