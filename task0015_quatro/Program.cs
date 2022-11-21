
Console.Write("Ваше число \n:");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 1;
while (count <= n)
{
    int res = count*count;
    count++;
    Console.Write($"{res}, ");
} 


