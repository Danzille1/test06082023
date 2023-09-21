// See https://aka.ms/new-console-template for more information
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Input b1 = ");
string numStr1 = Console.ReadLine();
float b1 = float.Parse(numStr1);

Console.Write("Input k1 = ");
string numStr2 = Console.ReadLine();
float k1 = float.Parse(numStr2);

Console.Write("Input b2 = ");
string numStr3 = Console.ReadLine();
float b2 = float.Parse(numStr3);

Console.Write("Input k2 = ");
string numStr4 = Console.ReadLine();
float k2= float.Parse(numStr4);

float x = (b2 - b1) / (k1 - k2);
float y = k1 * x + b1;

Console.Write("Crossing point coordinates: x= ");
Console.Write(x);
Console.Write(" y= ");
Console.WriteLine(y);