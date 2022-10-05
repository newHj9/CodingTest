using System;
using System.Linq;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        
        Array.Sort(d);
        
        for(int i = 0; i < d.Length; i++)
        {
            budget -= d[i];
            if(budget >= 0)
            {
                answer++;
            }
        }
        
        return answer;
    }
}