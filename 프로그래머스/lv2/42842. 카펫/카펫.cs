using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int wh = (brown/2) + 2;
        int min = 0, max = 0;
        
        min = wh / 2;
        max = wh - min;

        if(min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }

        while(min > 1)
        {
            if(yellow == (max - 2) * (min - 2))
            {
                break;
            }

            max++;
            min--;
        }
        
        
        answer[0] = max;
        answer[1] = min;
        
        return answer;
    }
}

/*
if(wh % 2 != 0)
        {
            min = wh / 2;
            max = wh - min;
            
            if(min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }
            
            while(min > 1)
            {
                if(yellow == (max - 2) * (min - 2))
                {
                    break;
                }
                
                max++;
                min--;
            }
        }
        else
        {
            int temp = wh / 2;
            
            max = temp;
            min = temp;
            
            while(min > 1)
            {
                if(yellow == (max - 2) * (min - 2))
                {
                    break;
                }
                
                max++;
                min--;
            }
        }
*/