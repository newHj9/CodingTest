using System.Text;

Dictionary<string, int> octalNumber = new Dictionary<string, int>()
{
    {"000", 0}, {"001", 1}, {"010", 2}, {"011", 3}, 
    {"100", 4}, {"101", 5}, {"110", 6}, {"111", 7}
};

string input = Console.ReadLine();

if (input.Length % 3 == 1 || input.Length % 3 == 2)
{
    int num = input.Length % 3 == 1 ? 2 : 1;
    for (int i = 0; i < num; i++)
    {
        input = '0' + input;
    }
}

StringBuilder sb = new StringBuilder();
int idx = 0;
while (idx < input.Length)
{
    string str = "";

    str = input.Substring(idx, 3);
    sb.Append(octalNumber[str]);
    idx += 3;
}

Console.WriteLine(sb);