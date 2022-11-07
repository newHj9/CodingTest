int N = int.Parse(Console.ReadLine());
        
        int cnt = 0;
        int title = 666;
        
        while (true)
        {
            string str = title.ToString();

            if (str.Contains("666"))
            {
                cnt++;
            }

            if (cnt == N)
            {
                break;
            }
                
            title++;
        }
        Console.WriteLine(title);