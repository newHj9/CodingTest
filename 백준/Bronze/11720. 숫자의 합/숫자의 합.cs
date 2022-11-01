int N = int.Parse(Console.ReadLine());
string M = Console.ReadLine();
int sum = 0;

for (int i = 0; i < N; i++)
{
    sum += M[i] - '0';
}

Console.WriteLine(sum);