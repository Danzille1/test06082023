// See https://aka.ms/new-console-template for more information
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Input number = ");
int a = int.Parse(Console.ReadLine());

Console.Write("Input degree = ");
int b = int.Parse(Console.ReadLine());

int res = 1;

for (int i = 1; i<= b; i++)
 {
    res = res * a;
 }

Console.Write(a);
Console.Write(",");
Console.Write(b);
Console.Write(" -> ");
Console.WriteLine(res);
