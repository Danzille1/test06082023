// See https://aka.ms/new-console-template for more information
//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = GetRandomArray(8);
PrintArray(arr);

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0,100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item+", ");
    }
}

