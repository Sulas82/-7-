using System;
using System.Diagnostics.Metrics;
static double Average(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum /= arr.Length;
}

static int[] Arrays(int[] arr, string name)
{
    Random rnd = new Random();
    Console.WriteLine($"Массив {name}:");
    for (int i = 0; i <= arr.Length - 1; ++i)
    {
        arr[i] = rnd.Next(-100, 300);
        Console.Write($" {arr[i]}");
    }
    Console.WriteLine();
    int[] result = new int[arr.Length];
    return result;
}
