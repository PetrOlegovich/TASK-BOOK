// Написать программу замены элементов массива: положительные элементы заменить на соответсвующие отрицательные, и наоборот
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] RandMass (int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}
Console.WriteLine("Введдите длинну массива : ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = RandMass(num);
Console.WriteLine(string.Join(",", array));

for(int i = 0; i < array.Length ; i++)
{
    if(array[i] > 0)
    {
        array[i] = -array[i];         // можно было просто умножить на -1. и все. 
    }
    else
    {
        array[i] = Math.Abs(array[i]);
    }
}
Console.WriteLine(string.Join(", ",array));