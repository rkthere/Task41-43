﻿//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите точку b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


double intersection(double b1, double k1, double b2, double k2)
{
    double y = 0;
    double x = (-b2 + b1)/(-k1 + k2);
    if(b1 > 0 && k1 > 0 && b2 > 0 && k2 > 0)
    {
        y = k1 * x + b1;
        y = k2 * x + b2;
    }
    return x;
}
double result = Convert.ToDouble(intersection(b1,k1,b2,k2));
Console.WriteLine($"Точка пересечения двух прямых => {result}");