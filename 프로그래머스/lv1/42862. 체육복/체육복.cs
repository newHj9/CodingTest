using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        int[] stu = Enumerable.Repeat(1, n + 1).ToArray();
        int sum = -1;
        
        foreach(int l in lost)
        {
            --stu[l];
        }
        
        foreach(int r in reserve)
        {
            ++stu[r];
        }
        
        for(int i = 0; i < stu.Length; i++)
        {
            if (i == stu.Length - 1)
            {
                if(stu[i] == 2 && stu[i - 1] == 0)
                {
                    --stu[i];
                    ++stu[i - 1];
                }
            }
            else 
            {
                
                if(stu[i] == 2)
                {
                    if(stu[i - 1] == 0)
                    {
                        --stu[i];
                        ++stu[i - 1];
                    }
                    else if(stu[i + 1] == 0)
                    {
                        --stu[i];
                        ++stu[i + 1];
                    }
                }
            }
        }
        
        
        foreach(int s in stu)
        {
            int temp = s == 2 ? 1 : s;
            sum += temp;
        }
        
        
        return answer = sum >= n ? n : sum;
    }
}