// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void PrintArray(double [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray( double [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = Math.Round((Convert.ToDouble((new Random().Next(-100, 200)) + new Random().NextDouble())), 2);
//         }

//     }
// }
// Console.WriteLine("Введите количество cстолбцов : ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк    : ");
// int line = Convert.ToInt32(Console.ReadLine());
// double [,] matrix = new double [column, line];
// // PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите размерность двумерного массива m x n");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [m,n];
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// matrix[i,j] = new Random().Next(0,11);
// Console.Write(matrix[i,j] + " ");
// }
// Console.WriteLine();
// }




// Console.WriteLine("Введите размерность двумерного массива m x n");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [m,n];
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// matrix[i,j] = i+j;
// Console.Write(matrix[i,j] + " ");
// }
// Console.WriteLine();
// }


// Console.WriteLine("Введите размерность двумерного массива m x n");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {

//         matrix[i, j] = new Random().Next(5, 6);
//             if (i%2 == 0 && j%2==0 )
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         Console.Write(matrix[i, j] + "  ");
//     }
//     Console.WriteLine();
// }



// Console.WriteLine("Введите размерность двумерного массива m x n");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// int res = 0;
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {

//         matrix[i, j] = new Random().Next(1, 9);
//             if (i == j)
//             {
//                 res = res + matrix[i, j];
//             }
//         Console.Write(matrix[i, j] + "  ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"сумма диоганали = \n{res}");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.






// Задача 49: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.WriteLine("Введите размерность двумерного массива m x n");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// for (int i = 0; i < n; i++)
// {
//     double sum = 0;
//     for (int j = 0; j < m; j++)
//     {
//         sum += matrix[j, i];
//     }
//     Console.WriteLine($"среднее арифметическое {i + 1} столба = " + Math.Round(sum / m, 2));
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



Console.WriteLine("Введите размер двумерного массива M x N");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Введите координаты массива M х N");
Console.Write("Введите M : ");
int firstDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N : ");
int lastDot = Convert.ToInt32(Console.ReadLine());
if (firstDot  <= m && lastDot <= n)
{
    Console.WriteLine("результат ваших координат : " + matrix[firstDot-1, lastDot-1]);
}
else
{
    Console.WriteLine("нет таких координат ");
}
