// [1] Input
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // [2] Process
        //arr = arr.Distinct().ToArray();
        Array.Sort(arr);

        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            bool[] check = new bool[] {true, false, false, false, false};
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = 1; k < check.Length; k++)
                {
                    if (check[k] == false && arr[j] - arr[i] == k)
                    {
                        check[k] = true;
                        result[i]++;
                        //Console.WriteLine(result[i]);
                    }
                }
            }
        }
        
        Array.Sort(result);
        
        // [3] OutPut
        Console.WriteLine(4 - result[arr.Length - 1]);