using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 람다식을 매개변수로 전달");
    var multiplesOf3 = FindNumbers(n => n % 3 == 0);

    Console.WriteLine("3의 배수:");

    foreach (var n in multiplesOf3)
    {
        Console.Write($"{n} ");
    }

    Console.WriteLine();

    var perfectSquares = FindNumbers(n =>
    {
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
    });

    Console.WriteLine("제곱수:");

    foreach (var n in perfectSquares)
    {
        Console.Write($"{n} ");
    }

    static List<int> FindNumbers(Predicate<int> predicate)
    {
        List<int> results = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            if (predicate(i))
            {
                results.Add(i);
            }
        }

        return results;
    }
}

