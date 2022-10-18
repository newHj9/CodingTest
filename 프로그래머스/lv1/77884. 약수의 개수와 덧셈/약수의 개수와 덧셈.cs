using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int[] cnt = new int[right+1];
        
        for(int i = left; i <= right; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(i % j == 0)
                {
                    ++cnt[i]; 
                }
            }
        }
        
        for(int i = left; i <= right; i++)
        {
            if(cnt[i] % 2 == 0)
            {
                answer += i;
            }
            else
            {
                answer += -i;
            }
        }
        
        return answer;
    }
}