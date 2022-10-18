using System.ComponentModel.DataAnnotations;

namespace codingTest;

public class CodingTest_20
{
    public void BJ10870()
    {
        // 피보나치 수 5
        int N = int.Parse(Console.ReadLine());

        int Fibonacci(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            else if (N == 1)
            {
                return 1;
            }

            return Fibonacci(N - 1) + Fibonacci(N - 2);
        }
        
        Console.WriteLine(Fibonacci(N));
        
    }

    public void BJ25501()
    {
        // 재귀의 귀재
        int T = int.Parse(Console.ReadLine());
        string[] input = new string[T];
        int[] cnt = new int[T];
        
        for (int i = 0; i < T; i++)
        {
            input[i] = Console.ReadLine();
        }

        int recursion(string s, int l, int r, int idx)
        {
            cnt[idx]++;
            
            if (l >= r)
                return 1;
            else if (s[l] != s[r])
                return 0;
            else 
                return recursion(s, l + 1, r - 1, idx);
        }

        int isPalindrome(string s, int len, int idx)
        {
            return recursion(s, 0, len - 1, idx);
        }

        for (int i = 0; i < T; i++)
        {
            string str = input[i];
            Console.WriteLine($"{isPalindrome(str, str.Length, i)} {cnt[i]}");
        }
    }

    public void BJ24060()
    {
        // 알고리즘 수업 - 병합 정렬 1
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int K = input[1];
        int[] tmp = new int[A.Length];
        
        List<int> list = new List<int>();

        int cnt = 0;

        void merge_sort(int[] A, int left, int right)
        {
            int mid;
            
            if (left < right)
            {
                list.Add(A[left]);
                mid = (left + right) / 2;
                merge_sort(A, left, mid);
                merge_sort(A, mid + 1, right);
                merge(A, left, mid, right);
            }
        }

        void merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int t = left;

            while (i <= mid && j <= right)
            {
                cnt++;
                
                if (A[i] <= A[j])
                {
                    //list.Add(A[i]);
                    tmp[t++] = A[i++];
                }
                else
                {
                    list.Add(A[j]);
                    tmp[t++] = A[j++];
                }
            }

            if (i > mid)
            {
                for (int k = j; k <= right; k++)
                {
                    tmp[t++] = A[k];
                }
            }
            else
            {
                for (int k = i; k <= mid; k++)
                {
                    tmp[t++] = A[k];
                }
            }

            for (int k = left; k <= right; k++)
            {
                A[k] = tmp[k];
            }
        }
        
        merge_sort(A, 0, A.Length - 1);

        foreach (var l in tmp)
        {
            Console.WriteLine(l);
        }
        Console.WriteLine($"cnt : {cnt}");
        
        foreach (var l in list)
        {
            Console.WriteLine(l);
        }
        
    }
    /*
    public void BJ24060()
    {
        // 알고리즘 수업 - 병합 정렬 1
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int K = input[1];
        int[] tmp = new int[A.Length];
        
        List<int> list = new List<int>();

        void merge_sort(int[] A, int p, int r)
        {
            int q;
            
            if (p < r)
            {
                q = (p + r) / 2;
                merge_sort(A, p, q);
                merge_sort(A, q + 1, r);
                merge(A, p, q, r);
            }
        }

        void merge(int[] A, int p, int q, int r)
        {
            int i = p;
            int j = q + 1;
            int t = 1;
            while (i <= q && j <= r)
            {
                if (A[i] <= A[j])
                {
                    tmp[t++] = A[i++];
                    tmp[t++] = A[j++];
                }
            }
            
            while (i <= p)
            {
                tmp[t++] = A[i++];
            }
            
            while (j <= r)
            {
                tmp[t++] = A[j++];
            }

            i = p;
            t = 1;
            list.Add(tmp[t]);
            while (i <= r)
            {
                A[i++] = tmp[t++];
            }
        }
        
        merge_sort(A, 0, A.Length - 1);

        foreach (var l in list)
        {
            Console.WriteLine(l);
        }
    }
    */
    
    public void BJ14629()
    {
        // 숫자조각
    }
}