using System;

public class Solution {
    public string solution(string s) {
        char[] str = s.ToCharArray();
        Array.Sort(str);
        Array.Reverse(str);
        string answer = new string(str);
        return answer;
    }
}