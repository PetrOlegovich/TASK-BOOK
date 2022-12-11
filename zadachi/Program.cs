// void HelloYou(string firstName, string lastName)
// {
//     Console.WriteLine("Привет  "+ firstName+ " "+ lastName);
// }
// Console.Write("Введите ваше имя  ");
// string ? firstName = Console.ReadLine();
// Console.Write("Введите вашу фамилию  ");
// string ? lastName = Console.ReadLine();
// HelloYou(firstName, lastName);

///////////////////////////////////////////

// string[,] table = new string[2, 5];
// table [1, 2] = "слово";
// for ( int i = 0; i< 2 ; i++)
// {
//     for(int j = 0; j<5; j++)
//     {
//         Console.Write($"{table[i, j]}  ");
//     }
//     Console.WriteLine();
// }


// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]}  ");
//     } 
//     Console.WriteLine();   

// }






void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);