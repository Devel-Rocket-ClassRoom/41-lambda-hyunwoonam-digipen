using System;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Func<string, string> toUpper = s => s.ToUpper();
Func<string, string> mask  = s => { 
    return $"{s.Substring(0, 2)}***";
};
Func<string, string> greet = s => $"안녕하세요, {s}님!";

Console.Write("[대문자 변환] ");
ApplyAndPrint("hello world", toUpper);
Console.Write("[마스킹 처리] ");
ApplyAndPrint("SecretCode", mask);
Console.Write("[인사말 생성] ");
ApplyAndPrint("민수", greet);
void ApplyAndPrint(string input, Func<string, string> formatter)
{
    string result = formatter(input);
    Console.WriteLine($"{input} → {result}");
}