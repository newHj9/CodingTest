using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split(' ');
        
        for(int i = 0; i < str.Length; i++)
        {
            string ss = str[i];
            for(int j = 0; j < ss.Length; j++)
            {
                if(j == 0)
                {
                    answer += ss[j].ToString().ToUpper();
                }
                else 
                {
                    answer += ss[j].ToString().ToLower();
                }
            }
            
            if(i < str.Length - 1)
            {
                answer += ' ';
            }
        }
        
        return answer;
    }
}