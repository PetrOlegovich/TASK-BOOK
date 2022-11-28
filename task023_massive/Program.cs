// Задать массив. НАписать программу которая определяет , присутствует ли заданное число в массиве .
// 4;массив [6, 7, 19, 345, 3]-> нет
// 3;массив [6, 7, 19, 345, 3]-> да

int [] RandomMasive(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length ; i++)
    {
        arr[i] = new Random().Next(-2, 5);
    }
    return arr;
}
Console.WriteLine("Введите длинну массива : ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = RandomMasive(num);
Console.WriteLine("Ваш массив :" + string.Join(",", array));
bool check = false;
Console.WriteLine("Введите число которое вы ищите : ");
int x = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < array.Length; j++)
{
    if(array[j] == x)
    {
        check = true;
    }
}
if (check == true )
{
    Console.WriteLine("ДА ");
}
else
{
    Console.WriteLine("НЕТ ");
}
