int N = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < N; i++)
{
    int plug = int.Parse(Console.ReadLine());
    if (i != N - 1) plug--;
    sum += plug;
}

Console.WriteLine(sum);