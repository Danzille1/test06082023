// See https://aka.ms/new-console-template for more information
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Input number = ");
int a = int.Parse(Console.ReadLine());

Console.Write(a);

int sum = 0;

while (a>0)
{
  sum = sum + (a % 10);
  a = a /10;
}

Console.Write(" -> ");
Console.WriteLine(sum);
