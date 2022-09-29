using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        List<int> sum = new List<int>();
        
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if(!sum.Contains(numbers[i] + numbers[j]))
                {
                    sum.Add(numbers[i] + numbers[j]);
                }
            }
        }
        
        answer = sum.ToArray();
        Array.Sort(answer);
        
        return answer;
    }
}