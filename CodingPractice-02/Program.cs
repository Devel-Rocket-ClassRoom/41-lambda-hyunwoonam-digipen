using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. Func 대리자");
    Func<int> func1 = () => 1234;
    Func<int, int> square = (a) => a*a;
    Func<int, int, int> add = (a,b) => a+b;

    Console.WriteLine(func1());
    Console.WriteLine(square(3));
    Console.WriteLine(add(3, 5));

}

Console.WriteLine();

{
    Console.WriteLine("2. Action 대리자");
    Action action1 = () => Console.WriteLine("안녕하세요!");
    Action<string> action2 = (s) => Console.WriteLine(s); ;
    Action<string, int> action3 = (s,i) =>
    {
        for(int j = 0; j < i;  j++)
        {
            Console.WriteLine($"{s}");
        }
    };

    action1();
    action2("Hello, Lambda!");
    action3("반복!", 3);

}

Console.WriteLine();

{
    Console.WriteLine("3. 익명 메서드와 람다식 비교");
    Func<int, int> anonymous = delegate (int x) { return x * x; };
    Func<int, int> lambda = x => x * x;

    Console.WriteLine(anonymous(2));
    Console.WriteLine(lambda(2));
    
}