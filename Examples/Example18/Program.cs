// See https://aka.ms/new-console-template for more information
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Input M = ");
string numStr = Console.ReadLine();
int m = int.Parse(numStr);
Console.WriteLine(m);

int count = 0;
for (int i = 1; i <= m; i++)
{
    Console.Write(i);
    Console.Write(" Input Number = ");
    string numStr1 = Console.ReadLine();
    int number = int.Parse(numStr1);

    if (number > 0) count++;
}

Console.Write("Amount of nubmers more than 0 = ");
Console.WriteLine(count);