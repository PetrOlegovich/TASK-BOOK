// 53. ЗАдать двумерный массив. Напишите программу которая поменяет первую 
//     и последнюю строку местами. 

// Пример: 
//     123    789
//     456 => 456
//     789    123


// Console.WriteLine("Введите размер двумерного массива M x N : ");
// Console.WriteLine("введите количество линий M :  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов  N :  ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ^^^ Ваш массив ^^^ ");

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (j < n && i == 0)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[m - 1, j];
//             matrix[m - 1, j] = temp;
//         }
//         Console.Write(matrix[i, j] + " ");
//     }

//     Console.WriteLine();
// }
// Console.WriteLine("END");


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// например был 2х5 стал 5х2;


// Console.WriteLine("Введите размер двумерного массива M x N : ");
// Console.WriteLine("введите количество линий M :  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов  N :  ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ^^^ Ваш  изначальный массив ^^^ ");
// int [,] modifiedMatrix = new int [n,m];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         modifiedMatrix[i,j] = matrix[j,i];
//         Console.Write(modifiedMatrix[i,j] + " ");
//     }
//     Console.WriteLine();

// }
// Console.WriteLine("^^^ Ваш измененный массив ^^^");




// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3    1 встречается 3 раза
// 4, 6, 1    2 встречается 2 раз
// 2, 1, 6    3 встречается 1 раз
//            4 встречается 1 раз
//            6 встречается 2 раза


// Console.WriteLine("введите размеры двумерного массива M x N. \nВведите M  :");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N : ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();


// int k = 0;
// int count = 0;
// while (k < 10)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == k)
//             {
//                 count++;
//             }
//         }

//     }
//     if (count > 0)
//     {
//         Console.WriteLine($"число {k} встречается {count} раз");
//     }
//     k++;
//     count = 0;
// }
// Console.WriteLine("END");


// Console.WriteLine("введите размеры двумерного массива M x N. \nВведите M  :");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N : ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// int[] countArray = new int[10];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int index = matrix[i, j];
//         countArray[index]++;
//     }
// }
// for (int i = 0; i < countArray.Length; i++)
// {
//     if(countArray[i] != 0)
//     {
//         Console.WriteLine( $"кол-во повторений для {i} = {countArray[i]} раз");
//     }

// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("введите размеры двумерного массива M x N. \nВведите M  :");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N : ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,,] matrix = new int[2, 2, 2];
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         for (int k = 0; k < 2; k++)
//         {
//             matrix[i, j, k] = new Random().Next(0, 10);
//             Console.Write(matrix[i, j, k] +$"({i},{j},{k}) " );
//         }
//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }
// Console.WriteLine();


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите размер двумерного массива M x N : ");
// Console.WriteLine("введите количество линий M :  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов  N :  ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ^^^ Ваш массив ^^^ ");
// Console.WriteLine("Сортировка по строкам: ");
//             int[] row = new int[colCount];
//             for (int i = 0; i < rowCount; i++)
//             {
//                 for (int j = 0; j < colCount; j++)
//                     row[j] = arr[i, j];
//                 BubbleSort(row);
//                 Insert(true, i, row, arr);
//             }


// static void Insert(bool isRow, int dim, int[] source, int[,] dest)
//         {
//             for (int k = 0; k < source.Length; k++)
//             {
//                 if (isRow)
//                     dest[dim, k] = source[k];
//                 else
//                     dest[k, dim] = source[k];
//             }
//         }

// static void BubbleSort(int[] inArray)
//         {
//             for (int i = 0; i < inArray.Length; i++)
//                 for (int j = 0; j < inArray.Length - i - 1; j++)
//                 {
//                     if (inArray[j] > inArray[j + 1])
//                     {
//                         int temp = inArray[j];
//                         inArray[j] = inArray[j + 1];
//                         inArray[j + 1] = temp;
//                     }
//                 }
//         }

// Console.WriteLine(" ^^^ Ваш массив ^^^ ");

// for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
//     for (var j = 0; j < a.GetLength(1); j++)
//     {
//         Console.Write("{0,4}", a[i, j]);
//     }




















// for (int i = 0; i < m; i++)
// {

//     for (int j = i + 1; j < n; j++)
//     {
//         int max = matrix[i,j];
//         int temp = matrix[i, j];

//         if (matrix[i, j] > temp )
//         {
//             max = matrix[i, j];
//         }

//         matrix[i, j] = max;
//         max = temp;
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ^^^ Ваш массив ^^^ ");







using System;
namespace BabbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colCount = 6;//n
            int rowCount = 5;//m
            int[,] arr = GenerateArray(rowCount, colCount);
            Console.WriteLine("Исходный массив");
            PrintArray(arr);
            Console.WriteLine("Сортировка по строкам: ");
            int[] row = new int[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = arr[i, j];
                BubbleSort(row);
                Insert(true, i, row, arr);
            }
            PrintArray(arr);
            Console.WriteLine("Сортировка по столбцам: ");
            int[] col = new int[rowCount];
            for (int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                    col[j] = arr[j, i];
                BubbleSort(col);
                Insert(false, i, col, arr);
            }
            PrintArray(arr);
        }
        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }
        public static int[,] GenerateArray(int t, int i)
        {
            int[,] table = new int[t, i];
            Random random = new Random();
            for (int a = 0; a < t; a++)
            {
                for (int b = 0; b < i; b++)
                {
                    table[a, b] = random.Next(0, 9);
                }
            }
            return table;
        }
        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
    }
}