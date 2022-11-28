// Написать программу которая на вход принимает число и на выход выдает количество цифр в чиселе
// Например: 
// 456 => 3
// 25 => 2 
// 1578 => 4

// Console.WriteLine("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// string num1 = Convert.ToString(num);
// int count = num1.Length;
// if(num < 0) 
// {
//     count = count-1;
// }
// Console.WriteLine(count);

Console.WriteLine("Введите число : ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 0;
if (num != 0)
{
    while (num > 0)
    {
        count++;
        num=num/10;
    }
}
else
{
    count = 1;
}
Console.WriteLine($"Количество цифр  : {count}");