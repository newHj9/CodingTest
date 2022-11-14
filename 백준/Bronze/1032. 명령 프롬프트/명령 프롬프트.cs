int N = int.Parse(Console.ReadLine());
string[] file = new string[N];
string result = "";

for (int i = 0; i < N; i++)
{
    file[i] = Console.ReadLine();
}

string checkStr = file[0];
for (int i = 0; i < checkStr.Length; i++)
{
    char checkCh = checkStr[i];
    bool check = false;
    for (int j = 1; j < N; j++)
    {
        string str = file[j];
        if (checkCh != str[i])
        {
            check = true;
            break;
        }
    }

    if (check)
        result += "?";
    else
        result += checkCh.ToString();
}
Console.WriteLine(result);