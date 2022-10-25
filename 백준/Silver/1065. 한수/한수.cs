using System;

int N = int.Parse(Console.ReadLine());
        int cnt = 0;

        if (N < 100)
        {
            Console.WriteLine(N);
        }
        else
        {
            for (int i = 100; i <= N; i++)
            {
                cnt++;
                
                string num = i.ToString();
                int diff = (num[0] - '0') - (num[1] - '0');
                
                for (int j = 1; j < num.Length - 1; j++)
                {
                    int diff2 = (num[j] - '0') - (num[j + 1] - '0');
                    if (diff != diff2)
                    {
                        cnt--;
                        break;
                    }
                }
            }
            Console.WriteLine(cnt + 99);
        }