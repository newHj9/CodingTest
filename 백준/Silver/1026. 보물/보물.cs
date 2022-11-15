int N = int.Parse(Console.ReadLine());
int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> aList = A.ToList();
aList.Sort();

int result = 0;
bool[] checkB = new bool[N];
for (int i = 0; i < N; i++)
{
    int max = -1, maxidx = 0;

    for (int j = 0; j < N; j++)
    {
        if (max < B[j] && !checkB[j])
        {
            max = B[j];
            maxidx = j;
        }
    }

    result += aList[i] * B[maxidx];
    checkB[maxidx] = true;
}

Console.WriteLine(result);