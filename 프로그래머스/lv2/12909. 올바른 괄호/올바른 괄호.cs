using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int open = 0, close = 0;
        bool check = false;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                check = false;
                open++;
            }
            else if(s[i] == ')')
            {
                check = true;
                close++;
            }
            
            if(open < close)
            {
                check = false;
                break;
            }
        }
        
        if(open != close)
        {
            check = false;
        }
        
        return answer = check;
    }
}