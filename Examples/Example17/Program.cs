// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

float[] arr = GetRandomArray(8);
PrintArray(arr);

//SumOfOddElements(arr);
MinMaxDifference(arr);

float[] GetRandomArray(int length)
{
    float[] result = new float[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0,100);
    }
    return result;
}

void MinMaxDifference(float[] arr)
{
 float min  = arr[0];
 float max  = arr[0];

 for (int i = 0; i < arr.GetLength(0); i++)
 {

  if (arr[i] > max)
  {
    max = arr[i];
  }

  if (arr[i] < min)
  {
    min = arr[i];
  }
 }
 Console.WriteLine();          
 Console.Write("max = ");
 Console.Write(max);

 Console.WriteLine();          
 Console.Write("min = ");
 Console.Write(min);

 Console.WriteLine();          
 Console.WriteLine(max - min);
}

void PrintArray(float[] arr)
{
    foreach (float item in arr)
    {
        Console.Write(item+", ");
    }
    Console.WriteLine();
}                    