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

Console.WriteLine();

{
    Console.WriteLine("2. Predicate 대리자");

    Predicate<int> isEven = n => n % 2 == 0;
    Func<int, bool> isOdd = n => n % 2 != 0;

    Console.WriteLine(isEven(4));
    Console.WriteLine(isOdd(4));
}

Console.WriteLine();

{
    Console.WriteLine("3. 클로저 - 외부 변수 캡처");

    int factor = 2;
    Func<int, int> multiplier = n => n * factor;

    Console.WriteLine(multiplier(3));

    factor = 10;

    Console.WriteLine(multiplier(3));
}

Console.WriteLine();

{
    Console.WriteLine("4. 클로저 - 캡처된 변수 수정");

    int count = 0;
    Action increment = () => count++;

    increment();
    increment();
    increment();

    Console.WriteLine(count);
}

Console.WriteLine();

{
    Console.WriteLine("5. 클로저와 변수 수명 연장");

    Func<int> counter = CreateCounter();

    Func<int> CreateCounter()
    {
        int count = 0;
        return () => count++;
    }

    Console.WriteLine(counter());
    Console.WriteLine(counter());
    Console.WriteLine(counter());
}
