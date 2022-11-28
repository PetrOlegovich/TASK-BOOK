// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат записать в новом массиве
// [1 2 3 4 5]-> 5 8 3
// [6 7 3 6]-> 36 21
 
// int[] RandomMassiv(int size)
// {
//     int [] arr = new int[size];
//     for ( int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 5);
//     }
//     return arr;
// }


// Console.WriteLine("Введите длинну массива : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] array = RandomMassiv(num);
// Console.WriteLine("Ваш массив :" + string.Join(",", array));
// int j = array.Length-1;
// int []Sum = new int[(array.Length - array.Length/2)];     //int sum = array.Length % 2 + array.Length / 2     или так
// for (int i = 0; i < Sum.Length; i++, j--) 
// {
//     if(i==j)
//     {
//         Sum[i]=array[i];
//         break;
//     }
//     Sum[i] = array[i]*array[j];
// }       
// Console.WriteLine(string.Join(" , ", Sum));



//////////////////////////////////////////////////////
//////////////////////////////////////////////////////
//////////////////////////////////////////////////////

//РЕШЕНИЕ ОТ ПРЕПОДАВАТЕЛЯ : 

int[] RandomMassiv(int size)
{
    int [] arr = new int[size];
    for ( int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 5);
    }
    return arr;
}


Console.WriteLine("Введите длинну массива : ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = RandomMassiv(num);
Console.WriteLine(string.Join(",", array));
int newLength = array.Length % 2 + array.Length / 2;
int[] newArray = new int [newLength];
for (int i = 0; i < array.Length/2; i++)
{
    newArray[i] = array[i] * array[array.Length-1-i];    
}
if(array.Length % 2 > 0)
{
    newArray[newArray.Length-1] = array[array.Length/2];
}
Console.WriteLine(string.Join(",", newArray));