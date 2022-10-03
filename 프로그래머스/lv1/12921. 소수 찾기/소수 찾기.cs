using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(int n) {
        long answer = 0;
        bool[] check = Enumerable.Repeat(false, n + 1).ToArray();
        
        check[0] = true;
        check[1] = true;
        
        for(int i = 2; i <= n; i++)
        {
            for(int j = i * 2; j <= n; j += i)
            {
                check[j] = true;
            }
        }
        
        return answer = check.Where(x => !x).Count();
    }
}