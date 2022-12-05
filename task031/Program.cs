// Console.WriteLine("Введите первую сторону : ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите  вторую сторону: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью сторону : ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num < num1+num2 && num1 < num+num2 && num2< num+num1)
// {
//     Console.WriteLine("СУЩЕСТВУЕТ");
// }
// else
// {
//     Console.WriteLine("НЕ СУЩЕСТВУЕТ");
// }

/////////////////////////////////////

// Console.WriteLine("Введите длинну массива : ");
// int value = Convert.ToInt32(Console.ReadLine());
// string BinaryCode = Convert.ToString(value, 2);
// Console.WriteLine(BinaryCode);

/////////////////////////////////////

// void BinaryView(int number)
// {
//     if( number == 0)
//     {
//         return;
//     }
//     BinaryView(number/2);
//     Console.Write(number%2);
// }
// Console.WriteLine("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// BinaryView(number);


///////////////////////////

// Console.WriteLine("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("0 ");
// Console.Write("1 ");
// int temp = 0;
// int temp2 = 0;
// int buf = 1;
// for (int i = 1; i < number - 1; i++)
// {
//     temp2 = temp;
//     temp = buf;
//     buf = temp2 + buf;
//     Console.Write(buf + " ");

// }
///////////////////////////

// void PrintFib(int n)
// {
//     Console.Write("0 1 ");
//     int neighbour1 = 0;
//     int neighbour2 = 1;
//     int res = 0;
//     for(int i =0; i<n -2; i++)
//     {
//         res = neighbour1+neighbour2;
//         Console.Write(res+ " ");
//         neighbour1=neighbour2;
//         neighbour2=res;
//     }
// }

// Console.WriteLine("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintFib(number);



//////////////////////////


// int[] RandomMassiv(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
//     return arr;
// }


// Console.WriteLine("Введите длинну массива : ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int[] array = RandomMassiv(num);
// int[] array2 = new int[array.Length];
// Console.WriteLine($"Ваш массив : " + string.Join(",", array));
// for (int i = 0; i < array.Length; i++)
// {
//     array2[i] = array[i];
// }
// Console.WriteLine($"Ваша копия  массива : " + string.Join(",", array2));
