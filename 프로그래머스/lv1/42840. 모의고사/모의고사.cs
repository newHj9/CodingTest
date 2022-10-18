using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<int> solution(int[] answers) {
        List<int> answer = new List<int>();
        
        int[] stu1 = new int[5] {1, 2, 3, 4, 5};
        int[] stu2 = new int[8] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] stu3 = new int[10] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        int[] cnt = new int[3];
        
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == stu1[i % stu1.Length])
            {
                cnt[0]++;
            }
            if(answers[i] == stu2[i % stu2.Length])
            {
                cnt[1]++;
            }
            if(answers[i] == stu3[i % stu3.Length])
            {
                cnt[2]++;
                
            }
        }
        
        
        int Max = 0;
        
        for(int i = 0; i < cnt.Length; i++)
        {
            if(Max < cnt[i])
            {
                Max = cnt[i];
            }
        }
        
        for(int i = 0; i < cnt.Length; i++)
        {
            if(Max == cnt[i])
            {
                answer.Add(i + 1);
            }
        }
        
        answer = answer.OrderBy(x => x).ToList();
        
        return answer;
    }
}