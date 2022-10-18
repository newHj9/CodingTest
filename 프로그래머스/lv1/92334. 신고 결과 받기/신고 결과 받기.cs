using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[] {};
        
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        Dictionary<string, int> cnt = new Dictionary<string, int>();

        for(int i = 0; i < report.Length; i++)
        {
            string[] str = report[i].Split(" ").ToArray();

            if (!dic.ContainsKey(str[0]))
            {
                dic.Add(str[0], new List<string>());
                dic[str[0]].Add(str[1]);
                Console.WriteLine(str[0]);
            }
            else if (dic[str[0]].Contains(str[1]))
            {
                continue;
            }
            else
            {
                dic[str[0]].Add(str[1]);
            }

            if (!cnt.ContainsKey(str[1]))
            {
                cnt.Add(str[1], 1);
            }
            else
            {
                ++cnt[str[1]];
            }
        }

        /*
        foreach (KeyValuePair<string, List<string>> item in dic)
        {
            foreach (var i in item.Value)
            {
                Console.WriteLine("[{0}:{1}]", item.Key, i);
            }
        }

        foreach (var c in cnt)
        {
            Console.WriteLine("[{0}:{1}]", c.Key, c.Value);
        }
        */
        
        //int[] answer = new int[id_list.Length];
        Dictionary<string, int> id = new Dictionary<string, int>();

        foreach (var i in id_list)
        {
            id.Add(i, 0);
        }

        foreach (var item in dic)
        {
            foreach (var i in item.Value)
            {
                if (cnt[i] >= k)
                {
                    ++id[item.Key];
                }
            }
        }
        
        
        return answer = id.Values.ToArray();
    }
}

/*
int[,] cnt = new int[id_list.Length, id_list.Length];
        int[] mail = new int[id_list.Length];
        
        List<string> rCopy = new List<string>();
        
        foreach(var r in report)
        {
            if(!rCopy.Contains(r))
                rCopy.Add(r);
        }
        
        for(int i = 0; i < rCopy.Count; i++)
        {
            string[] str = rCopy[i].Split(" ").ToArray();
            int id = 0;
            int rep = 0;
            
            for(int j = 0; j < id_list.Length; j++)
            {
                if(str[0] == id_list[j])
                {
                    id =j;
                    continue;
                }
                if(str[1] == id_list[j])
                {
                    rep = j;
                    continue;
                }
            }
            ++cnt[id, rep];
        }
        
        int[] repId = new int[id_list.Length];
        
        for(int i = 0; i < cnt.GetLength(1); i++)
        {
            for(int j = 0; j < cnt.GetLength(0); j++)
            {
                repId[i] += cnt[j, i];
                continue;
            }
        }
        
        
        for(int i = 0; i < cnt.GetLength(0); i++)
        {
            for(int j = 0; j < cnt.GetLength(1); j++)
            {
                Console.WriteLine($"{i} {j} : {cnt[i, j]}");
                if(repId[j] >= k)
                {
                    if(cnt[i,j] > 0)
                    {
                        ++mail[i];
                        continue;
                    }
                }
            }
            Console.WriteLine();
        }
*/

/*
        Dictionary<string, int> result = new Dictionary<string, int>();
        Dictionary<string, int> repCnt = new Dictionary<string, int>();
        
        List<string> repCopy = new List<string>();
        
        foreach(var id in id_list)
        {
            result.Add(id, 0);
            repCnt.Add(id, 0);
        }
        
        for(int i = 0; i < report.Length; i++)
        {
            if(!repCopy.Contains(report[i]))
                repCopy.Add(report[i]);
        }
        
        
        for(int i = 0; i < repCopy.Count; i++)
        {
            string[] str = repCopy[i].Split(" ").ToArray();
            ++repCnt[str[1]];
        }
        
        List<string> repName = new List<string>();
        
        foreach(var cnt in repCnt)
        {
            if(cnt.Value >= k)
            {
                repName.Add(cnt.Key);
            }
        }
        
        if(repName.Count <= 0)
        {
            answer = result.Values.ToArray();
        }
        else
        {
            for(int i = 0; i < repCopy.Count; i++)
            {
                string[] str = repCopy[i].Split(" ").ToArray();
                
                for(int j = 0; j < repName.Count; j++)
                {
                    if(str[1] == repName[j])
                    {
                        ++result[str[0]];
                    }
                }
            }
            
            answer = result.Values.ToArray();
        }
*/