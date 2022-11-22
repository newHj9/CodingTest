using System.Text;

int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int M = input[0];
int N = input[1];
string[] Eng = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
List<NumPlay> plays = new List<NumPlay>();

for (int i = M; i <= N; i++)
{
    string temp = i.ToString();
    if (i < 10)
    {
        plays.Add(new NumPlay(i, Eng[temp[0] - '0'], "a"));
    }
    else
    {
        plays.Add(new NumPlay(i, Eng[temp[0] - '0'],  Eng[temp[1] - '0']));
    }
}

plays = plays.OrderBy(x => x.eng1).ThenBy(y => y.eng2).ToList();
StringBuilder sb = new StringBuilder();
for (int i = 1; i <= plays.Count; i++)
{
    sb.Append(plays[i - 1].num + " ");
    if (i > 0 && i % 10 == 0)
        sb.Append("\n");
}

Console.WriteLine(sb);

public class NumPlay
{
    public int num;
    public string eng1;
    public string eng2;

    public NumPlay(int num, string eng1, string eng2)
    {
        this.num = num;
        this.eng1 = eng1;
        this.eng2 = eng2;
    }
}