// написать прорамму, которая будет принимать на ввод два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Например :
//  34, 4 ->  не кратно, остаток 4
//  16, 4 ->  кратно

Console.WriteLine("Введите первое число :  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :  ");
int num2 = Convert.ToInt32(Console.ReadLine());
int digit = num1%num2;
if (digit == 0)
{
    Console.WriteLine("кратно");
}
else 
{
    Console.WriteLine($"не кратно, остаток {digit}");
}