﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите точку b1: ");
double b1 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
Console.Write("Введите точку k1: ");
double k1 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
Console.Write("Введите точку b2: ");
double b2 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
Console.Write("Введите точку k2: ");
double k2 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;
Console.Write($"({x}; {y})");

// БЕЗ проверок . я к сожалению не понимаю как это можно сделать .