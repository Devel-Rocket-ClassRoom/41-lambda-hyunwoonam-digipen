using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Action<string> sys = CreateLogger("시스템");
Action<string> net = CreateLogger("네트워크");

sys("서버를 시작합니다.");
sys("초기화가 완료되었습니다.");
net("클라이언트가 접속했습니다.");
sys("요청을 처리합니다.");
net("데이터를 수신했습니다.");
net("클라이언트가 종료했습니다.");

Action<string> CreateLogger(string category)
{
    int num = 0;

    return message =>
    {
        num++;
        Console.WriteLine($"[{category} #{num}] {message}");
    };
}