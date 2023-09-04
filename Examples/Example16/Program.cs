// See https://aka.ms/new-console-template for more information
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = GetRandomArray(8);
PrintArray(arr);

SumOfOddElements(arr);

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100,999);
    }
    return result;
}

void SumOfOddElements(int[] arr)
{ 
 int sum  = arr[0];

 for (int i = 0; i < arr.GetLength(0); i++)
 { 

  if (i % 2 == 0)
  {
    sum = sum + arr[i];
    Console.WriteLine(arr[i]);
  }
  }

 Console.WriteLine();          // вывод нечётных по номеру элементов массива для проверки
 Console.WriteLine(sum);
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item+", ");
    }
    Console.WriteLine();
}