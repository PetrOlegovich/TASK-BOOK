// Console .WriteLine("ВВедите четверть координат : ");
// int n = Convert.ToInt32(Console.ReadLine());

// if ( n == 1)
// {
//     Console.WriteLine(" в первой четверти  (x>0; y>0) : ");
// }
// else if ( n == 2)
// {
//     Console.WriteLine(" во второй четверти  (x<0; y>0) : ");
// }
// else if ( n == 3)
// {
//     Console.WriteLine(" в третьей четверти  (x<0; y<0) : ");
// }
// else
// {
//     Console.WriteLine(" в четвертой четверти  (x>0; y<0)  ");
// }


string [] quarters = {" x > 0 ; y > 0", "x<0 ; y>0", "x<0; y<0", "X>0; y<0"};
                       
Console.WriteLine("Введите номер четверти : ");
int n =  Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 4)
{
    Console.WriteLine("Такой четверти нет ! ");
}
else 
{
    Console.WriteLine(quarters[n-1]);
}
















