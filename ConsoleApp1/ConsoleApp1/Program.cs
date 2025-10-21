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
