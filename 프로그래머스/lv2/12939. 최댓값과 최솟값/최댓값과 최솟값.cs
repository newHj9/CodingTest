using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int[] num = s.Split(" ").Select(int.Parse).ToArray();
        
        /*
        int max = num[0], min = num[0];
        
        foreach(int n in num)
        {
            if(max < n)
                max = n;
            if(min > n)
                min = n;
        }
        
        answer += min.ToString();
        answer += " ";
        answer += max.ToString();
        */
        
        answer = num.Min().ToString() + ' ' + num.Max().ToString();
        
        
        return answer;
    }
}