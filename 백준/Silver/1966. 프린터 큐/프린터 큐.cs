int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int[] priority = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int N = input[0];
    int M = input[1];

    Queue<int> P = new Queue<int>();
    Queue<int> idx = new Queue<int>();

    for (int j = 0; j < N; j++)
    {
        P.Enqueue(priority[j]);
        idx.Enqueue(j);
    }

    Array.Sort(priority);
    int cnt = 0, k = priority.Length - 1;
    while (cnt < N)
    {
        if (priority[k] == P.Peek())
        {
            P.Dequeue();
            cnt++;
            k--;
            var index = idx.Dequeue();
            if (M == index)
            {
                Console.WriteLine(cnt);
                break;
            }
        }
        else
        {
            P.Enqueue(P.Dequeue());
            idx.Enqueue(idx.Dequeue());
        }
    }
}