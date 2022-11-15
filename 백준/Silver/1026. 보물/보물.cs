int N = int.Parse(Console.ReadLine());
int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] S = new int[N];

List<int> aList = A.ToList();
List<int> bList = B.ToList();

aList.Sort();
bList.Sort();
bList.Reverse();

for (int i = 0; i < N; i++)
{
    S[i] = aList[i] * bList[i];
}

Console.WriteLine(S.Sum());