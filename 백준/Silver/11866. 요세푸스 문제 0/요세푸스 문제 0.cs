using System.Text;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = input[0];
int K = input[1];
Queue<int> quene = new Queue<int>();
List<int> list = new List<int>();

for (int i = 1; i <= N; i++)
{
    quene.Enqueue(i);
}

StringBuilder sb = new StringBuilder();
while (quene.Count != 0)
{
    for (int i = 0; i < K; i++)
    {
        if (i == K - 1)
            list.Add(quene.Dequeue());
        else
            quene.Enqueue(quene.Dequeue());
    }
}

for (int i = 0; i < list.Count; i++)
{
    sb.Append(list[i]);
    if (i != list.Count - 1)
        sb.Append(", ");
}
Console.Write("<" + sb + ">");