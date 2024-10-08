using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        int len = strings.Length;
        string[] answer = new string[len];
        
        for(int i=0; i<len; i++)
        {
            answer[i] = (strings[i][n]) + strings[i];
        }
        
        Array.Sort(answer);
        
        for(int j=0; j<len; j++)
        {
            answer[j] = answer[j].Substring(1);
        }
        
        return answer;
    }
}