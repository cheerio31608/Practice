using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string[] str = s.Split(" ");
        int[] num = Array.ConvertAll(str, int.Parse);
        int max = num.Max();
        int min = num.Min();
        string answer = $"{min} {max}";
        return answer;
    }
}