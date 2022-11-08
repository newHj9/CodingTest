using System.Text;

int N = int.Parse(Console.ReadLine());
int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int M = int.Parse(Console.ReadLine());
int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
StringBuilder sb = new StringBuilder();

Array.Sort(A);

for (int i = 0; i < M; i++)
{
    int start = 0, end = N - 1, middle = 0;
    bool check = false;

    while (start <= end)
    {
        middle = (start + end) / 2;

        if (B[i] < A[middle])
        {
            end = middle - 1;
        }
        else if (B[i] > A[middle])
        {
            start = middle + 1;
        }
        else if (B[i] == A[middle])
        {
            sb.AppendLine("1");
            check = true;
            break;
        }
    }
    if (!check)
        sb.AppendLine("0");
    }
        
Console.WriteLine(sb);