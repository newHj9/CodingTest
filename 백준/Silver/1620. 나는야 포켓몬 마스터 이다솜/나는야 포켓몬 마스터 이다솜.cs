using System.Text;

int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = input[0];
int M = input[1];
Dictionary<string, string> Pokemon = new Dictionary<string, string>();
Dictionary<string, string> Number = new Dictionary<string, string>();
string[] quest = new string[M];

for (int i = 0; i < N; i++)
{
    string monster = Console.ReadLine();
    Pokemon.Add(monster, (i+1).ToString());
    Number.Add((i+1).ToString(), monster);
}

for (int i = 0; i < M; i++)
{
    quest[i] = Console.ReadLine();
}

StringBuilder sb = new StringBuilder();
for (int i = 0; i < M; i++)
{
    if (Pokemon.ContainsKey(quest[i]))
        sb.AppendLine(Pokemon[quest[i]]);
    else
        sb.AppendLine(Number[quest[i]]);
}

Console.WriteLine(sb);