using System.Text;

string[] octalNumber = { "000", "001", "010", "011", "100", "101", "110", "111"};
string[] last = { "0", "1", "10", "11" };

string input = Console.ReadLine();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < input.Length; i++)
{
    if (i == 0 && input[i] - '0' < last.Length)
    {
        sb.Append(last[input[0] - '0']);
    }
    else
    {
        sb.Append(octalNumber[input[i] - '0']);
    }
}

Console.WriteLine(sb);