int [] RandomMassiv(int size)
{
    int[] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

void ReversMassiv(int [] array)
{
    for(int i = 0; i< array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = temp;
    }
}
Console.WriteLine("Введите длинну массива : ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = RandomMassiv(num);
Console.WriteLine(string.Join(",", array));
ReversMassiv(array);
Console.WriteLine(string.Join(",", array));


