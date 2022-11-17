int N = int.Parse(Console.ReadLine());
List<int> sum = new List<int>();

for (int i = 0; i < N; i++)
{
    int plug = int.Parse(Console.ReadLine());
    if (i != N - 1) plug--;
    sum.Add(plug);
}

Console.WriteLine(sum.Sum());