// int Method(int[] collection);

//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// Console.WriteLine("Введи :  ");
// int collection = Convert.ToInt32(Console.ReadLine());
// int n = Method(collection);
// Console.WriteLine("Вот :  " +n);

Console.WriteLine("Введи длинну массива :  ");
int cnt = Convert.ToInt32(Console.ReadLine());
int [] mass = new int [cnt];
for (int i = 0; i < cnt; i++)
{
    mass[i] = new Random().Next(0, 2);
    // Console.Write(" "+mass[i]);
}
Console.Write("[" + string.Join(", ", mass) + "]");