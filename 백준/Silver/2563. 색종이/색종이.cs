int N = int.Parse(Console.ReadLine());
int[,] paper = new int[100, 100];

for (int i = 0; i < N; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    for (int l = input[0]; l < input[0] + 10; l++)
    {
        for (int m = input[1]; m < input[1] + 10; m++)
        {
            if(paper[l, m] == 1) continue;
            paper[l, m] = 1;
        }
    }
}

Console.WriteLine(paper.Cast<int>().Sum());