using System;
using System.Diagnostics;

// README.md를 읽고 아래에 코드를 작성하세요

int[] numbers = { 10, 25, 7, 42, 18, 33 };

int sum = ProcessArray(numbers, data =>
{
    int total = 0;
    foreach (int i in data)
    {
        total += i; 
    }
    return total;
});

int max = ProcessArray(numbers, data =>
{
    int max = int.MinValue;

    foreach (int i in data)
    {
        if(max < i)
        {
            max = i; 
        }
    }
    return max;
});

int min = ProcessArray(numbers, data =>
{
    int min = int.MaxValue;

    foreach (int i in data)
    {
        if (min > i)
        {
            min = i;
        }
    }
    return max;
});

int even = ProcessArray(numbers, data =>
{
    int Count = 0;
    foreach (int i in data)
    {
        if(i % 2 == 0)
        {
            Count++; 
        }
    }
    return Count;
});


Console.WriteLine($"배열: {string.Join(", ", numbers)}");
Console.WriteLine($"합계: {sum}");
Console.WriteLine($"최댓값: {max}");
Console.WriteLine($"최솟값: {min}");
Console.WriteLine($"짝수 개수: {even}");

int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}