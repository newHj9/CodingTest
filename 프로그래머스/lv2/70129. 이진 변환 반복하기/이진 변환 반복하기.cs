using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int oneLength = 0;
        string binary = s;
        
        while(binary.Length > 1)
        {
            int cnt = binary.Count(x => x == '0');
            answer[1] += cnt;
        
            oneLength = binary.Length - cnt;
            binary = Convert.ToString(oneLength, 2);
            ++answer[0];
            /*
            while(oneLength > 0)
            {
                binary += (oneLength % 2).ToString();
                oneLength /= 2;
                ++answer[0];
            }
            
            char[] ch = binary.ToCharArray();
            Array.Reverse(ch);
            binary = new String(ch);
            */
            
            Console.WriteLine(binary);
        }
        
        
        return answer;
    }
}