using System;

public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[] {1, 1};
        int min = n, max = m;
        
        if(n > m)
        {
            min = m;
            max = n;
        }
        int j;
        for(int i = 1; i <= n; i += j)
        {
            for(j = 2; j <= n; j++)
            {
                if(min % j == 0 && max %j == 0)
                {
                    answer[0] *= j;
                    min /= j;
                    max /= j;
                    
                    break;
                }
            }
        }
        
        answer[1] = answer[0];
        answer[1] *= min;
        answer[1] *= max;
        
        return answer;
    }
}