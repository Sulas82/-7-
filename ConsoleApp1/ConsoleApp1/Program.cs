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

static void Main()
{
    string name;
    Console.Write("Введите название массива: ");
    name = Console.ReadLine();
    Console.Write("Введите размер массива: ");
    int countA = int.Parse(Console.ReadLine());
    int[] A = new int[countA];
    Arrays(A, name);
    Console.Write($"Среднее арифметическое массива{name}: ");
    Console.WriteLine(Average(A));

    Console.Write("Введите название массива: ");
    name = Console.ReadLine();
    Console.Write("Введите размер массива: ");
    int countB = int.Parse(Console.ReadLine());
    int[] B = new int[countB];
    Arrays(B, name);
    Console.Write($"Среднее арифметическое массива{name}: ");
    Console.WriteLine(Average(B));

    int[] C = new int[countA + countB];

    Console.WriteLine("Положительный массив С:");
    int count = 0;
    for (int i = 0; i <= A.Length - 1; ++i)
    {
        if (A[i] > 0)
        {
            C[count] = A[i];
            count++;
        }
    }
    for (int j = 0; j <= B.Length - 1; ++j)
    {
        if (B[j] > 0)
        {
            C[count] = B[j];
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Массив C пуст");
    }
    else
    {
        Console.Write("Массив С:");
        for (int i = 0; i < count; ++i)
        {
            Console.Write($" {C[i]}");
        }
        Array.Resize(ref C, count);
        Console.Write("Среднее арифметическое массива C: ");
        Console.WriteLine(Average(C));
    }
}

