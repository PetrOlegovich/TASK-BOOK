// Напишите программу которая принимает на вход число и проверяет, кротно ли оно одновременно 7 и 23.
// Например : 
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число для проверки : ");
int num = Convert.ToInt32(Console.ReadLine());
int digit1 = num%7;
int digit2 = num%23;
if (digit1 == 0 & digit2 ==0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}