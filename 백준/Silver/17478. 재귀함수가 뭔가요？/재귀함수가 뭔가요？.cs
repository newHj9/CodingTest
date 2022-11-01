int input = int.Parse(Console.ReadLine());

Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
string str1 = "\"재귀함수가 뭔가요?\"";
string str2 = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.";
string str3 = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.";
string str4 = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"";
string str5 = "\"재귀함수는 자기 자신을 호출하는 함수라네\"";
string str6 = "라고 답변하였지.";
char line = '_';

recursion1(input);

string recursion1(int n)
{
    string lineRepeat = "";
    if (n == 0)
    {
        lineRepeat = new String(line, input * 4);
        Console.WriteLine(lineRepeat + str1);
        Console.WriteLine(lineRepeat + str5);
        recursion2(input);
        return "";
    }

    if (n < input)
        lineRepeat = new String(line, (input - n) * 4);

    Console.WriteLine(lineRepeat + str1);
    Console.WriteLine(lineRepeat + str2);
    Console.WriteLine(lineRepeat + str3);
    Console.WriteLine(lineRepeat + str4);
    return recursion1(n - 1);
}

string recursion2(int n)
{
    if (n == 0)
    {
        Console.WriteLine(str6);
        return "";
    }

    string lineRepeat = new String(line, n * 4);
    Console.WriteLine(lineRepeat + str6);
    return recursion2(n - 1);
}