// S2.1. Составить программу:
// а) вычисления значения функции y=7x2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a2+7a+12 при любом значении а.

//а)// Console.WriteLine("Введите число Х : ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = 7*x*2+3*x+6;
// Console.WriteLine($"y = {y}");

// Console.WriteLine("Введите число a : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int x = 12*a*2+7*a+12;
// Console.WriteLine($"x = {x}");

//S2.2. Дана сторона квадрата. Найти его периметр.
// Console.WriteLine("Введите сторону квадрата для поиска перимитра : ");
// double x = Convert.ToDouble(Console.ReadLine());
// double P = x*4;
// Console.WriteLine($"Перимитр квадрата равен {P}");

// S2.3. Дан радиус окружности. Найти ее диаметр. 

// Console.WriteLine("Введите радиус окружности для поиска диаметра :");
// double r = Convert.ToDouble(Console.ReadLine());
// double D = 2 * r;
// Console.WriteLine($"Диаметр равен : {D}");

//S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности. —
// Console.WriteLine("Введите сторону куба для вычеслений : ");
// double x = Convert.ToDouble(Console.ReadLine());
// double plosh = x*x , ob = x*x*x;
// Console.WriteLine($"площадь стороны куба равен :{plosh} \nОбьем куба равна {ob}");


//S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.

// Console.Write("Введите радиус : ");
// double numr = Convert.ToDouble(Console.ReadLine());
// double numPi = 3.14;
// double numC = 2*numPi*numr;
// double numS = numPi*numr*numr;
// Console.WriteLine($"Длинна окружности = {Math.Round(numC, 2)}\nПлощадь круга = {Math.Round(numS, 2)}");


// S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.

// Console.Write("Введите первое число \n: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число \n: ");
// double num2 = Convert.ToDouble(Console.ReadLine());
// double sredA = (num1 + num2)/2;
// double sredG = Math.Sqrt(num1*num2);
// Console.WriteLine($"среднее арифметическое = {Math.Round(sredA, 3)} \n среднее геометрическое = {Math.Round(sredG, 3)}");



//S2.8. Известны объем и масса тела. Определить плотность материала этого тела.

// Console.Write("Введите массу \n: ");
// double colM = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите обьем \n: ");
// double colV = Convert.ToDouble(Console.ReadLine());
// double plot = colM/colV;
// Console.Write($"Плотность равна : {Math.Round(plot, 3)}");


// S2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.


// Console.Write("Введите количество жителей страны \n: ");
// double colP = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите площадь страны \n: ");
// double colS = Convert.ToDouble(Console.ReadLine());
// double plotnost = colP/colS;
// Console.Write($"Плотность населения равна : {Math.Round(plotnost, 2)} на километр квадратный ");


// S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.

// Console.Write("Введите катет 1  \n: ");
// double cat1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите катет 2 \n: ");
// double cat2 = Convert.ToDouble(Console.ReadLine());
// double gepa = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
// Console.WriteLine($"гипатенуза  равна \n: {Math.Round(gepa, 2)} ");

//обмен значениями из двух переменных 
// int a = 555;
// int b = 777;
// int col = a;

// col = a;
// a = b;
// b = col;
// Console.WriteLine($"значение а = {a}, значение б = {b}");

// 3,2 обмен трех переменных значениями

// int a =5;
// int b = 8;
// int c = 10;
// int col = c;

// c = a;
// a = b;
// b = col;
// Console.WriteLine($"a = {a} ; b=  {b} ; c=  {c} ;");


//Присвоение значений 
// int a = 5;   //10             //10
// int b = 8;   //5             //5
// int c = 10;   //8          //8
// int col = b; //8

// b = a; //■
// a = c; 
// c = col;//■
// Console.WriteLine($"a = {a} ; b=  {b} ; c=  {c} ;");



// S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).


// S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.

// Console.WriteLine("Введите внешний радиус кольца : ");
// double r1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите внутренний радиус кольца : ");
// double r2 = Convert.ToDouble(Console.ReadLine());
// double pi = 3.14;

// double PloRing = Math.Round((pi * Math.Pow(r1, 2)) - (pi * Math.Pow(r2, 2)), 2);
// Console.WriteLine($"Площадь кольца равна {PloRing}");

// S2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей. 

// Console.WriteLine("число 1  : ");
// double n1 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
// Console.WriteLine("число 2  : ");
// double n2 = Math.Abs(Convert.ToDouble(Console.ReadLine()));

// double sredA = Math.Round((n1+n2)/2, 2);
// double sredG = Math.Round(Math.Sqrt(n1*n2), 2);
// Console.WriteLine($"Среднее арефметическое {n1} и {n2} = {sredA}");
// Console.WriteLine($"Среднее геометрическое чисел {n1} и {n2} = {sredG}");


// S2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.

// double kat1 = 10;
// double kat2 = 20;
// double gepa = Math.Round(Math.Sqrt(Math.Pow(kat1, 2) + Math.Pow(kat2, 2)), 2);
// double Perimit = kat1+kat2+gepa;
// Console.WriteLine(Perimit);
 

//  S3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:
// а) a4 за две операции;
// б) a6  за три операции;
// в) a7 за четыре операции;
// г) a8  за три операции;
// д) a9 за четыре операции;
// е) a10  за четыре операции.