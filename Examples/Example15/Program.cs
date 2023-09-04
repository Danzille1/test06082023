// See https://aka.ms/new-console-template for more information
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = GetRandomArray(8);
PrintArray(arr);

CountEvenNumbers(arr);

// Console.Write("res = "); 
// Console.WriteLine(res);

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100,999);
    }
    return result;
}

void CountEvenNumbers(int[] arr)
{ 
 int count  = 0;

 for (int i = 0; i < arr.GetLength(0); i++)
 { 
  if (arr[i] % 2 == 0)
  {
    count++;
  }
 
 }
 Console.WriteLine();
 Console.WriteLine(count);
}


void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item+", ");
    }
}

