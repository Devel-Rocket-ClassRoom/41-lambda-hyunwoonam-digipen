using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 가장 간단한 람다식");

    PrintMessage printMessage = () => Console.WriteLine("안녕하세요.");

    printMessage();
}

Console.WriteLine();

{
    Console.WriteLine("2. 매개변수와 반환값이 있는 람다식");

    Transformer square = x => x * x;

    Console.WriteLine(square(3));
    Console.WriteLine(square(4));

}

Console.WriteLine();

{
    Console.WriteLine("3. 여러 매개변수가 있는 람다식");

    IsLonger isLong = (string msg, int len) => msg.Length > len;

    Console.WriteLine(isLong("안녕하세요.", 5));
    Console.WriteLine(isLong("반갑습니다.", 10));

}

Console.WriteLine();

{
    Console.WriteLine("4. 문장 람다");

    Greeting greeting = () =>
    {
        Console.WriteLine("안녕하세요.");
        Console.WriteLine("반갑습니다.");
    };

    greeting();
}

Console.WriteLine();

{
    Console.WriteLine("5. 문장 람다에서 값 반환");

    Calculator add = (a,b) =>
    {
        int result = a + b;

        Console.WriteLine($"{a} + {b} = {result}");
        return result;
    };

    int sum = add(3, 5);

    Console.WriteLine($"합계: {sum}");

}

delegate void PrintMessage();
delegate int Transformer(int x);
delegate bool IsLonger(string msg, int len);
delegate void Greeting();
delegate int Calculator(int a, int b);