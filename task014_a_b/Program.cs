Console.WriteLine("Точка A, введите x=  ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка A, введите y=  ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка B, введите x=  ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка B, введите y=  ");
double yB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2));
dist = Math.Round(dist, 2);
Console.WriteLine($"длинна между точками А и В = {dist}");