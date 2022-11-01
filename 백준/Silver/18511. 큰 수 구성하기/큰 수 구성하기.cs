class n_18511
{
    public static int[] arr, arr2;
    public static int max = 0;
    public static void dfs(int cnt, int num)
    {
        if (cnt == 8)
            return;
        num *= 10;
        if (num >= arr[0])
            return;
        for(int i=0; i < arr[1]; i++)
        {
            int tmp = num + arr2[i];
            if (tmp > arr[0]) continue;
            if (tmp > max) max = tmp;
            dfs(cnt + 1, tmp);
        }
    }
    public static void Main(string[] args)
    {
        arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        arr2= Console.ReadLine().Split().Select(int.Parse).ToArray();
        dfs(0, 0);
        Console.WriteLine(max);
    }
}